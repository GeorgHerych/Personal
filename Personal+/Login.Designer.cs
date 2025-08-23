namespace Personal_
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Text_Login = new System.Windows.Forms.TextBox();
            this.Text_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(152, 163);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 25);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(145, 144);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.RememberMe_CheckedChanged);
            // 
            // Text_Login
            // 
            this.Text_Login.Location = new System.Drawing.Point(110, 68);
            this.Text_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text_Login.Name = "Text_Login";
            this.Text_Login.Size = new System.Drawing.Size(153, 20);
            this.Text_Login.TabIndex = 3;
            // 
            // Text_Pass
            // 
            this.Text_Pass.Location = new System.Drawing.Point(109, 123);
            this.Text_Pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text_Pass.Name = "Text_Pass";
            this.Text_Pass.Size = new System.Drawing.Size(154, 20);
            this.Text_Pass.TabIndex = 4;
            this.Text_Pass.UseSystemPasswordChar = true;
            // 
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(165, 108);
            this.Pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(53, 13);
            this.Pass.TabIndex = 6;
            this.Pass.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 237);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_Pass);
            this.Controls.Add(this.Text_Login);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Text_Login;
        private System.Windows.Forms.TextBox Text_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pass;
    }
}