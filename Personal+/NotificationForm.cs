using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Personal_
{
    public class NotificationForm : Form
    {
        private readonly Notification _notification;
        private Label _readersLabel;

        public NotificationForm(Notification notification)
        {
            _notification = notification;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Сповіщення";
            this.Width = 400;
            this.Height = 200;
            var textLabel = new Label { Text = _notification.Text, Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            var okButton = new Button { Text = "OK", Dock = DockStyle.Bottom, Height = 40 };
            okButton.Click += (s, e) => this.DialogResult = DialogResult.OK;
            _readersLabel = new Label { Dock = DockStyle.Bottom, Height = 30, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            Controls.Add(textLabel);
            Controls.Add(okButton);
            Controls.Add(_readersLabel);
            LoadReaders();
        }

        private void LoadReaders()
        {
            using (var db = new AppDbContext())
            {
                var readers = db.NotificationReads
                    .Where(r => r.NotificationId == _notification.Id)
                    .Select(r => r.UserId)
                    .ToList();
                var names = db.Users
                    .Where(u => readers.Contains(u.Id))
                    .Select(u => u.Login)
                    .ToList();
                _readersLabel.Text = names.Count > 0 ? "Прочитали: " + string.Join(", ", names) : "Ніхто не прочитав";
            }
        }
    }
}
