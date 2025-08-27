namespace Personal_
{
    partial class KtvpForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.labelSubdivision = new System.Windows.Forms.Label();
            this.cmbSubdivision = new System.Windows.Forms.ComboBox();
            this.labelAsOf = new System.Windows.Forms.Label();
            this.dtpAsOf = new System.Windows.Forms.DateTimePicker();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.labelGroupSheet = new System.Windows.Forms.Label();
            this.txtGroupSheet = new System.Windows.Forms.TextBox();
            this.labelDocument = new System.Windows.Forms.Label();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.labelDeputy = new System.Windows.Forms.Label();
            this.txtDeputy = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(12, 15);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(99, 13);
            this.labelUnit.TabIndex = 0;
            this.labelUnit.Text = "Військова частина";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(117, 12);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(200, 21);
            this.cmbUnit.TabIndex = 1;
            // 
            // labelSubdivision
            // 
            this.labelSubdivision.AutoSize = true;
            this.labelSubdivision.Location = new System.Drawing.Point(12, 42);
            this.labelSubdivision.Name = "labelSubdivision";
            this.labelSubdivision.Size = new System.Drawing.Size(63, 13);
            this.labelSubdivision.TabIndex = 2;
            this.labelSubdivision.Text = "Підрозділ";
            // 
            // cmbSubdivision
            // 
            this.cmbSubdivision.FormattingEnabled = true;
            this.cmbSubdivision.Location = new System.Drawing.Point(117, 39);
            this.cmbSubdivision.Name = "cmbSubdivision";
            this.cmbSubdivision.Size = new System.Drawing.Size(200, 21);
            this.cmbSubdivision.TabIndex = 3;
            // 
            // labelAsOf
            // 
            this.labelAsOf.AutoSize = true;
            this.labelAsOf.Location = new System.Drawing.Point(12, 69);
            this.labelAsOf.Name = "labelAsOf";
            this.labelAsOf.Size = new System.Drawing.Size(63, 13);
            this.labelAsOf.TabIndex = 4;
            this.labelAsOf.Text = "Станом на";
            // 
            // dtpAsOf
            // 
            this.dtpAsOf.Location = new System.Drawing.Point(117, 66);
            this.dtpAsOf.Name = "dtpAsOf";
            this.dtpAsOf.Size = new System.Drawing.Size(200, 20);
            this.dtpAsOf.TabIndex = 5;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(12, 96);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(44, 13);
            this.labelPeriod.TabIndex = 6;
            this.labelPeriod.Text = "Період";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(117, 92);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(95, 20);
            this.dtpFrom.TabIndex = 7;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(222, 92);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(95, 20);
            this.dtpTo.TabIndex = 8;
            // 
            // labelGroupSheet
            // 
            this.labelGroupSheet.AutoSize = true;
            this.labelGroupSheet.Location = new System.Drawing.Point(12, 122);
            this.labelGroupSheet.Name = "labelGroupSheet";
            this.labelGroupSheet.Size = new System.Drawing.Size(116, 13);
            this.labelGroupSheet.TabIndex = 9;
            this.labelGroupSheet.Text = "До групової відомості";
            // 
            // txtGroupSheet
            // 
            this.txtGroupSheet.Location = new System.Drawing.Point(134, 119);
            this.txtGroupSheet.Name = "txtGroupSheet";
            this.txtGroupSheet.Size = new System.Drawing.Size(183, 20);
            this.txtGroupSheet.TabIndex = 10;
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Location = new System.Drawing.Point(12, 148);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(59, 13);
            this.labelDocument.TabIndex = 11;
            this.labelDocument.Text = "Документ";
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(117, 145);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(200, 20);
            this.txtDocument.TabIndex = 12;
            // 
            // labelDeputy
            // 
            this.labelDeputy.AutoSize = true;
            this.labelDeputy.Location = new System.Drawing.Point(12, 174);
            this.labelDeputy.Name = "labelDeputy";
            this.labelDeputy.Size = new System.Drawing.Size(66, 13);
            this.labelDeputy.TabIndex = 13;
            this.labelDeputy.Text = "Заступник";
            // 
            // txtDeputy
            // 
            this.txtDeputy.Location = new System.Drawing.Point(117, 171);
            this.txtDeputy.Name = "txtDeputy";
            this.txtDeputy.Size = new System.Drawing.Size(200, 20);
            this.txtDeputy.TabIndex = 14;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(341, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Створити";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(341, 41);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 23);
            this.btnDone.TabIndex = 16;
            this.btnDone.Text = "Виконані";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(341, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.AllowUserToAddRows = false;
            this.dataGridMembers.AllowUserToDeleteRows = false;
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrder,
            this.colPosition,
            this.colRank,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colMovement});
            this.dataGridMembers.Location = new System.Drawing.Point(15, 210);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.ReadOnly = true;
            this.dataGridMembers.Size = new System.Drawing.Size(650, 250);
            this.dataGridMembers.TabIndex = 19;
            // 
            // colOrder
            // 
            this.colOrder.HeaderText = "№";
            this.colOrder.Name = "colOrder";
            this.colOrder.ReadOnly = true;
            this.colOrder.Width = 30;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Посада";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Звання";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Прізвище";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "Ім'я";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colMiddleName
            // 
            this.colMiddleName.HeaderText = "По батькові";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            // 
            // colMovement
            // 
            this.colMovement.HeaderText = "Рух";
            this.colMovement.Name = "colMovement";
            this.colMovement.ReadOnly = true;
            // 
            // KtvpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.Controls.Add(this.dataGridMembers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtDeputy);
            this.Controls.Add(this.labelDeputy);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.txtGroupSheet);
            this.Controls.Add(this.labelGroupSheet);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.dtpAsOf);
            this.Controls.Add(this.labelAsOf);
            this.Controls.Add(this.cmbSubdivision);
            this.Controls.Add(this.labelSubdivision);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.labelUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KtvpForm";
            this.Text = "КТВП";
            this.Load += new System.EventHandler(this.KtvpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label labelSubdivision;
        private System.Windows.Forms.ComboBox cmbSubdivision;
        private System.Windows.Forms.Label labelAsOf;
        private System.Windows.Forms.DateTimePicker dtpAsOf;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label labelGroupSheet;
        private System.Windows.Forms.TextBox txtGroupSheet;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Label labelDeputy;
        private System.Windows.Forms.TextBox txtDeputy;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovement;
    }
}

