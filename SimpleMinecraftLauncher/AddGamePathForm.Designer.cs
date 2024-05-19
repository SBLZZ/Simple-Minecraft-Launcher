namespace SimpleMinecraftLauncher
{
    partial class AddGamePathForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGamePathForm));
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            BrowseGamePathButton = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            DoneButton = new Button();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            CancelButton = new Button();
            Label3 = new Label();
            Label4 = new Label();
            GamePathNameTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            AddGamePathTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Segoe UI", 10.25F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(12, 88);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(68, 20);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "游戏目录";
            metroLabel1.ThemeAuthor = "SBLZZ";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // BrowseGamePathButton
            // 
            BrowseGamePathButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseGamePathButton.BackColor = SystemColors.Control;
            BrowseGamePathButton.FlatAppearance.BorderSize = 0;
            BrowseGamePathButton.FlatStyle = FlatStyle.Flat;
            BrowseGamePathButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrowseGamePathButton.Location = new Point(516, 111);
            BrowseGamePathButton.Name = "BrowseGamePathButton";
            BrowseGamePathButton.Size = new Size(56, 30);
            BrowseGamePathButton.TabIndex = 8;
            BrowseGamePathButton.Text = "浏览";
            BrowseGamePathButton.UseVisualStyleBackColor = false;
            BrowseGamePathButton.Click += BrowseGamePathButton_Click;
            // 
            // DoneButton
            // 
            DoneButton.BackColor = SystemColors.Control;
            DoneButton.FlatAppearance.BorderSize = 0;
            DoneButton.FlatStyle = FlatStyle.Flat;
            DoneButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoneButton.Location = new Point(530, 324);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(42, 25);
            DoneButton.TabIndex = 9;
            DoneButton.Text = "完成";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneButton_Click;
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new Font("Segoe UI", 10.25F);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(12, 9);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(68, 20);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 10;
            metroLabel2.Text = "名称";
            metroLabel2.ThemeAuthor = "SBLZZ";
            metroLabel2.ThemeName = "MetroLight";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.Control;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(482, 324);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(42, 25);
            CancelButton.TabIndex = 12;
            CancelButton.Text = "取消";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Segoe UI", 10.5F);
            Label3.ForeColor = Color.Red;
            Label3.Location = new Point(12, 65);
            Label3.Name = "Label3";
            Label3.Size = new Size(93, 19);
            Label3.TabIndex = 13;
            Label3.Text = "名称不能为空";
            Label3.Visible = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Segoe UI", 10.5F);
            Label4.ForeColor = Color.Red;
            Label4.Location = new Point(12, 144);
            Label4.Name = "Label4";
            Label4.Size = new Size(121, 19);
            Label4.TabIndex = 14;
            Label4.Text = "游戏目录不能为空";
            Label4.Visible = false;
            // 
            // GamePathNameTextBox
            // 
            GamePathNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            GamePathNameTextBox.CustomButton.Image = null;
            GamePathNameTextBox.CustomButton.Location = new Point(532, 2);
            GamePathNameTextBox.CustomButton.Name = "";
            GamePathNameTextBox.CustomButton.Size = new Size(25, 25);
            GamePathNameTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            GamePathNameTextBox.CustomButton.TabIndex = 1;
            GamePathNameTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            GamePathNameTextBox.CustomButton.UseSelectable = true;
            GamePathNameTextBox.CustomButton.Visible = false;
            GamePathNameTextBox.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GamePathNameTextBox.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            GamePathNameTextBox.Location = new Point(12, 32);
            GamePathNameTextBox.MaxLength = 32767;
            GamePathNameTextBox.Name = "GamePathNameTextBox";
            GamePathNameTextBox.PasswordChar = '\0';
            GamePathNameTextBox.ScrollBars = ScrollBars.None;
            GamePathNameTextBox.SelectedText = "";
            GamePathNameTextBox.SelectionLength = 0;
            GamePathNameTextBox.SelectionStart = 0;
            GamePathNameTextBox.ShortcutsEnabled = true;
            GamePathNameTextBox.Size = new Size(560, 30);
            GamePathNameTextBox.TabIndex = 15;
            GamePathNameTextBox.UseSelectable = true;
            GamePathNameTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            GamePathNameTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // AddGamePathTextBox
            // 
            AddGamePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            AddGamePathTextBox.CustomButton.Image = null;
            AddGamePathTextBox.CustomButton.Location = new Point(470, 2);
            AddGamePathTextBox.CustomButton.Name = "";
            AddGamePathTextBox.CustomButton.Size = new Size(25, 25);
            AddGamePathTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            AddGamePathTextBox.CustomButton.TabIndex = 1;
            AddGamePathTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            AddGamePathTextBox.CustomButton.UseSelectable = true;
            AddGamePathTextBox.CustomButton.Visible = false;
            AddGamePathTextBox.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddGamePathTextBox.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            AddGamePathTextBox.Location = new Point(12, 111);
            AddGamePathTextBox.MaxLength = 32767;
            AddGamePathTextBox.Name = "AddGamePathTextBox";
            AddGamePathTextBox.PasswordChar = '\0';
            AddGamePathTextBox.ScrollBars = ScrollBars.None;
            AddGamePathTextBox.SelectedText = "";
            AddGamePathTextBox.SelectionLength = 0;
            AddGamePathTextBox.SelectionStart = 0;
            AddGamePathTextBox.ShortcutsEnabled = true;
            AddGamePathTextBox.Size = new Size(498, 30);
            AddGamePathTextBox.TabIndex = 16;
            AddGamePathTextBox.UseSelectable = true;
            AddGamePathTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            AddGamePathTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // AddGamePathForm
            // 
            AcceptButton = DoneButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(584, 361);
            Controls.Add(AddGamePathTextBox);
            Controls.Add(GamePathNameTextBox);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(CancelButton);
            Controls.Add(metroLabel2);
            Controls.Add(DoneButton);
            Controls.Add(BrowseGamePathButton);
            Controls.Add(metroLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddGamePathForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "添加游戏目录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private Button BrowseGamePathButton;
        private FolderBrowserDialog folderBrowserDialog;
        private Button DoneButton;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private Button CancelButton;
        private Label Label3;
        private Label Label4;
        public ReaLTaiizor.Controls.PoisonTextBox GamePathNameTextBox;
        public ReaLTaiizor.Controls.PoisonTextBox AddGamePathTextBox;
    }
}