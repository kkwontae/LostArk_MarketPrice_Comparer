
namespace LostArk_MarketPrice_Comparer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.panel_Item = new System.Windows.Forms.Panel();
            this.panel_Bookmark = new System.Windows.Forms.Panel();
            this.metroSetListBox_Bookmark = new MetroSet_UI.Controls.MetroSetListBox();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.panel_Picture = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSetButton_Search = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_Center_padding1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_ItemInfo = new System.Windows.Forms.Panel();
            this.metroSetTextBox_ItemName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel_ItemName = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox_PricePerEach = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel_PricePerEach = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox_Price = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel_Price = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox_BundleCount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel_BundleCount = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox_No = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel_Name = new MetroSet_UI.Controls.MetroSetLabel();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.metroSetCheckBox_Google = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetPanel_Options = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetCheckBox_KillChrome = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetButton_KillChrome = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton_Login = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetCheckBox_OTP = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetTextBox_OTP = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel_Option = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_Item.SuspendLayout();
            this.panel_Bookmark.SuspendLayout();
            this.panel_Center.SuspendLayout();
            this.panel_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ItemInfo.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.metroSetPanel_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalOffset = -1D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.Title = "Gold";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 164);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.CustomProperties = "LineTension=0.6";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.LabelFormat = "#.0";
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.DarkBlue;
            series2.MarkerBorderWidth = 0;
            series2.MarkerColor = System.Drawing.Color.SteelBlue;
            series2.MarkerImageTransparentColor = System.Drawing.Color.White;
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 3;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(491, 177);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(577, 0);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 16;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // panel_Item
            // 
            this.panel_Item.BackColor = System.Drawing.Color.White;
            this.panel_Item.Controls.Add(this.panel_Bookmark);
            this.panel_Item.Controls.Add(this.panel_Center);
            this.panel_Item.Controls.Add(this.panel_ItemInfo);
            this.panel_Item.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item.Location = new System.Drawing.Point(0, 0);
            this.panel_Item.Name = "panel_Item";
            this.panel_Item.Size = new System.Drawing.Size(491, 164);
            this.panel_Item.TabIndex = 19;
            // 
            // panel_Bookmark
            // 
            this.panel_Bookmark.Controls.Add(this.metroSetListBox_Bookmark);
            this.panel_Bookmark.Controls.Add(this.metroSetTextBox1);
            this.panel_Bookmark.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Bookmark.Location = new System.Drawing.Point(323, 0);
            this.panel_Bookmark.Name = "panel_Bookmark";
            this.panel_Bookmark.Padding = new System.Windows.Forms.Padding(3);
            this.panel_Bookmark.Size = new System.Drawing.Size(133, 164);
            this.panel_Bookmark.TabIndex = 2;
            // 
            // metroSetListBox_Bookmark
            // 
            this.metroSetListBox_Bookmark.BackColor = System.Drawing.Color.White;
            this.metroSetListBox_Bookmark.BorderColor = System.Drawing.Color.LightGray;
            this.metroSetListBox_Bookmark.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetListBox_Bookmark.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetListBox_Bookmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetListBox_Bookmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetListBox_Bookmark.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroSetListBox_Bookmark.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroSetListBox_Bookmark.IsDerivedStyle = true;
            this.metroSetListBox_Bookmark.ItemHeight = 25;
            this.metroSetListBox_Bookmark.Location = new System.Drawing.Point(3, 3);
            this.metroSetListBox_Bookmark.MultiSelect = false;
            this.metroSetListBox_Bookmark.Name = "metroSetListBox_Bookmark";
            this.metroSetListBox_Bookmark.SelectedIndex = -1;
            this.metroSetListBox_Bookmark.SelectedItem = null;
            this.metroSetListBox_Bookmark.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetListBox_Bookmark.SelectedItemColor = System.Drawing.Color.White;
            this.metroSetListBox_Bookmark.SelectedText = null;
            this.metroSetListBox_Bookmark.SelectedValue = null;
            this.metroSetListBox_Bookmark.ShowBorder = true;
            this.metroSetListBox_Bookmark.ShowScrollBar = false;
            this.metroSetListBox_Bookmark.Size = new System.Drawing.Size(127, 158);
            this.metroSetListBox_Bookmark.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetListBox_Bookmark.StyleManager = null;
            this.metroSetListBox_Bookmark.TabIndex = 1;
            this.metroSetListBox_Bookmark.TabStop = false;
            this.metroSetListBox_Bookmark.ThemeAuthor = "Narwin";
            this.metroSetListBox_Bookmark.ThemeName = "MetroLite";
            this.metroSetListBox_Bookmark.SelectedIndexChanged += new MetroSet_UI.Controls.MetroSetListBox.SelectedIndexChangedEventHandler(this.metroSetListBox_Bookmark_SelectedIndexChanged);
            this.metroSetListBox_Bookmark.Click += new System.EventHandler(this.metroSetListBox_Bookmark_Click);
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.AutoCompleteCustomSource = null;
            this.metroSetTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.IsDerivedStyle = true;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(3, 3);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = true;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(127, 158);
            this.metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 0;
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroLite";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
            // 
            // panel_Center
            // 
            this.panel_Center.Controls.Add(this.panel_Picture);
            this.panel_Center.Controls.Add(this.metroSetButton_Search);
            this.panel_Center.Controls.Add(this.panel_Center_padding1);
            this.panel_Center.Controls.Add(this.textBox1);
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Center.Location = new System.Drawing.Point(223, 0);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Padding = new System.Windows.Forms.Padding(3);
            this.panel_Center.Size = new System.Drawing.Size(100, 164);
            this.panel_Center.TabIndex = 1;
            // 
            // panel_Picture
            // 
            this.panel_Picture.Controls.Add(this.pictureBox1);
            this.panel_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Picture.Location = new System.Drawing.Point(3, 3);
            this.panel_Picture.Name = "panel_Picture";
            this.panel_Picture.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Picture.Size = new System.Drawing.Size(94, 94);
            this.panel_Picture.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroSetButton_Search
            // 
            this.metroSetButton_Search.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Search.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroSetButton_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_Search.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Search.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Search.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_Search.IsDerivedStyle = true;
            this.metroSetButton_Search.Location = new System.Drawing.Point(3, 97);
            this.metroSetButton_Search.Name = "metroSetButton_Search";
            this.metroSetButton_Search.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Search.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Search.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_Search.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Search.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Search.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_Search.Size = new System.Drawing.Size(94, 31);
            this.metroSetButton_Search.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_Search.StyleManager = null;
            this.metroSetButton_Search.TabIndex = 1;
            this.metroSetButton_Search.Text = "Search";
            this.metroSetButton_Search.ThemeAuthor = "Narwin";
            this.metroSetButton_Search.ThemeName = "MetroLite";
            this.metroSetButton_Search.Click += new System.EventHandler(this.metroSetButton_Search_Click);
            // 
            // panel_Center_padding1
            // 
            this.panel_Center_padding1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Center_padding1.Location = new System.Drawing.Point(3, 128);
            this.panel_Center_padding1.Name = "panel_Center_padding1";
            this.panel_Center_padding1.Size = new System.Drawing.Size(94, 3);
            this.panel_Center_padding1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(3, 131);
            this.textBox1.MaxLength = 10;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 30);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel_ItemInfo
            // 
            this.panel_ItemInfo.Controls.Add(this.metroSetTextBox_ItemName);
            this.panel_ItemInfo.Controls.Add(this.metroSetLabel_ItemName);
            this.panel_ItemInfo.Controls.Add(this.metroSetTextBox_PricePerEach);
            this.panel_ItemInfo.Controls.Add(this.metroSetLabel_PricePerEach);
            this.panel_ItemInfo.Controls.Add(this.metroSetTextBox_Price);
            this.panel_ItemInfo.Controls.Add(this.metroSetLabel_Price);
            this.panel_ItemInfo.Controls.Add(this.metroSetTextBox_BundleCount);
            this.panel_ItemInfo.Controls.Add(this.metroSetLabel_BundleCount);
            this.panel_ItemInfo.Controls.Add(this.metroSetTextBox_No);
            this.panel_ItemInfo.Controls.Add(this.metroSetLabel_Name);
            this.panel_ItemInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ItemInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_ItemInfo.Name = "panel_ItemInfo";
            this.panel_ItemInfo.Size = new System.Drawing.Size(223, 164);
            this.panel_ItemInfo.TabIndex = 0;
            // 
            // metroSetTextBox_ItemName
            // 
            this.metroSetTextBox_ItemName.AutoCompleteCustomSource = null;
            this.metroSetTextBox_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_ItemName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_ItemName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_ItemName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_ItemName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_ItemName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_ItemName.Image = null;
            this.metroSetTextBox_ItemName.IsDerivedStyle = true;
            this.metroSetTextBox_ItemName.Lines = null;
            this.metroSetTextBox_ItemName.Location = new System.Drawing.Point(109, 36);
            this.metroSetTextBox_ItemName.MaxLength = 32767;
            this.metroSetTextBox_ItemName.Multiline = false;
            this.metroSetTextBox_ItemName.Name = "metroSetTextBox_ItemName";
            this.metroSetTextBox_ItemName.ReadOnly = true;
            this.metroSetTextBox_ItemName.Size = new System.Drawing.Size(108, 23);
            this.metroSetTextBox_ItemName.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_ItemName.StyleManager = null;
            this.metroSetTextBox_ItemName.TabIndex = 9;
            this.metroSetTextBox_ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_ItemName.ThemeAuthor = "Narwin";
            this.metroSetTextBox_ItemName.ThemeName = "MetroLite";
            this.metroSetTextBox_ItemName.UseSystemPasswordChar = false;
            this.metroSetTextBox_ItemName.WatermarkText = "";
            // 
            // metroSetLabel_ItemName
            // 
            this.metroSetLabel_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_ItemName.IsDerivedStyle = true;
            this.metroSetLabel_ItemName.Location = new System.Drawing.Point(3, 36);
            this.metroSetLabel_ItemName.Name = "metroSetLabel_ItemName";
            this.metroSetLabel_ItemName.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel_ItemName.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel_ItemName.StyleManager = null;
            this.metroSetLabel_ItemName.TabIndex = 8;
            this.metroSetLabel_ItemName.Text = "Item Name";
            this.metroSetLabel_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_ItemName.ThemeAuthor = "Narwin";
            this.metroSetLabel_ItemName.ThemeName = "MetroLite";
            // 
            // metroSetTextBox_PricePerEach
            // 
            this.metroSetTextBox_PricePerEach.AutoCompleteCustomSource = null;
            this.metroSetTextBox_PricePerEach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_PricePerEach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_PricePerEach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_PricePerEach.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_PricePerEach.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_PricePerEach.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_PricePerEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_PricePerEach.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_PricePerEach.Image = null;
            this.metroSetTextBox_PricePerEach.IsDerivedStyle = true;
            this.metroSetTextBox_PricePerEach.Lines = null;
            this.metroSetTextBox_PricePerEach.Location = new System.Drawing.Point(109, 135);
            this.metroSetTextBox_PricePerEach.MaxLength = 32767;
            this.metroSetTextBox_PricePerEach.Multiline = false;
            this.metroSetTextBox_PricePerEach.Name = "metroSetTextBox_PricePerEach";
            this.metroSetTextBox_PricePerEach.ReadOnly = true;
            this.metroSetTextBox_PricePerEach.Size = new System.Drawing.Size(108, 23);
            this.metroSetTextBox_PricePerEach.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_PricePerEach.StyleManager = null;
            this.metroSetTextBox_PricePerEach.TabIndex = 7;
            this.metroSetTextBox_PricePerEach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_PricePerEach.ThemeAuthor = "Narwin";
            this.metroSetTextBox_PricePerEach.ThemeName = "MetroLite";
            this.metroSetTextBox_PricePerEach.UseSystemPasswordChar = false;
            this.metroSetTextBox_PricePerEach.WatermarkText = "";
            // 
            // metroSetLabel_PricePerEach
            // 
            this.metroSetLabel_PricePerEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel_PricePerEach.IsDerivedStyle = true;
            this.metroSetLabel_PricePerEach.Location = new System.Drawing.Point(3, 135);
            this.metroSetLabel_PricePerEach.Name = "metroSetLabel_PricePerEach";
            this.metroSetLabel_PricePerEach.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel_PricePerEach.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel_PricePerEach.StyleManager = null;
            this.metroSetLabel_PricePerEach.TabIndex = 6;
            this.metroSetLabel_PricePerEach.Text = "Price Per Each";
            this.metroSetLabel_PricePerEach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_PricePerEach.ThemeAuthor = "Narwin";
            this.metroSetLabel_PricePerEach.ThemeName = "MetroLite";
            // 
            // metroSetTextBox_Price
            // 
            this.metroSetTextBox_Price.AutoCompleteCustomSource = null;
            this.metroSetTextBox_Price.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_Price.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_Price.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_Price.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_Price.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_Price.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_Price.Image = null;
            this.metroSetTextBox_Price.IsDerivedStyle = true;
            this.metroSetTextBox_Price.Lines = null;
            this.metroSetTextBox_Price.Location = new System.Drawing.Point(109, 102);
            this.metroSetTextBox_Price.MaxLength = 32767;
            this.metroSetTextBox_Price.Multiline = false;
            this.metroSetTextBox_Price.Name = "metroSetTextBox_Price";
            this.metroSetTextBox_Price.ReadOnly = true;
            this.metroSetTextBox_Price.Size = new System.Drawing.Size(108, 23);
            this.metroSetTextBox_Price.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_Price.StyleManager = null;
            this.metroSetTextBox_Price.TabIndex = 5;
            this.metroSetTextBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_Price.ThemeAuthor = "Narwin";
            this.metroSetTextBox_Price.ThemeName = "MetroLite";
            this.metroSetTextBox_Price.UseSystemPasswordChar = false;
            this.metroSetTextBox_Price.WatermarkText = "";
            // 
            // metroSetLabel_Price
            // 
            this.metroSetLabel_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Price.IsDerivedStyle = true;
            this.metroSetLabel_Price.Location = new System.Drawing.Point(3, 102);
            this.metroSetLabel_Price.Name = "metroSetLabel_Price";
            this.metroSetLabel_Price.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel_Price.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel_Price.StyleManager = null;
            this.metroSetLabel_Price.TabIndex = 4;
            this.metroSetLabel_Price.Text = "Price";
            this.metroSetLabel_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Price.ThemeAuthor = "Narwin";
            this.metroSetLabel_Price.ThemeName = "MetroLite";
            // 
            // metroSetTextBox_BundleCount
            // 
            this.metroSetTextBox_BundleCount.AutoCompleteCustomSource = null;
            this.metroSetTextBox_BundleCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_BundleCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_BundleCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_BundleCount.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_BundleCount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_BundleCount.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_BundleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_BundleCount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_BundleCount.Image = null;
            this.metroSetTextBox_BundleCount.IsDerivedStyle = true;
            this.metroSetTextBox_BundleCount.Lines = null;
            this.metroSetTextBox_BundleCount.Location = new System.Drawing.Point(109, 69);
            this.metroSetTextBox_BundleCount.MaxLength = 32767;
            this.metroSetTextBox_BundleCount.Multiline = false;
            this.metroSetTextBox_BundleCount.Name = "metroSetTextBox_BundleCount";
            this.metroSetTextBox_BundleCount.ReadOnly = true;
            this.metroSetTextBox_BundleCount.Size = new System.Drawing.Size(108, 23);
            this.metroSetTextBox_BundleCount.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_BundleCount.StyleManager = null;
            this.metroSetTextBox_BundleCount.TabIndex = 3;
            this.metroSetTextBox_BundleCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_BundleCount.ThemeAuthor = "Narwin";
            this.metroSetTextBox_BundleCount.ThemeName = "MetroLite";
            this.metroSetTextBox_BundleCount.UseSystemPasswordChar = false;
            this.metroSetTextBox_BundleCount.WatermarkText = "";
            // 
            // metroSetLabel_BundleCount
            // 
            this.metroSetLabel_BundleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_BundleCount.IsDerivedStyle = true;
            this.metroSetLabel_BundleCount.Location = new System.Drawing.Point(3, 69);
            this.metroSetLabel_BundleCount.Name = "metroSetLabel_BundleCount";
            this.metroSetLabel_BundleCount.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel_BundleCount.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel_BundleCount.StyleManager = null;
            this.metroSetLabel_BundleCount.TabIndex = 2;
            this.metroSetLabel_BundleCount.Text = "Bundle Count";
            this.metroSetLabel_BundleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_BundleCount.ThemeAuthor = "Narwin";
            this.metroSetLabel_BundleCount.ThemeName = "MetroLite";
            // 
            // metroSetTextBox_No
            // 
            this.metroSetTextBox_No.AutoCompleteCustomSource = null;
            this.metroSetTextBox_No.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_No.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_No.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_No.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_No.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_No.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_No.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_No.Image = null;
            this.metroSetTextBox_No.IsDerivedStyle = true;
            this.metroSetTextBox_No.Lines = null;
            this.metroSetTextBox_No.Location = new System.Drawing.Point(109, 3);
            this.metroSetTextBox_No.MaxLength = 32767;
            this.metroSetTextBox_No.Multiline = false;
            this.metroSetTextBox_No.Name = "metroSetTextBox_No";
            this.metroSetTextBox_No.ReadOnly = true;
            this.metroSetTextBox_No.Size = new System.Drawing.Size(108, 23);
            this.metroSetTextBox_No.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_No.StyleManager = null;
            this.metroSetTextBox_No.TabIndex = 1;
            this.metroSetTextBox_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_No.ThemeAuthor = "Narwin";
            this.metroSetTextBox_No.ThemeName = "MetroLite";
            this.metroSetTextBox_No.UseSystemPasswordChar = false;
            this.metroSetTextBox_No.WatermarkText = "";
            // 
            // metroSetLabel_Name
            // 
            this.metroSetLabel_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Name.IsDerivedStyle = true;
            this.metroSetLabel_Name.Location = new System.Drawing.Point(3, 3);
            this.metroSetLabel_Name.Name = "metroSetLabel_Name";
            this.metroSetLabel_Name.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel_Name.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel_Name.StyleManager = null;
            this.metroSetLabel_Name.TabIndex = 0;
            this.metroSetLabel_Name.Text = "No.";
            this.metroSetLabel_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Name.ThemeAuthor = "Narwin";
            this.metroSetLabel_Name.ThemeName = "MetroLite";
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.White;
            this.panel_Content.Controls.Add(this.chart1);
            this.panel_Content.Controls.Add(this.panel_Item);
            this.panel_Content.Location = new System.Drawing.Point(17, 92);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(491, 341);
            this.panel_Content.TabIndex = 20;
            // 
            // metroSetCheckBox_Google
            // 
            this.metroSetCheckBox_Google.BackColor = System.Drawing.Color.Transparent;
            this.metroSetCheckBox_Google.BackgroundColor = System.Drawing.Color.White;
            this.metroSetCheckBox_Google.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetCheckBox_Google.Checked = false;
            this.metroSetCheckBox_Google.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetCheckBox_Google.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetCheckBox_Google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetCheckBox_Google.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetCheckBox_Google.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetCheckBox_Google.IsDerivedStyle = true;
            this.metroSetCheckBox_Google.Location = new System.Drawing.Point(5, 97);
            this.metroSetCheckBox_Google.Name = "metroSetCheckBox_Google";
            this.metroSetCheckBox_Google.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.metroSetCheckBox_Google.Size = new System.Drawing.Size(71, 16);
            this.metroSetCheckBox_Google.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetCheckBox_Google.StyleManager = null;
            this.metroSetCheckBox_Google.TabIndex = 20;
            this.metroSetCheckBox_Google.Text = "Google";
            this.metroSetCheckBox_Google.ThemeAuthor = "Narwin";
            this.metroSetCheckBox_Google.ThemeName = "MetroLite";
            // 
            // metroSetPanel_Options
            // 
            this.metroSetPanel_Options.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel_Options.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel_Options.BorderThickness = 1;
            this.metroSetPanel_Options.Controls.Add(this.metroSetCheckBox_KillChrome);
            this.metroSetPanel_Options.Controls.Add(this.metroSetButton_KillChrome);
            this.metroSetPanel_Options.Controls.Add(this.metroSetButton_Login);
            this.metroSetPanel_Options.Controls.Add(this.metroSetCheckBox_OTP);
            this.metroSetPanel_Options.Controls.Add(this.metroSetTextBox_OTP);
            this.metroSetPanel_Options.Controls.Add(this.metroSetLabel_Option);
            this.metroSetPanel_Options.Controls.Add(this.metroSetCheckBox_Google);
            this.metroSetPanel_Options.IsDerivedStyle = true;
            this.metroSetPanel_Options.Location = new System.Drawing.Point(514, 92);
            this.metroSetPanel_Options.Name = "metroSetPanel_Options";
            this.metroSetPanel_Options.Size = new System.Drawing.Size(153, 337);
            this.metroSetPanel_Options.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel_Options.StyleManager = null;
            this.metroSetPanel_Options.TabIndex = 21;
            this.metroSetPanel_Options.ThemeAuthor = "Narwin";
            this.metroSetPanel_Options.ThemeName = "MetroLite";
            // 
            // metroSetCheckBox_KillChrome
            // 
            this.metroSetCheckBox_KillChrome.BackColor = System.Drawing.Color.Transparent;
            this.metroSetCheckBox_KillChrome.BackgroundColor = System.Drawing.Color.White;
            this.metroSetCheckBox_KillChrome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetCheckBox_KillChrome.Checked = false;
            this.metroSetCheckBox_KillChrome.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetCheckBox_KillChrome.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetCheckBox_KillChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetCheckBox_KillChrome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetCheckBox_KillChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetCheckBox_KillChrome.IsDerivedStyle = true;
            this.metroSetCheckBox_KillChrome.Location = new System.Drawing.Point(4, 318);
            this.metroSetCheckBox_KillChrome.Name = "metroSetCheckBox_KillChrome";
            this.metroSetCheckBox_KillChrome.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.metroSetCheckBox_KillChrome.Size = new System.Drawing.Size(147, 16);
            this.metroSetCheckBox_KillChrome.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetCheckBox_KillChrome.StyleManager = null;
            this.metroSetCheckBox_KillChrome.TabIndex = 25;
            this.metroSetCheckBox_KillChrome.Text = "Always Kill on Exit";
            this.metroSetCheckBox_KillChrome.ThemeAuthor = "Narwin";
            this.metroSetCheckBox_KillChrome.ThemeName = "MetroLite";
            // 
            // metroSetButton_KillChrome
            // 
            this.metroSetButton_KillChrome.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_KillChrome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_KillChrome.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_KillChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_KillChrome.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_KillChrome.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_KillChrome.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_KillChrome.IsDerivedStyle = true;
            this.metroSetButton_KillChrome.Location = new System.Drawing.Point(5, 289);
            this.metroSetButton_KillChrome.Name = "metroSetButton_KillChrome";
            this.metroSetButton_KillChrome.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_KillChrome.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_KillChrome.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_KillChrome.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_KillChrome.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_KillChrome.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_KillChrome.Size = new System.Drawing.Size(144, 23);
            this.metroSetButton_KillChrome.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_KillChrome.StyleManager = null;
            this.metroSetButton_KillChrome.TabIndex = 24;
            this.metroSetButton_KillChrome.Text = "Kill Chrome";
            this.metroSetButton_KillChrome.ThemeAuthor = "Narwin";
            this.metroSetButton_KillChrome.ThemeName = "MetroLite";
            this.metroSetButton_KillChrome.Click += new System.EventHandler(this.metroSetButton_KillChrome_Click);
            // 
            // metroSetButton_Login
            // 
            this.metroSetButton_Login.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Login.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_Login.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Login.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Login.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_Login.IsDerivedStyle = true;
            this.metroSetButton_Login.Location = new System.Drawing.Point(4, 3);
            this.metroSetButton_Login.Name = "metroSetButton_Login";
            this.metroSetButton_Login.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Login.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Login.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_Login.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Login.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Login.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_Login.Size = new System.Drawing.Size(146, 32);
            this.metroSetButton_Login.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_Login.StyleManager = null;
            this.metroSetButton_Login.TabIndex = 22;
            this.metroSetButton_Login.Text = "Log in";
            this.metroSetButton_Login.ThemeAuthor = "Narwin";
            this.metroSetButton_Login.ThemeName = "MetroLite";
            this.metroSetButton_Login.Click += new System.EventHandler(this.metroSetButton_Login_Click);
            // 
            // metroSetCheckBox_OTP
            // 
            this.metroSetCheckBox_OTP.BackColor = System.Drawing.Color.Transparent;
            this.metroSetCheckBox_OTP.BackgroundColor = System.Drawing.Color.White;
            this.metroSetCheckBox_OTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetCheckBox_OTP.Checked = false;
            this.metroSetCheckBox_OTP.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetCheckBox_OTP.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetCheckBox_OTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetCheckBox_OTP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetCheckBox_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetCheckBox_OTP.IsDerivedStyle = true;
            this.metroSetCheckBox_OTP.Location = new System.Drawing.Point(6, 165);
            this.metroSetCheckBox_OTP.Name = "metroSetCheckBox_OTP";
            this.metroSetCheckBox_OTP.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.metroSetCheckBox_OTP.Size = new System.Drawing.Size(147, 16);
            this.metroSetCheckBox_OTP.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetCheckBox_OTP.StyleManager = null;
            this.metroSetCheckBox_OTP.TabIndex = 23;
            this.metroSetCheckBox_OTP.Text = "Use OTP ?";
            this.metroSetCheckBox_OTP.ThemeAuthor = "Narwin";
            this.metroSetCheckBox_OTP.ThemeName = "MetroLite";
            this.metroSetCheckBox_OTP.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.metroSetCheckBox_OTP_CheckedChanged);
            // 
            // metroSetTextBox_OTP
            // 
            this.metroSetTextBox_OTP.AutoCompleteCustomSource = null;
            this.metroSetTextBox_OTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_OTP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_OTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_OTP.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_OTP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_OTP.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_OTP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_OTP.Image = null;
            this.metroSetTextBox_OTP.IsDerivedStyle = true;
            this.metroSetTextBox_OTP.Lines = null;
            this.metroSetTextBox_OTP.Location = new System.Drawing.Point(5, 187);
            this.metroSetTextBox_OTP.MaxLength = 8;
            this.metroSetTextBox_OTP.Multiline = false;
            this.metroSetTextBox_OTP.Name = "metroSetTextBox_OTP";
            this.metroSetTextBox_OTP.ReadOnly = false;
            this.metroSetTextBox_OTP.Size = new System.Drawing.Size(147, 30);
            this.metroSetTextBox_OTP.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_OTP.StyleManager = null;
            this.metroSetTextBox_OTP.TabIndex = 22;
            this.metroSetTextBox_OTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_OTP.ThemeAuthor = "Narwin";
            this.metroSetTextBox_OTP.ThemeName = "MetroLite";
            this.metroSetTextBox_OTP.UseSystemPasswordChar = false;
            this.metroSetTextBox_OTP.WatermarkText = "";
            // 
            // metroSetLabel_Option
            // 
            this.metroSetLabel_Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Option.IsDerivedStyle = true;
            this.metroSetLabel_Option.Location = new System.Drawing.Point(4, 38);
            this.metroSetLabel_Option.Name = "metroSetLabel_Option";
            this.metroSetLabel_Option.Size = new System.Drawing.Size(68, 53);
            this.metroSetLabel_Option.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel_Option.StyleManager = null;
            this.metroSetLabel_Option.TabIndex = 21;
            this.metroSetLabel_Option.Text = "Save Login Sessions";
            this.metroSetLabel_Option.ThemeAuthor = "Narwin";
            this.metroSetLabel_Option.ThemeName = "MetroLite";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(431, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 61);
            this.textBox2.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.metroSetPanel_Options);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Papyrus", 15F);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(14, 110, 14, 18);
            this.Text = "LostARK Market Comparer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_Item.ResumeLayout(false);
            this.panel_Bookmark.ResumeLayout(false);
            this.panel_Center.ResumeLayout(false);
            this.panel_Center.PerformLayout();
            this.panel_Picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ItemInfo.ResumeLayout(false);
            this.panel_Content.ResumeLayout(false);
            this.metroSetPanel_Options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel panel_Item;
        private System.Windows.Forms.Panel panel_ItemInfo;
        private System.Windows.Forms.Panel panel_Bookmark;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_Search;
        private System.Windows.Forms.Panel panel_Center_padding1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Name;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Picture;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_No;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_PricePerEach;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_PricePerEach;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_Price;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Price;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_BundleCount;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_BundleCount;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_ItemName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_ItemName;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private MetroSet_UI.Controls.MetroSetCheckBox metroSetCheckBox_Google;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel_Options;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Option;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_OTP;
        private MetroSet_UI.Controls.MetroSetCheckBox metroSetCheckBox_OTP;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_Login;
        private MetroSet_UI.Controls.MetroSetCheckBox metroSetCheckBox_KillChrome;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_KillChrome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroSet_UI.Controls.MetroSetListBox metroSetListBox_Bookmark;
    }
}

