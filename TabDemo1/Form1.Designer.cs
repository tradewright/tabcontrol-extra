namespace TabDemo1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlExtra2 = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.tabControlExtra1 = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControlExtra2.SuspendLayout();
            this.tabControlExtra1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.tabControlExtra2);
            this.panel3.Controls.Add(this.tabControlExtra1);
            this.panel3.Location = new System.Drawing.Point(28, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 421);
            this.panel3.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(20, 313);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 76);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.TabControl1_Click);
            this.tabControl1.DoubleClick += new System.EventHandler(this.TabControl1_DoubleClick);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseClick);
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseDoubleClick);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseDown);
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wazzles";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.TabPage1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gloopy Mongolian Furzletts";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.TabPage2_Paint);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(541, 50);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hoopy Froods";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(541, 50);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Z";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(541, 50);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Extremely long tab caption that will overflow the available space in the control," +
    " at least it will if I make it even longer than it already is - I should think t" +
    "his must be enough!";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(21, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Note: this is a standard TabControl";
            // 
            // tabControlExtra2
            // 
            this.tabControlExtra2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlExtra2.Controls.Add(this.tabPage16);
            this.tabControlExtra2.Controls.Add(this.tabPage17);
            this.tabControlExtra2.Controls.Add(this.tabPage18);
            this.tabControlExtra2.Controls.Add(this.tabPage19);
            this.tabControlExtra2.Controls.Add(this.tabPage20);
            this.tabControlExtra2.DisplayStyle = TradeWright.UI.Forms.TabStyle.Chrome;
            // 
            // 
            // 
            this.tabControlExtra2.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControlExtra2.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabControlExtra2.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlExtra2.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabControlExtra2.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabControlExtra2.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(159)))), ((int)(((byte)(148)))));
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(159)))), ((int)(((byte)(148)))));
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(159)))), ((int)(((byte)(148)))));
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.tabControlExtra2.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorFocused = System.Drawing.Color.Black;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.Color.White;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.Color.Black;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.Color.White;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorSelected = System.Drawing.Color.Black;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.Color.White;
            this.tabControlExtra2.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControlExtra2.DisplayStyleProvider.FocusTrack = false;
            this.tabControlExtra2.DisplayStyleProvider.HotTrack = true;
            this.tabControlExtra2.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabControlExtra2.DisplayStyleProvider.Opacity = 1F;
            this.tabControlExtra2.DisplayStyleProvider.Overlap = 16;
            this.tabControlExtra2.DisplayStyleProvider.Padding = new System.Drawing.Point(16, 5);
            this.tabControlExtra2.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabControlExtra2.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabControlExtra2.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.SelectedTabIsLarger = false;
            this.tabControlExtra2.DisplayStyleProvider.ShowTabCloser = true;
            this.tabControlExtra2.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.TabColorFocused1 = System.Drawing.SystemColors.ControlLight;
            this.tabControlExtra2.DisplayStyleProvider.TabColorFocused2 = System.Drawing.SystemColors.ControlLight;
            this.tabControlExtra2.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControlExtra2.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabControlExtra2.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabControlExtra2.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabControlExtra2.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.tabControlExtra2.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabControlExtra2.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabControlExtra2.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControlExtra2.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlText;
            this.tabControlExtra2.HotTrack = true;
            this.tabControlExtra2.Location = new System.Drawing.Point(20, 135);
            this.tabControlExtra2.Name = "tabControlExtra2";
            this.tabControlExtra2.SelectedIndex = 0;
            this.tabControlExtra2.Size = new System.Drawing.Size(567, 94);
            this.tabControlExtra2.TabIndex = 3;
            this.tabControlExtra2.TabOffset = 0;
            this.tabControlExtra2.TabClosing += new System.EventHandler<System.Windows.Forms.TabControlCancelEventArgs>(this.tabControlExtra2_TabClosing);
            this.tabControlExtra2.TabClosed += new System.EventHandler<System.Windows.Forms.TabControlEventArgs>(this.tabControlExtra2_TabClosed);
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 4);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(559, 60);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Wazzles with sprinkles";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Location = new System.Drawing.Point(4, 4);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(559, 60);
            this.tabPage17.TabIndex = 1;
            this.tabPage17.Text = "Gloopy Mongolian Furzletts";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // tabPage18
            // 
            this.tabPage18.Location = new System.Drawing.Point(4, 4);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(559, 60);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Hoopy Froods";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // tabPage19
            // 
            this.tabPage19.Location = new System.Drawing.Point(4, 4);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(559, 60);
            this.tabPage19.TabIndex = 3;
            this.tabPage19.Text = "Z";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // tabPage20
            // 
            this.tabPage20.Location = new System.Drawing.Point(4, 4);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage20.Size = new System.Drawing.Size(559, 60);
            this.tabPage20.TabIndex = 4;
            this.tabPage20.Text = "Extremely long tab caption that will overflow the available space in the control";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // tabControlExtra1
            // 
            this.tabControlExtra1.Controls.Add(this.tabPage11);
            this.tabControlExtra1.Controls.Add(this.tabPage12);
            this.tabControlExtra1.Controls.Add(this.tabPage13);
            this.tabControlExtra1.Controls.Add(this.tabPage14);
            this.tabControlExtra1.Controls.Add(this.tabPage15);
            this.tabControlExtra1.DisplayStyle = TradeWright.UI.Forms.TabStyle.Rectangular;
            // 
            // 
            // 
            this.tabControlExtra1.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabControlExtra1.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControlExtra1.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControlExtra1.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.tabControlExtra1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.tabControlExtra1.DisplayStyleProvider.BorderColorUnselected = System.Drawing.Color.Transparent;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.CloserColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.Color.White;
            this.tabControlExtra1.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(195)))), ((int)(((byte)(241)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.Color.White;
            this.tabControlExtra1.DisplayStyleProvider.CloserColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(112)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tabControlExtra1.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabControlExtra1.DisplayStyleProvider.FocusTrack = false;
            this.tabControlExtra1.DisplayStyleProvider.HotTrack = true;
            this.tabControlExtra1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabControlExtra1.DisplayStyleProvider.Opacity = 1F;
            this.tabControlExtra1.DisplayStyleProvider.Overlap = 0;
            this.tabControlExtra1.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 5);
            this.tabControlExtra1.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabControlExtra1.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControlExtra1.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.tabControlExtra1.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.tabControlExtra1.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.Color.DimGray;
            this.tabControlExtra1.DisplayStyleProvider.SelectedTabIsLarger = false;
            this.tabControlExtra1.DisplayStyleProvider.ShowTabCloser = true;
            this.tabControlExtra1.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabControlExtra1.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabControlExtra1.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControlExtra1.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControlExtra1.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.tabControlExtra1.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.tabControlExtra1.DisplayStyleProvider.TabColorSelected1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.tabControlExtra1.DisplayStyleProvider.TabColorSelected2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.tabControlExtra1.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.Color.Transparent;
            this.tabControlExtra1.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.Color.Transparent;
            this.tabControlExtra1.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tabControlExtra1.DisplayStyleProvider.TextColorFocused = System.Drawing.Color.White;
            this.tabControlExtra1.DisplayStyleProvider.TextColorHighlighted = System.Drawing.Color.White;
            this.tabControlExtra1.DisplayStyleProvider.TextColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tabControlExtra1.DisplayStyleProvider.TextColorUnselected = System.Drawing.Color.White;
            this.tabControlExtra1.HotTrack = true;
            this.tabControlExtra1.Location = new System.Drawing.Point(20, 20);
            this.tabControlExtra1.Name = "tabControlExtra1";
            this.tabControlExtra1.SelectedIndex = 0;
            this.tabControlExtra1.Size = new System.Drawing.Size(567, 94);
            this.tabControlExtra1.TabIndex = 2;
            this.tabControlExtra1.TabOffset = 300;
            this.tabControlExtra1.TabClosing += new System.EventHandler<System.Windows.Forms.TabControlCancelEventArgs>(this.tabControlExtra1_TabClosing);
            this.tabControlExtra1.TabClosed += new System.EventHandler<System.Windows.Forms.TabControlEventArgs>(this.tabControlExtra1_TabClosed);
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 30);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage11.Size = new System.Drawing.Size(559, 60);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "Wazzles";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 30);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(559, 60);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "Gloopy Mongolian Furzletts";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 30);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(559, 60);
            this.tabPage13.TabIndex = 2;
            this.tabPage13.Text = "Hoopy Froods";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 30);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(559, 60);
            this.tabPage14.TabIndex = 3;
            this.tabPage14.Text = "Z";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 30);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(559, 60);
            this.tabPage15.TabIndex = 4;
            this.tabPage15.Text = "Extremely long tab caption that will overflow the available space in the control";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControlExtra2.ResumeLayout(false);
            this.tabControlExtra1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TradeWright.UI.Forms.TabControlExtra tabControlExtra1;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage15;
        private TradeWright.UI.Forms.TabControlExtra tabControlExtra2;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
    }
}

