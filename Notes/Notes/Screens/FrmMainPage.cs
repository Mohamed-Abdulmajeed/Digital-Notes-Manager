using DevExpress.XtraScheduler;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Guna.UI2.WinForms;
using Notes.dialog;
using Notes.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Color = System.Drawing.Color;
using Document = QuestPDF.Fluent.Document;
using Font = System.Drawing.Font;
using IContainer = QuestPDF.Infrastructure.IContainer;
using Path = System.IO.Path;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using System.Media;

namespace Notes.Screens
{
    public partial class FrmMainPage : Form
    {
        NotesDBContext db = new NotesDBContext();
        Users user;
        Label lblSelectedDate;
        Label lblSelectedFilter;
        List<string[]> DataList = new List<string[]>();
        Notes.Models.Notes currentNote = null!;
        public FrmMainPage(Users CurrentUser)
        {
            InitializeComponent();
            user = CurrentUser;
            lblSelectedDate = lblAllDays;
            lblSelectedFilter = lblNone;
            countdownTimer.Tick += CountdownTimer_Tick!;

            lblAllDays.Click += (s, e) => { resetSelectedLabels(lblAllDays); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblTodays.Click += (s, e) => { resetSelectedLabels(lblTodays); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblWeek.Click += (s, e) => { resetSelectedLabels(lblWeek); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblMonth.Click += (s, e) => { resetSelectedLabels(lblMonth); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblNone.Click += (s, e) => { resetSelectedLabels(lblNone); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblCategory.Click += (s, e) => { resetSelectedLabels(lblCategory); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblTitle.Click += (s, e) => { resetSelectedLabels(lblTitle); filterNotes(lblSelectedDate, lblSelectedFilter); };
            lblStar.Click += (s, e) => { resetSelectedLabels(lblStar); filterNotes(lblSelectedDate, lblSelectedFilter); };

        }
        public void resetSelectedLabels(Label selected)
        {
            if (selected == lblAllDays)
            {
                lblSelectedDate = lblAllDays;
                lblAllDays.ForeColor = Color.Red;
                lblTodays.ForeColor = Color.Black;
                lblWeek.ForeColor = Color.Black;
                lblMonth.ForeColor = Color.Black;
            }
            else if (selected == lblTodays)
            {
                lblSelectedDate = lblTodays;
                lblTodays.ForeColor = Color.Red;
                lblAllDays.ForeColor = Color.Black;
                lblWeek.ForeColor = Color.Black;
                lblMonth.ForeColor = Color.Black;
            }
            else if (selected == lblWeek)
            {
                lblSelectedDate = lblWeek;
                lblWeek.ForeColor = Color.Red;
                lblAllDays.ForeColor = Color.Black;
                lblTodays.ForeColor = Color.Black;
                lblMonth.ForeColor = Color.Black;
            }
            else if (selected == lblMonth)
            {
                lblSelectedDate = lblMonth;
                lblMonth.ForeColor = Color.Red;
                lblAllDays.ForeColor = Color.Black;
                lblTodays.ForeColor = Color.Black;
                lblWeek.ForeColor = Color.Black;
            }
            else if (selected == lblNone)
            {
                lblSelectedFilter = lblNone;
                lblNone.ForeColor = Color.Red;
                lblCategory.ForeColor = Color.Black;
                lblStar.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Black;
            }
            else if (selected == lblTitle)
            {
                lblSelectedFilter = lblTitle;
                lblTitle.ForeColor = Color.Red;
                lblCategory.ForeColor = Color.Black;
                lblStar.ForeColor = Color.Black;
                lblNone.ForeColor = Color.Black;
            }
            else if (selected == lblCategory)
            {
                lblSelectedFilter = lblCategory;
                lblCategory.ForeColor = Color.Red;
                lblTitle.ForeColor = Color.Black;
                lblStar.ForeColor = Color.Black;
                lblNone.ForeColor = Color.Black;
            }
            else if (selected == lblStar)
            {
                lblSelectedFilter = lblStar;
                lblStar.ForeColor = Color.Red;
                lblTitle.ForeColor = Color.Black;
                lblCategory.ForeColor = Color.Black;
                lblNone.ForeColor = Color.Black;
            }
        }
        public void filterNotes(Label date, Label filter)
        {
            var noteDate = db.Notes.ToList();

            if (date == lblTodays)
            {
                noteDate = db.Notes.Where(n => n.DateTime.Date == DateTime.Now.Date).ToList();
            }
            else if (date == lblWeek)
            {
                var today = DateTime.Today;
                var Week = today.AddDays(7);
                noteDate = db.Notes.Where(n => n.DateTime.Date <= Week && n.DateTime.Date >= today).ToList();
            }
            else if (date == lblMonth)
            {
                var today = DateTime.Today;
                var Month = today.AddDays(30);
                noteDate = db.Notes.Where(n => n.DateTime.Date <= Month && n.DateTime.Date >= today).ToList();
            }
            //--------------------------------------
            var filterNote = db.Notes.ToList();
            if (filter == lblTitle)
            {
                filterNote = db.Notes.Where(n => n.Title!.ToLower().Contains(txtFilter.Text.ToLower())).ToList();
            }
            else if (filter == lblCategory)
            {
                filterNote = db.Notes.Where(n => n.Category!.ToLower().Contains(txtFilter.Text.ToLower())).ToList();

            }
            else if (filter == lblStar)
            {
                filterNote = db.Notes.Where(n => n.IsStar == true).ToList();
            }
            //--------------------------------------
            var finalFilter = noteDate.Intersect(filterNote).Where(n => n.UserId == user.Id).OrderBy(n=>n.DateTime).ToList();
            flpCart.Controls.Clear();
            DataList.Clear();
            SetNextNote();
            foreach (var note in finalFilter)
            {
                if (note.DateTime > DateTime.Now)
                {
                    TimeSpan reminder = note.DateTime - DateTime.Now;
                    string reminderText = $"{reminder.Days} days, {reminder.Hours} H, {reminder.Minutes} M";
                    Panel card = CreateCartCard(note.Id, note.Title!, note.Content!, note.Category!, note.DateTime, reminder, note.Color!, note.IsStar);
                    flpCart.Controls.Add(card);
                    DataList.Add(new string[] { note.Title!, note.Content!, note.Category!, note.DateTime.ToShortDateString(), reminderText, note.IsStar.ToString() });
                }
            }
        }
        private Panel CreateCartCard(int Id,string title, string content,string category,DateTime creationDate,TimeSpan reminderSpan,string color,bool isStar,int borderRadius = 15)
        {
            DateTime reminderDate = creationDate + reminderSpan;

            Panel card = new Panel
            {
                Size = new Size(250, 250),
                BackColor = Color.FromName(color),
                Margin = new Padding(10)
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = borderRadius * 2;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(card.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(card.Width - radius, card.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, card.Height - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    card.Region = new Region(path);
                }
            };

            // Title
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(230, 25),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Content
            Label lblContent = new Label
            {
                Text = content,
                Font = new Font("Segoe UI", 8),
                AutoSize = false,
                Size = new Size(230, 60),
                Location = new Point(10, lblTitle.Bottom + 5),
                TextAlign = ContentAlignment.TopLeft,
                AutoEllipsis = true
            };

            // Category
            Label lblCategory = new Label
            {
                Text = "Category: " + category,
                Font = new Font("Segoe UI", 9),
                AutoSize = false,
                Size = new Size(230, 25),
                Location = new Point(10, lblContent.Bottom + 5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // CreationDate
            Label lblCreationDate = new Label
            {
                Text = "Date: " + creationDate.ToString("g"),
                Font = new Font("Segoe UI", 8),
                AutoSize = false,
                Size = new Size(230, 25),
                Location = new Point(10, lblCategory.Bottom + 5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // ReminderDate
            Label lblReminderDate = new Label
            {
                Text = "Remaining: " + $"{reminderSpan.Days} days, {reminderSpan.Hours} H, {reminderSpan.Minutes} M",
                Font = new Font("Segoe UI", 8),
                AutoSize = false,
                Size = new Size(230, 25),
                Location = new Point(10, lblCreationDate.Bottom + 2),
                TextAlign = ContentAlignment.MiddleLeft
            };
            // Button Star
            Button btnStar = new Button
            {
                Size = new Size(30, 30),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btnStar.FlatAppearance.BorderSize = 0;
            btnStar.BackgroundImage = isStar ? Properties.Resources.Filled_star : Properties.Resources.empty_star;
            btnStar.Location = new Point(card.Width - btnStar.Width - 5, 5);
            card.Controls.Add(btnStar);
            btnStar.BringToFront();

            btnStar.Click += (s, e) => ChangeStar(Id, isStar);

            // Panel Edit/Delete
            Panel btnPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                Padding = new Padding(5)
            };
            // btnEdit
            Button btnEdit = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(30, 5),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = Properties.Resources.edit,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += (s, e) => EditCart(Id);

            // btnDelete
            Button btnDelete = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(btnPanel.Width - 30, 5),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btnDelete.FlatAppearance.BorderSize = 0;

            btnDelete.Click += (s, e) => DeleteCart(Id);

            // add Controls to btnPanel(edit , delete)
            btnPanel.Controls.Add(btnEdit);
            btnPanel.Controls.Add(btnDelete);

            // add Controls to Panel
            card.Controls.Add(btnPanel);
            card.Controls.Add(lblReminderDate);
            card.Controls.Add(lblCreationDate);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblContent);
            card.Controls.Add(lblTitle);

            return card;
        }
        private void ChangeStar(int id, bool currentStar)
        {
            bool newStar = !currentStar;
            var note = db.Notes.Find(id)!;
            note.IsStar = newStar;
            db.SaveChanges();
            RefreshNotes();
        }
        private void DeleteCart(int id)
        {
            var dialog = new ConfirmDialog("Are you sure you want to delete this item?", " Confirm Deletion");

            dialog.ShowDialog();

            if (dialog.IsConfirmed)
            {
                var note = db.Notes.Find(id)!;
                db.Notes.Remove(note);
                db.SaveChanges();
                RefreshNotes();
            }
        }
        private void EditCart(int id)
        {
            var note = db.Notes.Find(id)!;
            FrmUpdateNote frmUpdate = new FrmUpdateNote(note, db);
            frmUpdate.ShowDialog();
            RefreshNotes();
        }
        private void SetNextNote()
        {
            countdownTimer.Stop();
            currentNote = db.Notes.Where(n => n.User!.UserName == user.UserName && n.DateTime > DateTime.Now).OrderBy(n => n.DateTime).FirstOrDefault()!;
            
            TimeSpan reminder = currentNote.DateTime - DateTime.Now;

            if (currentNote == null)
            {
                lblTitleNextNote.Text = string.Empty;
                lblTimeLeft.Text = "No Notes";
                return;
            }

            lblTitleNextNote.Text = "Title : " + currentNote.Title;
            lblTimeLeft.Text = $"Remaining: {reminder.Days} days, {reminder.Hours:D2}:{reminder.Minutes:D2}:{reminder.Seconds:D2}";

            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (currentNote == null) return;

            TimeSpan reminder = currentNote.DateTime - DateTime.Now;

            if (reminder.TotalSeconds > 0)
            {
                lblTimeLeft.Text = $"Remaining: {reminder.Days} D, {reminder.Hours:D2}:{reminder.Minutes:D2}:{reminder.Seconds:D2}";
            }
            else
            {
                countdownTimer.Stop();
                Notes.Models.Notes note = currentNote;
                RefreshNotes();
                string soundFile = Path.Combine(Application.StartupPath, "aMonaph.mp3");
                MsgDialog msg = new MsgDialog("Notes time has begun to " + note.Title, soundFile);
                msg.ShowDialog();
            }
        }

        public void RefreshNotes()
        {
            flpCart.Controls.Clear();
            DataList.Clear();
            var userNotes = db.Notes.Where(n => n.User!.UserName == user.UserName).ToList();
            dataGVExpired.Rows.Clear();

            foreach (var note in userNotes.OrderBy(n => n.DateTime))
            {
                if (note.DateTime > DateTime.Now)
                {
                    TimeSpan reminder = note.DateTime - DateTime.Now;
                    Panel card = CreateCartCard(note.Id, note.Title!, note.Content!, note.Category!, note.DateTime, reminder, note.Color!, note.IsStar);
                    flpCart.Controls.Add(card);
                    string reminderText = $"{reminder.Days} days, {reminder.Hours} H, {reminder.Minutes} M";

                    DataList.Add(new string[] { note.Title!, note.Content!, note.Category!, note.DateTime.ToShortDateString(), reminderText, note.IsStar.ToString() });
                }
                else
                {
                    dataGVExpired.Rows.Add(
                        note.Title,
                        note.Content,
                        note.Category,
                        note.DateTime.ToShortDateString(),
                        "Expired",
                        note.IsStar.ToString());
                }
            }
            SetNextNote();
        }
        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            dataGVExpired.Columns.Add("Title", "Title");
            dataGVExpired.Columns.Add("Content", "Content");
            dataGVExpired.Columns.Add("Category", "Category");
            dataGVExpired.Columns.Add("Date", "Date");
            dataGVExpired.Columns.Add("Reminder", "Reminder");
            dataGVExpired.Columns.Add("IsStar", "IsStar");
            RefreshNotes();
            SetNextNote();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddNewNote addForm = new FrmAddNewNote(user);
            addForm.ShowDialog();
            RefreshNotes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text File (*.txt)|*.txt|PDF File (*.pdf)|*.pdf|Word Document (*.docx)|*.docx";
            saveDialog.Title = "Save Data";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;
                string extension = System.IO.Path.GetExtension(filePath).ToLower();

                if (extension == ".txt")
                    SaveAsTxt(filePath);
                else if (extension == ".docx")
                    SaveAsWord(filePath);
                else if (extension == ".pdf")
                    SaveAsPdf(filePath);
            }
        }
        private void SaveAsTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int col1 = 20; // Title
                int col2 = 30; // Content
                int col3 = 15; // Category
                int col4 = 15; // Date
                int col5 = 25; // Reminder
                int col6 = 10; // IsStar

                writer.WriteLine(
                    $"{"Title".PadRight(col1)}" +
                    $"{"Content".PadRight(col2)}" +
                    $"{"Category".PadRight(col3)}" +
                    $"{"Date".PadRight(col4)}" +
                    $"{"Reminder".PadRight(col5)}" +
                    $"{"IsStar".PadRight(col6)}"
                );

                writer.WriteLine(new string('-', col1 + col2 + col3 + col4 + col5 + col6));

                foreach (var row in DataList)
                {
                    var wrappedContent = SplitText(row[1], col2);

                    writer.WriteLine(
                    $"{row[0].PadRight(col1)}" +
                    $"{wrappedContent[0].PadRight(col2)}" +
                    $"{row[2].PadRight(col3)}" +
                    $"{row[3].PadRight(col4)}" +
                    $"{row[4].PadRight(col5)}" +
                    $"{row[5].PadRight(col6)}"
                );

                    for (int i = 1; i < wrappedContent.Count; i++)
                    {
                        writer.WriteLine(
                            $"{"".PadRight(col1)}" +
                            $"{wrappedContent[i].PadRight(col2)}" +
                            $"{"".PadRight(col3)}" +
                            $"{"".PadRight(col4)}" +
                            $"{"".PadRight(col5)}" +
                            $"{"".PadRight(col6)}"
                        );
                    }
                }
            }

            MsgDialog msg = new MsgDialog("The TXT file has been saved successfully!");
            msg.ShowDialog();
        }
        private List<string> SplitText(string text, int maxWidth)
        {
            List<string> lines = new List<string>();

            if (string.IsNullOrWhiteSpace(text))
            {
                lines.Add("");
                return lines;
            }

            string[] words = text.Split(' ');
            string currentLine = "";

            foreach (string word in words)
            {
                if ((currentLine + word).Length > maxWidth)
                {
                    lines.Add(currentLine.TrimEnd());
                    currentLine = word + " ";
                }
                else
                {
                    currentLine += word + " ";
                }
            }

            if (!string.IsNullOrWhiteSpace(currentLine))
                lines.Add(currentLine.TrimEnd());

            return lines;
        }

        private void SaveAsWord(string filePath)
        {
            using (WordprocessingDocument wordDoc =
            WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();

                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                var body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());

                var table = new DocumentFormat.OpenXml.Wordprocessing.Table();

                var props = new DocumentFormat.OpenXml.Wordprocessing.TableProperties(
                new DocumentFormat.OpenXml.Wordprocessing.TableBorders(
                new DocumentFormat.OpenXml.Wordprocessing.TopBorder { Val = DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, Size = 6 },
                new DocumentFormat.OpenXml.Wordprocessing.BottomBorder { Val = DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, Size = 6 },
                new DocumentFormat.OpenXml.Wordprocessing.LeftBorder { Val = DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, Size = 6 },
                new DocumentFormat.OpenXml.Wordprocessing.RightBorder { Val = DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, Size = 6 },
                new DocumentFormat.OpenXml.Wordprocessing.InsideHorizontalBorder { Val = DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, Size = 6 },
                new DocumentFormat.OpenXml.Wordprocessing.InsideVerticalBorder { Val = DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, Size = 6 }
                    )
                );

                table.AppendChild(props);

                var headerRow = new DocumentFormat.OpenXml.Wordprocessing.TableRow();
                string[] headers = { "Title", "Content", "Category", "Date", "Reminder", "IsStar" };

                foreach (var headerText in headers)
                {
                    var cell = new DocumentFormat.OpenXml.Wordprocessing.TableCell(
                        new DocumentFormat.OpenXml.Wordprocessing.Paragraph(
                            new DocumentFormat.OpenXml.Wordprocessing.Run(
                                new DocumentFormat.OpenXml.Wordprocessing.RunProperties(
                                    new DocumentFormat.OpenXml.Wordprocessing.Bold() 
                                ),
                                new DocumentFormat.OpenXml.Wordprocessing.Text(headerText)
                            )
                        )
                    );
                    headerRow.Append(cell);
                }

                table.Append(headerRow);

                foreach (var row in DataList)
                {
                    var tableRow = new DocumentFormat.OpenXml.Wordprocessing.TableRow();

                    foreach (var cellText in row)
                    {
                        var cell = new DocumentFormat.OpenXml.Wordprocessing.TableCell(
                            new DocumentFormat.OpenXml.Wordprocessing.Paragraph(
                                new DocumentFormat.OpenXml.Wordprocessing.Run(
                                    new DocumentFormat.OpenXml.Wordprocessing.Text(cellText ?? string.Empty)
                                )
                            )
                        );
                        tableRow.Append(cell);
                    }

                    table.Append(tableRow);
                }

                body.Append(table);
                mainPart.Document.Save();
            }

            MsgDialog msg = new MsgDialog("The Word file has been saved successfully!");
            msg.ShowDialog();
        }

        private void SaveAsPdf(string filePath)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            string[] headers = { "Title", "Content", "Category", "Date", "Reminder", "IsStar" };

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);
                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < headers.Length; i++)
                                columns.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            for (int i = 0; i < headers.Length; i++)
                                header.Cell().Element(CellStyle).Text(headers[i]).Bold();
                        });

                        foreach (var row in DataList)
                        {
                            table.Cell().Element(CellStyle).Text(row[0]);
                            table.Cell().Element(CellStyle).Text(row[1]);
                            table.Cell().Element(CellStyle).Text(row[2]);
                            table.Cell().Element(CellStyle).Text(row[3]);
                            table.Cell().Element(CellStyle).Text(row[4]);
                            table.Cell().Element(CellStyle).Text(row[5]);
                        }
                    });
                });
            }).GeneratePdf(filePath);
            MsgDialog msg = new MsgDialog("The PDF file has been saved successfully!");
            msg.ShowDialog();
        }

        private static IContainer CellStyle(IContainer container)
        {
            return container
                .Padding(5)
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2);
        }

    }
}
