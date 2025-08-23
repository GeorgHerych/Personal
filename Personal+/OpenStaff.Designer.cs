namespace Personal_
{
    partial class OpenStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReferenceNumber = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.chkForming = new System.Windows.Forms.CheckBox();
            this.chkVacant = new System.Windows.Forms.CheckBox();
            this.labelDivision = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.labelAssociation = new System.Windows.Forms.Label();
            this.cmbAssociation = new System.Windows.Forms.ComboBox();
            this.labelManagement = new System.Windows.Forms.Label();
            this.cmbManagement = new System.Windows.Forms.ComboBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReferenceNumber
            //
            this.labelReferenceNumber.AutoSize = true;
            this.labelReferenceNumber.Location = new System.Drawing.Point(12, 15);
            this.labelReferenceNumber.Name = "labelReferenceNumber";
            this.labelReferenceNumber.Size = new System.Drawing.Size(103, 13);
            this.labelReferenceNumber.TabIndex = 0;
            this.labelReferenceNumber.Text = "Довідковий номер:";
            //
            // txtReferenceNumber
            //
            this.txtReferenceNumber.Location = new System.Drawing.Point(121, 12);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(80, 20);
            this.txtReferenceNumber.TabIndex = 1;
            //
            // labelStatus
            //
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(207, 15);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Статус:";
            //
            // chkCompleted
            //
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(260, 14);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(105, 17);
            this.chkCompleted.TabIndex = 3;
            this.chkCompleted.Text = "Укомплектовано";
            this.chkCompleted.UseVisualStyleBackColor = true;
            //
            // chkForming
            //
            this.chkForming.AutoSize = true;
            this.chkForming.Location = new System.Drawing.Point(371, 14);
            this.chkForming.Name = "chkForming";
            this.chkForming.Size = new System.Drawing.Size(82, 17);
            this.chkForming.TabIndex = 4;
            this.chkForming.Text = "Формується";
            this.chkForming.UseVisualStyleBackColor = true;
            //
            // chkVacant
            //
            this.chkVacant.AutoSize = true;
            this.chkVacant.Location = new System.Drawing.Point(459, 14);
            this.chkVacant.Name = "chkVacant";
            this.chkVacant.Size = new System.Drawing.Size(74, 17);
            this.chkVacant.TabIndex = 5;
            this.chkVacant.Text = "Вакантно";
            this.chkVacant.UseVisualStyleBackColor = true;
            //
            // labelDivision
            //
            this.labelDivision.AutoSize = true;
            this.labelDivision.Location = new System.Drawing.Point(12, 45);
            this.labelDivision.Name = "labelDivision";
            this.labelDivision.Size = new System.Drawing.Size(58, 13);
            this.labelDivision.TabIndex = 6;
            this.labelDivision.Text = "Дивізіон:";
            //
            // cmbDivision
            //
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(76, 42);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbDivision.TabIndex = 7;
            //
            // labelAssociation
            //
            this.labelAssociation.AutoSize = true;
            this.labelAssociation.Location = new System.Drawing.Point(203, 45);
            this.labelAssociation.Name = "labelAssociation";
            this.labelAssociation.Size = new System.Drawing.Size(74, 13);
            this.labelAssociation.TabIndex = 8;
            this.labelAssociation.Text = "Об'єднання:";
            //
            // cmbAssociation
            //
            this.cmbAssociation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssociation.FormattingEnabled = true;
            this.cmbAssociation.Location = new System.Drawing.Point(283, 42);
            this.cmbAssociation.Name = "cmbAssociation";
            this.cmbAssociation.Size = new System.Drawing.Size(121, 21);
            this.cmbAssociation.TabIndex = 9;
            //
            // labelManagement
            //
            this.labelManagement.AutoSize = true;
            this.labelManagement.Location = new System.Drawing.Point(410, 45);
            this.labelManagement.Name = "labelManagement";
            this.labelManagement.Size = new System.Drawing.Size(72, 13);
            this.labelManagement.TabIndex = 10;
            this.labelManagement.Text = "Управління:";
            //
            // cmbManagement
            //
            this.cmbManagement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManagement.FormattingEnabled = true;
            this.cmbManagement.Location = new System.Drawing.Point(488, 42);
            this.cmbManagement.Name = "cmbManagement";
            this.cmbManagement.Size = new System.Drawing.Size(121, 21);
            this.cmbManagement.TabIndex = 11;
            //
            // labelUnit
            //
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(615, 45);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(59, 13);
            this.labelUnit.TabIndex = 12;
            this.labelUnit.Text = "Підрозділ:";
            //
            // cmbUnit
            //
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(680, 42);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 13;
            //
            // btnPrint
            //
            this.btnPrint.Location = new System.Drawing.Point(807, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Друк";
            this.btnPrint.UseVisualStyleBackColor = true;
            //
            // labelSearch
            //
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(888, 45);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(102, 13);
            this.labelSearch.TabIndex = 15;
            this.labelSearch.Text = "Пошуковий запит:";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(996, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 16;
            //
            // dataGridViewStaff
            //
            this.dataGridViewStaff.AllowUserToAddRows = false;
            this.dataGridViewStaff.AllowUserToDeleteRows = false;
            this.dataGridViewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.PositionColumn,
            this.RankColumn,
            this.NameColumn,
            this.StatusColumn});
            this.dataGridViewStaff.Location = new System.Drawing.Point(15, 80);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.ReadOnly = true;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1181, 469);
            this.dataGridViewStaff.TabIndex = 17;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "№";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Width = 40;
            // 
            // PositionColumn
            // 
            this.PositionColumn.HeaderText = "Посада";
            this.PositionColumn.Name = "PositionColumn";
            this.PositionColumn.ReadOnly = true;
            this.PositionColumn.Width = 200;
            // 
            // RankColumn
            // 
            this.RankColumn.HeaderText = "Звання";
            this.RankColumn.Name = "RankColumn";
            this.RankColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "П.І.Б.";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 250;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 80;
            // 
            // OpenStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1210, 561);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.cmbManagement);
            this.Controls.Add(this.labelManagement);
            this.Controls.Add(this.cmbAssociation);
            this.Controls.Add(this.labelAssociation);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.labelDivision);
            this.Controls.Add(this.chkVacant);
            this.Controls.Add(this.chkForming);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.labelReferenceNumber);
            this.Name = "OpenStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Штат";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelReferenceNumber;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.CheckBox chkForming;
        private System.Windows.Forms.CheckBox chkVacant;
        private System.Windows.Forms.Label labelDivision;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label labelAssociation;
        private System.Windows.Forms.ComboBox cmbAssociation;
        private System.Windows.Forms.Label labelManagement;
        private System.Windows.Forms.ComboBox cmbManagement;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}

