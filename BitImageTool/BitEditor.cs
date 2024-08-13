using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitImageTool
{
    public partial class BitEditor : Control
    {
        public Color CellSetColor { get; set; } = Color.Blue;
        public Color CellUnsetColor { get; set; } = Color.AliceBlue;

        public bool DrawBorder { get; set; } = true;
        public bool DrawGrid { get; set; } = true;
        public Color CellBorderColor { get; set; } = Color.FromArgb(120, 180, 180, 180);

        public bool ReadOnly { get; set; } = false;

        public bool[,] Field { get; private set; }

        public delegate void ChangedByUserEventHandler(object sender, int x, int y, bool value);
        public event ChangedByUserEventHandler ChangedByUser;

        public event MouseEventHandler BeforeMouseDown;


        public BitEditor()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            Field = new bool[fieldWidth, fieldHeight];

            this.Paint += BitEditor_Paint;
            this.MouseDown += BitEditor_MouseDown;
            this.MouseMove += BitEditor_MouseMove;
            this.MouseUp += BitEditor_MouseUp;

            this.SizeChanged += (sender, e) => updateControlSize();

            updateControlSize();
        }

        // if value is null invert pixel
        void setPixel(int x, int y, bool? value)
        {
            if (x >= 0 && x < fieldWidth && y >= 0 && y < fieldHeight)
            {
                bool v = value.HasValue ? value.Value : !Field[x, y];
                Field[x, y] = v;
                Invalidate();
                ChangedByUser?.Invoke(this, x, y, v);
            }
        }


        public void CopyFrom(BitEditor src)
        {
            for (int y = 0; y < fieldHeight; y++)
                for (int x = 0; x < fieldWidth; x++)
                    if (x < src.fieldWidth && y < src.fieldHeight) Field[x, y] = src.Field[x, y];
            Invalidate();
        }

        bool mouseHold = false;
        int previousX = -1, previousY = -1;
        private void BitEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (ReadOnly) return;
            if (!mouseHold) return;

            int x = e.X / TileSize;
            int y = e.Y / TileSize;
            if (x == previousX && y == previousY) return;
            previousX = x;
            previousY = y;
                        
            if (e.Button == MouseButtons.Left) setPixel(x, y, true);
            if (e.Button == MouseButtons.Right) setPixel(x, y, false);
            if (e.Button == MouseButtons.Middle) setPixel(x, y, null);
        }

        private void BitEditor_MouseDown(object sender, MouseEventArgs e)
        {
            BeforeMouseDown?.Invoke(sender, e);
            if (ReadOnly) return;

            int x = e.X / TileSize;
            int y = e.Y / TileSize;
            if (e.Button == MouseButtons.Left) setPixel(x, y, true);
            if (e.Button == MouseButtons.Right) setPixel(x, y, false);
            if (e.Button == MouseButtons.Middle) setPixel(x, y, null);
            if (e.Button != MouseButtons.None) mouseHold = true;
        }

        private void BitEditor_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
        }

        public Action<long> DrawPaintPerformance { get; set; }
        private void BitEditor_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush cellSetBrush = null;
            SolidBrush cellUnsetBrush = null;
            Pen cellBorderPen = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                cellSetBrush = new SolidBrush(CellSetColor);
                cellUnsetBrush = new SolidBrush(CellUnsetColor);
                cellBorderPen = new Pen(CellBorderColor, 1);

                var g = e.Graphics;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                for (int y = 0; y < fieldHeight; y++)
                    for (int x = 0; x < fieldWidth; x++)
                    {
                        int px = x * tileSize + 1;
                        int py = y * tileSize + 1;
                        var r = new Rectangle(px, py, tileSize, tileSize);
                        g.FillRectangle(Field[x, y] ? cellSetBrush : cellUnsetBrush, r);
                        //if (DrawGrid && y > 0) g.DrawLine(cellBorderPen, px, py, px + tileSize, py);
                        //if (DrawGrid && x > 0) g.DrawLine(cellBorderPen, px, py, px, py + tileSize);
                        //if (DrawGrid) g.DrawRectangle(cellBorderPen, r);
                    }
                if (DrawGrid) // optimized grid drawing
                {
                    for (int x = 1; x < fieldWidth; x++)
                    {
                        int px = x * tileSize + 1;
                        g.DrawLine(cellBorderPen, px, 0, px, Height - 1);
                        //g.FillRectangle(cellSetBrush, px, 0, 1, Height);
                    }
                    for (int y = 1; y < fieldHeight; y++)
                    {
                        int py = y * tileSize + 1;
                        g.DrawLine(cellBorderPen, 0, py, Width - 1, py);
                        //g.FillRectangle(cellSetBrush, 0, py, Width, 1);
                    }
                }
                if (DrawBorder) g.DrawRectangle(cellBorderPen, 0, 0, Width - 1, Height - 1);
            }
            finally
            {
                cellSetBrush?.Dispose();
                cellUnsetBrush?.Dispose();
                cellBorderPen?.Dispose();
            }
            watch.Stop();
            DrawPaintPerformance?.Invoke(watch.ElapsedTicks);
        }

        public delegate bool FillFuncDelegate(int x, int y);
        public void ForEach(FillFuncDelegate fillFunc)
        {
            for (int y = 0; y < fieldHeight; y++)
                for (int x = 0; x < fieldWidth; x++)
                    Field[x, y] = fillFunc(x, y);
            Invalidate();
        }

        public void CloneForEach(FillFuncDelegate fillFunc)
        {
            bool[,] f = new bool[fieldWidth, fieldHeight];
            for (int y = 0; y < fieldHeight; y++)
                for (int x = 0; x < fieldWidth; x++)
                    f[x, y] = fillFunc(x, y);
            Field = f;
            Invalidate();
        }

        public bool this[int x, int y]
        {
            get
            {
                if (x >= 0 && x < fieldWidth && y >= 0 && y < fieldHeight) return Field[x, y];
                return false;
            }
            set
            {
                if (x >= 0 && x < fieldWidth && y >= 0 && y < fieldHeight) Field[x, y] = value;
            }
        }

        public void AdjustSizeIfNeeded(int w, int h)
        {
            if (FieldWidth != w) FieldWidth = w;
            if (FieldHeight != h) FieldHeight = h;
        }

        void updateControlSize()
        {
            Width = fieldWidth * tileSize + 2;
            Height = fieldHeight * tileSize + 2;
            Refresh();
        }

        int fieldWidth = 8;
        public int FieldWidth
        {
            get { return fieldWidth; }
            set
            {
                fieldWidth = value;
                Field = new bool[fieldWidth, fieldHeight];
                updateControlSize();
            }
        }

        int fieldHeight = 8;
        public int FieldHeight
        {
            get { return fieldHeight; }
            set
            {
                fieldHeight = value;
                Field = new bool[fieldWidth, fieldHeight];
                updateControlSize();
            }
        }

        int tileSize = 16;
        public int TileSize
        {
            get { return tileSize; }
            set
            {
                tileSize = value;
                updateControlSize();
            }
        }
    }
}
