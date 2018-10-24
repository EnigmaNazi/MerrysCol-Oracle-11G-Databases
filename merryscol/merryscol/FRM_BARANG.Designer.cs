namespace merryscol
{
    partial class FRM_BARANG
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
            this.button_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.cmb_satuan = new System.Windows.Forms.ComboBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.txt_kode_barang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.txt_warna = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_search.Location = new System.Drawing.Point(418, 238);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 37;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(3, 240);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(409, 20);
            this.txt_search.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Pencarian berdasarkan Kode/Nama Pelanggan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 231);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_close.Location = new System.Drawing.Point(390, 187);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(84, 35);
            this.button_close.TabIndex = 33;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_delete.Location = new System.Drawing.Point(299, 187);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 35);
            this.button_delete.TabIndex = 32;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_edit.Location = new System.Drawing.Point(208, 187);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(84, 35);
            this.button_edit.TabIndex = 31;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_save.Location = new System.Drawing.Point(117, 187);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(84, 35);
            this.button_save.TabIndex = 30;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_new.Location = new System.Drawing.Point(26, 187);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(84, 35);
            this.button_new.TabIndex = 29;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(370, 93);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 28;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(370, 51);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(102, 20);
            this.txt_harga.TabIndex = 27;
            // 
            // cmb_satuan
            // 
            this.cmb_satuan.FormattingEnabled = true;
            this.cmb_satuan.Items.AddRange(new object[] {
            "pasang",
            "lusin",
            "buah"});
            this.cmb_satuan.Location = new System.Drawing.Point(370, 7);
            this.cmb_satuan.Name = "cmb_satuan";
            this.cmb_satuan.Size = new System.Drawing.Size(100, 21);
            this.cmb_satuan.TabIndex = 26;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(91, 51);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(134, 20);
            this.txt_nama_barang.TabIndex = 25;
            // 
            // txt_kode_barang
            // 
            this.txt_kode_barang.Enabled = false;
            this.txt_kode_barang.Location = new System.Drawing.Point(91, 7);
            this.txt_kode_barang.Name = "txt_kode_barang";
            this.txt_kode_barang.Size = new System.Drawing.Size(113, 20);
            this.txt_kode_barang.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(292, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(292, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Harga   Rp.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(292, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kode Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(8, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Style";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(8, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Warna";
            // 
            // txt_style
            // 
            this.txt_style.Location = new System.Drawing.Point(91, 93);
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(186, 20);
            this.txt_style.TabIndex = 40;
            // 
            // txt_warna
            // 
            this.txt_warna.Location = new System.Drawing.Point(91, 136);
            this.txt_warna.Name = "txt_warna";
            this.txt_warna.Size = new System.Drawing.Size(100, 20);
            this.txt_warna.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.txt_warna);
            this.panel1.Controls.Add(this.txt_style);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_stock);
            this.panel1.Controls.Add(this.txt_harga);
            this.panel1.Controls.Add(this.cmb_satuan);
            this.panel1.Controls.Add(this.txt_nama_barang);
            this.panel1.Controls.Add(this.txt_kode_barang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 170);
            this.panel1.TabIndex = 42;
            // 
            // FRM_BARANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::merryscol.Properties.Resources.Adolf_Hitler_Nazi_Flag__6_1_;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_new);
            this.Name = "FRM_BARANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_BARANG";
            this.Load += new System.EventHandler(this.FRM_BARANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.ComboBox cmb_satuan;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.TextBox txt_kode_barang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.TextBox txt_warna;
        private System.Windows.Forms.Panel panel1;
    }
}

