namespace Sistem_Manajemen_Hotel.User_Control
{
    partial class UserControlReservasi
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
            this.tabControlReservasi = new System.Windows.Forms.TabControl();
            this.tabPageTambahReservasi = new System.Windows.Forms.TabPage();
            this.tabPageCariReservasi = new System.Windows.Forms.TabPage();
            this.tabPageUpdateDeleteReservasi = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambahReservasi = new System.Windows.Forms.Button();
            this.txt_ID_ClientTambah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Tipe_RuanganTambah = new System.Windows.Forms.ComboBox();
            this.cmb_Nomor_RuanganTambah = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Tgl_MasukTambah = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTgl_KeluarTambah = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewCariReservasi = new System.Windows.Forms.DataGridView();
            this.txt_IDClient_CariReservasi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_OUT_UpdateCancel = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_IN_UpdateCancel = new System.Windows.Forms.DateTimePicker();
            this.cmb_NoRuang_UpdateCancel = new System.Windows.Forms.ComboBox();
            this.cmb_TipeRuangan_UpdateCancel = new System.Windows.Forms.ComboBox();
            this.btnUpdateReservasi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_IDClient_UpdateCancel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelReservasi = new System.Windows.Forms.Button();
            this.tabControlReservasi.SuspendLayout();
            this.tabPageTambahReservasi.SuspendLayout();
            this.tabPageCariReservasi.SuspendLayout();
            this.tabPageUpdateDeleteReservasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariReservasi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReservasi
            // 
            this.tabControlReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservasi.Controls.Add(this.tabPageTambahReservasi);
            this.tabControlReservasi.Controls.Add(this.tabPageCariReservasi);
            this.tabControlReservasi.Controls.Add(this.tabPageUpdateDeleteReservasi);
            this.tabControlReservasi.Location = new System.Drawing.Point(30, 29);
            this.tabControlReservasi.Name = "tabControlReservasi";
            this.tabControlReservasi.SelectedIndex = 0;
            this.tabControlReservasi.Size = new System.Drawing.Size(1042, 406);
            this.tabControlReservasi.TabIndex = 0;
            // 
            // tabPageTambahReservasi
            // 
            this.tabPageTambahReservasi.Controls.Add(this.dateTimePickerTgl_KeluarTambah);
            this.tabPageTambahReservasi.Controls.Add(this.dateTimePicker_Tgl_MasukTambah);
            this.tabPageTambahReservasi.Controls.Add(this.cmb_Nomor_RuanganTambah);
            this.tabPageTambahReservasi.Controls.Add(this.cmb_Tipe_RuanganTambah);
            this.tabPageTambahReservasi.Controls.Add(this.btnTambahReservasi);
            this.tabPageTambahReservasi.Controls.Add(this.label7);
            this.tabPageTambahReservasi.Controls.Add(this.txt_ID_ClientTambah);
            this.tabPageTambahReservasi.Controls.Add(this.label6);
            this.tabPageTambahReservasi.Controls.Add(this.label4);
            this.tabPageTambahReservasi.Controls.Add(this.label3);
            this.tabPageTambahReservasi.Controls.Add(this.label5);
            this.tabPageTambahReservasi.Controls.Add(this.label8);
            this.tabPageTambahReservasi.Location = new System.Drawing.Point(4, 26);
            this.tabPageTambahReservasi.Name = "tabPageTambahReservasi";
            this.tabPageTambahReservasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTambahReservasi.Size = new System.Drawing.Size(1034, 376);
            this.tabPageTambahReservasi.TabIndex = 0;
            this.tabPageTambahReservasi.Text = "Tambah Reservasi";
            this.tabPageTambahReservasi.UseVisualStyleBackColor = true;
            this.tabPageTambahReservasi.Leave += new System.EventHandler(this.tabPageTambahReservasi_Leave);
            // 
            // tabPageCariReservasi
            // 
            this.tabPageCariReservasi.Controls.Add(this.dataGridViewCariReservasi);
            this.tabPageCariReservasi.Controls.Add(this.txt_IDClient_CariReservasi);
            this.tabPageCariReservasi.Controls.Add(this.label9);
            this.tabPageCariReservasi.Controls.Add(this.label1);
            this.tabPageCariReservasi.Location = new System.Drawing.Point(4, 26);
            this.tabPageCariReservasi.Name = "tabPageCariReservasi";
            this.tabPageCariReservasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCariReservasi.Size = new System.Drawing.Size(1034, 376);
            this.tabPageCariReservasi.TabIndex = 1;
            this.tabPageCariReservasi.Text = "Cari Reservasi";
            this.tabPageCariReservasi.UseVisualStyleBackColor = true;
            this.tabPageCariReservasi.Enter += new System.EventHandler(this.tabPageCariReservasi_Enter);
            this.tabPageCariReservasi.Leave += new System.EventHandler(this.tabPageCariReservasi_Leave);
            // 
            // tabPageUpdateDeleteReservasi
            // 
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.dateTimePicker_OUT_UpdateCancel);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.dateTimePicker_IN_UpdateCancel);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.cmb_NoRuang_UpdateCancel);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.cmb_TipeRuangan_UpdateCancel);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.btnCancelReservasi);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.btnUpdateReservasi);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.label10);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.txt_IDClient_UpdateCancel);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.label11);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.label12);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.label13);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.label14);
            this.tabPageUpdateDeleteReservasi.Controls.Add(this.label2);
            this.tabPageUpdateDeleteReservasi.Location = new System.Drawing.Point(4, 26);
            this.tabPageUpdateDeleteReservasi.Name = "tabPageUpdateDeleteReservasi";
            this.tabPageUpdateDeleteReservasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteReservasi.Size = new System.Drawing.Size(1034, 376);
            this.tabPageUpdateDeleteReservasi.TabIndex = 2;
            this.tabPageUpdateDeleteReservasi.Text = "Update dan Delete Reservasi";
            this.tabPageUpdateDeleteReservasi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(18, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tambah Reservasi :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Reservasi :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update dan Cancel Reservasi :";
            // 
            // btnTambahReservasi
            // 
            this.btnTambahReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahReservasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnTambahReservasi.FlatAppearance.BorderSize = 0;
            this.btnTambahReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahReservasi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahReservasi.ForeColor = System.Drawing.Color.White;
            this.btnTambahReservasi.Location = new System.Drawing.Point(154, 246);
            this.btnTambahReservasi.Name = "btnTambahReservasi";
            this.btnTambahReservasi.Size = new System.Drawing.Size(126, 40);
            this.btnTambahReservasi.TabIndex = 6;
            this.btnTambahReservasi.Text = "Tambah";
            this.btnTambahReservasi.UseVisualStyleBackColor = false;
            this.btnTambahReservasi.Click += new System.EventHandler(this.btnTambahReservasi_Click);
            // 
            // txt_ID_ClientTambah
            // 
            this.txt_ID_ClientTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID_ClientTambah.Location = new System.Drawing.Point(152, 138);
            this.txt_ID_ClientTambah.Name = "txt_ID_ClientTambah";
            this.txt_ID_ClientTambah.Size = new System.Drawing.Size(305, 23);
            this.txt_ID_ClientTambah.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(148, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Client :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(575, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nomor Ruangan :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(148, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipe Ruangan :";
            // 
            // cmb_Tipe_RuanganTambah
            // 
            this.cmb_Tipe_RuanganTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Tipe_RuanganTambah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipe_RuanganTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Tipe_RuanganTambah.FormattingEnabled = true;
            this.cmb_Tipe_RuanganTambah.Items.AddRange(new object[] {
            "Please select.....",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cmb_Tipe_RuanganTambah.Location = new System.Drawing.Point(153, 79);
            this.cmb_Tipe_RuanganTambah.Name = "cmb_Tipe_RuanganTambah";
            this.cmb_Tipe_RuanganTambah.Size = new System.Drawing.Size(305, 25);
            this.cmb_Tipe_RuanganTambah.TabIndex = 1;
            this.cmb_Tipe_RuanganTambah.SelectedIndexChanged += new System.EventHandler(this.cmb_Tipe_RuanganTambah_SelectedIndexChanged);
            // 
            // cmb_Nomor_RuanganTambah
            // 
            this.cmb_Nomor_RuanganTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Nomor_RuanganTambah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nomor_RuanganTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Nomor_RuanganTambah.FormattingEnabled = true;
            this.cmb_Nomor_RuanganTambah.Items.AddRange(new object[] {
            "Please select....."});
            this.cmb_Nomor_RuanganTambah.Location = new System.Drawing.Point(579, 79);
            this.cmb_Nomor_RuanganTambah.Name = "cmb_Nomor_RuanganTambah";
            this.cmb_Nomor_RuanganTambah.Size = new System.Drawing.Size(305, 25);
            this.cmb_Nomor_RuanganTambah.TabIndex = 2;
            // 
            // dateTimePicker_Tgl_MasukTambah
            // 
            this.dateTimePicker_Tgl_MasukTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_Tgl_MasukTambah.Location = new System.Drawing.Point(152, 201);
            this.dateTimePicker_Tgl_MasukTambah.Name = "dateTimePicker_Tgl_MasukTambah";
            this.dateTimePicker_Tgl_MasukTambah.Size = new System.Drawing.Size(305, 23);
            this.dateTimePicker_Tgl_MasukTambah.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(148, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tanggal Masuk :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(575, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tanggal Keluar :";
            // 
            // dateTimePickerTgl_KeluarTambah
            // 
            this.dateTimePickerTgl_KeluarTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTgl_KeluarTambah.Location = new System.Drawing.Point(579, 201);
            this.dateTimePickerTgl_KeluarTambah.Name = "dateTimePickerTgl_KeluarTambah";
            this.dateTimePickerTgl_KeluarTambah.Size = new System.Drawing.Size(305, 23);
            this.dateTimePickerTgl_KeluarTambah.TabIndex = 4;
            // 
            // dataGridViewCariReservasi
            // 
            this.dataGridViewCariReservasi.AllowUserToAddRows = false;
            this.dataGridViewCariReservasi.AllowUserToDeleteRows = false;
            this.dataGridViewCariReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCariReservasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCariReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariReservasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewCariReservasi.Location = new System.Drawing.Point(31, 136);
            this.dataGridViewCariReservasi.Name = "dataGridViewCariReservasi";
            this.dataGridViewCariReservasi.ReadOnly = true;
            this.dataGridViewCariReservasi.Size = new System.Drawing.Size(967, 215);
            this.dataGridViewCariReservasi.TabIndex = 0;
            this.dataGridViewCariReservasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCariReservasi_CellClick);
            // 
            // txt_IDClient_CariReservasi
            // 
            this.txt_IDClient_CariReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDClient_CariReservasi.Location = new System.Drawing.Point(161, 90);
            this.txt_IDClient_CariReservasi.Name = "txt_IDClient_CariReservasi";
            this.txt_IDClient_CariReservasi.Size = new System.Drawing.Size(266, 23);
            this.txt_IDClient_CariReservasi.TabIndex = 1;
            this.txt_IDClient_CariReservasi.TextChanged += new System.EventHandler(this.txt_IDClient_CariReservasi_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Client :";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Reservasi_ID";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Reservasi_TipeRuangan";
            this.Column2.HeaderText = "Tipe Ruangan";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Reservasi_NoRuangan";
            this.Column3.HeaderText = "Nomor Ruangan";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Reservasi_ID_Client";
            this.Column4.HeaderText = "ID Client";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Reservasi_Masuk";
            this.Column5.HeaderText = "Tanggal Masuk";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Reservasi_Keluar";
            this.Column6.HeaderText = "Tanggal Keluar";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dateTimePicker_OUT_UpdateCancel
            // 
            this.dateTimePicker_OUT_UpdateCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_OUT_UpdateCancel.Location = new System.Drawing.Point(579, 201);
            this.dateTimePicker_OUT_UpdateCancel.Name = "dateTimePicker_OUT_UpdateCancel";
            this.dateTimePicker_OUT_UpdateCancel.Size = new System.Drawing.Size(305, 23);
            this.dateTimePicker_OUT_UpdateCancel.TabIndex = 5;
            // 
            // dateTimePicker_IN_UpdateCancel
            // 
            this.dateTimePicker_IN_UpdateCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_IN_UpdateCancel.Location = new System.Drawing.Point(152, 201);
            this.dateTimePicker_IN_UpdateCancel.Name = "dateTimePicker_IN_UpdateCancel";
            this.dateTimePicker_IN_UpdateCancel.Size = new System.Drawing.Size(305, 23);
            this.dateTimePicker_IN_UpdateCancel.TabIndex = 4;
            // 
            // cmb_NoRuang_UpdateCancel
            // 
            this.cmb_NoRuang_UpdateCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_NoRuang_UpdateCancel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NoRuang_UpdateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_NoRuang_UpdateCancel.FormattingEnabled = true;
            this.cmb_NoRuang_UpdateCancel.Items.AddRange(new object[] {
            "Please select....."});
            this.cmb_NoRuang_UpdateCancel.Location = new System.Drawing.Point(579, 79);
            this.cmb_NoRuang_UpdateCancel.Name = "cmb_NoRuang_UpdateCancel";
            this.cmb_NoRuang_UpdateCancel.Size = new System.Drawing.Size(305, 25);
            this.cmb_NoRuang_UpdateCancel.TabIndex = 2;
            // 
            // cmb_TipeRuangan_UpdateCancel
            // 
            this.cmb_TipeRuangan_UpdateCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_TipeRuangan_UpdateCancel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipeRuangan_UpdateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TipeRuangan_UpdateCancel.FormattingEnabled = true;
            this.cmb_TipeRuangan_UpdateCancel.Items.AddRange(new object[] {
            "Please select.....",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cmb_TipeRuangan_UpdateCancel.Location = new System.Drawing.Point(153, 79);
            this.cmb_TipeRuangan_UpdateCancel.Name = "cmb_TipeRuangan_UpdateCancel";
            this.cmb_TipeRuangan_UpdateCancel.Size = new System.Drawing.Size(305, 25);
            this.cmb_TipeRuangan_UpdateCancel.TabIndex = 1;
            this.cmb_TipeRuangan_UpdateCancel.SelectedIndexChanged += new System.EventHandler(this.cmb_TipeRuangan_UpdateCancel_SelectedIndexChanged);
            // 
            // btnUpdateReservasi
            // 
            this.btnUpdateReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateReservasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnUpdateReservasi.FlatAppearance.BorderSize = 0;
            this.btnUpdateReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReservasi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservasi.ForeColor = System.Drawing.Color.White;
            this.btnUpdateReservasi.Location = new System.Drawing.Point(154, 246);
            this.btnUpdateReservasi.Name = "btnUpdateReservasi";
            this.btnUpdateReservasi.Size = new System.Drawing.Size(126, 40);
            this.btnUpdateReservasi.TabIndex = 6;
            this.btnUpdateReservasi.Text = "Update";
            this.btnUpdateReservasi.UseVisualStyleBackColor = false;
            this.btnUpdateReservasi.Click += new System.EventHandler(this.btnUpdateReservasi_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(575, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tanggal Keluar :";
            // 
            // txt_IDClient_UpdateCancel
            // 
            this.txt_IDClient_UpdateCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDClient_UpdateCancel.Location = new System.Drawing.Point(152, 138);
            this.txt_IDClient_UpdateCancel.Name = "txt_IDClient_UpdateCancel";
            this.txt_IDClient_UpdateCancel.Size = new System.Drawing.Size(305, 23);
            this.txt_IDClient_UpdateCancel.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(148, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tanggal Masuk :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(148, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID Client :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(575, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nomor Ruangan :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(148, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tipe Ruangan :";
            // 
            // btnCancelReservasi
            // 
            this.btnCancelReservasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelReservasi.BackColor = System.Drawing.Color.Red;
            this.btnCancelReservasi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelReservasi.FlatAppearance.BorderSize = 0;
            this.btnCancelReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservasi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservasi.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservasi.Location = new System.Drawing.Point(331, 246);
            this.btnCancelReservasi.Name = "btnCancelReservasi";
            this.btnCancelReservasi.Size = new System.Drawing.Size(126, 40);
            this.btnCancelReservasi.TabIndex = 7;
            this.btnCancelReservasi.Text = "Cancel";
            this.btnCancelReservasi.UseVisualStyleBackColor = false;
            this.btnCancelReservasi.Click += new System.EventHandler(this.btnCancelReservasi_Click);
            this.btnCancelReservasi.Leave += new System.EventHandler(this.btnCancelReservasi_Leave);
            // 
            // UserControlReservasi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservasi);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlReservasi";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlReservasi_Load);
            this.tabControlReservasi.ResumeLayout(false);
            this.tabPageTambahReservasi.ResumeLayout(false);
            this.tabPageTambahReservasi.PerformLayout();
            this.tabPageCariReservasi.ResumeLayout(false);
            this.tabPageCariReservasi.PerformLayout();
            this.tabPageUpdateDeleteReservasi.ResumeLayout(false);
            this.tabPageUpdateDeleteReservasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariReservasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservasi;
        private System.Windows.Forms.TabPage tabPageTambahReservasi;
        private System.Windows.Forms.TabPage tabPageCariReservasi;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteReservasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambahReservasi;
        private System.Windows.Forms.TextBox txt_ID_ClientTambah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Tipe_RuanganTambah;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Tgl_MasukTambah;
        private System.Windows.Forms.ComboBox cmb_Nomor_RuanganTambah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTgl_KeluarTambah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewCariReservasi;
        private System.Windows.Forms.TextBox txt_IDClient_CariReservasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OUT_UpdateCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_IN_UpdateCancel;
        private System.Windows.Forms.ComboBox cmb_NoRuang_UpdateCancel;
        private System.Windows.Forms.ComboBox cmb_TipeRuangan_UpdateCancel;
        private System.Windows.Forms.Button btnCancelReservasi;
        private System.Windows.Forms.Button btnUpdateReservasi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_IDClient_UpdateCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
