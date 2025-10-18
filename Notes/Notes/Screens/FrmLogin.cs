using Guna.UI2.WinForms;
using Notes.dialog;
using Notes.Models;
using Notes.Screens;
using System.IO;

namespace Notes
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picLoading.BackColor = Color.Transparent;
            picLoading.Image = Properties.Resources.loading;
            picLoading.Location = new Point(
                    (this.ClientSize.Width - picLoading.Width-100) / 2,
                    (this.ClientSize.Height - picLoading.Height-100) / 2
                );
            picLoading.Size=new Size(100,100);
            picLoading.BringToFront();
            
        }

        private void btnSinup_Click(object sender, EventArgs e)
        {
            FrmRegiser registerForm = new FrmRegiser();
            registerForm.Show();
            this.Hide();
        }
        bool passwordShown = false;

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            passwordShown = !passwordShown;
            if (passwordShown)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.IconRight = Properties.Resources.hide; ;
            }
            else
            {
                txtPassword.PasswordChar = '\u25CF';
                txtPassword.IconRight = Properties.Resources.show; ;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MsgDialog msg = new MsgDialog("Please enter both username and password.");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            if (username.Length < 3 || password.Length < 3)
            {
                MsgDialog msg = new MsgDialog("Username and password must be at least 3 characters long.");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            //-----------------------
            picLoading.Visible = true;
            btnSignin.Visible = false;
            btnSignin.Enabled = false;
            //-----------------------
            Users? existingUser = null;
            await Task.Run(() =>
            {
                NotesDBContext db = new NotesDBContext();
                existingUser = db.Users.FirstOrDefault(u => u.UserName == username);
            });
            if (existingUser == null)
            {
                MsgDialog msg = new MsgDialog("Username Not Found!. Go to Registeraion!.");
                System.Media.SystemSounds.Asterisk.Play();
                picLoading.Visible = false;
                btnSignin.Visible = true;
                btnSignin.Enabled = true;
                msg.ShowDialog();
                return;
            }
            if(existingUser.Password != password)
            {
                MsgDialog msg = new MsgDialog("Incorrect password. Please try again.");
                System.Media.SystemSounds.Asterisk.Play();
                picLoading.Visible = false;
                btnSignin.Visible = true;
                btnSignin.Enabled = true;
                msg.ShowDialog();
                return;
            }

            MsgDialog msg1 = new MsgDialog("Login Successfuly.");
            picLoading.Visible = false;
            btnSignin.Visible = true;
            btnSignin.Enabled = true;
            msg1.ShowDialog();

            FrmMainPage frmMainPage = new FrmMainPage(existingUser);
            frmMainPage.Show();
            this.Hide();
            
        }
    }
}
