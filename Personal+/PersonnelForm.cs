using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personal_
{
    public class PersonnelRecord
    {
        public string ShID { get; set; }
        public string PosID { get; set; }
        public string VSID { get; set; }
        public string TVO { get; set; }
        public string Status { get; set; }
        public string Nayavnist { get; set; }
        public string PPD { get; set; }
        public string Rank { get; set; }
        public string PIB { get; set; }
        public string Posada { get; set; }
        public string PidrozdilSkor { get; set; }
        public string BChS { get; set; }
        public string Category { get; set; }
        public string VOS { get; set; }
        public string IPN { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string SHPK { get; set; }
        public string TR { get; set; }
        public string PosadoviyOklad { get; set; }
    }

    public class PersonnelForm : Form
    {
        private TextBox txtSearch = new TextBox();
        private Button btnSearch = new Button();
        private ComboBox cmbDepartments = new ComboBox();
        private Button btnClear = new Button();
        private Button btnGroupSearch = new Button();
        private DataGridView grid = new DataGridView();
        private CheckBox chkAll = new CheckBox();
        private CheckBox chkOfficers = new CheckBox();
        private CheckBox chkSergeants = new CheckBox();
        private CheckBox chkSoldiers = new CheckBox();
        private Button btnExport = new Button();

        private BindingList<PersonnelRecord> allData = new BindingList<PersonnelRecord>();
        private BindingList<PersonnelRecord> viewData = new BindingList<PersonnelRecord>();

        public PersonnelForm()
        {
            InitializeComponent();
            LoadSampleData();
            ApplyFilters();
        }

        private void InitializeComponent()
        {
            this.Text = "Персонал";
            this.Width = 1200;
            this.Height = 700;

            txtSearch.SetBounds(10, 10, 200, 25);
            btnSearch.Text = "Пошук";
            btnSearch.SetBounds(220, 10, 75, 25);
            btnSearch.Click += (s, e) => ApplyFilters();

            cmbDepartments.SetBounds(310, 10, 150, 25);
            cmbDepartments.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartments.Items.Add("Усі");
            cmbDepartments.Items.Add("A");
            cmbDepartments.Items.Add("B");
            cmbDepartments.SelectedIndex = 0;
            cmbDepartments.SelectedIndexChanged += (s, e) => ApplyFilters();

            btnClear.Text = "Очистити";
            btnClear.SetBounds(470, 10, 90, 25);
            btnClear.Click += (s, e) =>
            {
                txtSearch.Clear();
                cmbDepartments.SelectedIndex = 0;
                chkAll.Checked = true;
                ApplyFilters();
            };

            btnGroupSearch.Text = "Груповий пошук";
            btnGroupSearch.SetBounds(570, 10, 130, 25);
            btnGroupSearch.Click += (s, e) => ApplyFilters();

            chkAll.Text = "всі";
            chkAll.SetBounds(720, 10, 50, 25);
            chkAll.Checked = true;
            chkAll.CheckedChanged += RankChanged;

            chkOfficers.Text = "офіцери";
            chkOfficers.SetBounds(780, 10, 80, 25);
            chkOfficers.CheckedChanged += RankChanged;

            chkSergeants.Text = "сержанти";
            chkSergeants.SetBounds(870, 10, 90, 25);
            chkSergeants.CheckedChanged += RankChanged;

            chkSoldiers.Text = "солдати";
            chkSoldiers.SetBounds(970, 10, 80, 25);
            chkSoldiers.CheckedChanged += RankChanged;

            btnExport.Text = "Вигрузити";
            btnExport.SetBounds(1060, 10, 100, 25);
            btnExport.Click += BtnExport_Click;

            grid.SetBounds(10, 50, 1150, 600);
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AutoGenerateColumns = false;
            grid.DataSource = viewData;
            string[] headers = { "ShID","PosID","VSID","TВО","Статус","Наявність","ППД","Звання","ПІБ","Посада","Підрозділ скор.","БЧС","Категорія","ВОС","ІПН","Дата народження","Телефон","ШПК","ТР","Посадовий оклад" };
            string[] props = { nameof(PersonnelRecord.ShID), nameof(PersonnelRecord.PosID), nameof(PersonnelRecord.VSID), nameof(PersonnelRecord.TVO), nameof(PersonnelRecord.Status), nameof(PersonnelRecord.Nayavnist), nameof(PersonnelRecord.PPD), nameof(PersonnelRecord.Rank), nameof(PersonnelRecord.PIB), nameof(PersonnelRecord.Posada), nameof(PersonnelRecord.PidrozdilSkor), nameof(PersonnelRecord.BChS), nameof(PersonnelRecord.Category), nameof(PersonnelRecord.VOS), nameof(PersonnelRecord.IPN), nameof(PersonnelRecord.BirthDate), nameof(PersonnelRecord.Phone), nameof(PersonnelRecord.SHPK), nameof(PersonnelRecord.TR), nameof(PersonnelRecord.PosadoviyOklad) };
            for (int i = 0; i < headers.Length; i++)
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = headers[i],
                    DataPropertyName = props[i],
                    Width = 100
                });
            }

            this.Controls.AddRange(new Control[] {
                txtSearch, btnSearch, cmbDepartments, btnClear, btnGroupSearch,
                chkAll, chkOfficers, chkSergeants, chkSoldiers, btnExport, grid
            });
        }

        private void RankChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked) return;
            chkAll.Checked = sender == chkAll;
            chkOfficers.Checked = sender == chkOfficers;
            chkSergeants.Checked = sender == chkSergeants;
            chkSoldiers.Checked = sender == chkSoldiers;
            ApplyFilters();
        }

        private void LoadSampleData()
        {
            allData.Add(new PersonnelRecord { ShID = "1", PosID = "10", VSID = "100", TVO = "A", Status = "активний", Nayavnist = "так", PPD = "Київ", Rank = "Офіцер", PIB = "Іваненко І.І.", Posada = "Командир", PidrozdilSkor = "A", BChS = "100", Category = "1", VOS = "1111", IPN = "123", BirthDate = "1990-01-01", Phone = "123456", SHPK = "1", TR = "", PosadoviyOklad = "1000" });
            allData.Add(new PersonnelRecord { ShID = "2", PosID = "20", VSID = "200", TVO = "B", Status = "активний", Nayavnist = "так", PPD = "Львів", Rank = "Сержант", PIB = "Петренко П.П.", Posada = "Сержант", PidrozdilSkor = "B", BChS = "80", Category = "2", VOS = "2222", IPN = "234", BirthDate = "1992-02-02", Phone = "234567", SHPK = "2", TR = "", PosadoviyOklad = "800" });
            allData.Add(new PersonnelRecord { ShID = "3", PosID = "30", VSID = "300", TVO = "A", Status = "активний", Nayavnist = "так", PPD = "Одеса", Rank = "Солдат", PIB = "Сидоренко С.С.", Posada = "Стрілець", PidrozdilSkor = "A", BChS = "90", Category = "3", VOS = "3333", IPN = "345", BirthDate = "1995-03-03", Phone = "345678", SHPK = "3", TR = "", PosadoviyOklad = "500" });
        }

        private void ApplyFilters()
        {
            IEnumerable<PersonnelRecord> query = allData;

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string term = txtSearch.Text.ToLowerInvariant();
                query = query.Where(p => (p.PIB ?? "").ToLowerInvariant().Contains(term));
            }

            if (cmbDepartments.SelectedIndex > 0)
            {
                string dep = cmbDepartments.SelectedItem.ToString();
                query = query.Where(p => p.PidrozdilSkor == dep);
            }

            if (chkOfficers.Checked)
                query = query.Where(p => p.Rank == "Офіцер");
            else if (chkSergeants.Checked)
                query = query.Where(p => p.Rank == "Сержант");
            else if (chkSoldiers.Checked)
                query = query.Where(p => p.Rank == "Солдат");

            viewData.Clear();
            foreach (var item in query)
                viewData.Add(item);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = "export.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.WriteLine(string.Join(",", new[]{"ShID","PosID","VSID","TВО","Статус","Наявність","ППД","Звання","ПІБ","Посада","Підрозділ скор.","БЧС","Категорія","ВОС","ІПН","Дата народження","Телефон","ШПК","ТР","Посадовий оклад"}));
                        foreach (var p in viewData)
                        {
                            writer.WriteLine(string.Join(",", new[]{p.ShID,p.PosID,p.VSID,p.TVO,p.Status,p.Nayavnist,p.PPD,p.Rank,p.PIB,p.Posada,p.PidrozdilSkor,p.BChS,p.Category,p.VOS,p.IPN,p.BirthDate,p.Phone,p.SHPK,p.TR,p.PosadoviyOklad}));
                        }
                    }
                    MessageBox.Show("Дані збережено.");
                }
            }
        }
    }
}
