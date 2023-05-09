
-- TÌM THÔNG TIN ĐẶT PHÒNG BẰNG MADAT
CREATE PROCEDURE dbo.GetTHONGTINDATPHONGById
    @MADAT VARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @MADAT IS NOT NULL
    BEGIN
        SELECT TOP 1 
            [MADAT],
            [MAYC],
            [TRANGTHAI],
            [THANHTIEN],
            [NGAYDEN],
            [SODEMLUUTRU],
            [SOPHONG],
            [LOAIPHONG],
            [YEUCAUDACBIET]
        FROM 
            [QLKHACHSAN].[dbo].[THONGTINDATPHONG]
        WHERE 
            [MADAT] = @MADAT;
    END
    ELSE
    BEGIN
        SELECT 
            [MADAT],
            [MAYC],
            [TRANGTHAI],
            [THANHTIEN],
            [NGAYDEN],
            [SODEMLUUTRU],
            [SOPHONG],
            [LOAIPHONG],
            [YEUCAUDACBIET]
        FROM 
            [QLKHACHSAN].[dbo].[THONGTINDATPHONG];
    END
END

-- EXEC dbo.GetTHONGTINDATPHONGById @MADAT = 'DH003';

-- EXEC dbo.GetTHONGTINDATPHONGById 


-- CẬP NHẬP TRẠNG THÁI THANH TOÁN
CREATE PROCEDURE usp_UpdateThongTinDatPhong
    @MADAT varchar(50)
AS
BEGIN
    UPDATE [QLKHACHSAN].[dbo].[THONGTINDATPHONG]
    SET [TRANGTHAI] = N'Đã thanh toán'
    WHERE [MADAT] = @MADAT
END


--EXEC usp_UpdateThongTinDatPhong @MADAT = 'DH002'

-- HIỂN THỊ THÔNG TIN KHÁCH HÀNG 
CREATE PROCEDURE usp_GetKhachHangByMAKH
    @MAKH varchar(50)
AS
BEGIN
    SELECT [MAKH]
          ,[TENKH]
          ,[DIACHI]
          ,[SODT]
          ,[SOFAX]
          ,[EMAIL]
          ,[CCCD]
          ,[SOTHE]
          ,[HINHTHUCTHANHTOAN]
    FROM [QLKHACHSAN].[dbo].[KHACHHANG]
    WHERE [MAKH] = @MAKH
END


--EXEC usp_GetKhachHangByMAKH @MAKH = 'KH003'

-- HIỂN THỊ THÔNG TIN KHUYẾN MÃI
CREATE PROCEDURE usp_GetAllKhuyenMaiTheoPhong
AS
BEGIN
    SELECT *
    FROM [QLKHACHSAN].[dbo].[KHUYENMAITHEOPHONG]
END


--EXEC usp_GetAllKhuyenMaiTheoPhong

