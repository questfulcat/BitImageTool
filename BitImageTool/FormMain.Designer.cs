namespace BitImageTool
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelBaseCode = new System.Windows.Forms.Label();
            this.toolButtonFlipVert = new BitImageTool.ToolButton();
            this.toolButtonRotateCCW = new BitImageTool.ToolButton();
            this.toolButtonShiftRight = new BitImageTool.ToolButton();
            this.toolButtonCyclic = new BitImageTool.ToolButton();
            this.toolButtonShiftLeft = new BitImageTool.ToolButton();
            this.toolButtonShiftDown = new BitImageTool.ToolButton();
            this.toolButtonShiftUp = new BitImageTool.ToolButton();
            this.toolButtonRotateCW = new BitImageTool.ToolButton();
            this.toolButtonFlipHoriz = new BitImageTool.ToolButton();
            this.toolButtonInvert = new BitImageTool.ToolButton();
            this.toolButtonFill = new BitImageTool.ToolButton();
            this.toolButtonDrawGrid = new BitImageTool.ToolButton();
            this.toolButtonAbout = new BitImageTool.ToolButton();
            this.toolButtonClear = new BitImageTool.ToolButton();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderBaseCode = new BitImageTool.Slider();
            this.sliderHeight = new BitImageTool.Slider();
            this.sliderWidth = new BitImageTool.Slider();
            this.sliderPreviewSize = new BitImageTool.Slider();
            this.sliderTileSize = new BitImageTool.Slider();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.bitEditorPreview = new BitImageTool.BitEditor();
            this.bitEditor = new BitImageTool.BitEditor();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panelOutputButtons = new System.Windows.Forms.Panel();
            this.toolButtonPasteOutput = new BitImageTool.ToolButton();
            this.toolButtonCopyOutput = new BitImageTool.ToolButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelControls.SuspendLayout();
            this.panelEditor.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panelOutputButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.Controls.Add(this.labelBaseCode);
            this.panelControls.Controls.Add(this.toolButtonFlipVert);
            this.panelControls.Controls.Add(this.toolButtonRotateCCW);
            this.panelControls.Controls.Add(this.toolButtonShiftRight);
            this.panelControls.Controls.Add(this.toolButtonCyclic);
            this.panelControls.Controls.Add(this.toolButtonShiftLeft);
            this.panelControls.Controls.Add(this.toolButtonShiftDown);
            this.panelControls.Controls.Add(this.toolButtonShiftUp);
            this.panelControls.Controls.Add(this.toolButtonRotateCW);
            this.panelControls.Controls.Add(this.toolButtonFlipHoriz);
            this.panelControls.Controls.Add(this.toolButtonInvert);
            this.panelControls.Controls.Add(this.toolButtonFill);
            this.panelControls.Controls.Add(this.toolButtonDrawGrid);
            this.panelControls.Controls.Add(this.toolButtonAbout);
            this.panelControls.Controls.Add(this.toolButtonClear);
            this.panelControls.Controls.Add(this.labelHeight);
            this.panelControls.Controls.Add(this.labelWidth);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.sliderBaseCode);
            this.panelControls.Controls.Add(this.sliderHeight);
            this.panelControls.Controls.Add(this.sliderWidth);
            this.panelControls.Controls.Add(this.sliderPreviewSize);
            this.panelControls.Controls.Add(this.sliderTileSize);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Location = new System.Drawing.Point(784, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(200, 661);
            this.panelControls.TabIndex = 0;
            // 
            // labelBaseCode
            // 
            this.labelBaseCode.AutoSize = true;
            this.labelBaseCode.Location = new System.Drawing.Point(8, 246);
            this.labelBaseCode.Name = "labelBaseCode";
            this.labelBaseCode.Size = new System.Drawing.Size(58, 13);
            this.labelBaseCode.TabIndex = 4;
            this.labelBaseCode.Text = "Base code";
            // 
            // toolButtonFlipVert
            // 
            this.toolButtonFlipVert.EncodedImage = "0DD0000oo0lo3Po70l?0PO00l00P10000nooioo70000H00`30PO00o30nO0lo3`o?0000";
            this.toolButtonFlipVert.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonFlipVert.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonFlipVert.IsChecked = false;
            this.toolButtonFlipVert.Location = new System.Drawing.Point(163, 319);
            this.toolButtonFlipVert.Name = "toolButtonFlipVert";
            this.toolButtonFlipVert.RadioGroup = 0;
            this.toolButtonFlipVert.Size = new System.Drawing.Size(24, 24);
            this.toolButtonFlipVert.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonFlipVert, "Flip vertically");
            this.toolButtonFlipVert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonFlipVert_MouseDown);
            // 
            // toolButtonRotateCCW
            // 
            this.toolButtonRotateCCW.EncodedImage = "0DD00000000?00o30>L0<03H0HP1P130<<0``00371<H60PO00l10`70PO00o100000000";
            this.toolButtonRotateCCW.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonRotateCCW.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonRotateCCW.IsChecked = false;
            this.toolButtonRotateCCW.Location = new System.Drawing.Point(163, 349);
            this.toolButtonRotateCCW.Name = "toolButtonRotateCCW";
            this.toolButtonRotateCCW.RadioGroup = 0;
            this.toolButtonRotateCCW.Size = new System.Drawing.Size(24, 24);
            this.toolButtonRotateCCW.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonRotateCCW, "Rotate CCW");
            this.toolButtonRotateCCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonRotateCCW_MouseDown);
            // 
            // toolButtonShiftRight
            // 
            this.toolButtonShiftRight.EncodedImage = "0DD000000000000000000000H00P700n1hoOPoo10n10h10P1000000000000000000000";
            this.toolButtonShiftRight.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonShiftRight.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonShiftRight.IsChecked = false;
            this.toolButtonShiftRight.Location = new System.Drawing.Point(119, 433);
            this.toolButtonShiftRight.Name = "toolButtonShiftRight";
            this.toolButtonShiftRight.RadioGroup = 0;
            this.toolButtonShiftRight.Size = new System.Drawing.Size(24, 24);
            this.toolButtonShiftRight.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonShiftRight, "Shift Right");
            this.toolButtonShiftRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonShiftRight_MouseDown);
            // 
            // toolButtonCyclic
            // 
            this.toolButtonCyclic.ButtonType = BitImageTool.ToolButtonType.Check;
            this.toolButtonCyclic.EncodedImage = "0DD00000000000l10lO0hP3P1<03P1<06`0H03P1<060`L0lc0`o30n30`300<00000000";
            this.toolButtonCyclic.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonCyclic.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonCyclic.IsChecked = true;
            this.toolButtonCyclic.Location = new System.Drawing.Point(88, 433);
            this.toolButtonCyclic.Name = "toolButtonCyclic";
            this.toolButtonCyclic.RadioGroup = 0;
            this.toolButtonCyclic.Size = new System.Drawing.Size(24, 24);
            this.toolButtonCyclic.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonCyclic, "Cyclic shift");
            // 
            // toolButtonShiftLeft
            // 
            this.toolButtonShiftLeft.EncodedImage = "0DD000000000000000000000H00h10h70hoOPoo1h700N00P1000000000000000000000";
            this.toolButtonShiftLeft.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonShiftLeft.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonShiftLeft.IsChecked = false;
            this.toolButtonShiftLeft.Location = new System.Drawing.Point(57, 433);
            this.toolButtonShiftLeft.Name = "toolButtonShiftLeft";
            this.toolButtonShiftLeft.RadioGroup = 0;
            this.toolButtonShiftLeft.Size = new System.Drawing.Size(24, 24);
            this.toolButtonShiftLeft.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonShiftLeft, "Shift Left");
            this.toolButtonShiftLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonShiftLeft_MouseDown);
            // 
            // toolButtonShiftDown
            // 
            this.toolButtonShiftDown.EncodedImage = "0DD00000000000H00P100600H00P100600o30l?0PO00n10`300?00H00P100000000000";
            this.toolButtonShiftDown.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonShiftDown.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonShiftDown.IsChecked = false;
            this.toolButtonShiftDown.Location = new System.Drawing.Point(88, 464);
            this.toolButtonShiftDown.Name = "toolButtonShiftDown";
            this.toolButtonShiftDown.RadioGroup = 0;
            this.toolButtonShiftDown.Size = new System.Drawing.Size(24, 24);
            this.toolButtonShiftDown.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonShiftDown, "Shift Down");
            this.toolButtonShiftDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonShiftDown_MouseDown);
            // 
            // toolButtonShiftUp
            // 
            this.toolButtonShiftUp.EncodedImage = "0DD00000000000H00P100?00l00h70PO00o30l?00600H00P100600H00P100000000000";
            this.toolButtonShiftUp.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonShiftUp.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonShiftUp.IsChecked = false;
            this.toolButtonShiftUp.Location = new System.Drawing.Point(88, 403);
            this.toolButtonShiftUp.Name = "toolButtonShiftUp";
            this.toolButtonShiftUp.RadioGroup = 0;
            this.toolButtonShiftUp.Size = new System.Drawing.Size(24, 24);
            this.toolButtonShiftUp.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonShiftUp, "Shift Up");
            this.toolButtonShiftUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonShiftUp_MouseDown);
            // 
            // toolButtonRotateCW
            // 
            this.toolButtonRotateCW.EncodedImage = "0DD00000000?00o30>L0<03H0HP1P130<<0``00338>0PI00n10h30P?00n10h?0000000";
            this.toolButtonRotateCW.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonRotateCW.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonRotateCW.IsChecked = false;
            this.toolButtonRotateCW.Location = new System.Drawing.Point(133, 349);
            this.toolButtonRotateCW.Name = "toolButtonRotateCW";
            this.toolButtonRotateCW.RadioGroup = 0;
            this.toolButtonRotateCW.Size = new System.Drawing.Size(24, 24);
            this.toolButtonRotateCW.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonRotateCW, "Rotate CW");
            this.toolButtonRotateCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonRotateCW_MouseDown);
            // 
            // toolButtonFlipHoriz
            // 
            this.toolButtonFlipHoriz.EncodedImage = "0DD0000P100600H0HP1V36LNHhiSaWOVOnKoi_mWOVOnHliQQW36L6HP1P100600H00000";
            this.toolButtonFlipHoriz.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonFlipHoriz.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonFlipHoriz.IsChecked = false;
            this.toolButtonFlipHoriz.Location = new System.Drawing.Point(133, 319);
            this.toolButtonFlipHoriz.Name = "toolButtonFlipHoriz";
            this.toolButtonFlipHoriz.RadioGroup = 0;
            this.toolButtonFlipHoriz.Size = new System.Drawing.Size(24, 24);
            this.toolButtonFlipHoriz.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonFlipHoriz, "Flip horizontally");
            this.toolButtonFlipHoriz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonFlipHoriz_MouseDown);
            // 
            // toolButtonInvert
            // 
            this.toolButtonInvert.EncodedImage = "0DD000hooWooOno_ioOVooHnoQio3Vo7Hn?PiO0Vo0Hn1Pi30V70H>0PI00VooOnoo1000";
            this.toolButtonInvert.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonInvert.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonInvert.IsChecked = false;
            this.toolButtonInvert.Location = new System.Drawing.Point(73, 319);
            this.toolButtonInvert.Name = "toolButtonInvert";
            this.toolButtonInvert.RadioGroup = 0;
            this.toolButtonInvert.Size = new System.Drawing.Size(24, 24);
            this.toolButtonInvert.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonInvert, "Invert");
            this.toolButtonInvert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonInvert_MouseDown);
            // 
            // toolButtonFill
            // 
            this.toolButtonFill.EncodedImage = "0DD000hooWooOnooiooWooOnooiooWooOnooiooWooOnooiooWooOnooiooWooOnoo1000";
            this.toolButtonFill.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonFill.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonFill.IsChecked = false;
            this.toolButtonFill.Location = new System.Drawing.Point(43, 319);
            this.toolButtonFill.Name = "toolButtonFill";
            this.toolButtonFill.RadioGroup = 0;
            this.toolButtonFill.Size = new System.Drawing.Size(24, 24);
            this.toolButtonFill.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonFill, "Fill");
            this.toolButtonFill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonFill_MouseDown);
            // 
            // toolButtonDrawGrid
            // 
            this.toolButtonDrawGrid.ButtonType = BitImageTool.ToolButtonType.Check;
            this.toolButtonDrawGrid.EncodedImage = "0DD0000P0000008000000200000P00000ZZZ00000200000P0000008000000200000000";
            this.toolButtonDrawGrid.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonDrawGrid.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonDrawGrid.IsChecked = true;
            this.toolButtonDrawGrid.Location = new System.Drawing.Point(13, 10);
            this.toolButtonDrawGrid.Name = "toolButtonDrawGrid";
            this.toolButtonDrawGrid.RadioGroup = 0;
            this.toolButtonDrawGrid.Size = new System.Drawing.Size(24, 24);
            this.toolButtonDrawGrid.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonDrawGrid, "Draw Grid");
            this.toolButtonDrawGrid.CheckedChanged += new System.Action<bool>(this.toolButtonDrawGrid_CheckedChanged);
            // 
            // toolButtonAbout
            // 
            this.toolButtonAbout.EncodedImage = "0DD0000000P?00o10>>0H`0P1300<00h00`10P300700<00`000000<00h10P700<00000";
            this.toolButtonAbout.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonAbout.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonAbout.IsChecked = false;
            this.toolButtonAbout.Location = new System.Drawing.Point(163, 10);
            this.toolButtonAbout.Name = "toolButtonAbout";
            this.toolButtonAbout.RadioGroup = 0;
            this.toolButtonAbout.Size = new System.Drawing.Size(24, 24);
            this.toolButtonAbout.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonAbout, "About");
            this.toolButtonAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolButtonAbout_MouseUp);
            // 
            // toolButtonClear
            // 
            this.toolButtonClear.EncodedImage = "0DD000hooWooO60PI00V10H60PI00V10H60PI00V10H60PI00V10H60PI00VooOnoo1000";
            this.toolButtonClear.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonClear.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonClear.IsChecked = false;
            this.toolButtonClear.Location = new System.Drawing.Point(13, 319);
            this.toolButtonClear.Name = "toolButtonClear";
            this.toolButtonClear.RadioGroup = 0;
            this.toolButtonClear.Size = new System.Drawing.Size(24, 24);
            this.toolButtonClear.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonClear, "Clear");
            this.toolButtonClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonClear_MouseDown);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(8, 196);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(8, 146);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preview Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tile Size";
            // 
            // sliderBaseCode
            // 
            this.sliderBaseCode.DrawTicks = false;
            this.sliderBaseCode.Location = new System.Drawing.Point(8, 262);
            this.sliderBaseCode.Maximum = 31;
            this.sliderBaseCode.Name = "sliderBaseCode";
            this.sliderBaseCode.Position = 16;
            this.sliderBaseCode.Size = new System.Drawing.Size(184, 23);
            this.sliderBaseCode.TabIndex = 0;
            this.sliderBaseCode.Text = "slider";
            this.sliderBaseCode.PositionChanged += new System.Action(this.sliderBaseCode_PositionChanged);
            // 
            // sliderHeight
            // 
            this.sliderHeight.DrawTicks = false;
            this.sliderHeight.Location = new System.Drawing.Point(8, 212);
            this.sliderHeight.Maximum = 56;
            this.sliderHeight.Name = "sliderHeight";
            this.sliderHeight.Position = 8;
            this.sliderHeight.Size = new System.Drawing.Size(184, 23);
            this.sliderHeight.TabIndex = 0;
            this.sliderHeight.Text = "slider";
            this.sliderHeight.PositionChanged += new System.Action(this.sliderWidthOrHeight_PositionChanged);
            // 
            // sliderWidth
            // 
            this.sliderWidth.DrawTicks = false;
            this.sliderWidth.Location = new System.Drawing.Point(8, 162);
            this.sliderWidth.Maximum = 56;
            this.sliderWidth.Name = "sliderWidth";
            this.sliderWidth.Position = 8;
            this.sliderWidth.Size = new System.Drawing.Size(184, 23);
            this.sliderWidth.TabIndex = 0;
            this.sliderWidth.Text = "slider";
            this.sliderWidth.PositionChanged += new System.Action(this.sliderWidthOrHeight_PositionChanged);
            // 
            // sliderPreviewSize
            // 
            this.sliderPreviewSize.DrawTicks = false;
            this.sliderPreviewSize.Location = new System.Drawing.Point(8, 112);
            this.sliderPreviewSize.Maximum = 7;
            this.sliderPreviewSize.Name = "sliderPreviewSize";
            this.sliderPreviewSize.Position = 0;
            this.sliderPreviewSize.Size = new System.Drawing.Size(184, 23);
            this.sliderPreviewSize.TabIndex = 0;
            this.sliderPreviewSize.Text = "slider";
            this.sliderPreviewSize.PositionChanged += new System.Action(this.sliderPreviewSize_PositionChanged);
            // 
            // sliderTileSize
            // 
            this.sliderTileSize.DrawTicks = false;
            this.sliderTileSize.Location = new System.Drawing.Point(8, 62);
            this.sliderTileSize.Maximum = 59;
            this.sliderTileSize.Name = "sliderTileSize";
            this.sliderTileSize.Position = 24;
            this.sliderTileSize.Size = new System.Drawing.Size(184, 23);
            this.sliderTileSize.TabIndex = 0;
            this.sliderTileSize.Text = "slider";
            this.sliderTileSize.PositionChanged += new System.Action(this.sliderTileSize_PositionChanged);
            // 
            // panelEditor
            // 
            this.panelEditor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEditor.Controls.Add(this.bitEditorPreview);
            this.panelEditor.Controls.Add(this.bitEditor);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditor.Location = new System.Drawing.Point(0, 0);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(784, 561);
            this.panelEditor.TabIndex = 1;
            // 
            // bitEditorPreview
            // 
            this.bitEditorPreview.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.bitEditorPreview.CellSetColor = System.Drawing.Color.Blue;
            this.bitEditorPreview.CellUnsetColor = System.Drawing.Color.AliceBlue;
            this.bitEditorPreview.DrawBorder = true;
            this.bitEditorPreview.DrawGrid = false;
            this.bitEditorPreview.DrawPaintPerformance = null;
            this.bitEditorPreview.FieldHeight = 8;
            this.bitEditorPreview.FieldWidth = 8;
            this.bitEditorPreview.Location = new System.Drawing.Point(12, 12);
            this.bitEditorPreview.Name = "bitEditorPreview";
            this.bitEditorPreview.ReadOnly = true;
            this.bitEditorPreview.Size = new System.Drawing.Size(10, 10);
            this.bitEditorPreview.TabIndex = 0;
            this.bitEditorPreview.Text = "bitEditorPreview";
            this.bitEditorPreview.TileSize = 1;
            // 
            // bitEditor
            // 
            this.bitEditor.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.bitEditor.CellSetColor = System.Drawing.Color.Blue;
            this.bitEditor.CellUnsetColor = System.Drawing.Color.AliceBlue;
            this.bitEditor.DrawBorder = true;
            this.bitEditor.DrawGrid = true;
            this.bitEditor.DrawPaintPerformance = null;
            this.bitEditor.FieldHeight = 16;
            this.bitEditor.FieldWidth = 16;
            this.bitEditor.Location = new System.Drawing.Point(12, 38);
            this.bitEditor.Name = "bitEditor";
            this.bitEditor.ReadOnly = false;
            this.bitEditor.Size = new System.Drawing.Size(386, 386);
            this.bitEditor.TabIndex = 0;
            this.bitEditor.Text = "bitEditor";
            this.bitEditor.TileSize = 24;
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOutput.Controls.Add(this.textBoxOutput);
            this.panelOutput.Controls.Add(this.panelOutputButtons);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOutput.Location = new System.Drawing.Point(0, 561);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Padding = new System.Windows.Forms.Padding(3);
            this.panelOutput.Size = new System.Drawing.Size(784, 100);
            this.panelOutput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(33, 3);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(748, 94);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutput_KeyPress);
            // 
            // panelOutputButtons
            // 
            this.panelOutputButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOutputButtons.Controls.Add(this.toolButtonPasteOutput);
            this.panelOutputButtons.Controls.Add(this.toolButtonCopyOutput);
            this.panelOutputButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutputButtons.Location = new System.Drawing.Point(3, 3);
            this.panelOutputButtons.Name = "panelOutputButtons";
            this.panelOutputButtons.Size = new System.Drawing.Size(30, 94);
            this.panelOutputButtons.TabIndex = 1;
            // 
            // toolButtonPasteOutput
            // 
            this.toolButtonPasteOutput.EncodedImage = "0DD00000000P100>00h10P?nooioo70P?00N00h00P10000000>Y?8U8PDR0>928H80000";
            this.toolButtonPasteOutput.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonPasteOutput.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonPasteOutput.IsChecked = false;
            this.toolButtonPasteOutput.Location = new System.Drawing.Point(3, 33);
            this.toolButtonPasteOutput.Name = "toolButtonPasteOutput";
            this.toolButtonPasteOutput.RadioGroup = 0;
            this.toolButtonPasteOutput.Size = new System.Drawing.Size(24, 24);
            this.toolButtonPasteOutput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonPasteOutput, "Put from clipboard");
            this.toolButtonPasteOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonPasteOutput_MouseDown);
            // 
            // toolButtonCopyOutput
            // 
            this.toolButtonCopyOutput.EncodedImage = "0DD0000000H00`10P700O00nooioo7O00h100700H000000000ViD4YDATB2Aj8HVP0000";
            this.toolButtonCopyOutput.EncodedImageLocation = new System.Drawing.Point(2, 2);
            this.toolButtonCopyOutput.EncodedImagePen = System.Drawing.Color.Black;
            this.toolButtonCopyOutput.IsChecked = false;
            this.toolButtonCopyOutput.Location = new System.Drawing.Point(3, 3);
            this.toolButtonCopyOutput.Name = "toolButtonCopyOutput";
            this.toolButtonCopyOutput.RadioGroup = 0;
            this.toolButtonCopyOutput.Size = new System.Drawing.Size(24, 24);
            this.toolButtonCopyOutput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.toolButtonCopyOutput, "Copy to clipboard");
            this.toolButtonCopyOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolButtonCopyOutput_MouseDown);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 100;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelEditor);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelControls);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bit Image Tool";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelEditor.ResumeLayout(false);
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.panelOutputButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.Panel panelOutput;
        private BitEditor bitEditorPreview;
        private BitEditor bitEditor;
        private Slider sliderTileSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Slider sliderPreviewSize;
        private System.Windows.Forms.Label labelWidth;
        private Slider sliderWidth;
        private System.Windows.Forms.Label labelHeight;
        private Slider sliderHeight;
        private System.Windows.Forms.TextBox textBoxOutput;
        private ToolButton toolButtonClear;
        private ToolButton toolButtonInvert;
        private ToolButton toolButtonFill;
        private ToolButton toolButtonFlipHoriz;
        private ToolButton toolButtonFlipVert;
        private ToolButton toolButtonRotateCCW;
        private ToolButton toolButtonRotateCW;
        private ToolButton toolButtonShiftDown;
        private ToolButton toolButtonShiftUp;
        private ToolButton toolButtonShiftRight;
        private ToolButton toolButtonCyclic;
        private ToolButton toolButtonShiftLeft;
        private System.Windows.Forms.Label labelBaseCode;
        private Slider sliderBaseCode;
        private System.Windows.Forms.Panel panelOutputButtons;
        private ToolButton toolButtonPasteOutput;
        private ToolButton toolButtonCopyOutput;
        private ToolButton toolButtonAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private ToolButton toolButtonDrawGrid;
    }
}

