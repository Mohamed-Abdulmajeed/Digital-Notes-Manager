using Notes.dialog;
using Notes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Notes.Screens
{
    public partial class FrmAddNewNote : Form
    {
        Users user;
        NotesDBContext db = new NotesDBContext();
        string selectedColor = "Coral";
        bool isStarred = false;
        public FrmAddNewNote(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmAddNewNote_Load(object sender, EventArgs e)
        {
            picLoading.Image = Properties.Resources.loading;
            picLoading.Location = new Point(
                    (this.ClientSize.Width - picLoading.Width - 100) / 2,
                    (this.ClientSize.Height - picLoading.Height - 100) / 2
                );
            picLoading.Size = new Size(100, 100);
            picLoading.BringToFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddNote_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtContent.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtCategory.Text))
            {
                MsgDialog msg = new MsgDialog("Please enter All Fields!!.");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            DateTime selectedDate = DTPDate.Value.Date;

            TimeSpan selectedTime = time.Time.TimeOfDay;

            DateTime finalDateTime = selectedDate.Add(selectedTime);
            if (finalDateTime < DateTime.Now)
            {
                MsgDialog msg = new MsgDialog("The selected date and time cannot be in the past!.");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }

            Notes.Models.Notes note = new Notes.Models.Notes
            {
                Title = txtTitle.Text,
                Content = txtContent.Text,
                Category = txtCategory.Text,
                DateTime = finalDateTime,
                Color = selectedColor,
                IsStar = isStarred,
                UserId = user.Id
            };
            picLoading.Visible = true;
            btnAddNote.Visible = false;
            btnAddNote.Enabled = false;
            await Task.Run(() =>
            {
                db.Notes.Add(note);
                db.SaveChanges();
            });
            picLoading.Visible = false;
            btnAddNote.Visible = true;
            btnAddNote.Enabled = true;

            MsgDialog msg1 = new MsgDialog("Note added successfully");
            msg1.ShowDialog();

            this.Close();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            isStarred = !isStarred;

            if (isStarred)
            {
                btnStar.BackgroundImage = Properties.Resources.Filled_star; ;
            }
            else
            {
                btnStar.BackgroundImage = Properties.Resources.empty_star; ;
            }
        }

        private void btnColorCoral_Click(object sender, EventArgs e)
        {
            selectedColor = "Coral";
            btnColorChoosed.FillColor = Color.Coral;
        }

        private void btnColorOrange_Click(object sender, EventArgs e)
        {
            selectedColor = "Orange";
            btnColorChoosed.FillColor = Color.Orange;
        }

        private void btnColorYellow_Click(object sender, EventArgs e)
        {
            selectedColor = "Yellow";
            btnColorChoosed.FillColor = Color.Yellow;
        }

        private void btnColorAqua_Click(object sender, EventArgs e)
        {
            selectedColor = "Aqua";
            btnColorChoosed.FillColor = Color.Aqua;
        }

        private void btnColorPink_Click(object sender, EventArgs e)
        {
            selectedColor = "Pink";
            btnColorChoosed.FillColor = Color.Pink;
        }

        private void btnColorLightGreen_Click(object sender, EventArgs e)
        {
            selectedColor = "LightGreen";
            btnColorChoosed.FillColor = Color.LightGreen;
        }
    }
}
