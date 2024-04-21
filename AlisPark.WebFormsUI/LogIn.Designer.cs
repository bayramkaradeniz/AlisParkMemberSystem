namespace AlisPark.WebFormsUI
{
    partial class LogIn
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
            this.gbxLogIn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsernameLogIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPasswordLogIn = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogIn
            // 
            this.gbxLogIn.Controls.Add(this.btnLogin);
            this.gbxLogIn.Controls.Add(this.tbxPasswordLogIn);
            this.gbxLogIn.Controls.Add(this.label2);
            this.gbxLogIn.Controls.Add(this.tbxUsernameLogIn);
            this.gbxLogIn.Controls.Add(this.label1);
            this.gbxLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLogIn.Location = new System.Drawing.Point(0, 0);
            this.gbxLogIn.Name = "gbxLogIn";
            this.gbxLogIn.Size = new System.Drawing.Size(605, 206);
            this.gbxLogIn.TabIndex = 0;
            this.gbxLogIn.TabStop = false;
            this.gbxLogIn.Text = "Giriş Yap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // tbxUsernameLogIn
            // 
            this.tbxUsernameLogIn.Location = new System.Drawing.Point(159, 39);
            this.tbxUsernameLogIn.Name = "tbxUsernameLogIn";
            this.tbxUsernameLogIn.Size = new System.Drawing.Size(219, 22);
            this.tbxUsernameLogIn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola :";
            // 
            // tbxPasswordLogIn
            // 
            this.tbxPasswordLogIn.Location = new System.Drawing.Point(159, 82);
            this.tbxPasswordLogIn.Name = "tbxPasswordLogIn";
            this.tbxPasswordLogIn.Size = new System.Drawing.Size(219, 22);
            this.tbxPasswordLogIn.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(277, 138);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 206);
            this.Controls.Add(this.gbxLogIn);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.gbxLogIn.ResumeLayout(false);
            this.gbxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPasswordLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsernameLogIn;
        private System.Windows.Forms.Label label1;
    }
}