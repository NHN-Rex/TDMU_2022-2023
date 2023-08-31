create database  Quan_Li_SV

on primary (
     Name = Quan_Li_SV_data,
	 FileName = 'D:\CSDL\Quan_Li_SV_data.MDF',
	 Size = 10mb,
	 maxsize = 100mb,
	 FileGrowth = 5mb

)
Log on (
  Name = Quan_Li_SV_log,
  Filename = 'D:\CSDL\Quan_Li_SV_log.ldf',
  Size = 10mb,
  maxsize = 100mb,
  FileGrowth = 5mb


)

go

use Quan_Li_SV

go

-- Tạo bảng 

   create table Nhanvien (
    MaNV int  PRIMARY KEY,
	TenNV Nvarchar (50) ,
	NgaySinh Date ,
	GioiTinh bit ,


   );
   create table DuAn(
    MaDA int  IDENTITY(1,1) primary key,
	TenDA  Nvarchar (50) ,
	NgayBD smalldatetime ,
	NgayKT smalldatetime,
   
   );

   create table ThamGia (
     MaNV int ,
	 MaDA int ,
	 NgayVaoDA smalldatetime  ,
	 NgayRaDA smalldatetime,
	 CONSTRAINT ThamGia_PK Primary key (MaNV,MaDA,NgayVaoDA)
   );

   
                                            -- Dữ Liệu
   -- Nhan Vien
    insert into Nhanvien 
	values (1,'Nguyen Hoang Anh ', '01-19-1995', 0)

	insert into Nhanvien
	values (2,'Tran Nhu Binh','3-3-1990',1)

	insert into Nhanvien
	values (3,'Nguyen Van Linh','1-30-1988',Null)

	insert into Nhanvien
	values (4,'Vo Thai Ha','2-3-1992',Null)

	insert into Nhanvien
	values (5,'Ho Thu Nga','4-2-1995',0)
   -- DuAn
     insert into DuAn
	 values  ('phan mem quan li truong hoc','2-2-2015','5-5-2017')

	 insert into DuAn
	 values ( 'He thong du bao thoi tiet','3-3-2015','8-3-2018')

	 insert into DuAn
	 values ( 'He thong xac thuc van tay','3-7-2015','8-5-2018')

   -- ThamGia
      insert into ThamGia
	  values (1,1,'3-3-2016','5-4-2017')

	  insert into ThamGia
	  values (2,1,'2-2-2014','5-5-2017')

	  insert into ThamGia
	  values (1,2,'3-3-2015','5-5-2018')

	  insert into ThamGia
	  values (3,2,'3-3-2015','4-4-2017')

-- Cau 2 

--2.1  DEFAULT 

   ALTER TABLE Nhanvien 
   ADD CONSTRAINT df_GioiTinh default '1' for GioiTinh;

--2.2 RẰNG BUỘC KHÓA NGOẠI

   ALTER TABLE ThamGia
   ADD Foreign key (MaNV) REFERENCES NhanVien(MaNV)

--2.3 RẰNG BUỘC KHÓA NGOẠI

   ALTER TABLE ThamGia
   ADD FOREIGN KEY (MaDA) REFERENCES DuAn(MaDA)

--2.4  SỬA DỮ LIỆU

   ALTER TABLE DuAn
   ALTER Column  TenDA Nvarchar (200)

--2.5 thêm cột 
     ALTER TABLE ThamGia 
	 ADD LyDoRADA Nvarchar (300)
   
 -- De xem thay đổi dự liệu ấn vào desgin  

 
--Cau 3

 

  




--Cau 4 Truy Vấn 

--A Viết truy vấn hiện ra tên dự án, ứng với mỗi dự án có số lượng người tham gia. Nếu dự án không có người tham gia thì số lượng là 0.

    select A.TenDA , count(MANV) AS 'So luong nguoi'
    from DuAn A left join ThamGia B on A.MaDA=B.MaDA
	group by TenDA

--B  Viết câu lệnh truy vấn hiện ra bảng như sau. Trong đó giới tính là 0 hiện ra "Nam", là 1 hiện ra "Nữ", trường hợp khác hiện ra "Không rõ".
    select GioiTinh,
	case
	   when GioiTinh =1 then 'Nam'
	   when GioiTinh =0 then 'Nu'
	   else 'Không la gi ca'
	end AS GioiTinh
	from Nhanvien 

--C Hãy cho biết tên các đề án có nhiều nhân viên tham gia nhất.

  select TOP(1) A.TenDA
  from DuAn  , (select A.TenDA , count (MaNV) as 'so luong' from DuAn A left join ThamGia B on A.MaDA=B.MaDA 
  Group by A.TenDA ) A
  where DuAn.TenDA=A.TenDA 
  order by [so luong] desc


--D Hãy cho biết tên các đề án chưa có nhân viên nào tham gia

  select  A.TenDA
  from DuAn  , (select A.TenDA , count (MaNV) as 'so luong' from DuAn A left join ThamGia B on A.MaDA=B.MaDA 
  Group by A.TenDA ) A
  where DuAn.TenDA=A.TenDA and [so luong]=0

--E Hãy cho biết tên của nhân viên nhỏ tuổi nhất đã từng tham gia đề án.

  select Top(1) A.TenNV ,min((DATEDIFF(yyyy,NGaySINH,CURRENT_TIMESTAMP)))
  from Nhanvien A
  group by A.TenNV

--F Hãy cập nhật giới tính là 1 cho những nhân viên chưa có thông tin về giới tính (giới tính bằng null).

     update Nhanvien set GioiTinh=1 where GioiTinh IS NUll

-- G 
   select A.SoLuongNam ,SoLuongNu 
   From  (select COUNT(MANv) AS 'SoLuongNam' from Nhanvien where GioiTinh=0) A,
   (select COUNT(MANv) AS 'SoLuongNu' from Nhanvien where GioiTinh=1) B

-- H
  
   select Top(1) TenDA 
   from (select TenDa , Datediff(DAY ,NgayBD,NgayKT) as 'Ngay' from DuAn ) A
   order by Ngay Desc
     
--câu 5 
    -- a  a.Tạo khung nhìn NhanVienDuAn để xem được tên dự án và tên nhân viên tham gia dự án đồng thời với ngày vào và ngày ra khỏi dự án.
	
	create view NhanVienDuAn
	 as
	   select TenDA, TenNV , NgayVaoDA ,NgayRaDA
	   from Nhanvien A ,ThamGia B,DuAn C
	   where A.MaNV=B.MaNV and B.MaDA=C.MaDA

   -- b.Tạo khung nhìn hiển thị tên, tuổi và giới tính của những nhân viên chưa tham gia dự án.

      create view Ten_Age
	  as
	    select TenNV ,(DATEDIFF(yyyy,NGaySINH,CURRENT_TIMESTAMP)) as 'Tuổi',GioiTinh
		from Nhanvien, (select A.TenDA , count (MaNV) as 'so luong' from DuAn A left join ThamGia B on A.MaDA=B.MaDA 
  Group by A.TenDA ) A
   
-- Câu 7
-- a.Tạo trigger KiemTraThamGia để kiểm tra mỗi khi chèn vào bảng Thamgia. Nếu số dự án đã tham gia quá ba dự án thì không cho phép và báo lỗi 'Không được tham gia quá 3 dự án ra màn hình.
     
	  create trigger tg_KiemTraThamGia
	  on Nhanvien
	  for insert 
	  as
	  begin
	       if ( select (DATEDIFF(yyyy,NGaySINH,CURRENT_TIMESTAMP)) from Nhanvien) <40 
		      begin 
			  print N'Khong cho phep chen vao'
			  rollback transaction 
			  end
	end

		     



		    
	
-- Câu 8
--  a.Nhập vào mã nhân viên, cho biết số dự án mà họ tham gia.

     create function NhanVien_1(@Manv int )
	 returns table 
	 as
     return 
	       select MaDA
		   from ThamGia 
		   where ThamGia.MaNV=@Manv

 
   select count(MaDa) from NhanVien_1 (1)
   

--b Nhập vào mã đề án, cho biết số lượng nhân viên tham gia đề án đó.

     create function SL_NhanVien (@MaDa int)
	 returns table 
	 as
	 return 
	        select Manv
			from ThamGia left join DuAn on ThamGia.MaDA=DuAn.MaDA
			where ThamGia.MaDA=@MaDa

  select count (MaNv) as'So Luong Nhan Vien'  from SL_NhanVien (1)
    