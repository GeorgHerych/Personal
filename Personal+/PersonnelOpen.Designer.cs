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
        private System.Windows.Forms.Label labelPersonalNumber;
        private System.Windows.Forms.TextBox txtPersonalNumber;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxPersonnel;

        private void InitializeComponent()
        {
            this.labelPersonalNumber = new System.Windows.Forms.Label();
            this.txtPersonalNumber = new System.Windows.Forms.TextBox();
            this.labelRank = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxPersonnel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelPersonalNumber
            // 
            this.labelPersonalNumber.AutoSize = true;
            this.labelPersonalNumber.Location = new System.Drawing.Point(12, 15);
            this.labelPersonalNumber.Name = "labelPersonalNumber";
            this.labelPersonalNumber.Size = new System.Drawing.Size(92, 13);
            this.labelPersonalNumber.TabIndex = 0;
            this.labelPersonalNumber.Text = "Особовий номер:";
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.Location = new System.Drawing.Point(110, 12);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalNumber.TabIndex = 1;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(220, 15);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(50, 13);
            this.labelRank.TabIndex = 2;
            this.labelRank.Text = "Звання:";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(276, 12);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(100, 20);
            this.txtRank.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(386, 15);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "У наявності",
            "Вибув"});
            this.cmbStatus.Location = new System.Drawing.Point(437, 12);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(564, 15);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(35, 13);
            this.labelFullName.TabIndex = 6;
            this.labelFullName.Text = "П.І.П:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(605, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(150, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(761, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Знайти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(842, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Додати +";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxPersonnel
            // 
            this.listBoxPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPersonnel.FormattingEnabled = true;
            this.listBoxPersonnel.ItemHeight = 15;
            this.listBoxPersonnel.Location = new System.Drawing.Point(15, 46);
            this.listBoxPersonnel.Name = "listBoxPersonnel";
            this.listBoxPersonnel.Size = new System.Drawing.Size(902, 394);
            this.listBoxPersonnel.TabIndex = 10;
            // 
            // PersonnelOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.listBoxPersonnel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.txtPersonalNumber);
            this.Controls.Add(this.labelPersonalNumber);
            this.Name = "PersonnelOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особовий склад";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}