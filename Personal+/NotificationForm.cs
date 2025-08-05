using System;
using System.Drawing;
using System.Windows.Forms;

namespace Personal_
{
    public class NotificationForm : Form
    {
        public NotificationForm(string sender, string text, Image avatar)
        {
            Text = $"Повідомлення від {sender}";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            var pic = new PictureBox
            {
                Image = avatar,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 64,
                Height = 64,
                Dock = DockStyle.Left
            };

            var lbl = new Label
            {
                Text = text,
                AutoSize = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            var btn = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                AutoSize = true
            };

            var panel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 2,
                Dock = DockStyle.Fill,
                AutoSize = true
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            panel.Controls.Add(pic, 0, 0);
            panel.SetRowSpan(pic, 2);
            panel.Controls.Add(lbl, 1, 0);
            panel.Controls.Add(btn, 1, 1);

            Controls.Add(panel);
            AcceptButton = btn;
        }
    }
}
