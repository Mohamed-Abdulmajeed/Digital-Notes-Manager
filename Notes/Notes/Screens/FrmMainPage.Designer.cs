namespace Notes.Screens
{
    partial class FrmMainPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpCart = new FlowLayoutPanel();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            lblTodays = new Label();
            lblWeek = new Label();
            lblMonth = new Label();
            lblAllDays = new Label();
            txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            lblStar = new Label();
            lblCategory = new Label();
            label3 = new Label();
            lblNone = new Label();
            dataGVExpired = new Guna.UI2.WinForms.Guna2DataGridView();
            panel3 = new Panel();
            label2 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTimeLeft = new Label();
            lblTitleNextNote = new Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVExpired).BeginInit();
            panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpCart
            // 
            flpCart.AutoScroll = true;
            flpCart.BackColor = Color.FromArgb(64, 64, 64);
            flpCart.Location = new Point(1, 205);
            flpCart.Margin = new Padding(10);
            flpCart.Name = "flpCart";
            flpCart.Padding = new Padding(10);
            flpCart.Size = new Size(1143, 646);
            flpCart.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(63, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 20;
            btnSave.CustomizableEdges = customizableEdges2;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = HorizontalAlignment.Left;
            btnSave.ImageSize = new Size(30, 30);
            btnSave.Location = new Point(103, 10);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnSave.Size = new Size(108, 47);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.TextAlign = HorizontalAlignment.Right;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1709, 67);
            panel2.TabIndex = 3;
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
            btnCancel.Location = new Point(1660, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(46, 43);
            btnCancel.TabIndex = 20;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 16F, FontStyle.Bold);
            label1.Location = new Point(447, 82);
            label1.Name = "label1";
            label1.Size = new Size(160, 40);
            label1.TabIndex = 4;
            label1.Text = "My Notes";
            // 
            // lblTodays
            // 
            lblTodays.AutoSize = true;
            lblTodays.Cursor = Cursors.Hand;
            lblTodays.Font = new Font("Segoe UI Symbol", 12F);
            lblTodays.Location = new Point(69, 163);
            lblTodays.Name = "lblTodays";
            lblTodays.Size = new Size(89, 32);
            lblTodays.TabIndex = 5;
            lblTodays.Text = "Todays";
            // 
            // lblWeek
            // 
            lblWeek.AutoSize = true;
            lblWeek.Cursor = Cursors.Hand;
            lblWeek.Font = new Font("Segoe UI Symbol", 12F);
            lblWeek.Location = new Point(174, 163);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(124, 32);
            lblWeek.TabIndex = 6;
            lblWeek.Text = "This Week";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Cursor = Cursors.Hand;
            lblMonth.Font = new Font("Segoe UI Symbol", 12F);
            lblMonth.Location = new Point(313, 163);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(136, 32);
            lblMonth.TabIndex = 7;
            lblMonth.Text = "This Month";
            // 
            // lblAllDays
            // 
            lblAllDays.AutoSize = true;
            lblAllDays.Cursor = Cursors.Hand;
            lblAllDays.Font = new Font("Segoe UI Symbol", 12F);
            lblAllDays.ForeColor = Color.Red;
            lblAllDays.Location = new Point(16, 163);
            lblAllDays.Name = "lblAllDays";
            lblAllDays.Size = new Size(41, 32);
            lblAllDays.TabIndex = 8;
            lblAllDays.Text = "All";
            // 
            // txtFilter
            // 
            txtFilter.BorderColor = Color.FromArgb(192, 0, 0);
            txtFilter.BorderRadius = 20;
            txtFilter.CustomizableEdges = customizableEdges5;
            txtFilter.DefaultText = "";
            txtFilter.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFilter.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFilter.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFilter.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtFilter.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFilter.Location = new Point(894, 118);
            txtFilter.Margin = new Padding(4, 6, 4, 6);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "";
            txtFilter.SelectedText = "";
            txtFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtFilter.Size = new Size(237, 38);
            txtFilter.TabIndex = 17;
            txtFilter.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Cursor = Cursors.Hand;
            lblTitle.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(857, 165);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Title";
            // 
            // lblStar
            // 
            lblStar.AutoSize = true;
            lblStar.Cursor = Cursors.Hand;
            lblStar.Font = new Font("Segoe UI Symbol", 12F);
            lblStar.Location = new Point(1071, 165);
            lblStar.Name = "lblStar";
            lblStar.Size = new Size(55, 32);
            lblStar.TabIndex = 15;
            lblStar.Text = "Star";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Cursor = Cursors.Hand;
            lblCategory.Font = new Font("Segoe UI Symbol", 12F);
            lblCategory.Location = new Point(941, 165);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(110, 32);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Symbol", 12F);
            label3.Location = new Point(767, 117);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 13;
            label3.Text = "Filter By :";
            // 
            // lblNone
            // 
            lblNone.AutoSize = true;
            lblNone.Cursor = Cursors.Hand;
            lblNone.Font = new Font("Segoe UI Symbol", 12F);
            lblNone.ForeColor = Color.Red;
            lblNone.Location = new Point(768, 165);
            lblNone.Name = "lblNone";
            lblNone.Size = new Size(73, 32);
            lblNone.TabIndex = 18;
            lblNone.Text = "None";
            // 
            // dataGVExpired
            // 
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGVExpired.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGVExpired.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 120, 200);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVExpired.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVExpired.ColumnHeadersHeight = 40;
            dataGVExpired.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 239, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGVExpired.DefaultCellStyle = dataGridViewCellStyle3;
            dataGVExpired.Dock = DockStyle.Bottom;
            dataGVExpired.GridColor = Color.FromArgb(231, 229, 255);
            dataGVExpired.Location = new Point(0, 70);
            dataGVExpired.MultiSelect = false;
            dataGVExpired.Name = "dataGVExpired";
            dataGVExpired.ReadOnly = true;
            dataGVExpired.RowHeadersVisible = false;
            dataGVExpired.RowHeadersWidth = 62;
            dataGVExpired.Size = new Size(553, 573);
            dataGVExpired.TabIndex = 19;
            dataGVExpired.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGVExpired.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGVExpired.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGVExpired.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGVExpired.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGVExpired.ThemeStyle.BackColor = Color.White;
            dataGVExpired.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGVExpired.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGVExpired.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGVExpired.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGVExpired.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGVExpired.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGVExpired.ThemeStyle.HeaderStyle.Height = 40;
            dataGVExpired.ThemeStyle.ReadOnly = true;
            dataGVExpired.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGVExpired.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVExpired.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGVExpired.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGVExpired.ThemeStyle.RowsStyle.Height = 33;
            dataGVExpired.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGVExpired.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(dataGVExpired);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1157, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(553, 643);
            panel3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Symbol", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(192, 19);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 19;
            label2.Text = "Expired Notes";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.Red;
            guna2Panel1.BorderRadius = 50;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblTimeLeft);
            guna2Panel1.Controls.Add(lblTitleNextNote);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = Color.FromArgb(0, 0, 64);
            guna2Panel1.Location = new Point(1157, 77);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.Color = Color.Transparent;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(550, 122);
            guna2Panel1.TabIndex = 21;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.BackColor = Color.Transparent;
            lblTimeLeft.Cursor = Cursors.Hand;
            lblTimeLeft.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeLeft.ForeColor = Color.Cornsilk;
            lblTimeLeft.Location = new Point(89, 62);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(117, 32);
            lblTimeLeft.TabIndex = 18;
            lblTimeLeft.Text = "Reminder";
            // 
            // lblTitleNextNote
            // 
            lblTitleNextNote.AutoSize = true;
            lblTitleNextNote.BackColor = Color.Transparent;
            lblTitleNextNote.Cursor = Cursors.Hand;
            lblTitleNextNote.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleNextNote.ForeColor = Color.Cornsilk;
            lblTitleNextNote.Location = new Point(89, 15);
            lblTitleNextNote.Name = "lblTitleNextNote";
            lblTitleNextNote.Size = new Size(79, 32);
            lblTitleNextNote.TabIndex = 17;
            lblTitleNextNote.Text = "Title : ";
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            // 
            // FrmMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1711, 849);
            Controls.Add(guna2Panel1);
            Controls.Add(panel3);
            Controls.Add(lblNone);
            Controls.Add(txtFilter);
            Controls.Add(lblTitle);
            Controls.Add(lblStar);
            Controls.Add(lblCategory);
            Controls.Add(label3);
            Controls.Add(lblAllDays);
            Controls.Add(lblMonth);
            Controls.Add(lblWeek);
            Controls.Add(lblTodays);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(flpCart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMainPage";
            Load += FrmMainPage_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGVExpired).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpCart;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private Label label1;
        private Label lblTodays;
        private Label lblWeek;
        private Label lblMonth;
        private Label lblAllDays;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Label lblTitle;
        private Label lblStar;
        private Label lblCategory;
        private Label label3;
        private Label lblNone;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DataGridView dataGVExpired;
        private Panel panel3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTitleNextNote;
        private System.Windows.Forms.Timer countdownTimer;
        private Label lblTimeLeft;
    }
}