using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_
{
    public partial class PersonnelOpen : Form
    {
        public PersonnelOpen()
        {
            InitializeComponent();
            Theme.Apply(this);

            try
            {
                var repo = new AccessServiceMemberRepository();
                var members = repo.GetAll();
                foreach (var m in members)
                {
                    listBoxPersonnel.Items.Add($"{m.Rank} {m.FullName} - {m.MovementType}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити дані: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
