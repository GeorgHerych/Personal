using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

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
        // Layout container
        private FlowLayoutPanel panel = new FlowLayoutPanel();

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

        // Extended movement fields
        private TextBox txtTVO = new TextBox();
        private Button btnTVOSearch = new Button();
        private TextBox txtTVOPosada = new TextBox();
        private Button btnTVOPosSearch = new Button();
        private TextBox txtSuhpay = new TextBox();
        private TextBox txtOrderNumber = new TextBox();
        private DateTimePicker dtpOrderDate = new DateTimePicker();
        private DateTimePicker dtpStart = new DateTimePicker();
        private DateTimePicker dtpEnd = new DateTimePicker();
        private TextBox txtTravelTime = new TextBox();
        private TextBox txtTerm = new TextBox();
        private TextBox txtPositionId = new TextBox();

        // Closure section
        private Label lblClosure = new Label();
        private Button btnAutoDate = new Button();
        private TextBox txtCloseOrderNumber = new TextBox();
        private DateTimePicker dtpCloseOrderDate = new DateTimePicker();
        private TextBox txtCloseReason = new TextBox();
        private TextBox txtCloseReport = new TextBox();
        private TextBox txtTotalLeave = new TextBox();

        // Status combos
        private ComboBox cmbStatus = new ComboBox();
        private ComboBox cmbAvailability = new ComboBox();
        private ComboBox cmbPPD = new ComboBox();

        // Bottom list box
        private ListBox lstBottom = new ListBox();

        public KTVPForm()
        {
            InitializeComponent();
            lstBottom.Width = panel.ClientSize.Width - 20;
        }

        private void InitializeComponent()
        {
            Text = "КТВП";
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            panel.WrapContents = true;
            panel.FlowDirection = FlowDirection.LeftToRight;

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

            // Extended movement fields
            var lblTVO = new Label { Text = "ТВО", Left = 10, Top = 310, Width = 80 };
            txtTVO.SetBounds(100, 310, 140, 25);
            btnTVOSearch.Text = "Пошук";
            btnTVOSearch.SetBounds(245, 310, 55, 25);

            var lblTVOPos = new Label { Text = "ТВО посади", Left = 10, Top = 340, Width = 80 };
            txtTVOPosada.SetBounds(100, 340, 140, 25);
            btnTVOPosSearch.Text = "Пошук";
            btnTVOPosSearch.SetBounds(245, 340, 55, 25);

            var lblSuhpay = new Label { Text = "Сухпай діб", Left = 10, Top = 370, Width = 80 };
            txtSuhpay.SetBounds(100, 370, 200, 25);

            var lblOrderNumber = new Label { Text = "Номер наказу", Left = 10, Top = 400, Width = 90 };
            txtOrderNumber.SetBounds(100, 400, 200, 25);

            var lblOrderDate = new Label { Text = "Дата наказу", Left = 10, Top = 430, Width = 90 };
            dtpOrderDate.SetBounds(100, 430, 200, 25);

            var lblStart = new Label { Text = "Початок", Left = 10, Top = 460, Width = 80 };
            dtpStart.SetBounds(100, 460, 200, 25);

            var lblEnd = new Label { Text = "Закінчення", Left = 10, Top = 490, Width = 80 };
            dtpEnd.SetBounds(100, 490, 200, 25);

            var lblTravelTime = new Label { Text = "Час на дорогу", Left = 10, Top = 520, Width = 90 };
            txtTravelTime.SetBounds(100, 520, 200, 25);

            var lblTerm = new Label { Text = "Термін", Left = 10, Top = 550, Width = 80 };
            txtTerm.SetBounds(100, 550, 200, 25);

            var lblPositionId = new Label { Text = "ІД посади", Left = 10, Top = 580, Width = 80 };
            txtPositionId.SetBounds(100, 580, 200, 25);

            // Closure section
            lblClosure.Text = "ЗАКРИТТЯ";
            lblClosure.Font = new Font(Font, FontStyle.Bold);
            lblClosure.SetBounds(10, 610, 100, 25);
            btnAutoDate.Text = "Автодата";
            btnAutoDate.SetBounds(120, 610, 80, 25);
            btnAutoDate.Click += (s, e) => dtpCloseOrderDate.Value = DateTime.Today;

            var lblCloseOrderNumber = new Label { Text = "№ наказу закр.", Left = 10, Top = 640, Width = 110 };
            txtCloseOrderNumber.SetBounds(120, 640, 180, 25);

            var lblCloseOrderDate = new Label { Text = "Дата наказу", Left = 10, Top = 670, Width = 110 };
            dtpCloseOrderDate.SetBounds(120, 670, 180, 25);

            var lblCloseReason = new Label { Text = "Підстава закінч.", Left = 10, Top = 700, Width = 110 };
            txtCloseReason.SetBounds(120, 700, 180, 25);

            var lblCloseReport = new Label { Text = "Рапорт закінч.", Left = 10, Top = 730, Width = 110 };
            txtCloseReport.SetBounds(120, 730, 180, 25);

            var lblTotalLeave = new Label { Text = "Всього відпустки", Left = 10, Top = 760, Width = 110 };
            txtTotalLeave.SetBounds(120, 760, 180, 25);

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
            lstBottom.SetBounds(10, 800, 840, 150);
            panel.SetFlowBreak(lstBottom, true);

            panel.Controls.AddRange(new Control[] {
                txtSearch, btnSearch, btnExport, btnNew, btnDuplicate, btnPrint,
                chkPrintAll, chkPrintNumber,
                btnClearFilter, btnGroupSearch, btnDepart, btnArrive, btnArrived,
                dtpDate, btnChangeDate,
                lblId, txtId, btnIdSearch, lblIdInfo,
                lblMovement, cmbMovementType,
                lblMeta, txtMeta, lblMisce, txtMisce, lblPidstava, txtPidstava, lblRaport, txtRaport,
                lblTVO, txtTVO, btnTVOSearch, lblTVOPos, txtTVOPosada, btnTVOPosSearch,
                lblSuhpay, txtSuhpay, lblOrderNumber, txtOrderNumber, lblOrderDate, dtpOrderDate,
                lblStart, dtpStart, lblEnd, dtpEnd, lblTravelTime, txtTravelTime,
                lblTerm, txtTerm, lblPositionId, txtPositionId,
                lblClosure, btnAutoDate, lblCloseOrderNumber, txtCloseOrderNumber,
                lblCloseOrderDate, dtpCloseOrderDate, lblCloseReason, txtCloseReason,
                lblCloseReport, txtCloseReport, lblTotalLeave, txtTotalLeave,
                lblStatus, cmbStatus, lblAvailability, cmbAvailability, lblPPD, cmbPPD,
                lstBottom
            });

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is Button)
                    ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            lstBottom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            Controls.Add(panel);
            Resize += (s, e) =>
            {
                lstBottom.Width = panel.ClientSize.Width - 20;
                lstBottom.Height = panel.ClientSize.Height - lstBottom.Top - 10;
            };
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
