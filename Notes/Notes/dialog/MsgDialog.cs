using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace Notes.dialog
{
    public partial class MsgDialog : Form
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
        private WindowsMediaPlayer? player;
        public MsgDialog(string message, string? soundFile = null)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(
            CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            lblMsg.Text = message;
            if (!string.IsNullOrEmpty(soundFile))
            {
                try
                {
                    player = new WindowsMediaPlayer();
                    player.URL = soundFile;  
                    player.controls.play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing sound: " + ex.Message);
                }
            }
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (player != null)
                player.controls.stop(); 
            this.Close();
        }

    }
}
