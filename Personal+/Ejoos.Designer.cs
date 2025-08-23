namespace Personal_
{
    partial class Ejoos
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
            this.lblBchs = new System.Windows.Forms.Label();
            this.cmbBchs = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateTable = new System.Windows.Forms.Button();
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.groupBoxRecalc = new System.Windows.Forms.GroupBox();
            this.lblSelectUnit = new System.Windows.Forms.Label();
            this.cmbSelectUnit = new System.Windows.Forms.ComboBox();
            this.btnRecalc = new System.Windows.Forms.Button();
            this.btnGenerateEjoos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBoxTable.SuspendLayout();
            this.groupBoxRecalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBchs
            // 
            this.lblBchs.AutoSize = true;
            this.lblBchs.Location = new System.Drawing.Point(16, 28);
            this.lblBchs.Name = "lblBchs";
            this.lblBchs.Size = new System.Drawing.Size(28, 13);
            this.lblBchs.TabIndex = 0;
            this.lblBchs.Text = "БЧС";
            // 
            // cmbBchs
            // 
            this.cmbBchs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBchs.FormattingEnabled = true;
            this.cmbBchs.Location = new System.Drawing.Point(108, 25);
            this.cmbBchs.Name = "cmbBchs";
            this.cmbBchs.Size = new System.Drawing.Size(121, 21);
            this.cmbBchs.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(16, 55);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Місяць";
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(108, 53);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(121, 20);
            this.numMonth.TabIndex = 3;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 81);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(21, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Рік";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(108, 79);
            this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(121, 20);
            this.numYear.TabIndex = 5;
            this.numYear.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // btnGenerateTable
            // 
            this.btnGenerateTable.Location = new System.Drawing.Point(19, 109);
            this.btnGenerateTable.Name = "btnGenerateTable";
            this.btnGenerateTable.Size = new System.Drawing.Size(210, 23);
            this.btnGenerateTable.TabIndex = 6;
            this.btnGenerateTable.Text = "Сформувати табель";
            this.btnGenerateTable.UseVisualStyleBackColor = true;
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.lblBchs);
            this.groupBoxTable.Controls.Add(this.btnGenerateTable);
            this.groupBoxTable.Controls.Add(this.cmbBchs);
            this.groupBoxTable.Controls.Add(this.lblMonth);
            this.groupBoxTable.Controls.Add(this.numYear);
            this.groupBoxTable.Controls.Add(this.numMonth);
            this.groupBoxTable.Controls.Add(this.lblYear);
            this.groupBoxTable.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(248, 150);
            this.groupBoxTable.TabIndex = 7;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Дані для табелю";
            // 
            // groupBoxRecalc
            // 
            this.groupBoxRecalc.Controls.Add(this.lblSelectUnit);
            this.groupBoxRecalc.Controls.Add(this.cmbSelectUnit);
            this.groupBoxRecalc.Controls.Add(this.btnRecalc);
            this.groupBoxRecalc.Location = new System.Drawing.Point(12, 168);
            this.groupBoxRecalc.Name = "groupBoxRecalc";
            this.groupBoxRecalc.Size = new System.Drawing.Size(248, 120);
            this.groupBoxRecalc.TabIndex = 8;
            this.groupBoxRecalc.TabStop = false;
            this.groupBoxRecalc.Text = "Перерахувати дані";
            // 
            // lblSelectUnit
            // 
            this.lblSelectUnit.AutoSize = true;
            this.lblSelectUnit.Location = new System.Drawing.Point(6, 29);
            this.lblSelectUnit.Name = "lblSelectUnit";
            this.lblSelectUnit.Size = new System.Drawing.Size(80, 13);
            this.lblSelectUnit.TabIndex = 0;
            this.lblSelectUnit.Text = "Вибрати ЦД";
            // 
            // cmbSelectUnit
            // 
            this.cmbSelectUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectUnit.FormattingEnabled = true;
            this.cmbSelectUnit.Location = new System.Drawing.Point(92, 26);
            this.cmbSelectUnit.Name = "cmbSelectUnit";
            this.cmbSelectUnit.Size = new System.Drawing.Size(143, 21);
            this.cmbSelectUnit.TabIndex = 1;
            // 
            // btnRecalc
            // 
            this.btnRecalc.Location = new System.Drawing.Point(9, 64);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(226, 23);
            this.btnRecalc.TabIndex = 2;
            this.btnRecalc.Text = "Перерахувати";
            this.btnRecalc.UseVisualStyleBackColor = true;
            // 
            // btnGenerateEjoos
            // 
            this.btnGenerateEjoos.Location = new System.Drawing.Point(21, 294);
            this.btnGenerateEjoos.Name = "btnGenerateEjoos";
            this.btnGenerateEjoos.Size = new System.Drawing.Size(237, 23);
            this.btnGenerateEjoos.TabIndex = 9;
            this.btnGenerateEjoos.Text = "Сформувати ЕЖООС";
            this.btnGenerateEjoos.UseVisualStyleBackColor = true;
            // 
            // Ejoos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 329);
            this.Controls.Add(this.btnGenerateEjoos);
            this.Controls.Add(this.groupBoxRecalc);
            this.Controls.Add(this.groupBoxTable);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметри ЕЖООС";
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBoxTable.ResumeLayout(false);
            this.groupBoxTable.PerformLayout();
            this.groupBoxRecalc.ResumeLayout(false);
            this.groupBoxRecalc.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblBchs;
        private System.Windows.Forms.ComboBox cmbBchs;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Button btnGenerateTable;
        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.GroupBox groupBoxRecalc;
        private System.Windows.Forms.Label lblSelectUnit;
        private System.Windows.Forms.ComboBox cmbSelectUnit;
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.Button btnGenerateEjoos;
    }
}