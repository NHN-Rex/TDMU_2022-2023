Create Database Hotel_Manager
Use Hotel_Manager

Create table Hotel(
	Hotel_address nvarchar(100) not null,
	Constraint PK_Hotel Primary key (Hotel_Address)
)

insert into Hotel values
('Binh duong'),
('Ninh Thuan'),
('Thu Dau Mot')


Create table Room(
	Room_address Nvarchar(100) not null,
	ID int not null,
	Strart_day Date not null,
	End_day Date not null,
	Size int not null,
	Water_bill int not null,
	Electricity_bill int not null,
	Room_price int not null,
	Constraint PK_Room Primary key (ID),
	Constraint FK_Room_Hotel Foreign key(Room_address) References Hotel(Hotel_address)
)

insert into Room values
('Ninh Thuan', 01, '01/01/2023', '01/02/2023', 4, 10000, 40000, 20000),
('Binh Duong', 02, '01/01/2023', '01/02/2023', 3, 111111, 2000, 300000)


Create table Items_in_room(
	Room_ID int not null,
	Items_name nvarchar(50) not null,
	Number_of_items int not null,
	Items_status nvarchar(50) not null,
	Constraint PK_Items_in_room Primary key (Room_ID),
	Constraint FK_Items_in_room_Room Foreign key(Room_ID) References Room(ID)
)

insert into Items_in_room values
(01, 'Tủ Lạnh', 1, 'Tốt')














