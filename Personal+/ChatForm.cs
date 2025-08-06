using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Personal_
{
    public class ChatForm : Form
    {
        private readonly User _currentUser;
        private ComboBox _userSelect;
        private ListBox _messages;
        private TextBox _input;
        private Button _sendButton;
        private CheckBox _showAll;

        public ChatForm(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            LoadUsers();
            UpdateMessages();
        }

        private void InitializeComponent()
        {
            Text = "Чат";
            Width = 600;
            Height = 400;
            _userSelect = new ComboBox { Left = 10, Top = 10, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            _userSelect.SelectedIndexChanged += (s, e) => UpdateMessages();
            _messages = new ListBox { Left = 10, Top = 40, Width = 560, Height = 250 };
            _input = new TextBox { Left = 10, Top = 300, Width = 480 };
            _sendButton = new Button { Text = "Надіслати", Left = 500, Top = 298, Width = 70 };
            _sendButton.Click += SendButton_Click;
            Controls.AddRange(new Control[] { _userSelect, _messages, _input, _sendButton });
            if (_currentUser.IsAdmin)
            {
                _showAll = new CheckBox { Text = "Всі чати", Left = 220, Top = 12 };
                _showAll.CheckedChanged += (s, e) => UpdateMessages();
                Controls.Add(_showAll);
            }
        }

        private void LoadUsers()
        {
            _userSelect.Items.Clear();
            _userSelect.Items.Add("Загальний");
            using (var db = new AppDbContext())
            {
                var users = db.Users.Where(u => u.IsActive && u.Id != _currentUser.Id).ToList();
                foreach (var u in users)
                    _userSelect.Items.Add(u);
            }
            _userSelect.DisplayMember = "Login";
            _userSelect.SelectedIndex = 0;
        }

        private User SelectedUser => _userSelect.SelectedItem as User;

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_input.Text)) return;
            using (var db = new AppDbContext())
            {
                var msg = new ChatMessage
                {
                    SenderId = _currentUser.Id,
                    ReceiverId = SelectedUser?.Id,
                    Text = _input.Text
                };
                db.ChatMessages.Add(msg);
                db.SaveChanges();
            }
            _input.Clear();
            UpdateMessages();
        }

        private void UpdateMessages()
        {
            _messages.Items.Clear();
            using (var db = new AppDbContext())
            {
                if (_currentUser.IsAdmin && _showAll != null && _showAll.Checked)
                {
                    var all = db.ChatMessages.Include(m => m.Sender).Include(m => m.Receiver).OrderBy(m => m.SentAt).ToList();
                    foreach (var m in all)
                        _messages.Items.Add(string.Format("{0:HH:mm} {1}->{2}: {3}", m.SentAt, m.Sender.Login, m.Receiver?.Login ?? "Всі", m.Text));
                    return;
                }

                if (SelectedUser == null)
                {
                    var msgs = db.ChatMessages.Include(m => m.Sender)
                        .Where(m => m.ReceiverId == null)
                        .OrderBy(m => m.SentAt)
                        .ToList();
                    foreach (var m in msgs)
                        _messages.Items.Add(string.Format("{0:HH:mm} {1}: {2}", m.SentAt, m.Sender.Login, m.Text));
                }
                else
                {
                    var msgs = db.ChatMessages.Include(m => m.Sender)
                        .Where(m => (m.SenderId == _currentUser.Id && m.ReceiverId == SelectedUser.Id) ||
                                    (m.SenderId == SelectedUser.Id && m.ReceiverId == _currentUser.Id))
                        .OrderBy(m => m.SentAt)
                        .ToList();
                    foreach (var m in msgs)
                        _messages.Items.Add(string.Format("{0:HH:mm} {1}: {2}", m.SentAt, m.Sender.Login, m.Text));
                }
            }
        }
    }
}
