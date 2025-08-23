using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Personal_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            btnLogin.Click += Login_Click;
            Text_Pass.UseSystemPasswordChar = true;

            if (Properties.Settings.Default.RememberMe)
            {
                Text_Login.Text = Properties.Settings.Default.Login;
                Text_Pass.Text = Properties.Settings.Default.Password;
                checkBox1.Checked = true;
            }
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            string login = Text_Login.Text.Trim();
            string pass = Text_Pass.Text;

            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введіть логін і пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = await AuthenticateAsync(login, pass);
            if(user == null)
            {
                MessageBox.Show("Невірний логін або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Login = login;
                Properties.Settings.Default.Password = pass;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.Login = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();

            Session.CurrentUser = user;
            this.Hide();
            using (var mainForm = new Form1())
            {
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.ShowDialog();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async Task<User> AuthenticateAsync(string login, string pass)
        {
            using (var db = new AppDbContext())
            {
                // Retrieve the user by login and validate the hashed password
                var user = await db.Users.FirstOrDefaultAsync(u => u.Login == login);
                if (user == null) return null;

                return BCrypt.Net.BCrypt.Verify(pass, user.Password) ? user : null;
            }
        }
        private void RememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static class Session {
            public static User CurrentUser { get; set; }
        }
    }
}
