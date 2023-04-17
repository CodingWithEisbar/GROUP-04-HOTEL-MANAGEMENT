use QLKHACHSAN
go
create or alter proc USP_kiemtratinhtrangvesinh @maphong varchar(30)
as
select * from PHONG where @maphong=SOPHONG
GO


create or alter proc USP_laydanhsachdichvu
as
select * from DICHVU
go;
create or alter proc USP_dangkithongtivanchuyen @SOL INT,@SOP VARCHAR(30)
as
declare @idx int = 1
declare @num VARCHAR(15)='VC0001'
while exists(select MADON from DANGKYVANCHUYENHANHLY where MADON=@num)
begin
set @idx=@idx+1
set @num=REPLICATE('0',4-len(cast(@idx as varchar)))+ CAST(@idx as varchar)
set @num='VC'+@num
END
INSERT INTO DANGKYVANCHUYENHANHLY(MADON,SOLUONG,SOPHONG)
VALUES(@num,@SOL,@SOP)

GO

