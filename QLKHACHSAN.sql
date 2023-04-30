﻿USE master
GO

IF DB_ID('QLKHACHSAN') IS NOT NULL ---KIỂM TRA NẾU KHÔNG CÓ CSDL TRÙNG TÊN ĐƯỢC TẠO TRƯỚC ĐÓ
	DROP DATABASE QLKHACHSAN
GO
CREATE DATABASE QLKHACHSAN
GO 
USE QLKHACHSAN 
GO

--- TẠO BẢNG DỮ LIỆU
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(50),
	HOTEN NVARCHAR(100),
	NGAYSINH DATE,
	SODT VARCHAR(50),
	DIACHI NVARCHAR(100),
	CCCD VARCHAR(12),
	CATRUC NVARCHAR(50),
	VAITRO NVARCHAR (50)
	
	CONSTRAINT PK_NHANVIEN
	PRIMARY KEY(MANV)
)

--- DÀNH CHO NHÂN VIÊN LỄ TÂN VÀ NHÂN VIÊN VỆ SINH
CREATE TABLE CHITIETNV
(
	MANV VARCHAR(50),
	TANGHD VARCHAR(100)
	
	CONSTRAINT PK_CHITIETNV
	PRIMARY KEY(MANV)
)
CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(50),
	TENKH NVARCHAR(100),
	DIACHI NVARCHAR(100),
	SODT VARCHAR(50),
	SOFAX VARCHAR(50),
	EMAIL NVARCHAR(100),
	CCCD NVARCHAR(12),
	SOTHE VARCHAR(100),
	HINHTHUCTHANHTOAN NVARCHAR(100)

	CONSTRAINT PK_KHACHHANG
	PRIMARY KEY(MAKH)	
)
/*select * from nhanvien
select * from taikhoan*/
CREATE TABLE KHACHHANGNHOM --- KHÁCH HÀNG ĐẠT PHÒNG THEO NHÓM
(	
	MAKH VARCHAR(50),
	TENDOANKHACH NVARCHAR(100),
	SONGUOI DECIMAL,
	NGAYDEN DATE,
	SODEMLUUTRU DECIMAL

	CONSTRAINT PK_KHACHHANGNHOM
	PRIMARY KEY (MAKH)
)
CREATE TABLE THENGANHANG
(
	SOTHE VARCHAR(100),
	TENCHUTHE NVARCHAR(100),
	NGANHANG NVARCHAR(100),
	CHINHANH NVARCHAR(100)

	CONSTRAINT PK_THENGANHANG
	PRIMARY KEY (SOTHE)
)
CREATE TABLE PHONG 
(
	SOPHONG VARCHAR(50),
	LOAIPHONG NVARCHAR(100),
	TINHTRANGLT NVARCHAR(100),
	TRANGTHAIVS NVARCHAR(100),
	DONGIA DECIMAL(10,2),
	MAKHUYENMAI VARCHAR(50)

	CONSTRAINT PK_PHONG
	PRIMARY KEY(SOPHONG)
)
CREATE TABLE HANGCHO
(
	STT DECIMAL,
	MAYC VARCHAR(50),
	NGAYDAT DATE
	
	CONSTRAINT PK_HANGCHO
	PRIMARY KEY (MAYC)
)
CREATE TABLE YEUCAUDATPHONG
(
	MAYC VARCHAR(50),
	MAKH VARCHAR(50),
	SOLUONG DECIMAL

	CONSTRAINT PK_YEUCAUDATPHONG
	PRIMARY KEY(MAYC)
)
CREATE TABLE THONGTINDATPHONG
(
	MADAT VARCHAR(50),
	MAYC VARCHAR(50),
	TRANGTHAI NVARCHAR(100),
	THANHTIEN DECIMAL(10,2),
	NGAYDEN DATE,
	SODEMLUUTRU DECIMAL,
	SOPHONG VARCHAR(50),
	LOAIPHONG NVARCHAR(100),
	YEUCAUDACBIET NVARCHAR(100)

	CONSTRAINT PK_THONGTINDATPHONG
	PRIMARY KEY(MADAT)
)
CREATE TABLE KHUYENMAITHEOPHONG
(
	MAKHUYENMAI VARCHAR(50),
	NOIDUNG NVARCHAR(100)
	
	CONSTRAINT PK_KHUYENMAITHEOPHONG
	PRIMARY KEY(MAKHUYENMAI)
)
/*INSERT INTO PHONG(SOPHONG) VALUES('P001');
UPDATE PHONG SET MAKHUYENMAI = 'KM001' WHERE SOPHONG = 'P001';
SELECT * FROM PHONG
select * from KHUYENMAITHEOPHONG
INSERT INTO KHUYENMAITHEOPHONG VALUES('KM001','P001','CCCCCCC');*/
CREATE TABLE DANGKYVANCHUYENHANHLY
(
	MADON VARCHAR(50),
	SOLUONG DECIMAL,
	SOPHONG VARCHAR(50)

	CONSTRAINT PK_DANGKYVANCHUYENHANHLY
	PRIMARY KEY(MADON)
)
CREATE TABLE DICHVU
(
	MADICHVU VARCHAR(50),
	TENDICHVU NVARCHAR(100),
	GIATIEN DECIMAL (10,2),
	MOTA NVARCHAR(200),

	CONSTRAINT PK_DICHVU
	PRIMARY KEY (MADICHVU)
)
--select * from DICHVU
/*INSERT INTO DICHVU VALUES('DV001',N'Bơi Lội',50000,N'Hoạt Động bơi lội ngoài trời rèn luyện nâng cao sức khỏe' + CHAR(13) + N'Giá vé: 50.000/vé')
SELECT * from TOURDULICH
INSERT INTO TOURDULICH VALUES ('DL001',N'Bà Nà Hill',N'Khu du lịch Bà Nà Hill với nhiều trò chơi mạo hiểm, thú vị','2023-09-17',N'Saigon Tourist')*/
CREATE TABLE TOURDULICH
(
	MATOUR VARCHAR(50),
	DIADIEM NVARCHAR(100),
	MOTA NVARCHAR(200),
	THOIGIANKHOIHANH DATE,
	DONVILUHANH NVARCHAR(100)

	CONSTRAINT PK_TOURDULICH
	PRIMARY KEY (MATOUR)
)
CREATE TABLE HOADON
(
	MAHD VARCHAR(50),
	MAKH VARCHAR(50),
	TONGTIEN DECIMAL (10,2)
	CONSTRAINT PK_HOADON
	PRIMARY KEY (MAHD)
)
CREATE TABLE CHITIETHOADON
(
	MACT VARCHAR(50),
	MAHD VARCHAR(50),
	NGAYLAP DATE,
	DICHVUSUDUNG VARCHAR(50), --- NỐI VỚI MADICHVU Ở BẢNG DỊCH VỤ
	DONGIA DECIMAL (10,2),
	SOLUONG DECIMAL

	CONSTRAINT PK_CHITIETHOADON
	PRIMARY KEY (MACT, MAHD)
)
CREATE TABLE PHIEU
(
	MAPHIEU VARCHAR(50),
	MAKH VARCHAR(50),
	NGAYLAP DATE

	CONSTRAINT PK_PHIEU
	PRIMARY KEY(MAPHIEU)
)
CREATE TABLE PHIEUDANGKYTOUR
(
	MAPHIEU VARCHAR(50),
	TOURTHAMGIA VARCHAR(50), -- MÃ TOUR
	SOLUONGNGUOI DECIMAL,
	HINHTHUCDICHUYEN NVARCHAR(100), -- HÌNH THỨC DI CHUYỂN "XE HỢP ĐỒNG", "TỰ TÚC"
	YEUCAUDACBIET NVARCHAR(100)

	CONSTRAINT PK_PHIEUDANGKYTOUR
	PRIMARY KEY(MAPHIEU)
)

-- PHIẾU ĐĂNG KÝ DỊCH VỤ
CREATE TABLE PHIEUDANGKYDICHVU
(
	MAPHIEU VARCHAR(50),
	NGAYSUDUNG DATE,
	DICHVUSUDUNG VARCHAR(50)

	CONSTRAINT PK_PHIEUDANGKYDICHVU
	PRIMARY KEY(MAPHIEU)
)
CREATE TABLE DANHSACHNHAXE
(
	MANHAXE VARCHAR(50),
	TENNHAXE NVARCHAR(100),
	SODT VARCHAR(50)

	CONSTRAINT PK_DANHSACHNHAXE
	PRIMARY KEY(MANHAXE)
)
CREATE TABLE TAIKHOAN
(
	USERNAME VARCHAR(50),
	PASS VARCHAR(50),
	VAITRO VARCHAR(50),
	MANV VARCHAR(50)

	CONSTRAINT PK_TAIKHOAN
	PRIMARY KEY(USERNAME,PASS)
)
/*SELECT * FROM NHANVIEN
insert into TAIKHOAN(USERNAME,PASS,VAITRO,MANV) values
('lvquan','123','LT','NV001')
delete TAIKHOAN where USERNAME = 'lvquan';
select * from TAIKHOAN
*/
CREATE TABLE YKIENKHACHHANG
(
	MAKH VARCHAR(50),
	NGAYLAP DATE,
	MOTA NVARCHAR(200)

	CONSTRAINT PK_YKKIENKHACHHANG
	PRIMARY KEY(MAKH)
)

CREATE TABLE BANGGIAVATDUNG
(
	MAVATDUNG VARCHAR(50),
	TENVATDUNG NVARCHAR(100),
	DONGIA DECIMAL (10,2)

	CONSTRAINT PK_BANGGIAVATDUNG
	PRIMARY KEY (MAVATDUNG)

)

CREATE TABLE TINHTRANGTRAPHONG
(
	MABAOCAO VARCHAR(50),
	MAPHONG VARCHAR(50),
	MAKH VARCHAR(50),
	NGAYLAP DATE,
	MAVATDUNGHUDAI VARCHAR(50), --- NỐI VỚI MAVATDUNG TRONG BẢNG TINHTRANGTRAPHONG
	NOIDUNG NVARCHAR(100), 
	THANHTIEN DECIMAL (10,2)

	CONSTRAINT PK_TINHTRANGTRAPHONG
	PRIMARY KEY (MABAOCAO)
	
)


--- CÀI ĐẶT KHÓA NGOẠI

ALTER TABLE KHACHHANGNHOM --- THÔNG TIN CHI TIẾT CỦA KHÁCH HÀNG ĐẶT PHÒNG THEO ĐOÀN PHẢI ĐƯỢC LƯU TRONG DANH SÁCH KHÁCH HÀNG
ADD CONSTRAINT FK_KHTM_KH
FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TK_NV
FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)

ALTER TABLE CHITIETNV
ADD CONSTRAINT FK_CHITIETNV_NV
FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV)



ALTER TABLE KHACHHANG
ADD CONSTRAINT FK_KH_TNGH
FOREIGN KEY (SOTHE) REFERENCES THENGANHANG (SOTHE)



ALTER TABLE YKIENKHACHHANG
ADD CONSTRAINT FK_YKKH_KH
FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH)

ALTER TABLE PHIEUDANGKYTOUR
ADD CONSTRAINT FK_PHIEUDANGKYTOUR_PHIEU
FOREIGN KEY (MAPHIEU) REFERENCES PHIEU (MAPHIEU)

ALTER TABLE PHIEUDANGKYDICHVU
ADD CONSTRAINT FK_PHIEUDANGKYDICHVU_PHIEU
FOREIGN KEY (MAPHIEU) REFERENCES PHIEU(MAPHIEU)

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CTHD_HD
FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CTHD_DV
FOREIGN KEY (DICHVUSUDUNG) REFERENCES DICHVU(MADICHVU)

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KH
FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH)


ALTER TABLE HANGCHO
ADD CONSTRAINT FK_HC_YC
FOREIGN KEY (MAYC) REFERENCES YEUCAUDATPHONG(MAYC)

ALTER TABLE YEUCAUDATPHONG
ADD CONSTRAINT FK_YC_KH
FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE THONGTINDATPHONG
ADD CONSTRAINT FK_TT_YC
FOREIGN KEY (MAYC) REFERENCES YEUCAUDATPHONG(MAYC)

/*ALTER TABLE KHUYENMAITHEOPHONG
ADD CONSTRAINT FK_KM_PHONG
FOREIGN KEY (SOPHONG) REFERENCES PHONG(SOPHONG)*/

ALTER TABLE PHIEU
ADD CONSTRAINT FK_PHIEU_KH
FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE DANGKYVANCHUYENHANHLY
ADD CONSTRAINT FK_DKVCHL_PHONG
FOREIGN KEY (SOPHONG) REFERENCES PHONG(SOPHONG)

ALTER TABLE TINHTRANGTRAPHONG --- KHÁCH HÀNG ĐƯỢC NÊU TRONG BẢNG BÁO CÁO TÌNH TRẠNG PHÒNG.
ADD CONSTRAINT FK_TINHTRANGTRAPHONG_KH
FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH)

ALTER TABLE TINHTRANGTRAPHONG
ADD CONSTRAINT FK_TINHTRANGTRAPHONG_PHONG
FOREIGN KEY (MAPHONG) REFERENCES PHONG(SOPHONG)

ALTER TABLE TINHTRANGTRAPHONG
ADD CONSTRAINT FK_TINHTRANGTRAPHONG_BANGGIAVATDUNG
FOREIGN KEY (MAVATDUNGHUDAI) REFERENCES BANGGIAVATDUNG(MAVATDUNG)


-- NHẬP DỮ LIỆU
INSERT NHANVIEN(MANV, HOTEN, NGAYSINH, SODT, DIACHI, CCCD, CATRUC, VAITRO)
VALUES ('NV001', N'Lê Văn Quân', '1973-02-15', '0838126126', N'69 Trịnh Đình Thảo, Phú Trung, Tân Phú, Thành phố Hồ Chí Minh', '782936885101', NULL , N'Lễ Tân'),
	   ('NV002', N'Nguyễn Văn Tuyết', '1979-10-30', '0374080895', N'565 Lạc Long Quân, Phường 10, Tân Bình, Thành phố Hồ Chí Minh', '823326582035', NULL , N'Lễ Tân'),
	   ('NV003', N'Trần Văn Thành', '1980-11-20', '0274010895', N'45 Lê Thánh Tôn, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh', '603167292135', NULL , N'Bellman'),
	   ('NV004', N'Mai Tuấn Khanh', '1978-05-08', '0999712602', N'973 Lũy Bán Bích, Tân Thành, Tân Phú, Thành phố Hồ Chí Minh', '445794292675', NULL , N'Bellman'),
	   ('NV005', N'Bùi Xuân Huy', '1979-10-11', '0397836164', N'1134 Phạm Văn Đồng, Linh Đông, Thành Phố Thủ Đức, Thành phố Hồ Chí Minh', '902270137212', NULL , N'Vệ sinh'),
	   ('NV006', N'Vũ Hồng Đức', '1989-02-12', '0897205247', N'740/15A Sư Vạn Hạnh, Phường 12, Quận 10, Thành phố Hồ Chí Minh', '095623791774', NULL , N'Kế Toán'),
	   ('NV007', N'Đoàn Văn Vui', '1990-01-02', '0523613534', N'B15/13c Ấp 2, Bình Chánh, Thành phố Hồ Chí Minh', '673275174393', NULL , N'Kế Toán')

INSERT CHITIETNV(MANV, TANGHD)
VALUES ('NV001', 'G'),
	   ('NV002', 'G' ),
	   ('NV003', '1' ),
	   ('NV004', '2' ),
	   ('NV005', '2' ),
	   ('NV006', 'G' ),
	   ('NV007', 'G' )

INSERT THENGANHANG (SOTHE, TENCHUTHE, NGANHANG, CHINHANH)
VALUES ('4849860728359294', 'TON THAT BACH', N'Vietcombank', N'Bình Thạnh'),
	   ('4961813447012597', 'LAI AN PHU', N'Agribank', N'Tân Hương')

INSERT KHACHHANG(MAKH, TENKH, DIACHI, SODT, SOFAX, EMAIL, CCCD, SOTHE, HINHTHUCTHANHTOAN)
VALUES ('KH001', N'Tôn Thất Bách', N'740/15A Sư Vạn Hạnh, Phường 12, Quận 10, Thành phố Hồ Chí Minh', '0339161316', '+84 24 123 4567', N'yokuneva@yahoo.com', '554926537264','4849860728359294', N'Thẻ tín dụng'),
	   ('KH002', N'Nguyễn Trung Nguyên', N'Hẻm 320 Trần Bình Trọng, Phường 4, Quận 5, Thành phố Hồ Chí Minh', '0999837480', '+84 28 234 5678', N'jasetaylor@yt-google.com', '790856623849', NULL, N'Tiền mặt'),
	   ('KH003', N'Lại An Phú', N'565 Lạc Long Quân, Phường 10, Tân Bình, Thành phố Hồ Chí Minh', '0374080895', '+84 236 345 6789', N'fkuhn@hotmail.com', '058411867415', '4961813447012597', N'Thẻ tín dụng'),
	   ('KH004', N'Trần Mạnh Hùng', N'973 Lũy Bán Bích, Tân Thành, Tân Phú, Thành phố Hồ Chí Minh', '0374080899',  '+84 123 445 4564', N'tmhung@hotmail.com', '098411867123', NULL, N'Tiền mặt')

INSERT KHACHHANGNHOM(MAKH, TENDOANKHACH, SONGUOI, NGAYDEN, SODEMLUUTRU)
VALUES ('KH003', N'ĐH Khoa học Tự nhiên - ĐHQG TPHCM', 100, '2020-02-12', 5)

INSERT PHONG (SOPHONG, LOAIPHONG, TINHTRANGLT, TRANGTHAIVS, DONGIA, MAKHUYENMAI)
VALUES ('101', N'Standard', N'Trống', N'Chưa vệ sinh', 150000, NULL),
	   ('102', N'Superior', N'Đặt trước', N'Đã vệ sinh', 735000, 'KM001'),
	   ('103', N'Deluxe', N'Trống', N'Đã vệ sinh', 840000, NULL),	
	   ('104', N'Suite', N'Trống', N'Đã vệ sinh', 1260000, NULL),
	   ('105', N'Deluxe', N'Trống', N'Đã vệ sinh', 840000, NULL),
	   ('106', N'Standard', N'Trống', N'Đã vệ sinh', 150000, NULL)

INSERT YEUCAUDATPHONG (MAYC, MAKH, SOLUONG)
VALUES ('YC001', 'KH003', 1)

INSERT HANGCHO(STT, MAYC, NGAYDAT)
VALUES (1, 'YC001', '2020-01-12')

INSERT THONGTINDATPHONG(MADAT, MAYC, TRANGTHAI, THANHTIEN, NGAYDEN, SODEMLUUTRU, SOPHONG, LOAIPHONG, YEUCAUDACBIET)
VALUES ('DH001', 'YC001', N'Chờ thanh toán', 220500, '2020-01-12', 5, '102', N'Standard', N'Vệ sinh trước khi tôi tới')


INSERT KHUYENMAITHEOPHONG(MAKHUYENMAI, NOIDUNG)
VALUES ('KM001', N'Buffet sáng miễn phí'),
	   ('KM002', N'Massage xông hơi cho 2 người'),
	   ('KM003', N'Miễn phí sử dụng các phòng gym và bể bơi'),
	   ('KM004', N'Miễn phí tất cả đồ ăn trong tủ lạnh')
	   

INSERT DANGKYVANCHUYENHANHLY (MADON , SOLUONG, SOPHONG)
VALUES ('HL001', 2, '102')

INSERT DICHVU (MADICHVU, TENDICHVU, GIATIEN, MOTA)
VALUES ('DV001', N'Bơi lội', 50000, N'Hoạt động bơi lội ngoài trời rèn luyện nâng cao sức khỏe'),
	   ('DV002', N'Cầu lông', 100000, N'Hệ thống sân cầu lông đạt chuẩn Olympic'),
	   ('DV003', N'Bóng chuyền', 100000, N'Sân Goft sang trọng, đẳng cấp giới thượng lưu'),
	   ('DV004', N'Bóng rổ', 100000, N'Buffet với nhiều món ngon từ những đầu bếp nhiều năm kinh nghiệm'),
	   ('DV005', N'Xông hơi', 120000, N'Thư giãn cùng với phòng xông hơi đạt chuẩn Quốc tế'),
	   ('DV006', N'Goft', 900000, N'Phong cách sống thượng lưu'),
	   ('DV007', N'Buffet', 120000, N'Nhiều món ngon được phục vụ bởi những đầu bếp nổi tiếng')


INSERT TOURDULICH (MATOUR, DIADIEM, MOTA, THOIGIANKHOIHANH, DONVILUHANH)
VALUES ('TOUR001', N'Phố cổ Hội An', N'Đắm chìm trong những nét cổ xưa', '2021-01-01', N'Travel VietNam'),
	   ('TOUR002', N'Thành cổ Quảng Trị', N'Mùa hè đỏ lửa 1972', '2022-10-01', N'Saigon Tourist'),
	   ('TOUR003', N'Vịnh Hạ Long', N'Danh lam thắng cảnh được UNESCO công nhận', '2022-01-10', N'Saigon Tourist'),
	   ('TOUR004', N'Qui Nhơn', N'Hóa thân thành Hàn Mạc Tử', '2022-10-01', N'Saigon Tourist')

INSERT HOADON (MAHD, MAKH, TONGTIEN)
VALUES ('HD001', 'KH003', 15000000)

INSERT CHITIETHOADON (MACT, MAHD, NGAYLAP, DICHVUSUDUNG, DONGIA, SOLUONG)
VALUES ('CTHD001','HD001', '2020-07-12', 'DV002', 100000, 1)

INSERT PHIEU (MAPHIEU, MAKH, NGAYLAP)
VALUES ('PH001', 'KH003', '2020-04-12'),
	   ('PH002', 'KH001', '2021-11-10'),
	   ('PH003', 'KH002', '2020-11-10')

INSERT PHIEUDANGKYTOUR (MAPHIEU, TOURTHAMGIA, SOLUONGNGUOI, HINHTHUCDICHUYEN, YEUCAUDACBIET)
VALUES ('PH001', 'TOUR001', 10, N'Tự túc', N'Có hướng dẫn viên riêng'),
	   ('PH002', 'TOUR002', 2, N'Xe hợp đồng', NULL)

INSERT PHIEUDANGKYDICHVU (MAPHIEU, NGAYSUDUNG, DICHVUSUDUNG)
VALUES ('PH002', '2021-11-11', 'DV001')


INSERT DANHSACHNHAXE (MANHAXE, TENNHAXE, SODT)
VALUES ('NX001', N'Huệ Nghĩa', '+84 7147900717'),
	   ('NX002', N'Phương Trang', '+84 7658214945'),
	   ('NX003', N'Thành Bưởi', '+84 9797500081')

INSERT TAIKHOAN(USERNAME, PASS, VAITRO, MANV)
VALUES ('TK001', '123', 'Le Tan', 'NV001'),
	   ('TK002', '123', 'Le Tan', 'NV002'),
	   ('TK003', '123', 'Bellman', 'NV003'),
	   ('TK004', '123', 'Bellman', 'NV004'),
	   ('TK005', '123', 'Ke Toan', 'NV006'),
	   ('TK006', '123', 'Ke Toan', 'NV007')

INSERT BANGGIAVATDUNG(MAVATDUNG, TENVATDUNG, DONGIA)
VALUES ('VD001', N'Tivi', 4500000),
	   ('VD002', N'Tủ lạnh', 2500000),
	   ('VD003', N'Điều hòa', 6000000),
	   ('VD004', N'Chìa khóa phòng', 250000),
	   ('VD005', N'Rèm cửa', 2500000)


INSERT TINHTRANGTRAPHONG(MABAOCAO, MAPHONG, MAKH, NGAYLAP, MAVATDUNGHUDAI, NOIDUNG, THANHTIEN)
VALUES ('BC001', '102', 'KH003', '2020-07-12', 'VD002', N'Gãy cánh cửa không rõ nguyên nhân', 2500000)
