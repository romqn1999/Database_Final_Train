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

go
create procedure CREATE_SINHVIEN
	@mssv		char(10),
	@hoten		nvarchar(50),
	@ngaysinh	date,
	@quequan	nvarchar(50)
as
begin
	insert into taikhoan values
		(@mssv, @mssv)
	insert into sinhvien values
		(@mssv, @hoten, @ngaysinh, @quequan)
end

go
create procedure UPDATE_SINHVIEN
	@mssv		char(10),
	@hoten		nvarchar(50),
	@ngaysinh	date,
	@quequan	nvarchar(50),
	@pass		char(30)
as
begin
	if LEN(@pass) > 0
		update taikhoan set pass = @pass where id = @mssv
	update	sinhvien
	set		hoten = @hoten,
			ngaysinh = @ngaysinh,
			quequan = @quequan			
	where	mssv = @mssv
end

go
create procedure CREATE_MONHOC
	@mamon		char(10),
	@tenmonhoc	nvarchar(50)
as
begin
	insert into monhoc values (@mamon, @tenmonhoc)
end

go
create procedure UPDATE_MONHOC
	@mamon		char(10),
	@mamon_moi	char(10),
	@tenmonhoc	nvarchar(50)
as
begin
	update	monhoc
	set		mamon = @mamon_moi,
			tenmonhoc = @tenmonhoc
	where	mamon = @mamon
end

go
create procedure CREATE_LOP
	@malop	char(10)
as
begin
	insert into lop values (@malop)	
end

go
create procedure UPDATE_LOP
	@malop		char(10),
	@malop_moi	char(10)
as
begin
	update	lop
	set		malop = @malop_moi
	where	malop = @malop
end

go
create procedure CREATE_HOCPHAN
	@malop	char(10),
	@mamon	char(10)
as
begin
	insert into lop_monhoc values (@malop, @mamon)
end

go
create procedure UPDATE_HOCPHAN
	@malop		char(10),
	@mamon		char(10),
	@malop_moi	char(10),
	@mamon_moi	char(10)
as
begin
	update	lop_monhoc
	set		malop = @malop_moi,
			mamon = @mamon_moi
	where	malop = @malop and mamon = @mamon				
end

go
create procedure DANGKY_HP
	@malop		char(10),
	@mamon		char(10),
	@mssv		char(10)
as
begin
	insert into dangky values (@malop, @mamon, @mssv)
end


-- Test	
exec CREATE_SINHVIEN '1712932', 'Lam Nguyen', '1999-06-01', 'Hue'
exec UPDATE_SINHVIEN '1712932', 'Lam Nguyen 1', '1999-06-01', 'Hue', '123456'

select * from sinhvien
select * from taikhoan