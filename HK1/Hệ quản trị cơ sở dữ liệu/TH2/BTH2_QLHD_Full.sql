CREATE DATABASE [QL_HOADON] ON  PRIMARY 
( NAME = N'QL_HOADON', FILENAME = N'D:\TDM\BAI GIANG\2. HQTCSDL\TONG HOP HP HQT CSDL\QUERY\BTH3\QL_HOADON.mdf' , 
	SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_HOADON_log', FILENAME = N'D:\TDM\BAI GIANG\2. HQTCSDL\TONG HOP HP HQT CSDL\QUERY\BTH3\QL_HOADON_log.ldf' , 
	SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
	
USE [QL_HOADON]
GO

CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [smallint] PRIMARY KEY,
	[TenSP] [nvarchar](40) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[DonGia] [money] NULL,
	[SoLuongTon] [int] NULL,
 )
GO
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (1, N'rượu', N'CHAI', 230.5000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (2, N'GIA VỊ', N'THÙNG', 40.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (3, N'BÁNH KEM', N'CÁI', 2.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (4, N'BƠ', N'KG', 15.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (5, N'BÁNH MÌ', N'CÁI', 1.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (6, N'NEM', N'KG', 10.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (7, N'TÁO', N'KG', 5.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (8, N'CÁ HỘP', N'THÙNG', 62.5000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (9, N'KẸO', N'THÙNG', 12.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (10, N'GẠO', N'KG', 2.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (11, N'NẾP', N'KG', 3.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (12, N'SỮA', N'HỘP', 20.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (13, N'BIA', N'THÙNG', 25.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (14, N'BỘT NGỌT', N'KG', 5.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (15, N'ĐƯỜNG', N'KG', 2.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (16, N'CAFÉ', N'HỘP', 20.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (17, N'DẦU ĂN', N'THÙNG', 25.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (18, N'THỊT HỘP', N'THÙNG', 120.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (19, N'TRỨNG', N'THÙNG', 55.0000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonViTinh], [DonGia], [SoLuongTon]) VALUES (20, N'THỊT NGUỘI', N'KG', 50.0000, NULL)
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/12/2015 15:51:57 ******/

CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int]PRIMARY KEY,
	[HoNV] [nvarchar](25) NULL,
	[TenNV] [nvarchar](10) NOT NULL,
	[Phai] [bit] NOT NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](14) NULL,
	[Hinh] [image] NULL)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (1, N'Nguyễn Ngọc', N'nga', 0, CAST(0x00005CA700000000 AS DateTime), N'13 Hùng Vương P4 Q5', N'5465465', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (2, N'hà Vĩnh Phát', N'phát', 1, CAST(0x0000720A00000000 AS DateTime), N'89 Đồng Khởi Q1', N'   8767461', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (3, N'Trần tuyết', N'oanh', 0, CAST(0x00005FD000000000 AS DateTime), N'45 Lê Qúy Đôn Q3', N'   5465465', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (4, N'nguyễn kim', N'ngọc', 0, CAST(0x0000738A00000000 AS DateTime), N'187 Hậu Giang P5 Q6', N'   5654654', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (5, N'TRƯƠNG DUY', N'hùng', 1, CAST(0x0000761800000000 AS DateTime), N'77 Trương Định Q1', N'   5871544', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (6, N'trương bá', N'thắng', 1, CAST(0x0000625C00000000 AS DateTime), N'92 Lê Thánh Tôn Q11', N'   8754165', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (7, N'lâm sơn', N'hoàng', 1, CAST(0x00006F8500000000 AS DateTime), N'45 Ký Con Q1', N'   8231231', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (8, N'nguyễn minh', N'hoàng', 1, CAST(0x0000623300000000 AS DateTime), N'22 Lạc Long Quân Q11', N'   7845138', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (9, N'vương ngọc', N'lan', 0, CAST(0x000060EE00000000 AS DateTime), N'227 Hai Bà Trưng Q1', N'   7784184', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (10, N'nguyễn thị', N'mai', 0, CAST(0x000060D000000000 AS DateTime), N'12 Nguyễn Chí Thanh Q3', N'   3451365', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (11, N'lê văn', N'hùng', 1, CAST(0x0000519300000000 AS DateTime), N'56 Nguyễn Trãi Q1', N'   5745785', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (12, N'nguyễn thị', N'hoa', 0, CAST(0x00005F4400000000 AS DateTime), N'12 Trần Hưng Đạo Q1', N'   5745785', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (13, N'lê thị bích', N'ngọc', 0, CAST(0x00007C2A00000000 AS DateTime), N'34 Nguyễn Thông Q3', N'   3333239', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (14, N'đặng', N'hùng', 1, CAST(0x00007C2A00000000 AS DateTime), N'12/A Hai Bà Trưng Q1', N'   7765889', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoNV], [TenNV], [Phai], [NgaySinh], [DiaChi], [DienThoai], [Hinh]) VALUES (15, N'đoàn', N'khoa', 1, CAST(0x00007D3C00000000 AS DateTime), N'78 Lê Lợi Gò Vấp', N'   7656766', NULL)

CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) PRIMARY KEY,
	[TenKH] [nvarchar](25) NULL,
	[DiaChi] [nvarchar](40) NULL,
	[ThanhPho] [nvarchar](10) NULL,
	[DienThoai] [nvarchar](14) NULL)

INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'bsco', N'CT CHỨNG KHOÁN NHĐT&PTVN', N'146 Nguyễn Công Trứ Q1', N'Sài gòn', N'   8218509')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'cinotec', N'điện toán sài gòn', N'43 Yết Kiêu P6 Q3', N'Sài gòn', N'   7931752')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'comeco', N'vật tư thiết bị vận tải', N'226 An Dương Vương P11 Q11', NULL, N'   8456781')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'fahasa', N'phát hành sách sài gòn', N'12 Thuận Kiều Q5', N'Sài gòn', N'   8452792')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'fisc', N'dịch vụ đầu tư nước ngoài', N'31 Trương Định P6 Q1', N'Sài gòn', N'   8458247')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'hntrco', N'hà nội tourist travel', N'18 Hai Bà Trưng', N'HÀ NỘI', N'   3824310')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'hunsan', N'hừng sáng', N'175 Lý Thường Kiệt TB', NULL, N'   5465487')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'lixco', N'bột giặt lix', N'79 Bàn Cờ P3 Q5', N'Sài gòn', N'   8952187')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'safico', N'thủy sản xuất khẩu', N'47 Bảy Sậy P1 Q11', N'Sài gòn', NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'sjc', N'vàng bạc đá quý tp.hcm', N'350 CMT8 P12 Q5', NULL, N'   8543543')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'tafaco', N'thương mại tân phát', N'4 Trần Phú Q5', N'Sài gòn', N'   8754875')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'thadaco', N'xây dựng thành đạt', N'6E Huỳnh Thúc Kháng BĐ', N'HÀ NỘI', N'   5465454')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'tracodi', N'đầu tư phát triển gtvt', N'343 Nhật Tao Q10', NULL, N'   5321321')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'tranaco', N'dịch vụ vận tải q3', N'156 Lê Đại Hành P7 Q10', N'Sài gòn', N'   8654635')

CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](5) PRIMARY KEY,
	[MaKH] [nvarchar](10) NULL,
	[MaNV] [int] NOT NULL,
	[NgayLapHD] [date] NULL,
	[NgayGiaoHang] [date] NULL)

INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10148', N'FAHASA', 2, CAST(0x23310B00 AS Date), CAST(0x2D310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10149', N'BSCO', 1, CAST(0x2D320B00 AS Date), CAST(0x3B320B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10150', N'hunsan', 4, CAST(0x59310B00 AS Date), CAST(0x92310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10151', N'lixco', 5, CAST(0xDB310B00 AS Date), CAST(0xDD310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10152', N'bsco', 1, CAST(0xEA300B00 AS Date), CAST(0xF2300B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10153', N'hunsan', 2, CAST(0xE9300B00 AS Date), CAST(0x0C310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10154', N'sjc', 10, CAST(0x21320B00 AS Date), CAST(0x36320B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10155', N'safico', 2, CAST(0xF9310B00 AS Date), CAST(0xFE310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10156', N'fisc', 4, CAST(0xEA300B00 AS Date), CAST(0xD6310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10157', N'safico', 2, CAST(0xE8300B00 AS Date), CAST(0x6A310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10158', N'hunsan', 5, CAST(0x08310B00 AS Date), CAST(0x1E310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10159', N'comeco', 8, CAST(0xE7300B00 AS Date), CAST(0x99310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10160', N'thadaco', 11, CAST(0xEB300B00 AS Date), CAST(0x93310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10162', N'cinotec', 7, CAST(0xF7300B00 AS Date), CAST(0x9D310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10163', N'tracodi', 3, CAST(0x58310B00 AS Date), CAST(0x99310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10166', N'sjc', 9, CAST(0xF3300B00 AS Date), CAST(0xDD310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10172', N'tafaco', 9, CAST(0xDD310B00 AS Date), CAST(0xE2310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10175', N'tranaco', 9, CAST(0x59310B00 AS Date), CAST(0xD8310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10177', N'comeco', 2, CAST(0xFB300B00 AS Date), CAST(0x98310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10183', N'safico', 2, CAST(0xDF300B00 AS Date), CAST(0x77310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10186', N'tracodi', 11, CAST(0xE0310B00 AS Date), CAST(0xEF310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10196', N'cinotec', 1, CAST(0x91310B00 AS Date), CAST(0x94310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10202', N'comeco', 4, CAST(0x68310B00 AS Date), CAST(0xE7310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10207', N'sjc', 2, CAST(0x62310B00 AS Date), CAST(0x7F310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10209', N'tracodi', 8, CAST(0x07310B00 AS Date), CAST(0x67310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10210', N'sjc', 1, CAST(0x6F310B00 AS Date), CAST(0xD2310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10214', N'hunsan', 6, CAST(0x9E310B00 AS Date), CAST(0xDD310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10221', N'tracodi', 11, CAST(0xD3310B00 AS Date), CAST(0xEF310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10223', N'sjc', 8, CAST(0xFE300B00 AS Date), CAST(0x19310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10224', N'safico', 7, CAST(0x58310B00 AS Date), CAST(0x72310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10225', N'comeco', 2, CAST(0x60310B00 AS Date), CAST(0x6A310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10226', N'fahasa', 3, CAST(0xDC310B00 AS Date), CAST(0xEF310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10227', N'safico', 8, CAST(0xE8300B00 AS Date), CAST(0x09310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10228', N'hunsan', 2, CAST(0x02310B00 AS Date), CAST(0x25310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10230', N'hunsan', 2, CAST(0xE4310B00 AS Date), CAST(0xE7310B00 AS Date))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayGiaoHang]) VALUES (N'10238', N'lixco', 7, CAST(0xD3310B00 AS Date), CAST(0xEF310B00 AS Date))
/****** Object:  Table [dbo].[CTHOADON]    Script Date: 10/12/2015 15:51:57 ******/

CREATE TABLE [dbo].[CTHOADON](
	[MaHD] [nvarchar](5) PRIMARY KEY,
	[MaSP] [smallint] NOT NULL,
	[SoLuong] [smallint] NULL,
	[DonGiaBan] [money] NULL)
	
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10148', 3, 20, 2.1000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10148', 4, 30, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10148', 9, 20, 12.6000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10149', 2, 22, 42.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10149', 8, 10, 65.6300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10150', 4, 10, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10150', 6, 20, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10150', 7, 30, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10151', 2, 20, 42.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10151', 3, 10, 2.1000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10151', 4, 23, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10152', 7, 22, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10152', 8, 10, 65.6300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10153', 4, 10, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10153', 5, 10, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10154', 10, 4, 2.1000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10156', 8, 20, 65.6300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10157', 3, 4, 2.1000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10157', 4, 50, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10157', 9, 10, 12.6000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10157', 11, 15, 3.1500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10158', 4, 18, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10158', 5, 30, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10158', 6, 50, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10159', 1, 30, 242.0300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10159', 7, 2, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10160', 9, 30, 12.6000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10162', 1, 5, 242.0300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10162', 2, 10, 42.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10162', 7, 12, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10166', 1, 10, 242.0300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10166', 6, 20, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10172', 5, 25, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10175', 8, 20, 65.6300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10183', 4, 12, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10183', 5, 20, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10183', 6, 12, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10186', 6, 50, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10196', 4, 12, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10196', 9, 50, 12.6000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10207', 5, 15, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10209', 7, 20, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10209', 14, 20, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10214', 16, 10, 21.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10224', 9, 22, 12.6000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10225', 1, 10, 242.0300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10225', 4, 7, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10225', 5, 55, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10226', 4, 21, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10226', 6, 110, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10226', 16, 15, 21.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10226', 17, 15, 16.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10227', 2, 15, 42.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10227', 12, 20, 21.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10228', 4, 45, 15.7500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10228', 5, 15, 1.0500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10228', 7, 28, 5.2500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10228', 11, 12, 3.1500)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10230', 2, 30, 42.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10230', 6, 30, 10.5000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10230', 12, 10, 21.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10238', 1, 4, 242.0300)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10238', 2, 10, 42.0000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10238', 3, 12, 2.1000)
INSERT [dbo].[CTHOADON] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES (N'10238', 9, 20, 12.6000)
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 10/12/2015 15:51:57 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_HOADON_NHANVIEN]    Script Date: 10/12/2015 15:51:57 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_CTHOADON_HOADON]    Script Date: 10/12/2015 15:51:57 ******/
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FK_CTHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CTHOADON_SANPHAM]    Script Date: 10/12/2015 15:51:57 ******/
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FK_CTHOADON_SANPHAM]
GO
