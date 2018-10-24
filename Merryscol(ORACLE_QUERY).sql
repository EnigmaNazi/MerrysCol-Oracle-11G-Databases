CREATE TABLE  "LOGIN" 
   (	"USERNAME" VARCHAR2(50) NOT NULL ENABLE, 
	"PASSWORD" VARCHAR2(50), 
	"STATUS" VARCHAR2(50), 
	 PRIMARY KEY ("USERNAME") ENABLE
   )

CREATE TABLE  "BARANG" 
   (	"KODE_BARANG" VARCHAR2(15) NOT NULL ENABLE, 
	"NAMA_BARANG" VARCHAR2(50), 
	"STYLE" VARCHAR2(50), 
	"WARNA" VARCHAR2(50), 
	"SATUAN" VARCHAR2(50), 
	"HARGA" FLOAT(126), 
	"STOCK" NUMBER, 
	 PRIMARY KEY ("KODE_BARANG") ENABLE
   )

CREATE TABLE  "SUPPLIER" 
   (	"KODE_SUPPLIER" VARCHAR2(15) NOT NULL ENABLE, 
	"NAMA_SUPPLIER" VARCHAR2(50), 
	"TELP_SUPPLIER" VARCHAR2(15), 
	"ALAMAT_SUPPLIER" VARCHAR2(500), 
	 PRIMARY KEY ("KODE_SUPPLIER") ENABLE
   )

CREATE TABLE  "PELANGGAN" 
   (	"KODE_PELANGGAN" VARCHAR2(15) NOT NULL ENABLE, 
	"NAMA_PELANGGAN" VARCHAR2(50), 
	"TELP_PELANGGAN" VARCHAR2(15), 
	"ALAMAT_PELANGGAN" VARCHAR2(50), 
	 PRIMARY KEY ("KODE_PELANGGAN") ENABLE
   )

CREATE TABLE  "ORDER_BARANG" 
   (	"NO_ORDER" VARCHAR2(15) NOT NULL ENABLE, 
	"KODE_SUPPLIER" VARCHAR2(15), 
	"KODE_BARANG" VARCHAR2(15) NOT NULL ENABLE, 
	"JUMLAH_ORDER" NUMBER, 
	"KETERANGAN" VARCHAR2(500), 
	"TGL_ORDER" DATE, 
	 PRIMARY KEY ("KODE_BARANG") ENABLE
   )

CREATE TABLE  "ORDER_BARANG_DETAIL" 
   (	"NO_ORDER" VARCHAR2(15), 
	"KODE_SUPPLIER" VARCHAR2(15), 
	"KODE_BARANG" VARCHAR2(15), 
	"JUMLAH_ORDER" NUMBER, 
	"KETERANGAN" VARCHAR2(500), 
	"TGL_ORDER" DATE
   )

CREATE TABLE  "PENERIMAAN" 
   (	"NO_PENERIMAAN" VARCHAR2(15) NOT NULL ENABLE, 
	"KODE_SUPPLIER" VARCHAR2(15), 
	"KODE_BARANG" VARCHAR2(15) NOT NULL ENABLE, 
	"JUMLAH_TERIMA" FLOAT(126), 
	"KETERANGAN" VARCHAR2(500), 
	"TGL_PENERIMAAN" DATE, 
	 PRIMARY KEY ("KODE_BARANG") ENABLE
   )

CREATE TABLE  "PENERIMAAN_DETAIL" 
   (	"NO_PENERIMAAN" VARCHAR2(15), 
	"KODE_SUPPLIER" VARCHAR2(15), 
	"KODE_BARANG" VARCHAR2(15), 
	"JUMLAH_TERIMA" FLOAT(126), 
	"KETERANGAN" VARCHAR2(500), 
	"TGL_PENERIMAAN" DATE
   )

CREATE TABLE  "PENJUALAN" 
   (	"NO_PENJUALAN" VARCHAR2(15) NOT NULL ENABLE, 
	"KODE_PELANGGAN" VARCHAR2(15), 
	"KODE_BARANG" VARCHAR2(15) NOT NULL ENABLE, 
	"JUMLAH_BELI" FLOAT(126), 
	"SUBTOTAL" FLOAT(126), 
	"KETERANGAN" VARCHAR2(500), 
	"TGL_PENJUALAN" DATE, 
	"TGL_PENERIMAAN" DATE, 
	 PRIMARY KEY ("KODE_BARANG") ENABLE
   )

CREATE TABLE  "PENJUALAN_DETAIL" 
   (	"NO_PENJUALAN" VARCHAR2(15), 
	"KODE_PELANGGAN" VARCHAR2(15), 
	"KODE_BARANG" VARCHAR2(15), 
	"JUMLAH_BELI" FLOAT(126), 
	"SUBTOTAL" FLOAT(126), 
	"KETERANGAN" VARCHAR2(500), 
	"TGL_PENJUALAN" DATE, 
	"TGL_PENERIMAAN" DATE
   )

INSERT INTO barang (kode_barang, nama_barang, style, warna, satuan, harga, stock) VALUES ('BRG0001', 'Jaket', 'Selena Gemez', 'Gray', 'buah', 2000000, 25)
INSERT INTO barang (kode_barang, nama_barang, style, warna, satuan, harga, stock) VALUES ('BRG0002', 'Sepatu Juling', 'Selna Juling', 'Merah', 'pasang', 4000000, 58)
INSERT INTO barang (kode_barang, nama_barang, style, warna, satuan, harga, stock) VALUES ('BRG0003', 'Dompet kambing', 'John F', 'Merah', 'buah', 500000, 56)
INSERT INTO barang (kode_barang, nama_barang, style, warna, satuan, harga, stock) VALUES ('BRG0004', 'Jaket Coeg', 'Justin Bieber', 'Biru', 'buah', 3000000, 50)
INSERT INTO barang (kode_barang, nama_barang, style, warna, satuan, harga, stock) VALUES ('BRG0005', 'Sepatu Andora', 'Selena Gomez', 'Merah', 'pasang', 3000000, 30)

INSERT INTO login (username, password, status) VALUES ('hans', '123', 'aktif')

INSERT INTO order (no_order, kode_supplier, kode_barang, jumlah_order, keterangan, tgl_order) VALUES ('ORD0001', 'SPL0001', 'BRG0002', 6, '-', '2017-04-09')

INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, telp_pelanggan, alamat_pelanggan) VALUES ('PLG0001', 'Bejo', '089967784367', 'Kedaton')
INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, telp_pelanggan, alamat_pelanggan) VALUES ('PLG0002', 'Paijo', '087709980099', 'Karang')
INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, telp_pelanggan, alamat_pelanggan) VALUES ('PLG0003', 'Painem', '081234435667', 'Karang')
INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, telp_pelanggan, alamat_pelanggan) VALUES ('PLG0004', 'Sugianto', '082256668899', 'Kedaton')
INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, telp_pelanggan, alamat_pelanggan) VALUES ('PLG0005', 'Sugik', '089866605554', 'Kedaton')

INSERT INTO penerimaan (no_penerimaan, kode_supplier, kode_barang, jumlah_terima, keterangan, tgl_penerimaan) VALUES ('PNM0002', 'SPL0001', 'BRG0002', 4, '-', '2017-04-19')
INSERT INTO penerimaan (no_penerimaan, kode_supplier, kode_barang, jumlah_terima, keterangan, tgl_penerimaan) VALUES ('PNM0002', 'SPL0001', 'BRG0003', 4, '-', '2017-05-16')

INSERT INTO penerimaan_detail (no_penerimaan, kode_supplier, kode_barang, jumlah_terima, keterangan, tgl_penerimaan) VALUES ('PNM0001', 'SPL0001', 'BRG0002', 20, '-', '2017-04-19')

INSERT INTO penjualan (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0004', 'PLG0001', 'BRG0002', 4, 16000000, '-', '2017-04-14', '2017-04-14')

INSERT INTO penjualan_detail (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0001', 'PLG0001', 'BRG0001', 7, 14000000, '-', '2017-04-08', '2017-04-20')
INSERT INTO penjualan_detail (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0001', 'PLG0001', 'BRG0002', 2, 8000000, '-', '2017-04-08', '2017-04-20')
INSERT INTO penjualan_detail (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0002', 'PLG0002', 'BRG0001', 7, 14000000, '-', '2017-04-08', '2017-04-27')
INSERT INTO penjualan_detail (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0002', 'PLG0002', 'BRG0002', 9, 36000000, '-', '2017-04-08', '2017-04-27')
INSERT INTO penjualan_detail (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0003', 'PLG0003', 'BRG0001', 6, 12000000, '-', '2017-04-08', '2017-04-12')
INSERT INTO penjualan_detail (no_penjualan, kode_pelanggan, kode_barang, jumlah_beli, subtotal, keterangan, tgl_penjualan, tgl_penerimaan) VALUES ('PNJ0003', 'PLG0001', 'BRG0003', 8, 4000000, '-', '2017-04-09', '2017-04-17')

INSERT INTO supplier (kode_supplier, nama_supplier, telp_supplier, alamat_supplier) VALUES ('SPL0001', 'Suyono', '089978786667', 'Waysido')
INSERT INTO supplier (kode_supplier, nama_supplier, telp_supplier, alamat_supplier) VALUES ('SPL0002', 'Rianto', '089788897676', 'Kedatron')
INSERT INTO supplier (kode_supplier, nama_supplier, telp_supplier, alamat_supplier) VALUES ('SPL0003', 'Toyotu', '082133456565', 'Karang')
INSERT INTO supplier (kode_supplier, nama_supplier, telp_supplier, alamat_supplier) VALUES ('SPL0004', 'Brodot', '089976765634', 'Kedaton')