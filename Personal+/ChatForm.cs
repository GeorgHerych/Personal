using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Personal_
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private Timer notificationTimer;

        private void ChatForm_Load(object sender, EventArgs e)
        {
            LoadMessages();
            notificationTimer = new Timer { Interval = 1000 };
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
            NotificationTimer_Tick(null, EventArgs.Empty);
        }

        private void LoadMessages()
        {
            listViewMessages.Items.Clear();
            imageListAvatars.Images.Clear();
            foreach (var msg in ChatService.GetMessages())
            {
                var key = msg.Sender;
                if (!imageListAvatars.Images.ContainsKey(key))
                {
                    using (var img = GetAvatarImage(key))
                    {
                        imageListAvatars.Images.Add(key, (Image)img.Clone());
                    }
                }

                var item = new ListViewItem(msg.Sender, key);
                item.SubItems.Add(msg.Text);
                item.SubItems.Add(msg.Timestamp.ToString("g"));
                var read = msg.ReadBy.Contains(Login.Session.CurrentUserLogin) ? "Так" : "Ні";
                item.SubItems.Add(read);
                listViewMessages.Items.Add(item);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var text = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;
            var senderLogin = Login.Session.CurrentUserLogin ?? "Користувач";
            ChatService.AddMessage(senderLogin, text);
            txtMessage.Clear();
            LoadMessages();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            foreach (var msg in ChatService.GetMessages())
            {
                if (!msg.ReadBy.Contains(Login.Session.CurrentUserLogin))
                {
                    ShowNotification(msg);
                    msg.ReadBy.Add(Login.Session.CurrentUserLogin);
                }
            }
        }

        private void ShowNotification(ChatMessage msg)
        {
            using (var img = GetAvatarImage(msg.Sender))
            using (var form = new NotificationForm(msg.Sender, msg.Text, img))
            {
                form.ShowDialog(this);
            }
            LoadMessages();
        }

        private Image GetAvatarImage(string login)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Login == login);
                var path = user?.AvatarPath;
                if (string.IsNullOrEmpty(path) || !File.Exists(path))
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "logo.png");
                }
                return Image.FromFile(path);
            }
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notificationTimer?.Stop();
            notificationTimer?.Dispose();
        }
    }
}
