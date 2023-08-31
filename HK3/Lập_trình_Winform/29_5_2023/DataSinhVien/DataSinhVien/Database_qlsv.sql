Create database QLSV
Use QLSV

Create table tblsinhvien(
	MaSV nvarchar(20) not null,
	TenSV nvarchar(30) not null,
	GioiTinh nvarchar(4) not null,
	NgaySinh date not null,
	quequan nvarchar(40) not null,
	malop nvarchar(10) not null,
)

insert into tblsinhvien(masv, TenSV, GioiTinh, NgaySinh, quequan, malop) values
('111', 'Nguyen Huu Nghia', 'Nam', '06/06/2003', 'Ninh Thuan', 'D21TNTT01'),
('222', 'Luc Tan Khoa', 'Nam', '06/02/2003', 'Ninh Thuan', 'D21TNTT01'),
('333', 'Nguyen Minh Tuyen', 'Nu', '06/05/2003', 'Binh Duong', 'D21HTTT01')

drop table tblsinhvien

select * from tblsinhvien