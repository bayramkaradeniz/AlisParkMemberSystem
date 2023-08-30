namespace AlisPark.WebFormsUI
{
    partial class AlisPark
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
            this.gbxGetByCategoryName = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.gbxSearchByMemberName = new System.Windows.Forms.GroupBox();
            this.tbxMemberNameSearch = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.gbxAddMember = new System.Windows.Forms.GroupBox();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.lblBalanceAdd = new System.Windows.Forms.Label();
            this.tbxBalanceAdd = new System.Windows.Forms.TextBox();
            this.tbxMemberSurnameAdd = new System.Windows.Forms.TextBox();
            this.tbxMemberPhoneAdd = new System.Windows.Forms.TextBox();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblMemberPhoneAdd = new System.Windows.Forms.Label();
            this.lblMemberSurnameAdd = new System.Windows.Forms.Label();
            this.tbxMemberNameAdd = new System.Windows.Forms.TextBox();
            this.lblMemberNameAdd = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.lblBalanceUpdate = new System.Windows.Forms.Label();
            this.tbxBalanceUpdate = new System.Windows.Forms.TextBox();
            this.tbxMemberSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxMemberPhoneUpdate = new System.Windows.Forms.TextBox();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblMemberPhoneUpdate = new System.Windows.Forms.Label();
            this.lblMemberSurnameUpdate = new System.Windows.Forms.Label();
            this.tbxMemberNameUpdate = new System.Windows.Forms.TextBox();
            this.lblMemberNameUpdate = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Button();
            this.gbxGetByCategoryName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.gbxSearchByMemberName.SuspendLayout();
            this.gbxAddMember.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGetByCategoryName
            // 
            this.gbxGetByCategoryName.Controls.Add(this.cbxCategory);
            this.gbxGetByCategoryName.Controls.Add(this.lblCategory);
            this.gbxGetByCategoryName.Location = new System.Drawing.Point(10, 11);
            this.gbxGetByCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.gbxGetByCategoryName.Name = "gbxGetByCategoryName";
            this.gbxGetByCategoryName.Padding = new System.Windows.Forms.Padding(10);
            this.gbxGetByCategoryName.Size = new System.Drawing.Size(400, 60);
            this.gbxGetByCategoryName.TabIndex = 0;
            this.gbxGetByCategoryName.TabStop = false;
            this.gbxGetByCategoryName.Text = "Kategoriye Göre Arama";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(130, 30);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(200, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 30);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori :";
            // 
            // dgvMember
            // 
            this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMember.Location = new System.Drawing.Point(10, 151);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(800, 150);
            this.dgvMember.TabIndex = 1;
            this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
            // 
            // gbxSearchByMemberName
            // 
            this.gbxSearchByMemberName.Controls.Add(this.tbxMemberNameSearch);
            this.gbxSearchByMemberName.Controls.Add(this.lblMemberName);
            this.gbxSearchByMemberName.Location = new System.Drawing.Point(10, 74);
            this.gbxSearchByMemberName.Name = "gbxSearchByMemberName";
            this.gbxSearchByMemberName.Padding = new System.Windows.Forms.Padding(10);
            this.gbxSearchByMemberName.Size = new System.Drawing.Size(400, 60);
            this.gbxSearchByMemberName.TabIndex = 2;
            this.gbxSearchByMemberName.TabStop = false;
            this.gbxSearchByMemberName.Text = "Üye Adına Göre Arama";
            // 
            // tbxMemberNameSearch
            // 
            this.tbxMemberNameSearch.Location = new System.Drawing.Point(130, 30);
            this.tbxMemberNameSearch.Name = "tbxMemberNameSearch";
            this.tbxMemberNameSearch.Size = new System.Drawing.Size(200, 20);
            this.tbxMemberNameSearch.TabIndex = 1;
            this.tbxMemberNameSearch.TextChanged += new System.EventHandler(this.tbxMemberNameSearch_TextChanged);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(15, 30);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(50, 13);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Üye Adı :";
            // 
            // gbxAddMember
            // 
            this.gbxAddMember.Controls.Add(this.btnMemberAdd);
            this.gbxAddMember.Controls.Add(this.cbxCategoryAdd);
            this.gbxAddMember.Controls.Add(this.lblBalanceAdd);
            this.gbxAddMember.Controls.Add(this.tbxBalanceAdd);
            this.gbxAddMember.Controls.Add(this.tbxMemberSurnameAdd);
            this.gbxAddMember.Controls.Add(this.tbxMemberPhoneAdd);
            this.gbxAddMember.Controls.Add(this.lblCategoryAdd);
            this.gbxAddMember.Controls.Add(this.lblMemberPhoneAdd);
            this.gbxAddMember.Controls.Add(this.lblMemberSurnameAdd);
            this.gbxAddMember.Controls.Add(this.tbxMemberNameAdd);
            this.gbxAddMember.Controls.Add(this.lblMemberNameAdd);
            this.gbxAddMember.Location = new System.Drawing.Point(10, 289);
            this.gbxAddMember.Name = "gbxAddMember";
            this.gbxAddMember.Size = new System.Drawing.Size(800, 172);
            this.gbxAddMember.TabIndex = 3;
            this.gbxAddMember.TabStop = false;
            this.gbxAddMember.Text = "Üye Ekle";
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Location = new System.Drawing.Point(600, 120);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(84, 23);
            this.btnMemberAdd.TabIndex = 10;
            this.btnMemberAdd.Text = "Ekle";
            this.btnMemberAdd.UseVisualStyleBackColor = true;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(500, 40);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(186, 21);
            this.cbxCategoryAdd.TabIndex = 9;
            // 
            // lblBalanceAdd
            // 
            this.lblBalanceAdd.AutoSize = true;
            this.lblBalanceAdd.Location = new System.Drawing.Point(430, 80);
            this.lblBalanceAdd.Name = "lblBalanceAdd";
            this.lblBalanceAdd.Size = new System.Drawing.Size(45, 13);
            this.lblBalanceAdd.TabIndex = 8;
            this.lblBalanceAdd.Text = "Bakiye :";
            // 
            // tbxBalanceAdd
            // 
            this.tbxBalanceAdd.Location = new System.Drawing.Point(500, 80);
            this.tbxBalanceAdd.Name = "tbxBalanceAdd";
            this.tbxBalanceAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxBalanceAdd.TabIndex = 7;
            // 
            // tbxMemberSurnameAdd
            // 
            this.tbxMemberSurnameAdd.Location = new System.Drawing.Point(100, 80);
            this.tbxMemberSurnameAdd.Name = "tbxMemberSurnameAdd";
            this.tbxMemberSurnameAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxMemberSurnameAdd.TabIndex = 6;
            // 
            // tbxMemberPhoneAdd
            // 
            this.tbxMemberPhoneAdd.Location = new System.Drawing.Point(100, 113);
            this.tbxMemberPhoneAdd.Name = "tbxMemberPhoneAdd";
            this.tbxMemberPhoneAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxMemberPhoneAdd.TabIndex = 5;
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(430, 40);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(52, 13);
            this.lblCategoryAdd.TabIndex = 4;
            this.lblCategoryAdd.Text = "Kategori :";
            // 
            // lblMemberPhoneAdd
            // 
            this.lblMemberPhoneAdd.AutoSize = true;
            this.lblMemberPhoneAdd.Location = new System.Drawing.Point(30, 120);
            this.lblMemberPhoneAdd.Name = "lblMemberPhoneAdd";
            this.lblMemberPhoneAdd.Size = new System.Drawing.Size(49, 13);
            this.lblMemberPhoneAdd.TabIndex = 3;
            this.lblMemberPhoneAdd.Text = "Telefon :";
            // 
            // lblMemberSurnameAdd
            // 
            this.lblMemberSurnameAdd.AutoSize = true;
            this.lblMemberSurnameAdd.Location = new System.Drawing.Point(30, 80);
            this.lblMemberSurnameAdd.Name = "lblMemberSurnameAdd";
            this.lblMemberSurnameAdd.Size = new System.Drawing.Size(67, 13);
            this.lblMemberSurnameAdd.TabIndex = 2;
            this.lblMemberSurnameAdd.Text = "Üye Soyadı :";
            // 
            // tbxMemberNameAdd
            // 
            this.tbxMemberNameAdd.Location = new System.Drawing.Point(100, 40);
            this.tbxMemberNameAdd.Name = "tbxMemberNameAdd";
            this.tbxMemberNameAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxMemberNameAdd.TabIndex = 1;
            // 
            // lblMemberNameAdd
            // 
            this.lblMemberNameAdd.AutoSize = true;
            this.lblMemberNameAdd.Location = new System.Drawing.Point(30, 40);
            this.lblMemberNameAdd.Name = "lblMemberNameAdd";
            this.lblMemberNameAdd.Size = new System.Drawing.Size(50, 13);
            this.lblMemberNameAdd.TabIndex = 0;
            this.lblMemberNameAdd.Text = "Üye Adı :";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.lblBalanceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxBalanceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxMemberSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxMemberPhoneUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.lblMemberPhoneUpdate);
            this.gbxUpdate.Controls.Add(this.lblMemberSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxMemberNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblMemberNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(10, 467);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(800, 172);
            this.gbxUpdate.TabIndex = 11;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Üye Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(600, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(500, 40);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(186, 21);
            this.cbxCategoryUpdate.TabIndex = 9;
            // 
            // lblBalanceUpdate
            // 
            this.lblBalanceUpdate.AutoSize = true;
            this.lblBalanceUpdate.Location = new System.Drawing.Point(430, 80);
            this.lblBalanceUpdate.Name = "lblBalanceUpdate";
            this.lblBalanceUpdate.Size = new System.Drawing.Size(45, 13);
            this.lblBalanceUpdate.TabIndex = 8;
            this.lblBalanceUpdate.Text = "Bakiye :";
            // 
            // tbxBalanceUpdate
            // 
            this.tbxBalanceUpdate.Location = new System.Drawing.Point(500, 80);
            this.tbxBalanceUpdate.Name = "tbxBalanceUpdate";
            this.tbxBalanceUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxBalanceUpdate.TabIndex = 7;
            // 
            // tbxMemberSurnameUpdate
            // 
            this.tbxMemberSurnameUpdate.Location = new System.Drawing.Point(100, 80);
            this.tbxMemberSurnameUpdate.Name = "tbxMemberSurnameUpdate";
            this.tbxMemberSurnameUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxMemberSurnameUpdate.TabIndex = 6;
            // 
            // tbxMemberPhoneUpdate
            // 
            this.tbxMemberPhoneUpdate.Location = new System.Drawing.Point(100, 113);
            this.tbxMemberPhoneUpdate.Name = "tbxMemberPhoneUpdate";
            this.tbxMemberPhoneUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxMemberPhoneUpdate.TabIndex = 5;
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(430, 40);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(52, 13);
            this.lblCategoryUpdate.TabIndex = 4;
            this.lblCategoryUpdate.Text = "Kategori :";
            // 
            // lblMemberPhoneUpdate
            // 
            this.lblMemberPhoneUpdate.AutoSize = true;
            this.lblMemberPhoneUpdate.Location = new System.Drawing.Point(30, 120);
            this.lblMemberPhoneUpdate.Name = "lblMemberPhoneUpdate";
            this.lblMemberPhoneUpdate.Size = new System.Drawing.Size(43, 13);
            this.lblMemberPhoneUpdate.TabIndex = 3;
            this.lblMemberPhoneUpdate.Text = "Telefon";
            // 
            // lblMemberSurnameUpdate
            // 
            this.lblMemberSurnameUpdate.AutoSize = true;
            this.lblMemberSurnameUpdate.Location = new System.Drawing.Point(30, 80);
            this.lblMemberSurnameUpdate.Name = "lblMemberSurnameUpdate";
            this.lblMemberSurnameUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblMemberSurnameUpdate.TabIndex = 2;
            this.lblMemberSurnameUpdate.Text = "Üye Soyadı :";
            // 
            // tbxMemberNameUpdate
            // 
            this.tbxMemberNameUpdate.Location = new System.Drawing.Point(100, 40);
            this.tbxMemberNameUpdate.Name = "tbxMemberNameUpdate";
            this.tbxMemberNameUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxMemberNameUpdate.TabIndex = 1;
            // 
            // lblMemberNameUpdate
            // 
            this.lblMemberNameUpdate.AutoSize = true;
            this.lblMemberNameUpdate.Location = new System.Drawing.Point(30, 40);
            this.lblMemberNameUpdate.Name = "lblMemberNameUpdate";
            this.lblMemberNameUpdate.Size = new System.Drawing.Size(50, 13);
            this.lblMemberNameUpdate.TabIndex = 0;
            this.lblMemberNameUpdate.Text = "Üye Adı :";
            // 
            // lblRemove
            // 
            this.lblRemove.Location = new System.Drawing.Point(750, 11);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(60, 30);
            this.lblRemove.TabIndex = 12;
            this.lblRemove.Text = "Sil";
            this.lblRemove.UseVisualStyleBackColor = true;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // AlisPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 670);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAddMember);
            this.Controls.Add(this.gbxSearchByMemberName);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.gbxGetByCategoryName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlisPark";
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.AlisPark_Load);
            this.gbxGetByCategoryName.ResumeLayout(false);
            this.gbxGetByCategoryName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.gbxSearchByMemberName.ResumeLayout(false);
            this.gbxSearchByMemberName.PerformLayout();
            this.gbxAddMember.ResumeLayout(false);
            this.gbxAddMember.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGetByCategoryName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.GroupBox gbxSearchByMemberName;
        private System.Windows.Forms.TextBox tbxMemberNameSearch;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.GroupBox gbxAddMember;
        private System.Windows.Forms.TextBox tbxMemberSurnameAdd;
        private System.Windows.Forms.TextBox tbxMemberPhoneAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblMemberPhoneAdd;
        private System.Windows.Forms.Label lblMemberSurnameAdd;
        private System.Windows.Forms.TextBox tbxMemberNameAdd;
        private System.Windows.Forms.Label lblMemberNameAdd;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.Label lblBalanceAdd;
        private System.Windows.Forms.TextBox tbxBalanceAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.Label lblBalanceUpdate;
        private System.Windows.Forms.TextBox tbxBalanceUpdate;
        private System.Windows.Forms.TextBox tbxMemberSurnameUpdate;
        private System.Windows.Forms.TextBox tbxMemberPhoneUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblMemberPhoneUpdate;
        private System.Windows.Forms.Label lblMemberSurnameUpdate;
        private System.Windows.Forms.TextBox tbxMemberNameUpdate;
        private System.Windows.Forms.Label lblMemberNameUpdate;
        private System.Windows.Forms.Button lblRemove;
    }
}