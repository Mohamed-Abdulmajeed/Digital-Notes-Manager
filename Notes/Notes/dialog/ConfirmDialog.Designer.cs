namespace Notes.dialog
{
    partial class ConfirmDialog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDialog));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblMsg = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnNo = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI", 11F);
            lblMsg.Location = new Point(99, 67);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 30);
            lblMsg.TabIndex = 0;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Red;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(188, 172);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(94, 40);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Yes";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnNo
            // 
            btnNo.BorderRadius = 20;
            btnNo.CustomizableEdges = customizableEdges3;
            btnNo.DisabledState.BorderColor = Color.DarkGray;
            btnNo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNo.FillColor = Color.Blue;
            btnNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(311, 172);
            btnNo.Name = "btnNo";
            btnNo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNo.Size = new Size(94, 40);
            btnNo.TabIndex = 3;
            btnNo.Text = "No";
            btnNo.Click += btnNo_Click;
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
            btnCancel.Location = new Point(542, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(46, 43);
            btnCancel.TabIndex = 21;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(53, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(64, 32);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Title";
            // 
            // ConfirmDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 250);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnNo);
            Controls.Add(guna2Button1);
            Controls.Add(lblMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmDialog";
            Load += ConfirmDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnNo;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private Label lblTitle;
    }
}