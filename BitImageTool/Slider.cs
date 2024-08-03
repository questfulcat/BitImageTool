using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitImageTool
{
    public class Slider : Control
    {
        bool sliderHold = false;
        int sliderSize = 20;
        int tickSize = 4;
        
        Color sliderBrushColor = Color.FromArgb(220, 220, 220);
        Color sliderPenColor = Color.FromArgb(200, 200, 200);
        Color tickBrushColor = Color.FromArgb(230, 230, 230);
        Color trackBrushColor = Color.FromArgb(240, 240, 240);

        public event Action PositionChanged;

        public Slider() : base()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            this.Paint += Slider_Paint;
            this.MouseDown += Slider_MouseDown;
            this.MouseMove += Slider_MouseMove;
            this.MouseUp += Slider_MouseUp;
        }

        private void Slider_MouseDown(object sender, MouseEventArgs e)
        {
            if (getSliderRect().Contains(e.X, e.Y)) sliderHold = true;
        }

        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (sliderHold)
            {
                int pos = (int)((e.X + step / 2 - sliderSize / 2) / step);
                if (pos < 0) pos = 0;
                if (pos > maximum) pos = maximum;
                if (pos != position)
                {
                    position = pos;
                    Refresh();
                    PositionChanged?.Invoke();
                }
            }
        }

        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            sliderHold = false;
        }

        private float step => (float)(this.Width - sliderSize - 1) / maximum;

        private void Slider_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using(SolidBrush trackBrush = new SolidBrush(trackBrushColor))
                g.FillRectangle(trackBrush, sliderSize / 2 - tickSize / 2, this.Height / 2 - tickSize / 2, this.Width - sliderSize + tickSize, tickSize);
            
            using(SolidBrush tickBrush = new SolidBrush(tickBrushColor))
                if (drawTicks)
                    for (int c = 0; c <= maximum; c++) g.FillRectangle(tickBrush, sliderSize / 2 + (int)(c * step) - tickSize / 2, this.Height / 2 - tickSize / 2, tickSize, tickSize);

            Rectangle r = getSliderRect();

            using(SolidBrush sliderBrush = new SolidBrush(sliderBrushColor))
                g.FillRectangle(sliderBrush, r);
            using(Pen sliderPen = new Pen(sliderPenColor))
                g.DrawRectangle(sliderPen, r);
        }

        Rectangle getSliderRect()
        {
            int pos = sliderSize / 2 + (int)(position * step);
            return new Rectangle(pos - sliderSize / 2, this.Height / 2 - sliderSize / 2, sliderSize, sliderSize);
        }

        int count => maximum + 1;

        int position = 0;
        public int Position
        {
            get { return position; }
            set
            {
                position = value;
                Refresh();
                PositionChanged?.Invoke();
            }
        }

        int maximum = 9;
        public int Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value > 0 ? value : 1;
                Refresh();
            }
        }

        bool drawTicks = true;
        public bool DrawTicks
        {
            get { return drawTicks; }
            set { drawTicks = value; Refresh(); }
        }

    }
}
