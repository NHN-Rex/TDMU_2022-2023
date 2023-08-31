CREATE DATABASE QL_SinhVien2
ON PRIMARY
(
	NAME=QL_Sinh_Vien_Data,
	FILENAME='C:\Users\HOME\Documents\SQL Server Management Studio\QL_Sinh_Vien_Data.mdf',
	SIZE=50MB,
	MAXSIZE=200MB,
	FILEGROWTH=10% 
)
LOG ON
(	NAME=QL_Sinh_Vien_Log,
	FILENAME='C:\Users\HOME\Documents\SQL Server Management Studio\QL_Sinh_Vien_Log.ldf',
	SIZE=10MB,
	MAXSIZE=UNLIMITED,
	FILEGROWTH=5MB)

CREATE TABLE khoa
(
	MaKhoa char(4),
	Tenkhoa Nvarchar(30),
	SiSo Int,
	CONSTRAINT Makhoa_pk PRIMARY KEY(Makhoa)
)

CREATE TABLE Lop
(
	MaLop varchar (10),
	Tenlop Nvarchar(30),
	GVCN Nvarchar(30),
	MaKhoa Char (4) foreign key references khoa,
	SiSo Int,
	Constraint MaLop_pk PRIMARY KEY(MaLop),
)
	
CREATE TABLE SinhVien
(
	MASV VARCHAR(10) PRIMARY KEY ,
	HODEM NVARCHAR(30),
	TEN NVARCHAR(20),
	PHAI BIT,
	NGAYSINH DATE,
	DIACHI NVARCHAR(50),
	DIENTHOAI NVARCHAR(14),
	MaLop varchar (10) 
)

ALTER TABLE SinhVien
add MaLop Varchar(10) foreign key references Lop

CREATE TABLE KETQUA(
	MASV VARCHAR(10) ,
	MAHP VARCHAR(10) ,
	PRIMARY KEY (MASV, MAHP),
	DIEMLAN1 FLOAT ,
	DIEMLAN2 FLOAT 
)

CREATE TABLE HocPhan
(
	MaHP varchar (10),
	TenHP nvarchar(30),
	SoTC INT,
	CONSTRAINT MaHP_pk PRIMARY KEY(MaHP)
)
--c
Alter table KETQUA add Constraint Df_Diem1 default 0 for DiemLan1;
Alter table KETQUA add Constraint Df_Diem2 default 0 for DiemLan2;
ALTER TABLE KETQUA ADD Constraint DiemLan1_kt CHECK (DiemLan1 between 0 and 10);
ALTER TABLE KETQUA ADD Constraint DiemLan2_kt CHECK (DiemLan2 between 0 and 10);
--H
Alter table SINHVIEN add Constraint NgaySinh_kt check ((2022-year(NgaySinh))>=18)
--G--
ALTER TABLE SinhVien
ADD SoCMND INT
Alter table SinhVien
ADD CONSTRAINT U_SoCMND UNIQUE(SoCMND)

--II--
INSERT INTO khoa
VALUES	('CNTT','Công nghệ thông tin','70'),
		('CTXH','Công tác xã hội','50'),
		('DDT','Điện-Điện tử','65'),
		('KHTN','Khoa học tự nhiên','81'),
		('KT','Kinh tế','51'),
		('LLCT','Lý luận chính trị','65'),
		('LS','Lịch sử','65'),
		('LU','Luật','65'),
		('NV','Ngữ Văn','65'),
		('SP','Sư phạm','65')

INSERT INTO HocPhan
VALUES	('CTR','Chính trị','3'),
		('JAVA','Lập trình JAVA','5'),
		('NMTH','Nhập môn tin học','4'),
		('PPLT','Phương pháp lập trình','5'),
		('PTWB','Phát triển web','3'),
		('TRR','Toán rời rạc','3')

INSERT INTO Lop
VALUES	('CKT2A','Kinh tế 2A','Lê Thanh Tùng','KT','45'),
		('CTH1A','Tin học 1A','Nguyễn Văn Minh','CNTT','56'),
		('CTH1B','Tin học 1B','Nguyễn Văn Thắng','CNTT','43'),
		('CTH2B','Tin học 2B','Nguyễn Văn Thắng','CNTT','43'),
		('DLS36A','Lịch sử 36A','Trần Văn Hải','LS','46'),
		('DSP35B','Sư phạm 35B','Nguyễn Hoàng','SP','50'),
		('DTH35A','Tin học 35A','Hoàng Văn Thạch','CNTT','45'),
		('DTH35B','Tin học 35B','Hoàng Văn Thạch','CNTT','45')

INSERT INTO KETQUA
VALUES	('A202','JAVA','4',''),
		('A204','JAVA','7',''),
		('A204','TRR','6.5',''),
		('B101','CTR','3','1'),
		('B101','TRR','8',''),
		('B102','CTR','9','7'),
		('B104','NMTH','8',''),
		('B102','PPLT','7',''),
		('B102','PTWB','2','3'),
		('B102','TRR','9',''),
		('B103','PPLT','7',''),
		('B103','PTWB','6',''),
		('B103','TRR','9','')

INSERT INTO SinhVien
Values	('A202','Tạ Thành','Lâm','False','11/1/1996','172 Nguyễn Du','','CKT2A','1'),
		('A203','Hoàng Minh','Minh','True','11/22/1994','132/12 Lê Lợi','','CKT2A','2'),
		('A204','Lê Thị','Hoa','False','03/12/1996','98 Võ Văn Kiệt','0990789213','CKT2A','3'),
		('B101','Lê Bá','Hải','True','12/12/1993','12 Trương Định','0909081312','CTH1B','4'),
		('B102','Phạm Thị','Hoa','False','01/09/1993','5 Lê Lai Q1','','CTH1B','5'),
		('B103','Lê Vĩnh Phúc','Phúc','True','01/04/1995','12 Phan Văn Trịnh','','CTH1B','6'),
		('B104','Phạm Văn','Hùng','True','09/04/1994','50 Nguyễn Kiệt','0919095413','DLS36A','7'),
		('B105','Nguyễn Thanh','Tâm','True','05/07/1991','45 Lê Quang Định','01689908231','CTH1B','8'),
		('B201','Đỗ','Hoàng','True','09/11/1996','12 Nguyễn Kiệt','01687990912','CTH2B','9'),
		('B202','Trần Thị','Dung','False','10/01/1994','39/12a Nguyễn','','CTH2B','10'),
		('B203','Lê Văn','Lợi','True','01/12/1993','145/1A Nguyễn','NULL','DSP35B','11'),
		('B204','Đặng Trung','Tiến','True','12/22/1995','11/1E Lê Lợi GV','','DTH2B','12'),
		('C3501','Nguyễn Văn','Hùng','True','12/12/1995','45 Bạch Đằng BT','','DTH35A','13'),
		('C3504','Trần Hùng','Hùng','True','12/12/1990','45 Nguyễn Trãi','09907213131','DTH35B','16'),
		('C3601','Nguyễn Hoàng','Nam','True','07/12/1985','12/A Võ Thị Sáu','','DLS36A','19')
		
--III--
--A--
SELECT * ,IIF(B.DIEMLAN1 >=5, 'DAT','KHONG DAT') AS'KETQUA'
FROM SINHVIEN A, KETQUA B
WHERE A.MASV=B.MASV

--B--

--C--
SELECT A.MASV, HODEM + ' ' + TEN AS HOTENSV,
ROUND(AVG(IIF(DIEMLAN1 > ISNULL(DIEMLAN2,0),DIEMLAN1,DIEMLAN2)),1)
AS DIEMTB,
CASE
WHEN ROUND(AVG(IIF(DIEMLAN1 >
ISNULL(DIEMLAN2,0),DIEMLAN1,DIEMLAN2)),1) >= 8 THEN N'GIỎI'
WHEN ROUND(AVG(IIF(DIEMLAN1 >
ISNULL(DIEMLAN2,0),DIEMLAN1,DIEMLAN2)),1) >= 6.5 THEN N'KHÁ'
WHEN ROUND(AVG(IIF(DIEMLAN1 >
ISNULL(DIEMLAN2,0),DIEMLAN1,DIEMLAN2)),1) >=5 THEN N'TRUNG BÌNH'
ELSE N'YẾU'
END AS XEPLOAI
FROM SINHVIEN A, KETQUA B
WHERE A.MASV = B.MASV
GROUP BY A.MASV, HODEM + ' ' + TEN

-- IV 
  --A--
   create view  Diemthi
	as
	  select   A.MASV,HODEM,Ten, TenHP, DiemLan1,DiemLan2
	  from SINHVIEN A, KETQUA B,HOCPHAN C
	  where A.MASV=B.MASV and B.MAHP=C.MAHP
  --B--
   create view TLH
   as 
     select DISTINCT A.MaSV , HoDem, Ten , C.TenHP ,Diemlan1, diemlan2
	 from SINHVIEN A, KETQUA B ,HOCPHAN C,LOP D
	 where A.MASV=B.MASV AND B.MAHP=C.MAHP AND A.MaLop=D.MALOP AND D.MAKHOA='CNTT'
