namespace Personal_
{
    partial class RaportOpen
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
        private System.Windows.Forms.Label labelQuickSearch;
        private System.Windows.Forms.TextBox txtQuickSearch;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnInternalDescription;
        private System.Windows.Forms.ListBox listBoxRaports;

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelQuickSearch = new System.Windows.Forms.Label();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnInternalDescription = new System.Windows.Forms.Button();
            this.listBoxRaports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Рапорти";
            // 
            // labelQuickSearch
            // 
            this.labelQuickSearch.AutoSize = true;
            this.labelQuickSearch.Location = new System.Drawing.Point(12, 46);
            this.labelQuickSearch.Name = "labelQuickSearch";
            this.labelQuickSearch.Size = new System.Drawing.Size(84, 13);
            this.labelQuickSearch.TabIndex = 1;
            this.labelQuickSearch.Text = "Швидкий пошук";
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(102, 43);
            this.txtQuickSearch.Name = "txtQuickSearch";
            this.txtQuickSearch.Size = new System.Drawing.Size(150, 20);
            this.txtQuickSearch.TabIndex = 2;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(258, 41);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(110, 23);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Text = "Скинути фільтр";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // btnInternalDescription
            // 
            this.btnInternalDescription.Location = new System.Drawing.Point(374, 41);
            this.btnInternalDescription.Name = "btnInternalDescription";
            this.btnInternalDescription.Size = new System.Drawing.Size(120, 23);
            this.btnInternalDescription.TabIndex = 4;
            this.btnInternalDescription.Text = "Внутрішній опис";
            this.btnInternalDescription.UseVisualStyleBackColor = true;
            // 
            // listBoxRaports
            // 
            this.listBoxRaports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                        | System.Windows.Forms.AnchorStyles.Left) 
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRaports.FormattingEnabled = true;
            this.listBoxRaports.Location = new System.Drawing.Point(15, 80);
            this.listBoxRaports.Name = "listBoxRaports";
            this.listBoxRaports.Size = new System.Drawing.Size(770, 355);
            this.listBoxRaports.TabIndex = 5;
            // 
            // RaportOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxRaports);
            this.Controls.Add(this.btnInternalDescription);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.txtQuickSearch);
            this.Controls.Add(this.labelQuickSearch);
            this.Controls.Add(this.labelTitle);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рапорти";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
