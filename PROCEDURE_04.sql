create or alter proc USP_TaoPhieuSudungDichvu @MAKH VARCHAR(30),@NGAYLAP DATE,@DICHVUSUDUNG VARCHAR(30)
as
begin
declare @idx int = 1
declare @num VARCHAR(15)='PDV0001'
while exists(select MAPHIEU from PHIEU where MAPHIEU=@num)
begin
set @idx=@idx+1
set @num=REPLICATE('0',4-len(cast(@idx as varchar)))+ CAST(@idx as varchar)
set @num='PDV'+@num
END
INSERT INTO PHIEU(MAPHIEU,MAKH,NGAYLAP)
VALUES(@num,@MAKH,@NGAYLAP)
INSERT INTO PHIEUDANGKYDICHVU(MAPHIEU,DICHVUSUDUNG,NGAYSUDUNG)
VALUES (@num,@DICHVUSUDUNG,@NGAYLAP)
end
GO

create or alter proc USP_TaoPhieuDangKyTour @MAKH VARCHAR(30),@MATOUR VARCHAR(30),@SONGUOITHAMGIA DECIMAL,@HINHTHUCDICHUYEN NVARCHAR(30),@YEUCAUDACBIET NVARCHAR(200),@NGAYLAP DATE
as
begin
declare @idx int = 1
declare @num VARCHAR(15)='PTOUR0001'
while exists(select MAPHIEU from PHIEU where MAPHIEU=@num)
begin
set @idx=@idx+1
set @num=REPLICATE('0',4-len(cast(@idx as varchar)))+ CAST(@idx as varchar)
set @num='PTOUR'+@num
END
INSERT INTO PHIEU(MAPHIEU,MAKH,NGAYLAP)
VALUES(@num,@MAKH,@NGAYLAP)
INSERT INTO PHIEUDANGKYTOUR(MAPHIEU,TOURTHAMGIA,SOLUONGNGUOI,HINHTHUCDICHUYEN,YEUCAUDACBIET)
VALUES(@num,@MATOUR,@SONGUOITHAMGIA,@HINHTHUCDICHUYEN,@YEUCAUDACBIET)
end
GO