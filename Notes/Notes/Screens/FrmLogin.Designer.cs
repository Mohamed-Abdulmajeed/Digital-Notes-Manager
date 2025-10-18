namespace Notes
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            lblForget = new Label();
            btnSignin = new Guna.UI2.WinForms.Guna2Button();
            btnSinup = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            picLoading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 86);
            label1.Name = "label1";
            label1.Size = new Size(186, 35);
            label1.TabIndex = 1;
            label1.Text = "Ready to Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 143);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.BorderColor = Color.FromArgb(64, 0, 0);
            txtUserName.BorderRadius = 20;
            txtUserName.CustomizableEdges = customizableEdges1;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtUserName.ForeColor = Color.Red;
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.IconLeft = (Image)resources.GetObject("txtUserName.IconLeft");
            txtUserName.IconLeftSize = new Size(50, 50);
            txtUserName.Location = new Point(269, 172);
            txtUserName.Margin = new Padding(4, 6, 4, 6);
            txtUserName.Name = "txtUserName";
            txtUserName.Padding = new Padding(0, 0, 100, 0);
            txtUserName.PlaceholderText = "";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUserName.Size = new Size(410, 50);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.FromArgb(64, 0, 0);
            txtPassword.BorderRadius = 20;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.Red;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(40, 40);
            txtPassword.IconRight = Properties.Resources.show;
            txtPassword.IconRightSize = new Size(40, 40);
            txtPassword.Location = new Point(269, 257);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(410, 45);
            txtPassword.TabIndex = 6;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.IconRightClick += txtPassword_IconRightClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 229);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // lblForget
            // 
            lblForget.AutoSize = true;
            lblForget.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForget.Location = new Point(501, 317);
            lblForget.Name = "lblForget";
            lblForget.Size = new Size(178, 23);
            lblForget.TabIndex = 7;
            lblForget.Text = "Forget Password?";
            // 
            // btnSignin
            // 
            btnSignin.BorderColor = Color.Maroon;
            btnSignin.BorderRadius = 23;
            btnSignin.CustomizableEdges = customizableEdges5;
            btnSignin.DisabledState.BorderColor = Color.DarkGray;
            btnSignin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignin.FillColor = Color.Black;
            btnSignin.FocusedColor = Color.Red;
            btnSignin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSignin.ForeColor = Color.White;
            btnSignin.HoverState.FillColor = Color.Red;
            btnSignin.Location = new Point(480, 386);
            btnSignin.Name = "btnSignin";
            btnSignin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSignin.Size = new Size(174, 45);
            btnSignin.TabIndex = 8;
            btnSignin.Text = "Sign In";
            btnSignin.Click += btnSignin_Click;
            // 
            // btnSinup
            // 
            btnSinup.BorderColor = Color.Maroon;
            btnSinup.BorderRadius = 23;
            btnSinup.CustomizableEdges = customizableEdges7;
            btnSinup.DisabledState.BorderColor = Color.DarkGray;
            btnSinup.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSinup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSinup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSinup.FillColor = SystemColors.ControlDarkDark;
            btnSinup.FocusedColor = Color.Red;
            btnSinup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSinup.ForeColor = Color.White;
            btnSinup.HoverState.FillColor = Color.Red;
            btnSinup.Location = new Point(278, 386);
            btnSinup.Name = "btnSinup";
            btnSinup.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSinup.Size = new Size(174, 45);
            btnSinup.TabIndex = 9;
            btnSinup.Text = "Sign Up";
            btnSinup.Click += btnSinup_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Transparent;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(684, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(49, 49);
            btnCancel.TabIndex = 20;
            btnCancel.Click += btnCancel_Click;
            // 
            // picLoading
            // 
            picLoading.BackColor = Color.Transparent;
            picLoading.Image = Properties.Resources.loading;
            picLoading.Location = new Point(278, 17);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(31, 31);
            picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            picLoading.TabIndex = 21;
            picLoading.TabStop = false;
            picLoading.Visible = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 491);
            Controls.Add(picLoading);
            Controls.Add(btnCancel);
            Controls.Add(btnSinup);
            Controls.Add(btnSignin);
            Controls.Add(lblForget);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xxxx";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label label3;
        private Label lblForget;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private Guna.UI2.WinForms.Guna2Button btnSinup;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private PictureBox picLoading;
    }
    
}
