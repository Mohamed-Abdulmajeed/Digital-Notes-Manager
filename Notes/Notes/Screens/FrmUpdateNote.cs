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

namespace Notes.Screens
{
    public partial class FrmUpdateNote : Form
    {
        Notes.Models.Notes note;
        NotesDBContext db;
        string selectedColor = "Coral";
        bool isStarred = false;

        public FrmUpdateNote(Notes.Models.Notes note, NotesDBContext _db)
        {
            InitializeComponent();
            this.note = note;
            this.db = _db;
            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;
            txtCategory.Text = note.Category;
            DTPDate.Value = note.DateTime;
            time.EditValue = note.DateTime;
            selectedColor = note.Color!;
            btnColorChoosed.FillColor = Color.FromName(note.Color!);
            isStarred = note.IsStar;
            if (isStarred)
                btnStar.BackgroundImage = Properties.Resources.Filled_star;

            else
                btnStar.BackgroundImage = Properties.Resources.empty_star;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtCategory.Text))
            {
                MsgDialog msg = new MsgDialog("Please enter All Fields!!");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            DateTime selectedDate = DTPDate.Value.Date;

            TimeSpan selectedTime = time.Time.TimeOfDay;

            DateTime finalDateTime = selectedDate.Add(selectedTime);
            if (finalDateTime < DateTime.Now)
            {
                MsgDialog msg = new MsgDialog("The selected date and time cannot be in the past!!");
                System.Media.SystemSounds.Asterisk.Play();
                msg.ShowDialog();
                return;
            }
            note.Title = txtTitle.Text.Trim();
            note.Content = txtContent.Text.Trim();
            note.Category = txtCategory.Text.Trim();
            note.DateTime = finalDateTime;
            note.Color = selectedColor;
            note.IsStar = isStarred;
            db.SaveChanges();
            this.Close();

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

    }
}
