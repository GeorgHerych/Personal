using System.Drawing;
using System.Windows.Forms;

namespace Personal_
{
    internal static class Theme
    {
        private static readonly Color FormBackground = Color.PaleGoldenrod;
        private static readonly Color HeaderBackground = Color.LightSteelBlue;
        private static readonly Color AlternatingRowBackground = Color.FromArgb(240, 248, 255);

        public static void Apply(Form form)
        {
            form.BackColor = FormBackground;
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView dgv)
                {
                    StyleDataGridView(dgv);
                }

                if (control.HasChildren)
                {
                    StyleControls(control.Controls);
                }
            }
        }

        private static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = HeaderBackground;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = AlternatingRowBackground;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGoldenrodYellow;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}

