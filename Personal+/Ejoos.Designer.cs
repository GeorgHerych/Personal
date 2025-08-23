namespace Personal_
{
    partial class Ejoos
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
            this.labelDataHeader = new System.Windows.Forms.Label();
            this.labelBCS = new System.Windows.Forms.Label();
            this.cmbBCS = new System.Windows.Forms.ComboBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnGenerateTable = new System.Windows.Forms.Button();
            this.labelRecalcHeader = new System.Windows.Forms.Label();
            this.labelChooseUnit = new System.Windows.Forms.Label();
            this.cmbChooseUnit = new System.Windows.Forms.ComboBox();
            this.btnRecalculate = new System.Windows.Forms.Button();
            this.btnGenerateEjoos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDataHeader
            // 
            this.labelDataHeader.AutoSize = true;
            this.labelDataHeader.Location = new System.Drawing.Point(12, 9);
            this.labelDataHeader.Name = "labelDataHeader";
            this.labelDataHeader.Size = new System.Drawing.Size(85, 13);
            this.labelDataHeader.TabIndex = 0;
            this.labelDataHeader.Text = "Дані для табелю:";
            // 
            // labelBCS
            // 
            this.labelBCS.AutoSize = true;
            this.labelBCS.Location = new System.Drawing.Point(12, 35);
            this.labelBCS.Name = "labelBCS";
            this.labelBCS.Size = new System.Drawing.Size(33, 13);
            this.labelBCS.TabIndex = 1;
            this.labelBCS.Text = "БЧС:";
            // 
            // cmbBCS
            // 
            this.cmbBCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBCS.FormattingEnabled = true;
            this.cmbBCS.Location = new System.Drawing.Point(120, 32);
            this.cmbBCS.Name = "cmbBCS";
            this.cmbBCS.Size = new System.Drawing.Size(180, 21);
            this.cmbBCS.TabIndex = 2;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(12, 62);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(43, 13);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "Місяць:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(120, 59);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(180, 20);
            this.txtMonth.TabIndex = 4;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 88);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(27, 13);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Рік:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(120, 85);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(180, 20);
            this.txtYear.TabIndex = 6;
            // 
            // btnGenerateTable
            // 
            this.btnGenerateTable.Location = new System.Drawing.Point(120, 111);
            this.btnGenerateTable.Name = "btnGenerateTable";
            this.btnGenerateTable.Size = new System.Drawing.Size(180, 23);
            this.btnGenerateTable.TabIndex = 7;
            this.btnGenerateTable.Text = "Сформувати табель";
            this.btnGenerateTable.UseVisualStyleBackColor = true;
            // 
            // labelRecalcHeader
            // 
            this.labelRecalcHeader.AutoSize = true;
            this.labelRecalcHeader.Location = new System.Drawing.Point(12, 152);
            this.labelRecalcHeader.Name = "labelRecalcHeader";
            this.labelRecalcHeader.Size = new System.Drawing.Size(150, 13);
            this.labelRecalcHeader.TabIndex = 8;
            this.labelRecalcHeader.Text = "Перерахувати дані для ЕЖООС:";
            // 
            // labelChooseUnit
            // 
            this.labelChooseUnit.AutoSize = true;
            this.labelChooseUnit.Location = new System.Drawing.Point(12, 178);
            this.labelChooseUnit.Name = "labelChooseUnit";
            this.labelChooseUnit.Size = new System.Drawing.Size(146, 13);
            this.labelChooseUnit.TabIndex = 9;
            this.labelChooseUnit.Text = "Вибрати ЦД для перерахунку:";
            // 
            // cmbChooseUnit
            // 
            this.cmbChooseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseUnit.FormattingEnabled = true;
            this.cmbChooseUnit.Location = new System.Drawing.Point(165, 175);
            this.cmbChooseUnit.Name = "cmbChooseUnit";
            this.cmbChooseUnit.Size = new System.Drawing.Size(200, 21);
            this.cmbChooseUnit.TabIndex = 10;
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.Location = new System.Drawing.Point(165, 202);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(200, 23);
            this.btnRecalculate.TabIndex = 11;
            this.btnRecalculate.Text = "Перерахувати";
            this.btnRecalculate.UseVisualStyleBackColor = true;
            // 
            // btnGenerateEjoos
            // 
            this.btnGenerateEjoos.Location = new System.Drawing.Point(165, 231);
            this.btnGenerateEjoos.Name = "btnGenerateEjoos";
            this.btnGenerateEjoos.Size = new System.Drawing.Size(200, 23);
            this.btnGenerateEjoos.TabIndex = 12;
            this.btnGenerateEjoos.Text = "Сформувати ЕЖООС";
            this.btnGenerateEjoos.UseVisualStyleBackColor = true;
            // 
            // Ejoos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.btnGenerateEjoos);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.cmbChooseUnit);
            this.Controls.Add(this.labelChooseUnit);
            this.Controls.Add(this.labelRecalcHeader);
            this.Controls.Add(this.btnGenerateTable);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.cmbBCS);
            this.Controls.Add(this.labelBCS);
            this.Controls.Add(this.labelDataHeader);
            this.Name = "Ejoos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметри ЕЖООС";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDataHeader;
        private System.Windows.Forms.Label labelBCS;
        private System.Windows.Forms.ComboBox cmbBCS;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnGenerateTable;
        private System.Windows.Forms.Label labelRecalcHeader;
        private System.Windows.Forms.Label labelChooseUnit;
        private System.Windows.Forms.ComboBox cmbChooseUnit;
        private System.Windows.Forms.Button btnRecalculate;
        private System.Windows.Forms.Button btnGenerateEjoos;
    }
}
