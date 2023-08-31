 Create database Hotel_Management1
use Hotel_Management1

Create table tblLoaiPhong
(
	ID varchar(10) not null Primary key,
	TenLoaiPhong nvarchar(30),
	KichThuoc nvarchar(10),
	DonGia int
)

Create table tblPhong
(
	ID int not null Primary key,
	TenPhong nvarchar(40),
	IDLoaiPhong varchar(10) not null,
	TrangThai nvarchar(10) not null
	Constraint FK_tblPhong_tblLoaiPhong Foreign key (IDLoaiPhong) References tblLoaiPhong(ID),
)

Create table tblKhachHang
(
	
	HoTen nvarchar(50) not null,
	CCCD nvarchar(20) Primary key not null,
	DienThoai nvarchar(10),
	QueQuan nvarchar(40),
	HKTT nvarchar(200),
)

Create table tblThuePhong
(
	ID int not null Primary key,
	CCCD nvarchar(20) not null,
	IDPhong int not null,
	GiaPhong int,
	GioThue varchar(50),
	GioTra varchar(50),
	TrangThai nvarchar(20),
	Constraint FK_tblThuePhong_tblKhachHang Foreign key (CCCD) References tblKhachHang(CCCD),
	Constraint FK_tblThuePhong_tblPhong Foreign key (IDPhong) References tblPhong(ID),
)

Create table tblHoaDon
(
	ID int not null,
	CCCD_KH nvarchar(20) not null,
	IDPhong int not null,
	GiaPhong int,
	GioThue varchar(50),
	GioTra varchar(50),
	TrangThai nvarchar(20),
	Constraint FK_tblHoaDon_tblKhachHang Foreign key (CCCD_KH) References tblKhachHang(CCCD),
	Constraint FK_tblHoaDon_tblPhong Foreign key (IDPhong) References tblPhong(ID),
)



Create table tblViTri
(
	ID int primary key not null,
	TenViTri nvarchar(20) not null
)

Create table tblNhanVien
(
	ID int UNIQUE not null,
	TenNhanVien nvarchar(30) not null,
	CCCD nvarchar(20) primary key not null,
	DiaChiHientai nvarchar(100) not null,
	IDViTri int not null,
	Constraint FK_tblNhanVien_tblViTri Foreign key (IDVitri) References tblViTri(ID)
)

Create table tblTaiKhoan
(
	ID int primary key not null,
	IDNV int unique not null,
	TaiKhoan nvarchar(50) unique not null,
	MatKhau nvarchar(150) not null,
	IDVitri int  not null,
	Constraint FK_tblTaiKhoan_tblNhanVien Foreign key (IDNV) References tblNhanVien(ID)
)
	Constraint FK_tblTaiKhoan_tblViTri Foreign key (IDViTri) References tblViTri(ID),

Create table tblCauHinh
(
	TenPhongTro nvarchar(40) Primary key,
	ChuPhongTro nvarchar(40),
	DiaChiPhongTro nvarchar(250),
	SoDienThoai nvarchar(20)
)