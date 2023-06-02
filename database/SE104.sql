CREATE DATABASE QUANLYTHUVIEN;
GO

USE QUANLYTHUVIEN;
GO

SET DATEFORMAT DMY;
GO

CREATE TABLE DOCGIA (
	MaDocGia int identity(1,1) primary key,
	HoTen nvarchar(50) not null,
	GioiTinh nvarchar(4) not null,
	NgaySinh date not null,
	CMND varchar(12) not null unique,
	SDT varchar(12) not null,
	Email varchar(50),
	NgayLapThe date not null,
	NgayHetHan date not null,
	TongPhat money not null default 0,
	TienNo money not null default 0,
	constraint chk_GioiTinh check (GioiTinh in (N'Nam', N'Nữ', N'Khác')),
	constraint chk_NgaySinh check (year(NgaySinh) > 1900),
	constraint chk_CMND check (len(CMND) = 9 or len(CMND) = 12),
	constraint chk_NgayLapThe check (NgayLapThe >= dateadd(year, 14, NgaySinh) and NgayLapThe <= cast(getdate() as date)),
	constraint chk_NgayHetHan check (NgayHetHan >= dateadd(month, 6, NgayLapThe)),
	constraint chk_TongPhat check (TongPhat >= TienNo),
	constraint chk_TienNo check (TienNo >= 0)
);

CREATE TABLE SACH (
	MaSach int identity(1,1) primary key,
	TenSach nvarchar(50) not null,
	TacGia nvarchar(50) not null,
	NamXB int not null,
	NhaXB nvarchar(50) not null,
	NgonNgu nvarchar(20) not null,
	SoLuong int not null,
	TriGia money not null,
	constraint chk_NamXB check (NamXB > 1900 and NamXB <= year(getdate())),
	constraint chk_SoLuong check (SoLuong >= 0),
	constraint chk_TriGia check (TriGia > 0)
);

CREATE TABLE MUONSACH (
	MaMuonSach int identity(1,1) primary key,
	MaDocGia int foreign key references DOCGIA(MaDocGia),
	MaSach int foreign key references SACH(MaSach) on delete set null,
	NgayMuon date not null,
	HanTra date not null,
	constraint chk_NgayMuon check (NgayMuon <= cast(getdate() as date)),
	constraint chk_HanTra check (HanTra > NgayMuon)
);

CREATE TABLE TRASACH (
	MaMuonSach int primary key,
	NgayTra date not null,
	TienPhat money not null default 0,
	foreign key (MaMuonSach) references MUONSACH(MaMuonSach),
	constraint chk_NgayTra check (NgayTra <= cast(getdate() as date)),
	constraint chk_TienPhat check (TienPhat >= 0)
);

CREATE TABLE THUTIEN (
	MaThuTien int identity(1,1) primary key,
	MaDocGia int foreign key references DOCGIA(MaDocGia),
	NgayThu date not null,
	TienThu money not null,
	constraint chk_NgayThu check (NgayThu <= cast(getdate() as date)),
	constraint chk_TienThu check (TienThu > 0)
);
GO

CREATE TRIGGER trg_ThemDocGia ON DOCGIA FOR INSERT AS
BEGIN
	if exists (select * from inserted where TongPhat != 0 or TienNo != 0)
	begin
		raiserror(N'DOCGIA: Không được thay đổi tổng phạt hoặc tiền nợ.', 11, 1);
		rollback;
	end;
END;
GO

CREATE TRIGGER trg_XoaDocGia ON DOCGIA INSTEAD OF DELETE AS
BEGIN
	delete from THUTIEN where MaDocGia in (select MaDocGia from deleted);
	delete from MUONSACH where MaDocGia in (select MaDocGia from deleted);
	delete from DOCGIA where MaDocGia in (select MaDocGia from deleted);
END;
GO

CREATE TRIGGER trg_SuaDocGia ON DOCGIA FOR UPDATE AS
BEGIN
	if exists (select * from inserted, deleted
	where inserted.MaDocGia = deleted.MaDocGia and inserted.NgayHetHan < deleted.NgayHetHan)
	begin
		raiserror(N'DOCGIA: Chỉ cho phép gia hạn ngày hết hạn.', 11, 1);
		rollback;
	end;
END;
GO

CREATE TRIGGER trg_ThemMuonSach ON MUONSACH FOR INSERT AS
BEGIN
	if exists (select * from inserted where MaSach is null)
	begin
		raiserror(N'MUONSACH: Mã sách trống.', 11, 1);
		rollback;
	end;

	else if exists (select * from inserted, DOCGIA dg
	where inserted.MaDocGia = dg.MaDocGia and NgayMuon > NgayHetHan)
	begin
		raiserror(N'MUONSACH: Thẻ độc giả hết hạn.', 11, 1);
		rollback;
	end;

	else if exists (select MaDocGia, count(ms.MaMuonSach)
	from MUONSACH ms left join TRASACH ts on ms.MaMuonSach = ts.MaMuonSach
	where MaDocGia in (select MaDocGia from inserted) and ts.MaMuonSach is null
	group by MaDocGia having count(ms.MaMuonSach) > 5)
	begin 
		raiserror(N'MUONSACH: Độc giả chỉ được mượn tối đa 5 quyển sách.', 11, 1);
		rollback;
	end;

	else
	begin
		update SACH set SoLuong -= cnt
		from SACH s
		inner join
		(select MaSach, count(MaMuonSach) as cnt
		from inserted group by MaSach) as x
		on x.MaSach = s.MaSach;
	end;
END;
GO

CREATE TRIGGER trg_XoaMuonSach ON MUONSACH INSTEAD OF DELETE AS
BEGIN
	update SACH set SoLuong += cnt
	from SACH s
	inner join
	(select deleted.MaSach, count(deleted.MaMuonSach) as cnt
	from deleted, MUONSACH ms
	where deleted.MaMuonSach = ms.MaMuonSach
	group by deleted.MaSach) as x
	on x.MaSach = s.MaSach;

	delete from TRASACH where MaMuonSach in (select MaMuonSach from deleted);
	delete from MUONSACH where MaMuonSach in (select MaMuonSach from deleted);
END;
GO

CREATE TRIGGER trg_SuaMuonSach ON MUONSACH FOR UPDATE AS
BEGIN
	if exists (select * from inserted, DOCGIA dg
	where inserted.MaDocGia = dg.MaDocGia and NgayMuon > NgayHetHan)
	or
	exists (select * from TRASACH ts, inserted
	where ts.MaMuonSach = inserted.MaMuonSach and NgayTra < NgayMuon)
	begin
		raiserror(N'MUONSACH: Ngày mượn không hợp lệ.', 11, 1);
		rollback;
	end;
END;
GO

CREATE TRIGGER trg_ThemTraSach ON TRASACH FOR INSERT AS
BEGIN
	if exists (select * from MUONSACH ms, inserted
	where ms.MaMuonSach = inserted.MaMuonSach and NgayTra < NgayMuon)
	begin
		raiserror(N'TRASACH: Ngày trả không hợp lệ.', 11, 1);
		rollback;
	end;

	else if exists (select * from inserted where TienPhat != 0)
	begin
		raiserror(N'TRASACH: Không được thay đổi tiền phạt.', 11, 1);
		rollback;
	end;

	else
	begin
		update SACH set SoLuong += cnt
		from SACH s
		inner join
		(select MaSach, count(inserted.MaMuonSach) as cnt
		from inserted, MUONSACH ms
		where inserted.MaMuonSach = ms.MaMuonSach
		group by MaSach) as x
		on x.MaSach = s.MaSach;

		update TRASACH set TienPhat = 1000 * diff
		from TRASACH ts
		inner join
		(select inserted.MaMuonSach, datediff(day, HanTra, NgayTra) as diff
		from MUONSACH ms, inserted where ms.MaMuonSach = inserted.MaMuonSach) as x
		on ts.MaMuonSach = x.MaMuonSach
		where diff > 0;

		update DOCGIA set TongPhat += total, TienNo += total
		from DOCGIA dg
		inner join
		(select MaDocGia, sum(TienPhat) as total
		from MUONSACH ms, TRASACH ts
		where ms.MaMuonSach = ts.MaMuonSach and ms.MaMuonSach in (select MaMuonSach from inserted)
		group by MaDocGia) as x
		on dg.MaDocGia = x.MaDocGia
	end;
END;
GO

CREATE TRIGGER trg_XoaTraSach ON TRASACH FOR DELETE AS
BEGIN
	update SACH set SoLuong -= cnt
	from SACH s
	inner join
	(select MaSach, count(deleted.MaMuonSach) as cnt
	from deleted, MUONSACH ms
	where deleted.MaMuonSach = ms.MaMuonSach
	group by MaSach) as x
	on x.MaSach = s.MaSach;

	update DOCGIA set TongPhat -= total, TienNo -= total
	from DOCGIA dg
	inner join
	(select MaDocGia, sum(TienPhat) as total
	from MUONSACH ms, deleted
	where ms.MaMuonSach = deleted.MaMuonSach
	group by MaDocGia) as x
	on dg.MaDocGia = x.MaDocGia;
END;
GO

CREATE TRIGGER trg_SuaTraSach ON TRASACH FOR UPDATE AS
BEGIN
	if exists (select * from MUONSACH ms, inserted
	where ms.MaMuonSach = inserted.MaMuonSach and NgayTra < NgayMuon)
	begin
		raiserror(N'TRASACH: Ngày trả không hợp lệ.', 11, 1);
		rollback;
	end;
END;
GO

CREATE TRIGGER trg_ThemThuTien ON THUTIEN FOR INSERT AS
BEGIN
	if exists (select inserted.MaDocGia, TienNo, sum(TienThu) from inserted, DOCGIA dg
	where inserted.MaDocGia = dg.MaDocGia
	group by inserted.MaDocGia, TienNo having sum(TienThu) > TienNo)
	begin
		raiserror(N'THUTIEN: Tiền thu không được lớn hơn tiền nợ.', 11, 1);
		rollback;
	end;

	else
	begin
		update DOCGIA set TienNo -= total
		from DOCGIA dg
		inner join
		(select MaDocGia, sum(TienThu) as total from inserted group by MaDocGia) as x
		on dg.MaDocGia = x.MaDocGia
	end;
END;
GO

CREATE TRIGGER trg_XoaThuTien ON THUTIEN FOR DELETE AS
BEGIN
	update DOCGIA set TienNo += total
	from DOCGIA dg
	inner join
	(select MaDocGia, sum(TienThu) as total from deleted group by MaDocGia) as x
	on dg.MaDocGia = x.MaDocGia
END;
GO



insert into DOCGIA (HoTen, GioiTinh, NgaySinh, CMND, SDT, NgayLapThe, NgayHetHan)
values ('ten', 'Nam', cast('1/1/2000' as date), '123456789', 'dt', cast('1/1/2014' as date), cast(getdate() as date));

select * from DOCGIA;

insert into SACH (TenSach, TacGia, NamXB, NhaXB, NgonNgu, SoLuong, TriGia)
values ('ten', 'tg', 2000, 'xb', N'Việt', 3, 20000);

select * from SACH;

insert into MUONSACH (MaDocGia, MaSach, NgayMuon, HanTra) values
(1, 1, cast('1/1/2015' as date), cast('1/6/2023' as date)),
(1, 1, cast('1/1/2015' as date), cast('1/6/2023' as date)),
(1, 1, cast('1/1/2015' as date), cast('1/6/2023' as date));

select * from MUONSACH;
select * from SACH;

insert into TRASACH (MaMuonSach, NgayTra) values
(1, cast(getdate() as date)),
(2, cast(getdate() as date)),
(3, cast(getdate() as date));

select * from TRASACH;
select * from SACH;
select * from DOCGIA

insert into THUTIEN (MaDocGia, NgayThu, TienThu) values
(1, cast(getdate() as date), 2000);

select * from THUTIEN;
select * from DOCGIA;



delete from THUTIEN;
select * from THUTIEN
select * from DOCGIA;

delete from TRASACH;
select * from TRASACH;
select * from SACH;
select * from DOCGIA;

delete from MUONSACH;
select * from MUONSACH;
select * from SACH;

delete from SACH;
select * from SACH;

delete from DOCGIA;
select * from DOCGIA;