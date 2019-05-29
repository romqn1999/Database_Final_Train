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

