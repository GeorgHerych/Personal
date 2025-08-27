using System;
using System.Windows.Forms;
using System.Linq;

namespace Personal_
{
    /// <summary>
    /// Form representing the KTVP interface. It exposes the same set of
    /// fields and buttons shown in the reference screenshot, but does not
    /// implement any business logic yet.
    /// </summary>
    public partial class KtvpForm : Form
    {
        public KtvpForm()
        {
            InitializeComponent();
        }

        private void KtvpForm_Load(object sender, EventArgs e)
        {
            // Populate combo boxes with example values.
            cmbUnit.Items.AddRange(new[] { "ВЧ 2060", "ВЧ 3014" });
            cmbSubdivision.Items.AddRange(new[] { "Рота 1", "Рота 2" });
            if (cmbUnit.Items.Count > 0) cmbUnit.SelectedIndex = 0;
            if (cmbSubdivision.Items.Count > 0) cmbSubdivision.SelectedIndex = 0;

            // Load service members from the database and display them.
            using (var db = new AppDbContext())
            {
                var members = db.ServiceMembers.ToList();
                int order = 1;
                foreach (var m in members)
                {
                    dataGridMembers.Rows.Add(order++, m.Position, m.Rank, m.LastName, m.FirstName, m.MiddleName, m.MovementType);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функція створення КТВП ще не реалізована.");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перегляд виконаних ще не реалізований.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Додавання записів поки не підтримується.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

