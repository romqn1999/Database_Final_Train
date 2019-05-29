create database QLSV
go

use QLSV
go

create table sinhvien
(
	mssv char(10) not null,
	hoten nvarchar(50),
	ngaysinh date,
	quequan nvarchar(50)
)

create table taikhoan
(
	id char(10) not null,
	pass char(30)
)

create table lop
(
	malop char(10) not null
)

create table monhoc
(
	mamon char(10) not null,
	tenmonhoc nvarchar(50)
)

create table lop_monhoc
(
	malop char(10) not null,
	mamon char(10) not null
)

create table dangky
(
	malop char(10) not null,
	mamon char(10) not null,
	mssv char(10) not null
)


alter table taikhoan add
	constraint pk_taikhoan primary key (id)

alter table sinhvien add
	constraint pk_sinhvien primary key (mssv),
	constraint fk_sinhvien_mssv foreign key (mssv) references taikhoan(id)

alter table lop add
	constraint pk_lop primary key (malop)

alter table monhoc add
	constraint pk_monhoc primary key (mamon)

alter table lop_monhoc add
	constraint pk_lop_monhoc primary key (malop, mamon),
	constraint fk_lop_monhoc_malop foreign key (malop) references lop(malop),
	constraint fk_lop_monhoc_mamon foreign key (mamon) references monhoc(mamon)

alter table dangky add
	constraint pk_dangky primary key (malop, mamon, mssv),
	constraint fk_dangky_malop_mamon foreign key (malop, mamon) references lop_monhoc(malop, mamon),
	constraint fk_dangky_mssv foreign key (mssv) references sinhvien(mssv)

insert into taikhoan (id, pass) values
('admin', 'admin'),
('1712001', 'a'),
('1712002', 'a'),
('1712003', 'a'),
('1712004', 'a'),
('1712005', 'a'),
('1712006', 'a'),
('1712007', 'a'),
('1712008', 'a'),
('1712009', 'a'),
('1712010', 'a')

insert into sinhvien (mssv, hoten, ngaysinh, quequan) values 
('1712001', N'Nguyễn Văn A', '02-01-1999', N'Hồ Chí Minh'),
('1712002', N'Trần Văn A', '04-12-1999', N'Huế'),
('1712003', N'Nguyễn Thị B', '12-24-1999', N'Đà Nẵng'),
('1712004', N'Trần Thanh C', '03-03-1999', N'Hồ Chí Minh'),
('1712005', N'Trần Nguyễn Thanh A', '12-12-1999', N'Hồ Chí Minh'),
('1712006', N'Lý Thiên E', '09-18-1999', N'Huế'),
('1712007', N'Trần Thị Thu T', '02-27-1999', N'Hà Nội'),
('1712008', N'Nguyễn Văn X', '5-28-1999', N'Hồ Chí Minh'),
('1712009', N'Trần Y', '06-15-1999', N'Huế'),
('1712010', N'Nguyễn Thị Z', '01-30-1999', N'Hồ Chí Minh')

insert into monhoc (mamon, tenmonhoc) values
('AA1', N'Môn học 1'),
('AA2', N'Môn học 2'),
('CS1', N'Cơ sở 1'),
('CS2', N'Cơ sở 2'),
('DC1', N'Đai cương 1'),
('DC2', N'Đại cương 2'),
('CN1', N'Chuyên ngành 1'),
('CN2', N'Chuyên ngành 2')

insert into lop(malop) values
('17CNTN'),
('17CTT1'),
('17CTT2'),
('17CTT3'),
('17CTT4')

insert into lop_monhoc(malop, mamon) values
('17CNTN', 'AA1'),
('17CNTN', 'DC1'),
('17CNTN', 'CS2'),
('17CNTN', 'CN1'),
('17CTT1', 'AA1'),
('17CTT1', 'AA2'),
('17CTT2', 'AA2'),
('17CTT2', 'DC2'),
('17CTT3', 'DC1'),
('17CTT4', 'DC1')

insert into dangky (malop, mamon, mssv) values 
('17CNTN', 'AA1', '1712001'),
('17CNTN', 'AA1', '1712003'),
('17CNTN', 'AA1', '1712009'),
('17CTT1', 'AA1', '1712002'),
('17CTT1', 'AA1', '1712003'),
('17CTT1', 'AA1', '1712004'),
('17CTT2', 'DC2', '1712001'),
('17CTT2', 'DC2', '1712007'),
('17CTT2', 'DC2', '1712008'),
('17CTT3', 'DC1', '1712009'),
('17CTT4', 'DC1', '1712010')