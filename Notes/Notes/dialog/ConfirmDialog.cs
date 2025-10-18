using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Notes.dialog
{
    public partial class ConfirmDialog : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
          );
        public bool IsConfirmed { get; private set; }

        public ConfirmDialog(string message, string title = "Confirm")
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(
            CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            lblTitle.Text = title;
            lblMsg.Text = message;
        }

        private void ConfirmDialog_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();

        }
    }
}
