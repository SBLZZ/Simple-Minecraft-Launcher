namespace SimpleMinecraftLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl = new ReaLTaiizor.Controls.TabPage();
            UsersTabPage = new TabPage();
            UsersListBox = new ReaLTaiizor.Controls.MetroListBox();
            DelUserButton = new Button();
            AdduserButton = new Button();
            LaunchTabPage = new TabPage();
            UsersComboBox = new ReaLTaiizor.Controls.PoisonComboBox();
            VersionConfig = new Button();
            ImageList = new ImageList(components);
            VersionsComboBox = new ReaLTaiizor.Controls.PoisonComboBox();
            LaunchButton = new Button();
            VersionsTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            OpenGameFolderButton = new Button();
            GamePathListBox = new ReaLTaiizor.Controls.MetroListBox();
            DelGamePathButton = new Button();
            AddGamePathButton = new Button();
            DelVersionButton = new Button();
            RefreshGamePathButton = new Button();
            VersionsListBox = new ReaLTaiizor.Controls.MetroListBox();
            DownloadTabPage = new TabPage();
            TabControl1 = new ReaLTaiizor.Controls.MetroTabControl();
            DVanilla_TabPage = new TabPage();
            TabControl2 = new ReaLTaiizor.Controls.TabPage();
            tabPage4 = new TabPage();
            RefreshReleaseButton = new Button();
            VanillaListBox = new ReaLTaiizor.Controls.MetroListBox();
            tabPage5 = new TabPage();
            RefreshSnapshotButton = new Button();
            SnapshotListBox = new ReaLTaiizor.Controls.MetroListBox();
            OldVerTabPage = new TabPage();
            RefreshOldverButton = new Button();
            OldVerListBox = new ReaLTaiizor.Controls.MetroListBox();
            DOptifine_TabPage = new TabPage();
            tabPage6 = new TabPage();
            TasksListBox = new ReaLTaiizor.Controls.MetroListBox();
            SettingsTabPage = new TabPage();
            SettingsTabControl = new ReaLTaiizor.Controls.MetroTabControl();
            GameSettings = new TabPage();
            JavaInfoLabel = new Label();
            GameMemTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            JavaPathComboBox = new ReaLTaiizor.Controls.PoisonComboBox();
            AddJavaPathTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            FindJavaButton = new Button();
            metroLabel4 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel3 = new ReaLTaiizor.Controls.MetroLabel();
            DelJavaPathButton = new Button();
            BrowseJavaPathButton = new Button();
            AddJavaPathButton = new Button();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            LauncherSettingsPage = new TabPage();
            poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            SidebarWeightTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            metroLabel6 = new ReaLTaiizor.Controls.MetroLabel();
            JavaPathDialog = new OpenFileDialog();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            toolTip1 = new ToolTip(components);
            OptimizationTimer = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            UsersTabPage.SuspendLayout();
            LaunchTabPage.SuspendLayout();
            VersionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            DownloadTabPage.SuspendLayout();
            TabControl1.SuspendLayout();
            DVanilla_TabPage.SuspendLayout();
            TabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            OldVerTabPage.SuspendLayout();
            tabPage6.SuspendLayout();
            SettingsTabPage.SuspendLayout();
            SettingsTabControl.SuspendLayout();
            GameSettings.SuspendLayout();
            LauncherSettingsPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.ActiveForeColor = SystemColors.ControlText;
            TabControl.ActiveLineTabColor = SystemColors.Highlight;
            TabControl.ActiveTabColor = SystemColors.ControlLight;
            TabControl.Alignment = TabAlignment.Left;
            TabControl.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            TabControl.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            TabControl.ControlBackColor = SystemColors.Control;
            TabControl.Controls.Add(UsersTabPage);
            TabControl.Controls.Add(LaunchTabPage);
            TabControl.Controls.Add(VersionsTabPage);
            TabControl.Controls.Add(DownloadTabPage);
            TabControl.Controls.Add(tabPage6);
            TabControl.Controls.Add(SettingsTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabControl.Font = new Font("Segoe UI", 10.5F);
            TabControl.FrameColor = SystemColors.Window;
            TabControl.ImageList = ImageList;
            TabControl.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            TabControl.ItemSize = new Size(40, 160);
            TabControl.LineColor = Color.Transparent;
            TabControl.LineTabColor = SystemColors.Control;
            TabControl.Location = new Point(0, 0);
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.NormalForeColor = SystemColors.ControlText;
            TabControl.PageColor = SystemColors.Window;
            TabControl.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(784, 411);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TabControl.StringType = StringAlignment.Near;
            TabControl.TabColor = SystemColors.Control;
            TabControl.TabIndex = 0;
            TabControl.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // UsersTabPage
            // 
            UsersTabPage.BackColor = SystemColors.Window;
            UsersTabPage.Controls.Add(UsersListBox);
            UsersTabPage.Controls.Add(DelUserButton);
            UsersTabPage.Controls.Add(AdduserButton);
            UsersTabPage.ImageIndex = 0;
            UsersTabPage.Location = new Point(164, 4);
            UsersTabPage.Name = "UsersTabPage";
            UsersTabPage.Padding = new Padding(3);
            UsersTabPage.Size = new Size(616, 403);
            UsersTabPage.TabIndex = 2;
            UsersTabPage.Text = "    用户";
            // 
            // UsersListBox
            // 
            UsersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsersListBox.BackColor = Color.White;
            UsersListBox.BorderColor = Color.LightGray;
            UsersListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            UsersListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            UsersListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsersListBox.HoveredItemBackColor = Color.LightGray;
            UsersListBox.HoveredItemColor = Color.DimGray;
            UsersListBox.IsDerivedStyle = true;
            UsersListBox.ItemHeight = 30;
            UsersListBox.Location = new Point(0, 0);
            UsersListBox.MultiSelect = false;
            UsersListBox.Name = "UsersListBox";
            UsersListBox.SelectedIndex = -1;
            UsersListBox.SelectedItem = null;
            UsersListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            UsersListBox.SelectedItemColor = Color.White;
            UsersListBox.SelectedText = null;
            UsersListBox.SelectedValue = null;
            UsersListBox.ShowBorder = false;
            UsersListBox.ShowScrollBar = true;
            UsersListBox.Size = new Size(610, 366);
            UsersListBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            UsersListBox.StyleManager = null;
            UsersListBox.TabIndex = 3;
            UsersListBox.ThemeAuthor = "SBLZZ";
            UsersListBox.ThemeName = "MetroLight";
            // 
            // DelUserButton
            // 
            DelUserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DelUserButton.BackColor = SystemColors.Control;
            DelUserButton.FlatAppearance.BorderSize = 0;
            DelUserButton.FlatStyle = FlatStyle.Flat;
            DelUserButton.Font = new Font("Segoe UI", 10.5F);
            DelUserButton.Location = new Point(444, 372);
            DelUserButton.Name = "DelUserButton";
            DelUserButton.Size = new Size(80, 25);
            DelUserButton.TabIndex = 2;
            DelUserButton.Text = "删除";
            DelUserButton.UseVisualStyleBackColor = false;
            DelUserButton.Click += DelUserButton_Click;
            // 
            // AdduserButton
            // 
            AdduserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AdduserButton.BackColor = SystemColors.Control;
            AdduserButton.FlatAppearance.BorderSize = 0;
            AdduserButton.FlatStyle = FlatStyle.Flat;
            AdduserButton.Font = new Font("Segoe UI", 10.5F);
            AdduserButton.Location = new Point(530, 372);
            AdduserButton.Name = "AdduserButton";
            AdduserButton.Size = new Size(80, 25);
            AdduserButton.TabIndex = 1;
            AdduserButton.Text = "添加";
            AdduserButton.UseVisualStyleBackColor = false;
            AdduserButton.Click += AdduserButton_Click;
            // 
            // LaunchTabPage
            // 
            LaunchTabPage.BackColor = SystemColors.Window;
            LaunchTabPage.Controls.Add(UsersComboBox);
            LaunchTabPage.Controls.Add(VersionConfig);
            LaunchTabPage.Controls.Add(VersionsComboBox);
            LaunchTabPage.Controls.Add(LaunchButton);
            LaunchTabPage.ImageIndex = 1;
            LaunchTabPage.Location = new Point(164, 4);
            LaunchTabPage.Name = "LaunchTabPage";
            LaunchTabPage.Padding = new Padding(3);
            LaunchTabPage.Size = new Size(616, 403);
            LaunchTabPage.TabIndex = 0;
            LaunchTabPage.Text = "    启动";
            // 
            // UsersComboBox
            // 
            UsersComboBox.AllowDrop = true;
            UsersComboBox.BackColor = Color.Transparent;
            UsersComboBox.CausesValidation = false;
            UsersComboBox.DropDownHeight = 80;
            UsersComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsersComboBox.FormattingEnabled = true;
            UsersComboBox.IntegralHeight = false;
            UsersComboBox.ItemHeight = 23;
            UsersComboBox.Location = new Point(6, 6);
            UsersComboBox.Name = "UsersComboBox";
            UsersComboBox.Size = new Size(120, 29);
            UsersComboBox.TabIndex = 5;
            UsersComboBox.UseSelectable = true;
            UsersComboBox.SelectedIndexChanged += UsersComboBox_SelectedIndexChanged;
            // 
            // VersionConfig
            // 
            VersionConfig.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            VersionConfig.BackColor = SystemColors.Control;
            VersionConfig.FlatAppearance.BorderSize = 0;
            VersionConfig.FlatStyle = FlatStyle.Flat;
            VersionConfig.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VersionConfig.ImageIndex = 6;
            VersionConfig.ImageList = ImageList;
            VersionConfig.Location = new Point(448, 357);
            VersionConfig.Name = "VersionConfig";
            VersionConfig.Size = new Size(34, 40);
            VersionConfig.TabIndex = 2;
            toolTip1.SetToolTip(VersionConfig, "版本设置");
            VersionConfig.UseVisualStyleBackColor = false;
            VersionConfig.Click += VersionConfig_Click;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "ico_Users.png");
            ImageList.Images.SetKeyName(1, "ico_Launch.png");
            ImageList.Images.SetKeyName(2, "ico_Versions.png");
            ImageList.Images.SetKeyName(3, "ico_Download.png");
            ImageList.Images.SetKeyName(4, "ico_Tasks.png");
            ImageList.Images.SetKeyName(5, "ico_settings.png");
            ImageList.Images.SetKeyName(6, "ico_version_config.png");
            ImageList.Images.SetKeyName(7, "ico_AddGamePath.png");
            ImageList.Images.SetKeyName(8, "ico_DelGamePath.png");
            ImageList.Images.SetKeyName(9, "ico_RefreshGamePath.png");
            ImageList.Images.SetKeyName(10, "ico_OpenGameFolder.png");
            // 
            // VersionsComboBox
            // 
            VersionsComboBox.AllowDrop = true;
            VersionsComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            VersionsComboBox.BackColor = Color.Transparent;
            VersionsComboBox.CausesValidation = false;
            VersionsComboBox.DropDownHeight = 400;
            VersionsComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VersionsComboBox.FormattingEnabled = true;
            VersionsComboBox.IntegralHeight = false;
            VersionsComboBox.ItemHeight = 23;
            VersionsComboBox.Location = new Point(448, 320);
            VersionsComboBox.Name = "VersionsComboBox";
            VersionsComboBox.Size = new Size(160, 29);
            VersionsComboBox.TabIndex = 1;
            VersionsComboBox.UseSelectable = true;
            VersionsComboBox.SelectedIndexChanged += VersionsComboBox_SelectedIndexChanged;
            VersionsComboBox.Click += VersionsComboBox_Click;
            // 
            // LaunchButton
            // 
            LaunchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LaunchButton.BackColor = SystemColors.Control;
            LaunchButton.FlatAppearance.BorderSize = 0;
            LaunchButton.FlatStyle = FlatStyle.Flat;
            LaunchButton.Font = new Font("Segoe UI", 12F);
            LaunchButton.Location = new Point(488, 357);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(120, 40);
            LaunchButton.TabIndex = 0;
            LaunchButton.Text = "启动";
            LaunchButton.UseVisualStyleBackColor = false;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // VersionsTabPage
            // 
            VersionsTabPage.BackColor = SystemColors.Window;
            VersionsTabPage.Controls.Add(splitContainer1);
            VersionsTabPage.ImageIndex = 2;
            VersionsTabPage.Location = new Point(164, 4);
            VersionsTabPage.Name = "VersionsTabPage";
            VersionsTabPage.Padding = new Padding(3);
            VersionsTabPage.Size = new Size(616, 403);
            VersionsTabPage.TabIndex = 5;
            VersionsTabPage.Text = "    版本";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(OpenGameFolderButton);
            splitContainer1.Panel1.Controls.Add(GamePathListBox);
            splitContainer1.Panel1.Controls.Add(DelGamePathButton);
            splitContainer1.Panel1.Controls.Add(AddGamePathButton);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DelVersionButton);
            splitContainer1.Panel2.Controls.Add(RefreshGamePathButton);
            splitContainer1.Panel2.Controls.Add(VersionsListBox);
            splitContainer1.Panel2MinSize = 0;
            splitContainer1.Size = new Size(610, 397);
            splitContainer1.SplitterDistance = 150;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // OpenGameFolderButton
            // 
            OpenGameFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenGameFolderButton.BackColor = SystemColors.Control;
            OpenGameFolderButton.FlatAppearance.BorderSize = 0;
            OpenGameFolderButton.FlatStyle = FlatStyle.Flat;
            OpenGameFolderButton.Font = new Font("Segoe UI", 10.5F);
            OpenGameFolderButton.ImageIndex = 10;
            OpenGameFolderButton.ImageList = ImageList;
            OpenGameFolderButton.Location = new Point(100, 0);
            OpenGameFolderButton.Margin = new Padding(0);
            OpenGameFolderButton.Name = "OpenGameFolderButton";
            OpenGameFolderButton.Size = new Size(50, 30);
            OpenGameFolderButton.TabIndex = 6;
            toolTip1.SetToolTip(OpenGameFolderButton, "打开该目录");
            OpenGameFolderButton.UseVisualStyleBackColor = false;
            OpenGameFolderButton.Click += OpenGameFolderButton_Click;
            // 
            // GamePathListBox
            // 
            GamePathListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GamePathListBox.BackColor = SystemColors.Control;
            GamePathListBox.BorderColor = Color.LightGray;
            GamePathListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            GamePathListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            GamePathListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GamePathListBox.HoveredItemBackColor = Color.LightGray;
            GamePathListBox.HoveredItemColor = Color.DimGray;
            GamePathListBox.IsDerivedStyle = true;
            GamePathListBox.ItemHeight = 30;
            GamePathListBox.Location = new Point(-4, 30);
            GamePathListBox.Margin = new Padding(0);
            GamePathListBox.MultiSelect = false;
            GamePathListBox.Name = "GamePathListBox";
            GamePathListBox.SelectedIndex = -1;
            GamePathListBox.SelectedItem = null;
            GamePathListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            GamePathListBox.SelectedItemColor = Color.White;
            GamePathListBox.SelectedText = null;
            GamePathListBox.SelectedValue = null;
            GamePathListBox.ShowBorder = false;
            GamePathListBox.ShowScrollBar = true;
            GamePathListBox.Size = new Size(154, 370);
            GamePathListBox.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            GamePathListBox.StyleManager = null;
            GamePathListBox.TabIndex = 4;
            GamePathListBox.ThemeAuthor = "SBLZZ";
            GamePathListBox.ThemeName = "MetroLight";
            GamePathListBox.SelectedIndexChanged += GamePathListBox_SelectedIndexChanged;
            // 
            // DelGamePathButton
            // 
            DelGamePathButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DelGamePathButton.BackColor = SystemColors.Control;
            DelGamePathButton.FlatAppearance.BorderSize = 0;
            DelGamePathButton.FlatStyle = FlatStyle.Flat;
            DelGamePathButton.Font = new Font("Segoe UI", 10.5F);
            DelGamePathButton.ImageIndex = 8;
            DelGamePathButton.ImageList = ImageList;
            DelGamePathButton.Location = new Point(50, 0);
            DelGamePathButton.Margin = new Padding(0);
            DelGamePathButton.Name = "DelGamePathButton";
            DelGamePathButton.Size = new Size(50, 30);
            DelGamePathButton.TabIndex = 3;
            toolTip1.SetToolTip(DelGamePathButton, "删除该目录");
            DelGamePathButton.UseVisualStyleBackColor = false;
            DelGamePathButton.Click += DelGameDirButton_Click;
            // 
            // AddGamePathButton
            // 
            AddGamePathButton.BackColor = SystemColors.Control;
            AddGamePathButton.FlatAppearance.BorderSize = 0;
            AddGamePathButton.FlatStyle = FlatStyle.Flat;
            AddGamePathButton.Font = new Font("Segoe UI", 10.5F);
            AddGamePathButton.ImageIndex = 7;
            AddGamePathButton.ImageList = ImageList;
            AddGamePathButton.Location = new Point(0, 0);
            AddGamePathButton.Margin = new Padding(0);
            AddGamePathButton.Name = "AddGamePathButton";
            AddGamePathButton.Size = new Size(50, 30);
            AddGamePathButton.TabIndex = 2;
            toolTip1.SetToolTip(AddGamePathButton, "添加目录");
            AddGamePathButton.UseVisualStyleBackColor = false;
            AddGamePathButton.Click += AddGamePathButton_Click;
            // 
            // DelVersionButton
            // 
            DelVersionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DelVersionButton.BackColor = SystemColors.Control;
            DelVersionButton.FlatAppearance.BorderSize = 0;
            DelVersionButton.FlatStyle = FlatStyle.Flat;
            DelVersionButton.Font = new Font("Segoe UI", 10.5F);
            DelVersionButton.ImageIndex = 8;
            DelVersionButton.ImageList = ImageList;
            DelVersionButton.Location = new Point(379, 370);
            DelVersionButton.Margin = new Padding(0);
            DelVersionButton.Name = "DelVersionButton";
            DelVersionButton.Size = new Size(40, 30);
            DelVersionButton.TabIndex = 7;
            toolTip1.SetToolTip(DelVersionButton, "删除该版本");
            DelVersionButton.UseVisualStyleBackColor = false;
            DelVersionButton.Click += DelVersionButton_Click;
            // 
            // RefreshGamePathButton
            // 
            RefreshGamePathButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RefreshGamePathButton.BackColor = SystemColors.Control;
            RefreshGamePathButton.FlatAppearance.BorderSize = 0;
            RefreshGamePathButton.FlatStyle = FlatStyle.Flat;
            RefreshGamePathButton.Font = new Font("Segoe UI", 10.5F);
            RefreshGamePathButton.ImageIndex = 9;
            RefreshGamePathButton.ImageList = ImageList;
            RefreshGamePathButton.Location = new Point(419, 370);
            RefreshGamePathButton.Margin = new Padding(0);
            RefreshGamePathButton.Name = "RefreshGamePathButton";
            RefreshGamePathButton.Size = new Size(40, 30);
            RefreshGamePathButton.TabIndex = 5;
            toolTip1.SetToolTip(RefreshGamePathButton, "刷新");
            RefreshGamePathButton.UseVisualStyleBackColor = false;
            RefreshGamePathButton.Click += button1_Click;
            // 
            // VersionsListBox
            // 
            VersionsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VersionsListBox.BackColor = Color.White;
            VersionsListBox.BorderColor = Color.LightGray;
            VersionsListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            VersionsListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            VersionsListBox.Font = new Font("Segoe UI", 10.5F);
            VersionsListBox.HoveredItemBackColor = Color.LightGray;
            VersionsListBox.HoveredItemColor = Color.DimGray;
            VersionsListBox.IsDerivedStyle = true;
            VersionsListBox.ItemHeight = 30;
            VersionsListBox.Location = new Point(0, 0);
            VersionsListBox.MultiSelect = false;
            VersionsListBox.Name = "VersionsListBox";
            VersionsListBox.SelectedIndex = -1;
            VersionsListBox.SelectedItem = null;
            VersionsListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            VersionsListBox.SelectedItemColor = Color.White;
            VersionsListBox.SelectedText = null;
            VersionsListBox.SelectedValue = null;
            VersionsListBox.ShowBorder = false;
            VersionsListBox.ShowScrollBar = true;
            VersionsListBox.Size = new Size(456, 397);
            VersionsListBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            VersionsListBox.StyleManager = null;
            VersionsListBox.TabIndex = 0;
            VersionsListBox.ThemeAuthor = "SBLZZ";
            VersionsListBox.ThemeName = "MetroLight";
            // 
            // DownloadTabPage
            // 
            DownloadTabPage.BackColor = SystemColors.Window;
            DownloadTabPage.Controls.Add(TabControl1);
            DownloadTabPage.ImageIndex = 3;
            DownloadTabPage.Location = new Point(164, 4);
            DownloadTabPage.Name = "DownloadTabPage";
            DownloadTabPage.Padding = new Padding(3);
            DownloadTabPage.Size = new Size(616, 403);
            DownloadTabPage.TabIndex = 6;
            DownloadTabPage.Text = "    下载";
            // 
            // TabControl1
            // 
            TabControl1.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.CubeOut;
            TabControl1.AnimateTime = 200;
            TabControl1.BackgroundColor = Color.White;
            TabControl1.Controls.Add(DVanilla_TabPage);
            TabControl1.Controls.Add(DOptifine_TabPage);
            TabControl1.ControlsVisible = true;
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.IsDerivedStyle = true;
            TabControl1.ItemSize = new Size(140, 28);
            TabControl1.Location = new Point(3, 3);
            TabControl1.MCursor = Cursors.Hand;
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.SelectedTextColor = Color.FromArgb(65, 177, 225);
            TabControl1.Size = new Size(610, 397);
            TabControl1.SizeMode = TabSizeMode.Fixed;
            TabControl1.Speed = 100;
            TabControl1.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            TabControl1.StyleManager = null;
            TabControl1.TabIndex = 0;
            TabControl1.TabStyle = ReaLTaiizor.Enum.Metro.TabStyle.Style2;
            TabControl1.ThemeAuthor = "SBLZZ";
            TabControl1.ThemeName = "MetroLight";
            TabControl1.UnselectedTextColor = SystemColors.ControlText;
            // 
            // DVanilla_TabPage
            // 
            DVanilla_TabPage.BackColor = SystemColors.Window;
            DVanilla_TabPage.Controls.Add(TabControl2);
            DVanilla_TabPage.Location = new Point(4, 32);
            DVanilla_TabPage.Name = "DVanilla_TabPage";
            DVanilla_TabPage.Padding = new Padding(3);
            DVanilla_TabPage.Size = new Size(602, 361);
            DVanilla_TabPage.TabIndex = 0;
            DVanilla_TabPage.Text = "原版下载";
            // 
            // TabControl2
            // 
            TabControl2.ActiveForeColor = SystemColors.ControlText;
            TabControl2.ActiveLineTabColor = SystemColors.Highlight;
            TabControl2.ActiveTabColor = SystemColors.Control;
            TabControl2.Alignment = TabAlignment.Left;
            TabControl2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            TabControl2.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            TabControl2.ControlBackColor = SystemColors.Control;
            TabControl2.Controls.Add(tabPage4);
            TabControl2.Controls.Add(tabPage5);
            TabControl2.Controls.Add(OldVerTabPage);
            TabControl2.Dock = DockStyle.Fill;
            TabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabControl2.FrameColor = SystemColors.Window;
            TabControl2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            TabControl2.ItemSize = new Size(40, 120);
            TabControl2.LineColor = SystemColors.Control;
            TabControl2.LineTabColor = SystemColors.Control;
            TabControl2.Location = new Point(3, 3);
            TabControl2.Multiline = true;
            TabControl2.Name = "TabControl2";
            TabControl2.NormalForeColor = SystemColors.ControlText;
            TabControl2.PageColor = SystemColors.Window;
            TabControl2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            TabControl2.SelectedIndex = 0;
            TabControl2.Size = new Size(596, 355);
            TabControl2.SizeMode = TabSizeMode.Fixed;
            TabControl2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TabControl2.StringType = StringAlignment.Near;
            TabControl2.TabColor = SystemColors.Control;
            TabControl2.TabIndex = 9;
            TabControl2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(41, 50, 63);
            tabPage4.Controls.Add(RefreshReleaseButton);
            tabPage4.Controls.Add(VanillaListBox);
            tabPage4.Location = new Point(124, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(468, 347);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "正式版";
            // 
            // RefreshReleaseButton
            // 
            RefreshReleaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RefreshReleaseButton.BackColor = SystemColors.Control;
            RefreshReleaseButton.FlatAppearance.BorderSize = 0;
            RefreshReleaseButton.FlatStyle = FlatStyle.Flat;
            RefreshReleaseButton.Font = new Font("Segoe UI", 10.5F);
            RefreshReleaseButton.ImageIndex = 9;
            RefreshReleaseButton.ImageList = ImageList;
            RefreshReleaseButton.Location = new Point(438, 317);
            RefreshReleaseButton.Name = "RefreshReleaseButton";
            RefreshReleaseButton.Size = new Size(30, 30);
            RefreshReleaseButton.TabIndex = 10;
            toolTip1.SetToolTip(RefreshReleaseButton, "刷新");
            RefreshReleaseButton.UseVisualStyleBackColor = false;
            RefreshReleaseButton.Click += RefreshReleaseButton_Click;
            // 
            // VanillaListBox
            // 
            VanillaListBox.BackColor = Color.White;
            VanillaListBox.BorderColor = Color.LightGray;
            VanillaListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            VanillaListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            VanillaListBox.Dock = DockStyle.Fill;
            VanillaListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VanillaListBox.HoveredItemBackColor = Color.LightGray;
            VanillaListBox.HoveredItemColor = Color.DimGray;
            VanillaListBox.IsDerivedStyle = true;
            VanillaListBox.ItemHeight = 25;
            VanillaListBox.Location = new Point(3, 3);
            VanillaListBox.Margin = new Padding(0);
            VanillaListBox.MultiSelect = false;
            VanillaListBox.Name = "VanillaListBox";
            VanillaListBox.SelectedIndex = -1;
            VanillaListBox.SelectedItem = null;
            VanillaListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            VanillaListBox.SelectedItemColor = Color.White;
            VanillaListBox.SelectedText = null;
            VanillaListBox.SelectedValue = null;
            VanillaListBox.ShowBorder = false;
            VanillaListBox.ShowScrollBar = true;
            VanillaListBox.Size = new Size(462, 341);
            VanillaListBox.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            VanillaListBox.StyleManager = null;
            VanillaListBox.TabIndex = 9;
            VanillaListBox.ThemeAuthor = "SBLZZ";
            VanillaListBox.ThemeName = "MetroLight";
            VanillaListBox.SelectedIndexChanged += VanillaListBox_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(41, 50, 63);
            tabPage5.Controls.Add(RefreshSnapshotButton);
            tabPage5.Controls.Add(SnapshotListBox);
            tabPage5.Location = new Point(124, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(468, 347);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "快照版";
            // 
            // RefreshSnapshotButton
            // 
            RefreshSnapshotButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RefreshSnapshotButton.BackColor = SystemColors.Control;
            RefreshSnapshotButton.FlatAppearance.BorderSize = 0;
            RefreshSnapshotButton.FlatStyle = FlatStyle.Flat;
            RefreshSnapshotButton.Font = new Font("Segoe UI", 10.5F);
            RefreshSnapshotButton.ImageIndex = 9;
            RefreshSnapshotButton.ImageList = ImageList;
            RefreshSnapshotButton.Location = new Point(438, 317);
            RefreshSnapshotButton.Name = "RefreshSnapshotButton";
            RefreshSnapshotButton.Size = new Size(30, 30);
            RefreshSnapshotButton.TabIndex = 12;
            toolTip1.SetToolTip(RefreshSnapshotButton, "刷新");
            RefreshSnapshotButton.UseVisualStyleBackColor = false;
            RefreshSnapshotButton.Click += RefreshSnapshotButton_Click;
            // 
            // SnapshotListBox
            // 
            SnapshotListBox.BackColor = Color.White;
            SnapshotListBox.BorderColor = Color.LightGray;
            SnapshotListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            SnapshotListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            SnapshotListBox.Dock = DockStyle.Fill;
            SnapshotListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SnapshotListBox.HoveredItemBackColor = Color.LightGray;
            SnapshotListBox.HoveredItemColor = Color.DimGray;
            SnapshotListBox.IsDerivedStyle = true;
            SnapshotListBox.ItemHeight = 25;
            SnapshotListBox.Location = new Point(3, 3);
            SnapshotListBox.Margin = new Padding(0);
            SnapshotListBox.MultiSelect = false;
            SnapshotListBox.Name = "SnapshotListBox";
            SnapshotListBox.SelectedIndex = -1;
            SnapshotListBox.SelectedItem = null;
            SnapshotListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            SnapshotListBox.SelectedItemColor = Color.White;
            SnapshotListBox.SelectedText = null;
            SnapshotListBox.SelectedValue = null;
            SnapshotListBox.ShowBorder = false;
            SnapshotListBox.ShowScrollBar = true;
            SnapshotListBox.Size = new Size(462, 341);
            SnapshotListBox.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            SnapshotListBox.StyleManager = null;
            SnapshotListBox.TabIndex = 11;
            SnapshotListBox.ThemeAuthor = "SBLZZ";
            SnapshotListBox.ThemeName = "MetroLight";
            SnapshotListBox.SelectedIndexChanged += SnapshotListBox_SelectedIndexChanged;
            // 
            // OldVerTabPage
            // 
            OldVerTabPage.BackColor = Color.FromArgb(41, 50, 63);
            OldVerTabPage.Controls.Add(RefreshOldverButton);
            OldVerTabPage.Controls.Add(OldVerListBox);
            OldVerTabPage.Location = new Point(124, 4);
            OldVerTabPage.Name = "OldVerTabPage";
            OldVerTabPage.Padding = new Padding(3);
            OldVerTabPage.Size = new Size(468, 347);
            OldVerTabPage.TabIndex = 2;
            OldVerTabPage.Text = "远古版";
            // 
            // RefreshOldverButton
            // 
            RefreshOldverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RefreshOldverButton.BackColor = SystemColors.Control;
            RefreshOldverButton.FlatAppearance.BorderSize = 0;
            RefreshOldverButton.FlatStyle = FlatStyle.Flat;
            RefreshOldverButton.Font = new Font("Segoe UI", 10.5F);
            RefreshOldverButton.ImageIndex = 9;
            RefreshOldverButton.ImageList = ImageList;
            RefreshOldverButton.Location = new Point(438, 317);
            RefreshOldverButton.Name = "RefreshOldverButton";
            RefreshOldverButton.Size = new Size(30, 30);
            RefreshOldverButton.TabIndex = 13;
            toolTip1.SetToolTip(RefreshOldverButton, "刷新");
            RefreshOldverButton.UseVisualStyleBackColor = false;
            RefreshOldverButton.Click += RefreshOldverButton_Click;
            // 
            // OldVerListBox
            // 
            OldVerListBox.BackColor = Color.White;
            OldVerListBox.BorderColor = Color.LightGray;
            OldVerListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            OldVerListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            OldVerListBox.Dock = DockStyle.Fill;
            OldVerListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OldVerListBox.HoveredItemBackColor = Color.LightGray;
            OldVerListBox.HoveredItemColor = Color.DimGray;
            OldVerListBox.IsDerivedStyle = true;
            OldVerListBox.ItemHeight = 25;
            OldVerListBox.Location = new Point(3, 3);
            OldVerListBox.Margin = new Padding(0);
            OldVerListBox.MultiSelect = false;
            OldVerListBox.Name = "OldVerListBox";
            OldVerListBox.SelectedIndex = -1;
            OldVerListBox.SelectedItem = null;
            OldVerListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            OldVerListBox.SelectedItemColor = Color.White;
            OldVerListBox.SelectedText = null;
            OldVerListBox.SelectedValue = null;
            OldVerListBox.ShowBorder = false;
            OldVerListBox.ShowScrollBar = true;
            OldVerListBox.Size = new Size(462, 341);
            OldVerListBox.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            OldVerListBox.StyleManager = null;
            OldVerListBox.TabIndex = 12;
            OldVerListBox.ThemeAuthor = "SBLZZ";
            OldVerListBox.ThemeName = "MetroLight";
            OldVerListBox.SelectedIndexChanged += OldVerListBox_SelectedIndexChanged;
            // 
            // DOptifine_TabPage
            // 
            DOptifine_TabPage.BackColor = SystemColors.Window;
            DOptifine_TabPage.Location = new Point(4, 32);
            DOptifine_TabPage.Name = "DOptifine_TabPage";
            DOptifine_TabPage.Padding = new Padding(3);
            DOptifine_TabPage.Size = new Size(602, 361);
            DOptifine_TabPage.TabIndex = 1;
            DOptifine_TabPage.Text = "OptiFine下载";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = SystemColors.Window;
            tabPage6.Controls.Add(TasksListBox);
            tabPage6.ImageIndex = 4;
            tabPage6.Location = new Point(164, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(616, 403);
            tabPage6.TabIndex = 7;
            tabPage6.Text = "    任务";
            // 
            // TasksListBox
            // 
            TasksListBox.BackColor = Color.White;
            TasksListBox.BorderColor = Color.LightGray;
            TasksListBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            TasksListBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            TasksListBox.Dock = DockStyle.Fill;
            TasksListBox.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TasksListBox.HoveredItemBackColor = Color.LightGray;
            TasksListBox.HoveredItemColor = Color.DimGray;
            TasksListBox.IsDerivedStyle = true;
            TasksListBox.ItemHeight = 30;
            TasksListBox.Location = new Point(0, 0);
            TasksListBox.MultiSelect = false;
            TasksListBox.Name = "TasksListBox";
            TasksListBox.SelectedIndex = -1;
            TasksListBox.SelectedItem = null;
            TasksListBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            TasksListBox.SelectedItemColor = Color.White;
            TasksListBox.SelectedText = null;
            TasksListBox.SelectedValue = null;
            TasksListBox.ShowBorder = false;
            TasksListBox.ShowScrollBar = true;
            TasksListBox.Size = new Size(616, 403);
            TasksListBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TasksListBox.StyleManager = null;
            TasksListBox.TabIndex = 0;
            TasksListBox.ThemeAuthor = "SBLZZ";
            TasksListBox.ThemeName = "MetroLight";
            // 
            // SettingsTabPage
            // 
            SettingsTabPage.BackColor = SystemColors.Window;
            SettingsTabPage.Controls.Add(SettingsTabControl);
            SettingsTabPage.ImageIndex = 5;
            SettingsTabPage.Location = new Point(164, 4);
            SettingsTabPage.Name = "SettingsTabPage";
            SettingsTabPage.Padding = new Padding(3);
            SettingsTabPage.Size = new Size(616, 403);
            SettingsTabPage.TabIndex = 4;
            SettingsTabPage.Text = "    设置";
            // 
            // SettingsTabControl
            // 
            SettingsTabControl.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.CubeIn;
            SettingsTabControl.AnimateTime = 200;
            SettingsTabControl.BackgroundColor = Color.White;
            SettingsTabControl.Controls.Add(GameSettings);
            SettingsTabControl.Controls.Add(LauncherSettingsPage);
            SettingsTabControl.ControlsVisible = true;
            SettingsTabControl.Dock = DockStyle.Fill;
            SettingsTabControl.ImageList = ImageList;
            SettingsTabControl.IsDerivedStyle = true;
            SettingsTabControl.ItemSize = new Size(100, 28);
            SettingsTabControl.Location = new Point(3, 3);
            SettingsTabControl.MCursor = Cursors.Hand;
            SettingsTabControl.Multiline = true;
            SettingsTabControl.Name = "SettingsTabControl";
            SettingsTabControl.SelectedIndex = 0;
            SettingsTabControl.SelectedTextColor = Color.FromArgb(65, 177, 225);
            SettingsTabControl.Size = new Size(610, 397);
            SettingsTabControl.SizeMode = TabSizeMode.Fixed;
            SettingsTabControl.Speed = 100;
            SettingsTabControl.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            SettingsTabControl.StyleManager = null;
            SettingsTabControl.TabIndex = 0;
            SettingsTabControl.TabStyle = ReaLTaiizor.Enum.Metro.TabStyle.Style2;
            SettingsTabControl.ThemeAuthor = "SBLZZ";
            SettingsTabControl.ThemeName = "MetroLight";
            SettingsTabControl.UnselectedTextColor = SystemColors.ControlText;
            // 
            // GameSettings
            // 
            GameSettings.AutoScroll = true;
            GameSettings.BackColor = SystemColors.Window;
            GameSettings.Controls.Add(JavaInfoLabel);
            GameSettings.Controls.Add(GameMemTextBox);
            GameSettings.Controls.Add(JavaPathComboBox);
            GameSettings.Controls.Add(AddJavaPathTextBox);
            GameSettings.Controls.Add(FindJavaButton);
            GameSettings.Controls.Add(metroLabel4);
            GameSettings.Controls.Add(metroLabel3);
            GameSettings.Controls.Add(DelJavaPathButton);
            GameSettings.Controls.Add(BrowseJavaPathButton);
            GameSettings.Controls.Add(AddJavaPathButton);
            GameSettings.Controls.Add(metroLabel2);
            GameSettings.Controls.Add(metroLabel1);
            GameSettings.ImageIndex = 0;
            GameSettings.Location = new Point(4, 32);
            GameSettings.Name = "GameSettings";
            GameSettings.Padding = new Padding(3);
            GameSettings.Size = new Size(602, 361);
            GameSettings.TabIndex = 0;
            GameSettings.Text = "游戏";
            // 
            // JavaInfoLabel
            // 
            JavaInfoLabel.AutoSize = true;
            JavaInfoLabel.ForeColor = SystemColors.GrayText;
            JavaInfoLabel.Location = new Point(3, 57);
            JavaInfoLabel.Name = "JavaInfoLabel";
            JavaInfoLabel.Size = new Size(121, 19);
            JavaInfoLabel.TabIndex = 16;
            JavaInfoLabel.Text = "                            ";
            // 
            // GameMemTextBox
            // 
            // 
            // 
            // 
            GameMemTextBox.CustomButton.Image = null;
            GameMemTextBox.CustomButton.Location = new Point(73, 1);
            GameMemTextBox.CustomButton.Name = "";
            GameMemTextBox.CustomButton.Size = new Size(23, 23);
            GameMemTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            GameMemTextBox.CustomButton.TabIndex = 1;
            GameMemTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            GameMemTextBox.CustomButton.UseSelectable = true;
            GameMemTextBox.CustomButton.Visible = false;
            GameMemTextBox.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            GameMemTextBox.Location = new Point(3, 150);
            GameMemTextBox.MaxLength = 32767;
            GameMemTextBox.Name = "GameMemTextBox";
            GameMemTextBox.PasswordChar = '\0';
            GameMemTextBox.ScrollBars = ScrollBars.None;
            GameMemTextBox.SelectedText = "";
            GameMemTextBox.SelectionLength = 0;
            GameMemTextBox.SelectionStart = 0;
            GameMemTextBox.ShortcutsEnabled = true;
            GameMemTextBox.Size = new Size(97, 25);
            GameMemTextBox.TabIndex = 15;
            toolTip1.SetToolTip(GameMemTextBox, "给游戏分配的内存");
            GameMemTextBox.UseSelectable = true;
            GameMemTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            GameMemTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            GameMemTextBox.TextChanged += GameMemTextBox_TextChanged;
            // 
            // JavaPathComboBox
            // 
            JavaPathComboBox.FormattingEnabled = true;
            JavaPathComboBox.ItemHeight = 23;
            JavaPathComboBox.Location = new Point(3, 25);
            JavaPathComboBox.Name = "JavaPathComboBox";
            JavaPathComboBox.Size = new Size(423, 29);
            JavaPathComboBox.TabIndex = 14;
            toolTip1.SetToolTip(JavaPathComboBox, "选择你的Java路径");
            JavaPathComboBox.UseSelectable = true;
            JavaPathComboBox.SelectedIndexChanged += JavaPathComboBox_SelectedIndexChanged;
            // 
            // AddJavaPathTextBox
            // 
            // 
            // 
            // 
            AddJavaPathTextBox.CustomButton.Image = null;
            AddJavaPathTextBox.CustomButton.Location = new Point(457, 1);
            AddJavaPathTextBox.CustomButton.Name = "";
            AddJavaPathTextBox.CustomButton.Size = new Size(23, 23);
            AddJavaPathTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            AddJavaPathTextBox.CustomButton.TabIndex = 1;
            AddJavaPathTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            AddJavaPathTextBox.CustomButton.UseSelectable = true;
            AddJavaPathTextBox.CustomButton.Visible = false;
            AddJavaPathTextBox.Location = new Point(3, 99);
            AddJavaPathTextBox.MaxLength = 32767;
            AddJavaPathTextBox.Name = "AddJavaPathTextBox";
            AddJavaPathTextBox.PasswordChar = '\0';
            AddJavaPathTextBox.ScrollBars = ScrollBars.None;
            AddJavaPathTextBox.SelectedText = "";
            AddJavaPathTextBox.SelectionLength = 0;
            AddJavaPathTextBox.SelectionStart = 0;
            AddJavaPathTextBox.ShortcutsEnabled = true;
            AddJavaPathTextBox.Size = new Size(481, 25);
            AddJavaPathTextBox.TabIndex = 13;
            AddJavaPathTextBox.UseSelectable = true;
            AddJavaPathTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            AddJavaPathTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // FindJavaButton
            // 
            FindJavaButton.BackColor = SystemColors.Control;
            FindJavaButton.FlatAppearance.BorderSize = 0;
            FindJavaButton.FlatStyle = FlatStyle.Flat;
            FindJavaButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindJavaButton.Location = new Point(432, 25);
            FindJavaButton.Name = "FindJavaButton";
            FindJavaButton.Size = new Size(100, 29);
            FindJavaButton.TabIndex = 11;
            FindJavaButton.Text = "自动寻找Java";
            FindJavaButton.UseVisualStyleBackColor = false;
            FindJavaButton.Click += FindJavaButton_Click;
            // 
            // metroLabel4
            // 
            metroLabel4.Font = new Font("Segoe UI", 10.25F);
            metroLabel4.IsDerivedStyle = true;
            metroLabel4.Location = new Point(106, 154);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(42, 20);
            metroLabel4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel4.StyleManager = null;
            metroLabel4.TabIndex = 10;
            metroLabel4.Text = "MB";
            metroLabel4.ThemeAuthor = "Taiizor";
            metroLabel4.ThemeName = "MetroLight";
            // 
            // metroLabel3
            // 
            metroLabel3.Font = new Font("Segoe UI", 10.25F);
            metroLabel3.IsDerivedStyle = true;
            metroLabel3.Location = new Point(3, 127);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(100, 20);
            metroLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel3.StyleManager = null;
            metroLabel3.TabIndex = 7;
            metroLabel3.Text = "游戏内存";
            metroLabel3.ThemeAuthor = "SBLZZ";
            metroLabel3.ThemeName = "MetroLight";
            // 
            // DelJavaPathButton
            // 
            DelJavaPathButton.BackColor = SystemColors.Control;
            DelJavaPathButton.FlatAppearance.BorderSize = 0;
            DelJavaPathButton.FlatStyle = FlatStyle.Flat;
            DelJavaPathButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelJavaPathButton.Location = new Point(538, 25);
            DelJavaPathButton.Name = "DelJavaPathButton";
            DelJavaPathButton.Size = new Size(42, 29);
            DelJavaPathButton.TabIndex = 6;
            DelJavaPathButton.Text = "删除";
            DelJavaPathButton.UseVisualStyleBackColor = false;
            DelJavaPathButton.Click += DelJavaPathButton_Click;
            // 
            // BrowseJavaPathButton
            // 
            BrowseJavaPathButton.BackColor = SystemColors.Control;
            BrowseJavaPathButton.FlatAppearance.BorderSize = 0;
            BrowseJavaPathButton.FlatStyle = FlatStyle.Flat;
            BrowseJavaPathButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrowseJavaPathButton.Location = new Point(538, 99);
            BrowseJavaPathButton.Name = "BrowseJavaPathButton";
            BrowseJavaPathButton.Size = new Size(42, 25);
            BrowseJavaPathButton.TabIndex = 5;
            BrowseJavaPathButton.Text = "浏览";
            BrowseJavaPathButton.UseVisualStyleBackColor = false;
            BrowseJavaPathButton.Click += BrowseJavaPathButton_Click;
            // 
            // AddJavaPathButton
            // 
            AddJavaPathButton.BackColor = SystemColors.Control;
            AddJavaPathButton.FlatAppearance.BorderSize = 0;
            AddJavaPathButton.FlatStyle = FlatStyle.Flat;
            AddJavaPathButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddJavaPathButton.Location = new Point(490, 99);
            AddJavaPathButton.Name = "AddJavaPathButton";
            AddJavaPathButton.Size = new Size(42, 25);
            AddJavaPathButton.TabIndex = 4;
            AddJavaPathButton.Text = "添加";
            AddJavaPathButton.UseVisualStyleBackColor = false;
            AddJavaPathButton.Click += AddJavaPathButton_Click;
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new Font("Segoe UI", 10.25F);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(3, 76);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(100, 20);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 3;
            metroLabel2.Text = "添加Java路径";
            metroLabel2.ThemeAuthor = "SBLZZ";
            metroLabel2.ThemeName = "MetroLight";
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Segoe UI", 10.25F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(3, 3);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(100, 20);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Java路径";
            metroLabel1.ThemeAuthor = "SBLZZ";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // LauncherSettingsPage
            // 
            LauncherSettingsPage.BackColor = SystemColors.Window;
            LauncherSettingsPage.Controls.Add(poisonLabel1);
            LauncherSettingsPage.Controls.Add(SidebarWeightTextBox);
            LauncherSettingsPage.Controls.Add(metroLabel6);
            LauncherSettingsPage.Location = new Point(4, 32);
            LauncherSettingsPage.Name = "LauncherSettingsPage";
            LauncherSettingsPage.Padding = new Padding(3);
            LauncherSettingsPage.Size = new Size(602, 361);
            LauncherSettingsPage.TabIndex = 1;
            LauncherSettingsPage.Text = "外观";
            // 
            // poisonLabel1
            // 
            poisonLabel1.AutoSize = true;
            poisonLabel1.ForeColor = SystemColors.GrayText;
            poisonLabel1.Location = new Point(109, 31);
            poisonLabel1.Name = "poisonLabel1";
            poisonLabel1.Size = new Size(84, 19);
            poisonLabel1.TabIndex = 17;
            poisonLabel1.Text = "默认值：160";
            poisonLabel1.UseCustomForeColor = true;
            // 
            // SidebarWeightTextBox
            // 
            // 
            // 
            // 
            SidebarWeightTextBox.CustomButton.Image = null;
            SidebarWeightTextBox.CustomButton.Location = new Point(75, 2);
            SidebarWeightTextBox.CustomButton.Name = "";
            SidebarWeightTextBox.CustomButton.Size = new Size(19, 19);
            SidebarWeightTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            SidebarWeightTextBox.CustomButton.TabIndex = 1;
            SidebarWeightTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            SidebarWeightTextBox.CustomButton.UseSelectable = true;
            SidebarWeightTextBox.CustomButton.Visible = false;
            SidebarWeightTextBox.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            SidebarWeightTextBox.Location = new Point(6, 26);
            SidebarWeightTextBox.MaxLength = 32767;
            SidebarWeightTextBox.Name = "SidebarWeightTextBox";
            SidebarWeightTextBox.PasswordChar = '\0';
            SidebarWeightTextBox.ScrollBars = ScrollBars.None;
            SidebarWeightTextBox.SelectedText = "";
            SidebarWeightTextBox.SelectionLength = 0;
            SidebarWeightTextBox.SelectionStart = 0;
            SidebarWeightTextBox.ShortcutsEnabled = true;
            SidebarWeightTextBox.Size = new Size(97, 24);
            SidebarWeightTextBox.TabIndex = 16;
            toolTip1.SetToolTip(SidebarWeightTextBox, "侧边栏的宽度");
            SidebarWeightTextBox.UseSelectable = true;
            SidebarWeightTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            SidebarWeightTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            metroLabel6.Font = new Font("Segoe UI", 10.25F);
            metroLabel6.IsDerivedStyle = true;
            metroLabel6.Location = new Point(3, 3);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(100, 20);
            metroLabel6.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel6.StyleManager = null;
            metroLabel6.TabIndex = 11;
            metroLabel6.Text = "边栏宽度";
            metroLabel6.ThemeAuthor = "SBLZZ";
            metroLabel6.ThemeName = "MetroLight";
            // 
            // JavaPathDialog
            // 
            JavaPathDialog.Filter = "Java|javaw.exe";
            JavaPathDialog.FileOk += JavaPathDialog_FileOk;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 68);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 68);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = SystemColors.Window;
            // 
            // OptimizationTimer
            // 
            OptimizationTimer.Enabled = true;
            OptimizationTimer.Interval = 5000;
            OptimizationTimer.Tick += OptimizationTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(784, 411);
            Controls.Add(TabControl);
            Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Simple Minecraft Launcher";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            UsersTabPage.ResumeLayout(false);
            LaunchTabPage.ResumeLayout(false);
            VersionsTabPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            DownloadTabPage.ResumeLayout(false);
            TabControl1.ResumeLayout(false);
            DVanilla_TabPage.ResumeLayout(false);
            TabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            OldVerTabPage.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            SettingsTabPage.ResumeLayout(false);
            SettingsTabControl.ResumeLayout(false);
            GameSettings.ResumeLayout(false);
            GameSettings.PerformLayout();
            LauncherSettingsPage.ResumeLayout(false);
            LauncherSettingsPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.TabPage TabControl;
        private TabPage LaunchTabPage;
        private ImageList ImageList;
        private TabPage UsersTabPage;
        private Button LaunchButton;
        private ReaLTaiizor.Controls.PoisonComboBox VersionsComboBox;
        private Button VersionConfig;
        private TabPage SettingsTabPage;
        private ReaLTaiizor.Controls.MetroTabControl SettingsTabControl;
        private TabPage GameSettings;
        private TabPage LauncherSettingsPage;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private Button BrowseJavaPathButton;
        private Button AddJavaPathButton;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private OpenFileDialog JavaPathDialog;
        private Button AdduserButton;
        private Button DelUserButton;
        private ReaLTaiizor.Controls.MetroListBox UsersListBox;
        private Button DelJavaPathButton;
        private ReaLTaiizor.Controls.MetroLabel metroLabel3;
        private ReaLTaiizor.Controls.MetroLabel metroLabel4;
        private Button FindJavaButton;
        private TabPage VersionsTabPage;
        private SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.MetroListBox VersionsListBox;
        private Button AddGamePathButton;
        private ReaLTaiizor.Controls.MetroListBox GamePathListBox;
        private Button DelGamePathButton;
        private ReaLTaiizor.Controls.MetroLabel metroLabel6;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.PoisonComboBox UsersComboBox;
        private ToolTip toolTip1;
        private Button RefreshGamePathButton;
        private Button OpenGameFolderButton;
        private ReaLTaiizor.Controls.PoisonComboBox JavaPathComboBox;
        private ReaLTaiizor.Controls.PoisonTextBox AddJavaPathTextBox;
        private ReaLTaiizor.Controls.PoisonTextBox GameMemTextBox;
        private ReaLTaiizor.Controls.PoisonTextBox SidebarWeightTextBox;
        private TabPage DownloadTabPage;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.MetroTabControl TabControl1;
        private TabPage DVanilla_TabPage;
        private TabPage DOptifine_TabPage;
        private Button DelVersionButton;
        private System.Windows.Forms.Timer OptimizationTimer;
        private ReaLTaiizor.Controls.TabPage TabControl2;
        private TabPage tabPage4;
        private Button RefreshReleaseButton;
        private ReaLTaiizor.Controls.MetroListBox VanillaListBox;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ReaLTaiizor.Controls.MetroListBox TasksListBox;
        private Button RefreshSnapshotButton;
        private ReaLTaiizor.Controls.MetroListBox SnapshotListBox;
        private Label JavaInfoLabel;
        private TabPage OldVerTabPage;
        private ReaLTaiizor.Controls.MetroListBox OldVerListBox;
        private Button RefreshOldverButton;
    }
}
