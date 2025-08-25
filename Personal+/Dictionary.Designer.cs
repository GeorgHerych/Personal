namespace Personal_
{
    partial class Dictionary
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuickSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPositionName = new System.Windows.Forms.Button();
            this.btnSubdivisionName = new System.Windows.Forms.Button();
            this.btnTariffGrade = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Штатний довідник";
            // 
            // lblQuickSearch
            // 
            this.lblQuickSearch.AutoSize = true;
            this.lblQuickSearch.Location = new System.Drawing.Point(12, 35);
            this.lblQuickSearch.Name = "lblQuickSearch";
            this.lblQuickSearch.Size = new System.Drawing.Size(83, 13);
            this.lblQuickSearch.TabIndex = 1;
            this.lblQuickSearch.Text = "Швидкий пошук";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnPositionName
            // 
            this.btnPositionName.Location = new System.Drawing.Point(307, 30);
            this.btnPositionName.Name = "btnPositionName";
            this.btnPositionName.Size = new System.Drawing.Size(100, 23);
            this.btnPositionName.TabIndex = 3;
            this.btnPositionName.Text = "назва посади";
            this.btnPositionName.UseVisualStyleBackColor = true;
            // 
            // btnSubdivisionName
            // 
            this.btnSubdivisionName.Location = new System.Drawing.Point(413, 30);
            this.btnSubdivisionName.Name = "btnSubdivisionName";
            this.btnSubdivisionName.Size = new System.Drawing.Size(100, 23);
            this.btnSubdivisionName.TabIndex = 4;
            this.btnSubdivisionName.Text = "назва підрозділу";
            this.btnSubdivisionName.UseVisualStyleBackColor = true;
            // 
            // btnTariffGrade
            // 
            this.btnTariffGrade.Location = new System.Drawing.Point(519, 30);
            this.btnTariffGrade.Name = "btnTariffGrade";
            this.btnTariffGrade.Size = new System.Drawing.Size(100, 23);
            this.btnTariffGrade.TabIndex = 5;
            this.btnTariffGrade.Text = "тарифний розряд";
            this.btnTariffGrade.UseVisualStyleBackColor = true;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(625, 30);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(100, 23);
            this.btnClearFilter.TabIndex = 6;
            this.btnClearFilter.Text = "очистити фільтр";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 59);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(776, 381);
            this.lstItems.TabIndex = 7;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnTariffGrade);
            this.Controls.Add(this.btnSubdivisionName);
            this.Controls.Add(this.btnPositionName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblQuickSearch);
            this.Controls.Add(this.lblTitle);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuickSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPositionName;
        private System.Windows.Forms.Button btnSubdivisionName;
        private System.Windows.Forms.Button btnTariffGrade;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ListBox lstItems;
    }
}
