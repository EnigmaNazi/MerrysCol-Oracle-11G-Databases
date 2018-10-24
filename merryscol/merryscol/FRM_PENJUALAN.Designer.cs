namespace merryscol
{
    partial class FRM_PENJUALAN
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
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.group_cari_barang = new System.Windows.Forms.GroupBox();
            this.dg_barang = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_satuan = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pilih_barang = new System.Windows.Forms.Button();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_warna = new System.Windows.Forms.TextBox();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.txt_kode_barang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_keterangan = new System.Windows.Forms.TextBox();
            this.txt_jumlah_beli = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_sub_total = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_no_penjualan = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.group_cari_pelanggan = new System.Windows.Forms.GroupBox();
            this.dg_pelanggan = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.pilih_pelanggan = new System.Windows.Forms.Button();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_no_telp = new System.Windows.Forms.TextBox();
            this.txt_nama_pelanggan = new System.Windows.Forms.TextBox();
            this.txt_kode_pelanggan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.group_cari_barang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_barang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.group_cari_pelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Location = new System.Drawing.Point(204, 474);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(86, 32);
            this.btn_close.TabIndex = 49;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.group_cari_barang);
            this.panel2.Controls.Add(this.txt_harga);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txt_satuan);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.pilih_barang);
            this.panel2.Controls.Add(this.txt_stock);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_warna);
            this.panel2.Controls.Add(this.txt_style);
            this.panel2.Controls.Add(this.txt_nama_barang);
            this.panel2.Controls.Add(this.txt_kode_barang);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 208);
            this.panel2.TabIndex = 46;
            // 
            // group_cari_barang
            // 
            this.group_cari_barang.BackColor = System.Drawing.Color.Yellow;
            this.group_cari_barang.Controls.Add(this.dg_barang);
            this.group_cari_barang.Controls.Add(this.label17);
            this.group_cari_barang.Controls.Add(this.textBox14);
            this.group_cari_barang.Location = new System.Drawing.Point(3, 20);
            this.group_cari_barang.Name = "group_cari_barang";
            this.group_cari_barang.Size = new System.Drawing.Size(392, 185);
            this.group_cari_barang.TabIndex = 17;
            this.group_cari_barang.TabStop = false;
            this.group_cari_barang.Text = "Pencarian data barang";
            this.group_cari_barang.Visible = false;
            // 
            // dg_barang
            // 
            this.dg_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_barang.Location = new System.Drawing.Point(7, 50);
            this.dg_barang.Name = "dg_barang";
            this.dg_barang.Size = new System.Drawing.Size(379, 129);
            this.dg_barang.TabIndex = 2;
            this.dg_barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_barang_CellContentClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cari Kode/Nama";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(96, 26);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(211, 20);
            this.textBox14.TabIndex = 0;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(267, 137);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(106, 20);
            this.txt_harga.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(226, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Harga";
            // 
            // txt_satuan
            // 
            this.txt_satuan.Location = new System.Drawing.Point(121, 171);
            this.txt_satuan.Name = "txt_satuan";
            this.txt_satuan.Size = new System.Drawing.Size(81, 20);
            this.txt_satuan.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Satuan";
            // 
            // pilih_barang
            // 
            this.pilih_barang.BackColor = System.Drawing.Color.White;
            this.pilih_barang.Location = new System.Drawing.Point(310, 32);
            this.pilih_barang.Name = "pilih_barang";
            this.pilih_barang.Size = new System.Drawing.Size(72, 26);
            this.pilih_barang.TabIndex = 11;
            this.pilih_barang.Text = "Pilih";
            this.pilih_barang.UseVisualStyleBackColor = false;
            this.pilih_barang.Click += new System.EventHandler(this.pilih_barang_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(267, 171);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(81, 20);
            this.txt_stock.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Stock";
            // 
            // txt_warna
            // 
            this.txt_warna.Location = new System.Drawing.Point(121, 137);
            this.txt_warna.Name = "txt_warna";
            this.txt_warna.Size = new System.Drawing.Size(81, 20);
            this.txt_warna.TabIndex = 8;
            // 
            // txt_style
            // 
            this.txt_style.Location = new System.Drawing.Point(121, 104);
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(155, 20);
            this.txt_style.TabIndex = 7;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(121, 70);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(155, 20);
            this.txt_nama_barang.TabIndex = 6;
            // 
            // txt_kode_barang
            // 
            this.txt_kode_barang.Location = new System.Drawing.Point(121, 36);
            this.txt_kode_barang.Name = "txt_kode_barang";
            this.txt_kode_barang.Size = new System.Drawing.Size(100, 20);
            this.txt_kode_barang.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Warna";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Style";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nama Barang";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kode Barang";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Data Barang:";
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new.Location = new System.Drawing.Point(20, 474);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(86, 32);
            this.btn_new.TabIndex = 47;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_keterangan
            // 
            this.txt_keterangan.Location = new System.Drawing.Point(122, 110);
            this.txt_keterangan.Multiline = true;
            this.txt_keterangan.Name = "txt_keterangan";
            this.txt_keterangan.Size = new System.Drawing.Size(308, 50);
            this.txt_keterangan.TabIndex = 3;
            // 
            // txt_jumlah_beli
            // 
            this.txt_jumlah_beli.Location = new System.Drawing.Point(122, 51);
            this.txt_jumlah_beli.Name = "txt_jumlah_beli";
            this.txt_jumlah_beli.Size = new System.Drawing.Size(123, 20);
            this.txt_jumlah_beli.TabIndex = 2;
            this.txt_jumlah_beli.TextChanged += new System.EventHandler(this.txt_jumlah_beli_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Keterangan";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txt_sub_total);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_keterangan);
            this.groupBox1.Controls.Add(this.txt_jumlah_beli);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(404, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 166);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penjualan";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Tanggal Terima";
            // 
            // txt_sub_total
            // 
            this.txt_sub_total.Location = new System.Drawing.Point(122, 81);
            this.txt_sub_total.Name = "txt_sub_total";
            this.txt_sub_total.Size = new System.Drawing.Size(123, 20);
            this.txt_sub_total.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Sub Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Jumlah Beli";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(548, 221);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 36);
            this.btn_add.TabIndex = 51;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(112, 474);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 32);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_no_penjualan
            // 
            this.txt_no_penjualan.Location = new System.Drawing.Point(83, 16);
            this.txt_no_penjualan.Name = "txt_no_penjualan";
            this.txt_no_penjualan.Size = new System.Drawing.Size(109, 20);
            this.txt_no_penjualan.TabIndex = 42;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_print.Location = new System.Drawing.Point(296, 474);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(86, 32);
            this.btn_print.TabIndex = 54;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.group_cari_pelanggan);
            this.panel1.Controls.Add(this.pilih_pelanggan);
            this.panel1.Controls.Add(this.txt_alamat);
            this.panel1.Controls.Add(this.txt_no_telp);
            this.panel1.Controls.Add(this.txt_nama_pelanggan);
            this.panel1.Controls.Add(this.txt_kode_pelanggan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 208);
            this.panel1.TabIndex = 45;
            // 
            // group_cari_pelanggan
            // 
            this.group_cari_pelanggan.BackColor = System.Drawing.Color.Yellow;
            this.group_cari_pelanggan.Controls.Add(this.dg_pelanggan);
            this.group_cari_pelanggan.Controls.Add(this.label18);
            this.group_cari_pelanggan.Controls.Add(this.textBox15);
            this.group_cari_pelanggan.Location = new System.Drawing.Point(3, 20);
            this.group_cari_pelanggan.Name = "group_cari_pelanggan";
            this.group_cari_pelanggan.Size = new System.Drawing.Size(392, 185);
            this.group_cari_pelanggan.TabIndex = 17;
            this.group_cari_pelanggan.TabStop = false;
            this.group_cari_pelanggan.Text = "Pencarian data pelanggan";
            this.group_cari_pelanggan.Visible = false;
            // 
            // dg_pelanggan
            // 
            this.dg_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pelanggan.Location = new System.Drawing.Point(7, 50);
            this.dg_pelanggan.Name = "dg_pelanggan";
            this.dg_pelanggan.Size = new System.Drawing.Size(379, 129);
            this.dg_pelanggan.TabIndex = 2;
            this.dg_pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_pelanggan_CellContentClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Cari Kode/Nama";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(96, 26);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(211, 20);
            this.textBox15.TabIndex = 0;
            // 
            // pilih_pelanggan
            // 
            this.pilih_pelanggan.BackColor = System.Drawing.Color.White;
            this.pilih_pelanggan.Location = new System.Drawing.Point(309, 36);
            this.pilih_pelanggan.Name = "pilih_pelanggan";
            this.pilih_pelanggan.Size = new System.Drawing.Size(72, 26);
            this.pilih_pelanggan.TabIndex = 0;
            this.pilih_pelanggan.Text = "Pilih";
            this.pilih_pelanggan.UseVisualStyleBackColor = false;
            this.pilih_pelanggan.Click += new System.EventHandler(this.pilih_pelanggan_Click);
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(120, 145);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(199, 41);
            this.txt_alamat.TabIndex = 8;
            // 
            // txt_no_telp
            // 
            this.txt_no_telp.Location = new System.Drawing.Point(120, 110);
            this.txt_no_telp.Name = "txt_no_telp";
            this.txt_no_telp.Size = new System.Drawing.Size(152, 20);
            this.txt_no_telp.TabIndex = 7;
            // 
            // txt_nama_pelanggan
            // 
            this.txt_nama_pelanggan.Location = new System.Drawing.Point(120, 75);
            this.txt_nama_pelanggan.Name = "txt_nama_pelanggan";
            this.txt_nama_pelanggan.Size = new System.Drawing.Size(199, 20);
            this.txt_nama_pelanggan.TabIndex = 6;
            // 
            // txt_kode_pelanggan
            // 
            this.txt_kode_pelanggan.Location = new System.Drawing.Point(120, 40);
            this.txt_kode_pelanggan.Name = "txt_kode_pelanggan";
            this.txt_kode_pelanggan.Size = new System.Drawing.Size(100, 20);
            this.txt_kode_pelanggan.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "No Telp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kode Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Pelanggan:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 246);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "No Penjualan";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(697, 221);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(143, 36);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // FRM_PENJUALAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_no_penjualan);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Name = "FRM_PENJUALAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_PENJUALAN";
            this.Load += new System.EventHandler(this.FRM_PENJUALAN_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.group_cari_barang.ResumeLayout(false);
            this.group_cari_barang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_barang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group_cari_pelanggan.ResumeLayout(false);
            this.group_cari_pelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox group_cari_barang;
        private System.Windows.Forms.DataGridView dg_barang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button pilih_barang;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_warna;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.TextBox txt_kode_barang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_keterangan;
        private System.Windows.Forms.TextBox txt_jumlah_beli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_sub_total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_no_penjualan;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox group_cari_pelanggan;
        private System.Windows.Forms.DataGridView dg_pelanggan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button pilih_pelanggan;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_no_telp;
        private System.Windows.Forms.TextBox txt_nama_pelanggan;
        private System.Windows.Forms.TextBox txt_kode_pelanggan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_satuan;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label21;
    }
}