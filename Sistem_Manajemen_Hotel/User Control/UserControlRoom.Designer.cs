namespace Sistem_Manajemen_Hotel.User_Control
{
    partial class UserControlRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlCariRuang = new System.Windows.Forms.TabControl();
            this.tabPageTambahRuang = new System.Windows.Forms.TabPage();
            this.rdb_No_TambahRuangan = new System.Windows.Forms.RadioButton();
            this.rdb_Yes_TambahRuangan = new System.Windows.Forms.RadioButton();
            this.cmbTipe_TambahRuangan = new System.Windows.Forms.ComboBox();
            this.btnTambahRuangan = new System.Windows.Forms.Button();
            this.txtPhoneTambahRuangan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageCariRuang = new System.Windows.Forms.TabPage();
            this.dataGridViewCariRuang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCariRuang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeleteRuang = new System.Windows.Forms.TabPage();
            this.rdb_No_UpdateDelete = new System.Windows.Forms.RadioButton();
            this.rdb_Yes_UpdateDelete = new System.Windows.Forms.RadioButton();
            this.cmbTipe_UpdateDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteRuangan = new System.Windows.Forms.Button();
            this.btnUpdateRuangan = new System.Windows.Forms.Button();
            this.txtPhone_UpdateDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlCariRuang.SuspendLayout();
            this.tabPageTambahRuang.SuspendLayout();
            this.tabPageCariRuang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariRuang)).BeginInit();
            this.tabPageUpdateDeleteRuang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCariRuang
            // 
            this.tabControlCariRuang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlCariRuang.Controls.Add(this.tabPageTambahRuang);
            this.tabControlCariRuang.Controls.Add(this.tabPageCariRuang);
            this.tabControlCariRuang.Controls.Add(this.tabPageUpdateDeleteRuang);
            this.tabControlCariRuang.Location = new System.Drawing.Point(30, 29);
            this.tabControlCariRuang.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCariRuang.Name = "tabControlCariRuang";
            this.tabControlCariRuang.SelectedIndex = 0;
            this.tabControlCariRuang.Size = new System.Drawing.Size(1042, 406);
            this.tabControlCariRuang.TabIndex = 0;
            this.tabControlCariRuang.Enter += new System.EventHandler(this.tabControlCariRuang_Enter);
            // 
            // tabPageTambahRuang
            // 
            this.tabPageTambahRuang.Controls.Add(this.rdb_No_TambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.rdb_Yes_TambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.cmbTipe_TambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.btnTambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.txtPhoneTambahRuangan);
            this.tabPageTambahRuang.Controls.Add(this.label5);
            this.tabPageTambahRuang.Controls.Add(this.label6);
            this.tabPageTambahRuang.Controls.Add(this.label7);
            this.tabPageTambahRuang.Controls.Add(this.label8);
            this.tabPageTambahRuang.Location = new System.Drawing.Point(4, 26);
            this.tabPageTambahRuang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTambahRuang.Name = "tabPageTambahRuang";
            this.tabPageTambahRuang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTambahRuang.Size = new System.Drawing.Size(1034, 376);
            this.tabPageTambahRuang.TabIndex = 0;
            this.tabPageTambahRuang.Text = "Tambah Ruang";
            this.tabPageTambahRuang.UseVisualStyleBackColor = true;
            this.tabPageTambahRuang.Leave += new System.EventHandler(this.tabPageTambahRuang_Leave);
            // 
            // rdb_No_TambahRuangan
            // 
            this.rdb_No_TambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_No_TambahRuangan.AutoSize = true;
            this.rdb_No_TambahRuangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_No_TambahRuangan.Location = new System.Drawing.Point(230, 169);
            this.rdb_No_TambahRuangan.Name = "rdb_No_TambahRuangan";
            this.rdb_No_TambahRuangan.Size = new System.Drawing.Size(48, 24);
            this.rdb_No_TambahRuangan.TabIndex = 4;
            this.rdb_No_TambahRuangan.TabStop = true;
            this.rdb_No_TambahRuangan.Text = "No";
            this.rdb_No_TambahRuangan.UseVisualStyleBackColor = true;
            // 
            // rdb_Yes_TambahRuangan
            // 
            this.rdb_Yes_TambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Yes_TambahRuangan.AutoSize = true;
            this.rdb_Yes_TambahRuangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Yes_TambahRuangan.Location = new System.Drawing.Point(153, 169);
            this.rdb_Yes_TambahRuangan.Name = "rdb_Yes_TambahRuangan";
            this.rdb_Yes_TambahRuangan.Size = new System.Drawing.Size(50, 24);
            this.rdb_Yes_TambahRuangan.TabIndex = 3;
            this.rdb_Yes_TambahRuangan.TabStop = true;
            this.rdb_Yes_TambahRuangan.Text = "Yes";
            this.rdb_Yes_TambahRuangan.UseVisualStyleBackColor = true;
            // 
            // cmbTipe_TambahRuangan
            // 
            this.cmbTipe_TambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipe_TambahRuangan.BackColor = System.Drawing.Color.White;
            this.cmbTipe_TambahRuangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipe_TambahRuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipe_TambahRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipe_TambahRuangan.FormattingEnabled = true;
            this.cmbTipe_TambahRuangan.Items.AddRange(new object[] {
            "Please select.....",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cmbTipe_TambahRuangan.Location = new System.Drawing.Point(153, 89);
            this.cmbTipe_TambahRuangan.Name = "cmbTipe_TambahRuangan";
            this.cmbTipe_TambahRuangan.Size = new System.Drawing.Size(304, 25);
            this.cmbTipe_TambahRuangan.TabIndex = 1;
            // 
            // btnTambahRuangan
            // 
            this.btnTambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahRuangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnTambahRuangan.FlatAppearance.BorderSize = 0;
            this.btnTambahRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahRuangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahRuangan.ForeColor = System.Drawing.Color.White;
            this.btnTambahRuangan.Location = new System.Drawing.Point(153, 219);
            this.btnTambahRuangan.Name = "btnTambahRuangan";
            this.btnTambahRuangan.Size = new System.Drawing.Size(126, 40);
            this.btnTambahRuangan.TabIndex = 0;
            this.btnTambahRuangan.Text = "Tambah";
            this.btnTambahRuangan.UseVisualStyleBackColor = false;
            this.btnTambahRuangan.Click += new System.EventHandler(this.btnTambahRuangan_Click);
            // 
            // txtPhoneTambahRuangan
            // 
            this.txtPhoneTambahRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneTambahRuangan.Location = new System.Drawing.Point(579, 89);
            this.txtPhoneTambahRuangan.Name = "txtPhoneTambahRuangan";
            this.txtPhoneTambahRuangan.Size = new System.Drawing.Size(305, 23);
            this.txtPhoneTambahRuangan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(575, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone No : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(148, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ketersediaan Ruangan : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(148, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipe Ruangan : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(18, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tambah Ruangan :";
            // 
            // tabPageCariRuang
            // 
            this.tabPageCariRuang.Controls.Add(this.dataGridViewCariRuang);
            this.tabPageCariRuang.Controls.Add(this.txtCariRuang);
            this.tabPageCariRuang.Controls.Add(this.label1);
            this.tabPageCariRuang.Controls.Add(this.label4);
            this.tabPageCariRuang.Location = new System.Drawing.Point(4, 26);
            this.tabPageCariRuang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCariRuang.Name = "tabPageCariRuang";
            this.tabPageCariRuang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCariRuang.Size = new System.Drawing.Size(1034, 376);
            this.tabPageCariRuang.TabIndex = 1;
            this.tabPageCariRuang.Text = "Cari Ruang";
            this.tabPageCariRuang.UseVisualStyleBackColor = true;
            this.tabPageCariRuang.Click += new System.EventHandler(this.tabPageCariRuang_Click);
            this.tabPageCariRuang.Enter += new System.EventHandler(this.tabPageCariRuang_Enter);
            this.tabPageCariRuang.Leave += new System.EventHandler(this.tabPageCariRuang_Leave);
            // 
            // dataGridViewCariRuang
            // 
            this.dataGridViewCariRuang.AllowUserToAddRows = false;
            this.dataGridViewCariRuang.AllowUserToDeleteRows = false;
            this.dataGridViewCariRuang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCariRuang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCariRuang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariRuang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewCariRuang.Location = new System.Drawing.Point(31, 136);
            this.dataGridViewCariRuang.Name = "dataGridViewCariRuang";
            this.dataGridViewCariRuang.ReadOnly = true;
            this.dataGridViewCariRuang.Size = new System.Drawing.Size(967, 215);
            this.dataGridViewCariRuang.TabIndex = 2;
            this.dataGridViewCariRuang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCariRuang_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Room_No";
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Room_Tipe";
            this.Column2.HeaderText = "Tipe Ruang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Ruang_Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Room_Status";
            this.Column4.HeaderText = "Status Kamar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtCariRuang
            // 
            this.txtCariRuang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCariRuang.Location = new System.Drawing.Point(161, 90);
            this.txtCariRuang.Name = "txtCariRuang";
            this.txtCariRuang.Size = new System.Drawing.Size(266, 23);
            this.txtCariRuang.TabIndex = 1;
            this.txtCariRuang.TextChanged += new System.EventHandler(this.txtCariRuang_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruang No :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cari Ruang : ";
            // 
            // tabPageUpdateDeleteRuang
            // 
            this.tabPageUpdateDeleteRuang.Controls.Add(this.rdb_No_UpdateDelete);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.rdb_Yes_UpdateDelete);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.cmbTipe_UpdateDelete);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.btnDeleteRuangan);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.btnUpdateRuangan);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.txtPhone_UpdateDelete);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.label2);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.label3);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.label9);
            this.tabPageUpdateDeleteRuang.Controls.Add(this.label10);
            this.tabPageUpdateDeleteRuang.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdateDeleteRuang.Name = "tabPageUpdateDeleteRuang";
            this.tabPageUpdateDeleteRuang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteRuang.Size = new System.Drawing.Size(1034, 376);
            this.tabPageUpdateDeleteRuang.TabIndex = 2;
            this.tabPageUpdateDeleteRuang.Text = "Update dan Delete Ruang";
            this.tabPageUpdateDeleteRuang.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteRuang.Leave += new System.EventHandler(this.tabPageUpdateDeleteRuang_Leave);
            // 
            // rdb_No_UpdateDelete
            // 
            this.rdb_No_UpdateDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_No_UpdateDelete.AutoSize = true;
            this.rdb_No_UpdateDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_No_UpdateDelete.Location = new System.Drawing.Point(230, 204);
            this.rdb_No_UpdateDelete.Name = "rdb_No_UpdateDelete";
            this.rdb_No_UpdateDelete.Size = new System.Drawing.Size(48, 24);
            this.rdb_No_UpdateDelete.TabIndex = 4;
            this.rdb_No_UpdateDelete.TabStop = true;
            this.rdb_No_UpdateDelete.Text = "No";
            this.rdb_No_UpdateDelete.UseVisualStyleBackColor = true;
            // 
            // rdb_Yes_UpdateDelete
            // 
            this.rdb_Yes_UpdateDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Yes_UpdateDelete.AutoSize = true;
            this.rdb_Yes_UpdateDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Yes_UpdateDelete.Location = new System.Drawing.Point(153, 204);
            this.rdb_Yes_UpdateDelete.Name = "rdb_Yes_UpdateDelete";
            this.rdb_Yes_UpdateDelete.Size = new System.Drawing.Size(50, 24);
            this.rdb_Yes_UpdateDelete.TabIndex = 3;
            this.rdb_Yes_UpdateDelete.TabStop = true;
            this.rdb_Yes_UpdateDelete.Text = "Yes";
            this.rdb_Yes_UpdateDelete.UseVisualStyleBackColor = true;
            // 
            // cmbTipe_UpdateDelete
            // 
            this.cmbTipe_UpdateDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipe_UpdateDelete.BackColor = System.Drawing.Color.White;
            this.cmbTipe_UpdateDelete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmbTipe_UpdateDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipe_UpdateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipe_UpdateDelete.FormattingEnabled = true;
            this.cmbTipe_UpdateDelete.Items.AddRange(new object[] {
            "Please select.....",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cmbTipe_UpdateDelete.Location = new System.Drawing.Point(153, 124);
            this.cmbTipe_UpdateDelete.Name = "cmbTipe_UpdateDelete";
            this.cmbTipe_UpdateDelete.Size = new System.Drawing.Size(304, 25);
            this.cmbTipe_UpdateDelete.TabIndex = 1;
            this.cmbTipe_UpdateDelete.UseWaitCursor = true;
            // 
            // btnDeleteRuangan
            // 
            this.btnDeleteRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRuangan.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRuangan.FlatAppearance.BorderSize = 0;
            this.btnDeleteRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRuangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRuangan.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRuangan.Location = new System.Drawing.Point(285, 254);
            this.btnDeleteRuangan.Name = "btnDeleteRuangan";
            this.btnDeleteRuangan.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteRuangan.TabIndex = 6;
            this.btnDeleteRuangan.Text = "Delete";
            this.btnDeleteRuangan.UseVisualStyleBackColor = false;
            this.btnDeleteRuangan.Click += new System.EventHandler(this.btnDeleteRuangan_Click);
            // 
            // btnUpdateRuangan
            // 
            this.btnUpdateRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateRuangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnUpdateRuangan.FlatAppearance.BorderSize = 0;
            this.btnUpdateRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRuangan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRuangan.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRuangan.Location = new System.Drawing.Point(153, 254);
            this.btnUpdateRuangan.Name = "btnUpdateRuangan";
            this.btnUpdateRuangan.Size = new System.Drawing.Size(126, 40);
            this.btnUpdateRuangan.TabIndex = 5;
            this.btnUpdateRuangan.Text = "Update";
            this.btnUpdateRuangan.UseVisualStyleBackColor = false;
            this.btnUpdateRuangan.Click += new System.EventHandler(this.btnUpdateRuangan_Click);
            // 
            // txtPhone_UpdateDelete
            // 
            this.txtPhone_UpdateDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone_UpdateDelete.Location = new System.Drawing.Point(579, 124);
            this.txtPhone_UpdateDelete.Name = "txtPhone_UpdateDelete";
            this.txtPhone_UpdateDelete.Size = new System.Drawing.Size(305, 23);
            this.txtPhone_UpdateDelete.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(575, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone No : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(148, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ketersediaan Ruangan : ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(148, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipe Ruangan : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(18, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update dan Delete Ruangan :";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlCariRuang);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlCariRuang.ResumeLayout(false);
            this.tabPageTambahRuang.ResumeLayout(false);
            this.tabPageTambahRuang.PerformLayout();
            this.tabPageCariRuang.ResumeLayout(false);
            this.tabPageCariRuang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariRuang)).EndInit();
            this.tabPageUpdateDeleteRuang.ResumeLayout(false);
            this.tabPageUpdateDeleteRuang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCariRuang;
        private System.Windows.Forms.TabPage tabPageTambahRuang;
        private System.Windows.Forms.TabPage tabPageCariRuang;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteRuang;
        private System.Windows.Forms.RadioButton rdb_No_TambahRuangan;
        private System.Windows.Forms.RadioButton rdb_Yes_TambahRuangan;
        private System.Windows.Forms.ComboBox cmbTipe_TambahRuangan;
        private System.Windows.Forms.Button btnTambahRuangan;
        private System.Windows.Forms.TextBox txtPhoneTambahRuangan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCariRuang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCariRuang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton rdb_No_UpdateDelete;
        private System.Windows.Forms.RadioButton rdb_Yes_UpdateDelete;
        private System.Windows.Forms.ComboBox cmbTipe_UpdateDelete;
        private System.Windows.Forms.Button btnUpdateRuangan;
        private System.Windows.Forms.TextBox txtPhone_UpdateDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteRuangan;
    }
}
