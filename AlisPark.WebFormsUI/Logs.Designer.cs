namespace AlisPark.WebFormsUI
{
    partial class Logs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.gbxSearchByMemberName = new System.Windows.Forms.GroupBox();
            this.tbxMemberNameSearchLog = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnRemoveLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.gbxSearchByMemberName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(13, 101);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.Size = new System.Drawing.Size(1055, 183);
            this.dgvLogs.TabIndex = 0;
            // 
            // gbxSearchByMemberName
            // 
            this.gbxSearchByMemberName.Controls.Add(this.tbxMemberNameSearchLog);
            this.gbxSearchByMemberName.Controls.Add(this.lblMemberName);
            this.gbxSearchByMemberName.Location = new System.Drawing.Point(13, 13);
            this.gbxSearchByMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchByMemberName.Name = "gbxSearchByMemberName";
            this.gbxSearchByMemberName.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.gbxSearchByMemberName.Size = new System.Drawing.Size(533, 74);
            this.gbxSearchByMemberName.TabIndex = 3;
            this.gbxSearchByMemberName.TabStop = false;
            this.gbxSearchByMemberName.Text = "Üye Adına Göre Arama";
            // 
            // tbxMemberNameSearchLog
            // 
            this.tbxMemberNameSearchLog.Location = new System.Drawing.Point(173, 37);
            this.tbxMemberNameSearchLog.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMemberNameSearchLog.Name = "tbxMemberNameSearchLog";
            this.tbxMemberNameSearchLog.Size = new System.Drawing.Size(265, 22);
            this.tbxMemberNameSearchLog.TabIndex = 1;
            this.tbxMemberNameSearchLog.TextChanged += new System.EventHandler(this.tbxMemberNameSearchLog_TextChanged);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(20, 37);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(61, 16);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Üye Adı :";
            // 
            // btnRemoveLogs
            // 
            this.btnRemoveLogs.Location = new System.Drawing.Point(981, 12);
            this.btnRemoveLogs.Name = "btnRemoveLogs";
            this.btnRemoveLogs.Size = new System.Drawing.Size(75, 40);
            this.btnRemoveLogs.TabIndex = 4;
            this.btnRemoveLogs.Text = "Kayıt Sil";
            this.btnRemoveLogs.UseVisualStyleBackColor = true;
            this.btnRemoveLogs.Click += new System.EventHandler(this.btnRemoveLogs_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.btnRemoveLogs);
            this.Controls.Add(this.gbxSearchByMemberName);
            this.Controls.Add(this.dgvLogs);
            this.Name = "Logs";
            this.Text = "Kayıt İşlemleri";
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.gbxSearchByMemberName.ResumeLayout(false);
            this.gbxSearchByMemberName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.GroupBox gbxSearchByMemberName;
        private System.Windows.Forms.TextBox tbxMemberNameSearchLog;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnRemoveLogs;
    }
}