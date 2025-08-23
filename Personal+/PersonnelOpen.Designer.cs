namespace Personal_
{
    partial class PersonnelOpen
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxCategories;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkOfficers;
        private System.Windows.Forms.CheckBox chkSergeants;
        private System.Windows.Forms.CheckBox chkSoldiers;
        private System.Windows.Forms.Label labelQuickSearch;
        private System.Windows.Forms.TextBox txtQuickSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnGroupSearch;
        private System.Windows.Forms.ListBox listBoxPersonnel;

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxCategories = new System.Windows.Forms.GroupBox();
            this.chkSoldiers = new System.Windows.Forms.CheckBox();
            this.chkSergeants = new System.Windows.Forms.CheckBox();
            this.chkOfficers = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.labelQuickSearch = new System.Windows.Forms.Label();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnGroupSearch = new System.Windows.Forms.Button();
            this.listBoxPersonnel = new System.Windows.Forms.ListBox();
            this.groupBoxCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Особовий склад";
            // 
            // groupBoxCategories
            // 
            this.groupBoxCategories.Controls.Add(this.chkSoldiers);
            this.groupBoxCategories.Controls.Add(this.chkSergeants);
            this.groupBoxCategories.Controls.Add(this.chkOfficers);
            this.groupBoxCategories.Controls.Add(this.chkAll);
            this.groupBoxCategories.Location = new System.Drawing.Point(15, 40);
            this.groupBoxCategories.Name = "groupBoxCategories";
            this.groupBoxCategories.Size = new System.Drawing.Size(280, 45);
            this.groupBoxCategories.TabIndex = 1;
            this.groupBoxCategories.TabStop = false;
            // 
            // chkSoldiers
            // 
            this.chkSoldiers.AutoSize = true;
            this.chkSoldiers.Location = new System.Drawing.Point(211, 19);
            this.chkSoldiers.Name = "chkSoldiers";
            this.chkSoldiers.Size = new System.Drawing.Size(63, 17);
            this.chkSoldiers.TabIndex = 3;
            this.chkSoldiers.Text = "Солдати";
            this.chkSoldiers.UseVisualStyleBackColor = true;
            // 
            // chkSergeants
            // 
            this.chkSergeants.AutoSize = true;
            this.chkSergeants.Location = new System.Drawing.Point(127, 19);
            this.chkSergeants.Name = "chkSergeants";
            this.chkSergeants.Size = new System.Drawing.Size(78, 17);
            this.chkSergeants.TabIndex = 2;
            this.chkSergeants.Text = "Сержанти";
            this.chkSergeants.UseVisualStyleBackColor = true;
            // 
            // chkOfficers
            // 
            this.chkOfficers.AutoSize = true;
            this.chkOfficers.Location = new System.Drawing.Point(54, 19);
            this.chkOfficers.Name = "chkOfficers";
            this.chkOfficers.Size = new System.Drawing.Size(67, 17);
            this.chkOfficers.TabIndex = 1;
            this.chkOfficers.Text = "Офіцери";
            this.chkOfficers.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 19);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(42, 17);
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "Всі";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // labelQuickSearch
            // 
            this.labelQuickSearch.AutoSize = true;
            this.labelQuickSearch.Location = new System.Drawing.Point(301, 55);
            this.labelQuickSearch.Name = "labelQuickSearch";
            this.labelQuickSearch.Size = new System.Drawing.Size(84, 13);
            this.labelQuickSearch.TabIndex = 2;
            this.labelQuickSearch.Text = "Швидкий пошук";
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(391, 52);
            this.txtQuickSearch.Name = "txtQuickSearch";
            this.txtQuickSearch.Size = new System.Drawing.Size(150, 20);
            this.txtQuickSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(547, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(628, 55);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Статус";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(679, 52);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(15, 92);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Вигрузити";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додати в/с";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(227, 92);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(110, 23);
            this.btnClearFilter.TabIndex = 9;
            this.btnClearFilter.Text = "Очистити фільтр";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // btnGroupSearch
            // 
            this.btnGroupSearch.Location = new System.Drawing.Point(343, 92);
            this.btnGroupSearch.Name = "btnGroupSearch";
            this.btnGroupSearch.Size = new System.Drawing.Size(110, 23);
            this.btnGroupSearch.TabIndex = 10;
            this.btnGroupSearch.Text = "Груповий пошук";
            this.btnGroupSearch.UseVisualStyleBackColor = true;
            // 
            // listBoxPersonnel
            // 
            this.listBoxPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPersonnel.FormattingEnabled = true;
            this.listBoxPersonnel.ItemHeight = 15;
            this.listBoxPersonnel.Location = new System.Drawing.Point(15, 131);
            this.listBoxPersonnel.Name = "listBoxPersonnel";
            this.listBoxPersonnel.Size = new System.Drawing.Size(902, 349);
            this.listBoxPersonnel.TabIndex = 11;
            // 
            // PersonnelOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 500);
            this.Controls.Add(this.listBoxPersonnel);
            this.Controls.Add(this.btnGroupSearch);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQuickSearch);
            this.Controls.Add(this.labelQuickSearch);
            this.Controls.Add(this.groupBoxCategories);
            this.Controls.Add(this.labelTitle);
            this.Name = "PersonnelOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особовий склад";
            this.groupBoxCategories.ResumeLayout(false);
            this.groupBoxCategories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
