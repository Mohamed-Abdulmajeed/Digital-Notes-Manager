using Notes.dialog;
using Notes.Models;
using Notes.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class FrmRegiser : Form
    {
        public FrmRegiser()
        {
            InitializeComponent();
        }

        private void FrmRegiser_Load(object sender, EventArgs e)
        {
            picLoading.Image = Properties.Resources.loading;
            picLoading.Location = new Point(
                    (this.ClientSize.Width - picLoading.Width - 100) / 2,
                    (this.ClientSize.Height - picLoading.Height - 100) / 2
                );
            picLoading.Size = new Size(100, 100);
            picLoading.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault()!;
            if (loginForm != null)
            {
                loginForm.Show();
            }
            this.Close();
        }
        bool passwordShown = false;
        private void guna2TextBox2_IconRightClick(object sender, EventArgs e)
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

        private async void btnSign_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
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
                MsgDialog msg = new MsgDialog("Username and password must be at least 3 characters long");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            //-----------------------
            picLoading.Visible = true;
            btnSign.Visible = false;
            btnSign.Enabled = false;
            //-----------------------
            Users? existingUser = null;
            NotesDBContext db = new NotesDBContext();

            await Task.Run(() =>
            {
                existingUser = db.Users.FirstOrDefault(u => u.UserName == username)!;
            });
            picLoading.Visible = false;
            btnSign.Visible = true;
            btnSign.Enabled = true;
            if (existingUser != null)
            {
                MsgDialog msg = new MsgDialog("exists. Please choose a different username");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            
                Users newUser = new Users
                {
                    UserName = username,
                    Password = password
                };
            db.Users.Add(newUser);
            db.SaveChanges();

            var User = db.Users.FirstOrDefault(u => u.UserName == username);

            MsgDialog msg1 = new MsgDialog("Registration completed, You can now log in.");
            msg1.ShowDialog();

            FrmMainPage frmMainPage = new FrmMainPage(User!);
            frmMainPage.Show();
            this.Close();

        }
    }
}
