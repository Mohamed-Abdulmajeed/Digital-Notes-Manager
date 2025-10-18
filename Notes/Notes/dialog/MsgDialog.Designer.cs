namespace Notes.dialog
{
    partial class MsgDialog
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
            btnOk = new Guna.UI2.WinForms.Guna2Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BorderRadius = 20;
            btnOk.CustomizableEdges = customizableEdges1;
            btnOk.DisabledState.BorderColor = Color.DarkGray;
            btnOk.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOk.FillColor = Color.Red;
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(280, 157);
            btnOk.Name = "btnOk";
            btnOk.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOk.Size = new Size(94, 40);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI", 12F);
            lblMsg.Location = new Point(69, 27);
            lblMsg.MaximumSize = new Size(500, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 32);
            lblMsg.TabIndex = 4;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MsgDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(650, 227);
            Controls.Add(lblMsg);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MsgDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MsgDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOk;
        private Label lblMsg;
    }
}