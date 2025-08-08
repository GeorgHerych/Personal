using System;
using System.Linq;
using System.Windows.Forms;

namespace Personal_
{
    /// <summary>
    /// Window "КТВП" that provides a number of controls for working with
    /// temporary movement of service members. The implementation focuses on
    /// laying out the interface elements so that future developers can wire
    /// additional business logic.
    /// </summary>
    public class KTVPForm : Form
    {
        // Search controls
        private TextBox txtSearch = new TextBox();
        private Button btnSearch = new Button();

        // Primary buttons
        private Button btnExport = new Button();
        private Button btnNew = new Button();
        private Button btnDuplicate = new Button();
        private Button btnPrint = new Button();

        // Checkboxes
        private CheckBox chkPrintAll = new CheckBox();
        private CheckBox chkPrintNumber = new CheckBox();

        // Filter buttons
        private Button btnClearFilter = new Button();
        private Button btnGroupSearch = new Button();
        private Button btnDepart = new Button();
        private Button btnArrive = new Button();
        private Button btnArrived = new Button();

        // Date controls
        private DateTimePicker dtpDate = new DateTimePicker();
        private Button btnChangeDate = new Button();

        // ID search
        private TextBox txtId = new TextBox();
        private Button btnIdSearch = new Button();
        private Label lblIdInfo = new Label();

        // Movement type
        private ComboBox cmbMovementType = new ComboBox();

        // Additional text fields
        private TextBox txtMeta = new TextBox();
        private TextBox txtMisce = new TextBox();
        private TextBox txtPidstava = new TextBox();
        private TextBox txtRaport = new TextBox();

        // Status combos
        private ComboBox cmbStatus = new ComboBox();
        private ComboBox cmbAvailability = new ComboBox();
        private ComboBox cmbPPD = new ComboBox();

        // Bottom list box
        private ListBox lstBottom = new ListBox();

        public KTVPForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "КТВП";
            Width = 900;
            Height = 600;

            // Search
            txtSearch.SetBounds(10, 10, 200, 25);
            btnSearch.Text = "Пошук";
            btnSearch.SetBounds(220, 10, 75, 25);

            // Primary buttons
            btnExport.Text = "Вигрузити";
            btnExport.SetBounds(310, 10, 90, 25);
            btnNew.Text = "Новий запис";
            btnNew.SetBounds(410, 10, 100, 25);
            btnDuplicate.Text = "Дублювати";
            btnDuplicate.SetBounds(520, 10, 90, 25);
            btnPrint.Text = "Друкувати";
            btnPrint.SetBounds(620, 10, 90, 25);

            // Checkboxes
            chkPrintAll.Text = "друкувати всі";
            chkPrintAll.SetBounds(720, 10, 120, 25);
            chkPrintNumber.Text = "друкувати №";
            chkPrintNumber.SetBounds(720, 35, 120, 25);

            // Filter buttons
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.SetBounds(10, 50, 120, 25);
            btnGroupSearch.Text = "Груповий пошук";
            btnGroupSearch.SetBounds(140, 50, 120, 25);
            btnDepart.Text = "Вибувають";
            btnDepart.SetBounds(270, 50, 90, 25);
            btnArrive.Text = "Прибувають";
            btnArrive.SetBounds(370, 50, 90, 25);
            btnArrived.Text = "Прибули";
            btnArrived.SetBounds(470, 50, 90, 25);

            // Date
            dtpDate.SetBounds(10, 85, 200, 25);
            btnChangeDate.Text = "Змінити дату";
            btnChangeDate.SetBounds(220, 85, 110, 25);

            // ID search
            var lblId = new Label { Text = "ІДВС:", Left = 10, Top = 120, Width = 50 };
            txtId.SetBounds(60, 120, 100, 25);
            btnIdSearch.Text = "Пошук";
            btnIdSearch.SetBounds(170, 120, 75, 25);
            btnIdSearch.Click += BtnIdSearch_Click;
            lblIdInfo.SetBounds(250, 120, 400, 25);

            // Movement type
            var lblMovement = new Label { Text = "Тип руху:", Left = 10, Top = 155, Width = 80 };
            cmbMovementType.SetBounds(100, 155, 200, 25);
            cmbMovementType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovementType.Items.AddRange(new object[] {
                "відрядження",
                "відпустка основна щорічна",
                "відпустка за сімейними обставинами",
                "відпустка за станом здоровя",
                "госпіталь",
                "форма 10",
                "СЗЧ",
                "прикомандирування",
                "зведений загін",
                "200",
                "призначення ТВО",
                "зниклий безвісти",
                "відпустка в звязку з вагітністю та пологами",
                "Резерв"
            });

            // Additional text fields
            var lblMeta = new Label { Text = "Мета", Left = 10, Top = 190, Width = 80 };
            txtMeta.SetBounds(100, 190, 200, 25);
            var lblMisce = new Label { Text = "Місце", Left = 10, Top = 220, Width = 80 };
            txtMisce.SetBounds(100, 220, 200, 25);
            var lblPidstava = new Label { Text = "Підстава", Left = 10, Top = 250, Width = 80 };
            txtPidstava.SetBounds(100, 250, 200, 25);
            var lblRaport = new Label { Text = "Рапорт", Left = 10, Top = 280, Width = 80 };
            txtRaport.SetBounds(100, 280, 200, 25);

            // Status combos
            var lblStatus = new Label { Text = "Статус", Left = 350, Top = 190, Width = 80 };
            cmbStatus.SetBounds(430, 190, 200, 25);
            cmbStatus.Items.AddRange(new object[] {
                "відношення",
                "призов",
                "наказ",
                "в штаті",
                "переведений",
                "звільнений",
                "прикомандерований",
                "вибув з відрядження",
                "в розпорядженні",
                "виключений зі списків"
            });
            var lblAvailability = new Label { Text = "Наявність", Left = 350, Top = 220, Width = 80 };
            cmbAvailability.SetBounds(430, 220, 200, 25);
            cmbAvailability.Items.AddRange(new object[] {
                "В наявності",
                "відрядження",
                "відпустка",
                "Госпіталь",
                "СЗЧ",
                "загинув",
                "помер",
                "зниклий безвісті",
                "полон",
                "в розпорядженні",
                "арешт"
            });
            var lblPPD = new Label { Text = "ППД", Left = 350, Top = 250, Width = 80 };
            cmbPPD.SetBounds(430, 250, 200, 25);
            cmbPPD.DropDownStyle = ComboBoxStyle.DropDown;

            // Bottom list
            lstBottom.SetBounds(10, 320, 840, 200);

            Controls.AddRange(new Control[] {
                txtSearch, btnSearch, btnExport, btnNew, btnDuplicate, btnPrint,
                chkPrintAll, chkPrintNumber,
                btnClearFilter, btnGroupSearch, btnDepart, btnArrive, btnArrived,
                dtpDate, btnChangeDate,
                lblId, txtId, btnIdSearch, lblIdInfo,
                lblMovement, cmbMovementType,
                lblMeta, txtMeta, lblMisce, txtMisce, lblPidstava, txtPidstava, lblRaport, txtRaport,
                lblStatus, cmbStatus, lblAvailability, cmbAvailability, lblPPD, cmbPPD,
                lstBottom
            });
        }

        private void BtnIdSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                using (var db = new AppDbContext())
                {
                    var member = db.ServiceMembers.FirstOrDefault(m => m.Id == id);
                    if (member != null)
                    {
                        lblIdInfo.Text = $"{member.Rank} {member.FullName}";
                        cmbMovementType.SelectedItem = member.MovementType;
                    }
                    else
                    {
                        lblIdInfo.Text = "Не знайдено";
                    }
                }
            }
        }
    }
}
