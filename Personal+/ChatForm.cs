using System;
using System.Windows.Forms;

namespace Personal_
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            ChatService.MarkAsRead(Login.Session.CurrentUserLogin);
            LoadMessages();
        }

        private void LoadMessages()
        {
            listViewMessages.Items.Clear();
            foreach (var msg in ChatService.GetMessages())
            {
                var item = new ListViewItem(msg.Sender);
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
            ChatService.MarkAsRead(senderLogin);
            txtMessage.Clear();
            LoadMessages();
        }
    }
}
