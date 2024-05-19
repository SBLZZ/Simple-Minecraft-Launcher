namespace SimpleMinecraftLauncher
{
    partial class AdduserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdduserForm));
            AddUserDoneButton = new Button();
            AddUserCancelButton = new Button();
            label1 = new Label();
            UsernameTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            UUIDTextBox = new ReaLTaiizor.Controls.PoisonTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // AddUserDoneButton
            // 
            AddUserDoneButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddUserDoneButton.BackColor = SystemColors.Control;
            AddUserDoneButton.FlatAppearance.BorderSize = 0;
            AddUserDoneButton.FlatStyle = FlatStyle.Flat;
            AddUserDoneButton.Font = new Font("Segoe UI", 10.5F);
            AddUserDoneButton.Location = new Point(281, 144);
            AddUserDoneButton.Name = "AddUserDoneButton";
            AddUserDoneButton.Size = new Size(91, 28);
            AddUserDoneButton.TabIndex = 2;
            AddUserDoneButton.Text = "完成";
            AddUserDoneButton.UseVisualStyleBackColor = false;
            AddUserDoneButton.Click += AddUserDoneButton_Click;
            // 
            // AddUserCancelButton
            // 
            AddUserCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddUserCancelButton.BackColor = SystemColors.Control;
            AddUserCancelButton.FlatAppearance.BorderSize = 0;
            AddUserCancelButton.FlatStyle = FlatStyle.Flat;
            AddUserCancelButton.Font = new Font("Segoe UI", 10.5F);
            AddUserCancelButton.Location = new Point(184, 144);
            AddUserCancelButton.Name = "AddUserCancelButton";
            AddUserCancelButton.Size = new Size(91, 28);
            AddUserCancelButton.TabIndex = 3;
            AddUserCancelButton.Text = "取消";
            AddUserCancelButton.UseVisualStyleBackColor = false;
            AddUserCancelButton.Click += AddUserCancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 4;
            label1.Text = "用户名";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            UsernameTextBox.CustomButton.Image = null;
            UsernameTextBox.CustomButton.Location = new Point(332, 2);
            UsernameTextBox.CustomButton.Name = "";
            UsernameTextBox.CustomButton.Size = new Size(25, 25);
            UsernameTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            UsernameTextBox.CustomButton.TabIndex = 1;
            UsernameTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            UsernameTextBox.CustomButton.UseSelectable = true;
            UsernameTextBox.CustomButton.Visible = false;
            UsernameTextBox.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextBox.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            UsernameTextBox.Location = new Point(12, 31);
            UsernameTextBox.MaxLength = 32767;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PasswordChar = '\0';
            UsernameTextBox.ScrollBars = ScrollBars.None;
            UsernameTextBox.SelectedText = "";
            UsernameTextBox.SelectionLength = 0;
            UsernameTextBox.SelectionStart = 0;
            UsernameTextBox.ShortcutsEnabled = true;
            UsernameTextBox.Size = new Size(360, 30);
            UsernameTextBox.TabIndex = 17;
            UsernameTextBox.UseSelectable = true;
            UsernameTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            UsernameTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // UUIDTextBox
            // 
            UUIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            UUIDTextBox.CustomButton.Image = null;
            UUIDTextBox.CustomButton.Location = new Point(332, 2);
            UUIDTextBox.CustomButton.Name = "";
            UUIDTextBox.CustomButton.Size = new Size(25, 25);
            UUIDTextBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            UUIDTextBox.CustomButton.TabIndex = 1;
            UUIDTextBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            UUIDTextBox.CustomButton.UseSelectable = true;
            UUIDTextBox.CustomButton.Visible = false;
            UUIDTextBox.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UUIDTextBox.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            UUIDTextBox.Location = new Point(12, 86);
            UUIDTextBox.MaxLength = 32767;
            UUIDTextBox.Name = "UUIDTextBox";
            UUIDTextBox.PasswordChar = '\0';
            UUIDTextBox.ScrollBars = ScrollBars.None;
            UUIDTextBox.SelectedText = "";
            UUIDTextBox.SelectionLength = 0;
            UUIDTextBox.SelectionStart = 0;
            UUIDTextBox.ShortcutsEnabled = true;
            UUIDTextBox.Size = new Size(360, 30);
            UUIDTextBox.TabIndex = 19;
            UUIDTextBox.UseSelectable = true;
            UUIDTextBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            UUIDTextBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 18;
            label2.Text = "UUID(可以不填)";
            // 
            // AdduserForm
            // 
            AcceptButton = AddUserDoneButton;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            CancelButton = AddUserCancelButton;
            ClientSize = new Size(384, 184);
            Controls.Add(UUIDTextBox);
            Controls.Add(label2);
            Controls.Add(UsernameTextBox);
            Controls.Add(label1);
            Controls.Add(AddUserCancelButton);
            Controls.Add(AddUserDoneButton);
            Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdduserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "添加用户";
            Load += AdduserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddUserCancelButton;
        private Label label1;
        private Button AddUserDoneButton;
        public ReaLTaiizor.Controls.PoisonTextBox UsernameTextBox;
        public ReaLTaiizor.Controls.PoisonTextBox UUIDTextBox;
        private Label label2;
    }
}