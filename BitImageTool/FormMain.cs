using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BitImageTool
{
    public partial class FormMain : Form
    {
        string appVersion = "0.2";
        Icon icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        BitEditor tmpEditor = new BitEditor();
        StringBuilder strout = new StringBuilder();

        public FormMain()
        {
            InitializeComponent();
            
            this.Icon = icon;
            this.Text += " v" + appVersion;
            tmpEditor.AdjustSizeIfNeeded(64, 64);

            bitEditor.ChangedByUser += BitEditor_ChangedByUser;
            bitEditorPreview.SizeChanged += (sender, e) => bitEditor.Top = bitEditorPreview.Top + bitEditorPreview.Height + 16;

            sliderWidthOrHeight_PositionChanged();
            sliderBaseCode_PositionChanged();
        }

        void updateEditors()
        {
            bitEditor.Invalidate();
            bitEditorPreview.AdjustSizeIfNeeded(bitEditor.FieldWidth, bitEditor.FieldHeight);
            bitEditorPreview.CopyFrom(bitEditor);
        }

        void imageToString()
        {
            strout.Clear();
            int basecode = sliderBaseCode.Position + 32;
            strout.Append((char)basecode);
            strout.Append((char)(basecode + bitEditor.FieldWidth));
            strout.Append((char)(basecode + bitEditor.FieldHeight));
            byte v = 0;
            byte bpos = 1;
            for (int y = 0; y < bitEditor.FieldHeight; y++)
                for (int x = 0; x < bitEditor.FieldWidth; x++)
                {
                    if (bitEditor.Field[x, y]) v |= bpos;
                    bpos <<= 1;
                    if (bpos >= 64) { strout.Append((char)(basecode + v)); v = 0; bpos = 1; }
                }
            if (bpos > 1) strout.Append((char)(basecode + v));
            textBoxOutput.Text = strout.ToString();
            textBoxOutput.BackColor = Color.White;
        }

        void stringToImage()
        {
            try
            {
                string s = textBoxOutput.Text;
                int basecode = s[0];
                if (basecode < 32) basecode = 32;
                if (basecode > 63) basecode = 63;

                int w = s[1] - basecode;
                int h = s[2] - basecode;
                bitEditor.AdjustSizeIfNeeded(w, h);
                while (s.Length < w * h / 6 + 2) s += '0';
                for (int y = 0; y < h; y++)
                    for (int x = 0; x < w; x++)
                        bitEditor.Field[x, y] = 3 + (y * w + x) / 6 < s.Length ? ((s[3 + (y * w + x) / 6] - basecode) & (1 << (y * w + x) % 6)) > 0 : false;
                updateEditors();
                sliderBaseCode.Position = basecode - 32;
                textBoxOutput.BackColor = Color.White;
            }
            catch
            {
                textBoxOutput.BackColor = Color.Red;
            }
        }

        //Bitmap stringToBitmap(Color pen, string s)
        //{
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

        private void BitEditor_ChangedByUser(object sender, int x, int y, bool value)
        {
            bitEditorPreview.Field[x, y] = value;
            bitEditorPreview.Invalidate();
            imageToString();
        }

        private void sliderTileSize_PositionChanged()
        {
            bitEditor.TileSize = sliderTileSize.Position + 6;
        }

        private void sliderPreviewSize_PositionChanged()
        {
            bitEditorPreview.TileSize = sliderPreviewSize.Position + 1;
        }

        private void sliderWidthOrHeight_PositionChanged()
        {
            tmpEditor.CopyFrom(bitEditor);
            bitEditor.AdjustSizeIfNeeded(sliderWidth.Position + 8, sliderHeight.Position + 8);
            bitEditorPreview.AdjustSizeIfNeeded(bitEditor.FieldWidth, bitEditor.FieldHeight);
            bitEditor.CopyFrom(tmpEditor);
            bitEditorPreview.CopyFrom(bitEditor);

            labelWidth.Text = $"Width: {sliderWidth.Position + 8}";
            labelHeight.Text = $"Height: {sliderHeight.Position + 8}";

            imageToString();
        }

        private void textBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x0D) { stringToImage(); e.Handled = true; }
        }

        private void toolButtonClear_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.ForEach((x, y) => false);
            updateEditors();
            imageToString();
        }

        private void toolButtonFill_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.ForEach((x, y) => true);
            updateEditors();
            imageToString();
        }

        private void toolButtonInvert_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.ForEach((x, y) => !bitEditor[x, y]);
            updateEditors();
            imageToString();
        }

        private void toolButtonFlipHoriz_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.CloneForEach((x, y) => bitEditor[bitEditor.FieldWidth - x - 1, y]);
            updateEditors();
            imageToString();
        }

        private void toolButtonFlipVert_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.CloneForEach((x, y) => bitEditor[x, bitEditor.FieldHeight - y - 1]);
            updateEditors();
            imageToString();
        }

        private void toolButtonRotateCW_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.CloneForEach((x, y) => bitEditor[bitEditor.FieldWidth - y - 1, x]);
            updateEditors();
            imageToString();
        }

        private void toolButtonRotateCCW_MouseDown(object sender, MouseEventArgs e)
        {
            bitEditor.CloneForEach((x, y) => bitEditor[y, bitEditor.FieldWidth - x - 1]);
            updateEditors();
            imageToString();
        }

        private void toolButtonShiftUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolButtonCyclic.IsChecked)
                bitEditor.CloneForEach((x, y) => (y == bitEditor.FieldHeight - 1) ? bitEditor[x, 0] : bitEditor[x, y + 1]);
            else bitEditor.CloneForEach((x, y) => bitEditor[x, y + 1]);
            updateEditors();
            imageToString();
        }

        private void toolButtonShiftDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolButtonCyclic.IsChecked)
                bitEditor.CloneForEach((x, y) => (y == 0) ? bitEditor[x, bitEditor.FieldHeight - 1] : bitEditor[x, y - 1]);
            else bitEditor.CloneForEach((x, y) => bitEditor[x, y - 1]);
            updateEditors();
            imageToString();
        }

        private void toolButtonShiftLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolButtonCyclic.IsChecked)
                bitEditor.CloneForEach((x, y) => (x == bitEditor.FieldWidth - 1) ? bitEditor[0, y] : bitEditor[x + 1, y]);
            else bitEditor.CloneForEach((x, y) => bitEditor[x + 1, y]);
            updateEditors();
            imageToString();
        }

        private void toolButtonShiftRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolButtonCyclic.IsChecked)
                bitEditor.CloneForEach((x, y) => (x == 0) ? bitEditor[bitEditor.FieldWidth - 1, y] : bitEditor[x - 1, y]);
            else bitEditor.CloneForEach((x, y) => bitEditor[x - 1, y]);
            updateEditors();
            imageToString();
        }

        private void sliderBaseCode_PositionChanged()
        {
            labelBaseCode.Text = $"Base code {sliderBaseCode.Position + 32}";
            imageToString();
        }

        private void toolButtonCopyOutput_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(textBoxOutput.Text);
        }

        private void toolButtonPasteOutput_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxOutput.Text = Clipboard.GetText();
            stringToImage();
        }

        private void toolButtonAbout_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Version {appVersion}\r\nMIT License\r\ndeveloper: questfulcat\r\nhttps://github.com/questfulcat/BitImageTool", "BitImageTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
