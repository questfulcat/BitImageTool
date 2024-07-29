﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BitImageTool
{
    public enum ToolButtonType { Button, Check, Radio };

    public class ToolButton : Control
    {
        bool mouseOver = false;
        bool mouseDown = false;

        SolidBrush backBrush = new SolidBrush(Color.FromArgb(0xE0, 0xE0, 0xE0));
        Pen borderPen = new Pen(Color.FromArgb(0xD0, 0xD0, 0xD0));
        SolidBrush mouseOverBrush = new SolidBrush(Color.FromArgb(0xF0, 0xF0, 0xF0));
        SolidBrush mouseDownBrush = new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0xFF));
        SolidBrush checkedBrush = new SolidBrush(Color.FromArgb(0xC0, 0xC0, 0xFF));
        SolidBrush mouseOverCheckedBrush = new SolidBrush(Color.FromArgb(0xD0, 0xD0, 0xFF));


        public ToolButton() : base()
        {
            this.Paint += ToolButton_Paint;
            this.MouseEnter += (sender, e) => { mouseOver = true; Refresh(); };
            this.MouseLeave += (sender, e) => { mouseOver = false; Refresh(); };
            this.MouseDown += (sender, e) => { mouseDown = true; check(); Refresh(); };
            this.MouseUp += (sender, e) => { mouseDown = false; Refresh(); };
            Refresh();
        }

        //Bitmap stringToBitmap(Color pen, string s)
        //{
        //    if (pen == null || s == null) return null;
        //    try
        //    {
        //        int basecode = s[0];
        //        int w = s[1] - basecode;
        //        int h = s[2] - basecode;
        //        Bitmap bmp = new Bitmap(w, h);
        //        for (int y = 0; y < h; y++)
        //            for (int x = 0; x < w; x++)
        //                bmp.SetPixel(x, y, ((s[3 + (y * w + x) / 6] - basecode) & (1 << (y * w + x) % 6)) > 0 ? pen : Color.Transparent);
        //        return bmp;
        //    }
        //    catch { return null; }
        //}

        // with antialiasing
        Bitmap stringToBitmap(Color pen, string s)
        {
            if (pen == null || s == null) return null;
            try
            {
                //var watch = System.Diagnostics.Stopwatch.StartNew();
                Color phalf = Color.FromArgb(pen.A / 4, pen.R, pen.G, pen.B);
                int basecode = s[0];
                int w = s[1] - basecode;
                int h = s[2] - basecode;
                var data = new Color[h, w];
                for (int y = 0; y < h; y++)
                    for (int x = 0; x < w; x++)
                        data[y, x] = ((s[3 + (y * w + x) / 6] - basecode) & (1 << (y * w + x) % 6)) > 0 ? pen : Color.Transparent; 

                // antialiasing
                Bitmap bmp = new Bitmap(w, h);
                for (int y = 1; y < h - 1; y++)
                    for (int x = 1; x < w - 1; x++)
                    {
                        int q = 0;
                        if (data[y - 1, x] == pen) q++;
                        if (data[y + 1, x] == pen) q++;
                        if (data[y, x - 1] == pen) q++;
                        if (data[y, x + 1] == pen) q++;
                        if ((q == 2 || q == 3) && data[y, x] == Color.Transparent) data[y, x] = phalf;
                        bmp.SetPixel(x, y, data[y, x]);
                    }
                //watch.Stop();
                //MessageBox.Show(watch.ElapsedTicks.ToString());
                return bmp;
            }
            catch { return null; }
        }

        private void ToolButton_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            SolidBrush brush;
            if (mouseDown) brush = mouseDownBrush;
            else if (isChecked && mouseOver && buttonType != ToolButtonType.Radio) brush = mouseOverCheckedBrush;
            else if (IsChecked) brush = checkedBrush;
            else if (mouseOver) brush = mouseOverBrush;
            else brush = backBrush;

            g.FillRectangle(brush, 0, 0, this.Width, this.Height);
            
            SizeF textSize = g.MeasureString(text, Font);
            g.DrawString(text, Font, new SolidBrush(this.ForeColor), (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);

            if (encodedImageBitmap == null && !string.IsNullOrWhiteSpace(EncodedImage))
                encodedImageBitmap = stringToBitmap(EncodedImagePen, EncodedImage);

            if (encodedImageBitmap != null) g.DrawImage(encodedImageBitmap, EncodedImageLocation);

            g.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void check()
        {
            if (buttonType == ToolButtonType.Button) isChecked = false;
            if (buttonType == ToolButtonType.Check) isChecked = !isChecked;
            if (buttonType == ToolButtonType.Radio)
            {
                foreach (var c in Parent.Controls) if (c is ToolButton tb && tb.ButtonType == ToolButtonType.Radio && tb.RadioGroup == this.RadioGroup) tb.IsChecked = false;
                isChecked = true;
            }
        }


        ToolButtonType buttonType = ToolButtonType.Button;
        [DefaultValue(ToolButtonType.Button)]
        public ToolButtonType ButtonType
        {
            get { return buttonType; }
            set { buttonType = value; Refresh(); }
        }

        
        bool isChecked = false;
        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; Refresh(); }
        }

        public int RadioGroup { get; set; }

        string text = "";
        public override string Text
        {
            get { return text; }
            set { text = value; Refresh(); }
        }


        Bitmap encodedImageBitmap;
        string encodedImage;
        public string EncodedImage
        {
            get { return encodedImage; }
            set { encodedImage = value; encodedImageBitmap = null; Refresh(); }
        }

        Color encodedImagePen;
        public Color EncodedImagePen
        {
            get { return encodedImagePen; }
            set { encodedImagePen = value; encodedImageBitmap = null; Refresh(); }
        }
        public Point EncodedImageLocation { get; set; }

    }
}