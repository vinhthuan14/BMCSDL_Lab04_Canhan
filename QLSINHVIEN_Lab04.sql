create database QLSV_Lab04
go
use QLSV_Lab04
go
/*----------------------------------------------------------
MASV:
HO TEN:
LAB: 03
NGAY:
----------------------------------------------------------*/
/*CAC CAU LENH TAO TABLE*/
create table SINHVIEN (
	MASV NVARCHAR(20),
	HOTEN NVARCHAR(100)NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR (20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY (max) NOT NULL
	PRIMARY KEY (MASV)
)
go

CREATE TABLE NHANVIEN (
	MANV NVARCHAR(20) ,
HOTEN NVARCHAR(100) NOT NULL,
EMAIL VARCHAR(20),
LUONG VARBINARY(MAX),
TENDN NVARCHAR(100) NOT NULL,
MATKHAU VARBINARY (MAX) NOT NULL
PRIMARY KEY (MANV)
)
GO

CREATE TABLE LOP (
	MALOP VARCHAR (20),
TENLOP NVARCHAR(100) NOT NULL,
MANV VARCHAR (20)
PRIMARY KEY (MALOP)
)

create proc  SP_INS_ENCRYPT_SINHVIEN(@MASV nvarchar(20),@HOTEN nvarchar(100),@NGAYSINH datetime,@DIACHI nvarchar(200),@MALOP varchar(20),@TENDN nvarchar(100),@MATKHAU varchar(32))
as
begin
	insert into SINHVIEN(MASV,HOTEN,NGAYSINH,DIACHI,MALOP,TENDN,MATKHAU) values (@MASV,@HOTEN,@NGAYSINH,@DIACHI,@MALOP,@TENDN,CAST(@MATKHAU AS varbinary(MAX)))
end

DROP PROCEDURE SP_INS_ENCRYPT_SINHVIEN
EXEC SP_INS_ENCRYPT_SINHVIEN 'SV1', 'NGUYEN VAN A', '1/1/1990','280 AN DUONG VUONG', 'CNTT-K35', 'sv1', 'e10adc3949ba59abbe56e057f20f883e'

select * from SINHVIEN
SELECT * FROM SINHVIEN
--create master key
/*CREATE MASTER KEY ENCRYPTION
BY PASSWORD = '4501104230'

--certificate key
CREATE CERTIFICATE IMS_ENCRYPT
WITH SUBJECT = 'EncryptData'
--CREATE SYMMETRIC KEY
CREATE SYMMETRIC KEY SSN_Key_EncryptData
WITH ALGORITHM = AES_256
ENCRYPTION BY CERTIFICATE IMS_ENCRYPT

*/
create proc SP_INS_ENCRYPT_NHANVIEN (
	@MANV NVARCHAR(20) ,
@HOTEN NVARCHAR(100),
@EMAIL VARCHAR(20),
@LUONG VARCHAR(MAX),
@TENDN NVARCHAR(100) ,
@MATKHAU VARCHAR(MAX)
)
AS
BEGIN
/*OPEN SYMMETRIC KEY SSN_Key_EncryptData
	DECRYPTION BY CERTIFICATE IMS_ENCRYPT;*/
	INSERT INTO NHANVIEN(MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU) VALUES
	(@MANV, @HOTEN, @EMAIL,CAST(@LUONG AS varbinary(MAX)), @TENDN,CAST(@MATKHAU AS varbinary(MAX)))
END
EXEC SP_INS_ENCRYPT_NHANVIEN 'NV02', 'NGUYEN VAN B', 'NVB@', 'asdasds','NVB', 'abcd12'
SELECT * FROM NHANVIEN
DROP PROC SP_INS_ENCRYPT_NHANVIEN
create procedure SP_SEL_NHANVIEN 
as
select MANV, HOTEN, EMAIL,CAST(LUONG AS varchar(MAX)) AS LUONG
from NHANVIEN

go
DROP PROCEDURE SP_SEL_NHANVIEN 
SELECT MANV, HOTEN, EMAIL, LUONG FROM NHANVIEN

--cau f
exec sp_executesql N'SELECT [t0].[MANV], [t0].[HOTEN], [t0].[EMAIL], [t0].[LUONG], [t0].[TENDN], [t0].[MATKHAU]
FROM [dbo].[NHANVIEN] AS [t0]
WHERE [t0].[TENDN] = @p0',N'@p0 nvarchar(4000)',@p0=N'nva'
Go
exec sp_executesql N'SELECT [t0].[MASV], [t0].[HOTEN], [t0].[NGAYSINH], [t0].[DIACHI], [t0].[MALOP], [t0].[TENDN], [t0].[MATKHAU]
FROM [dbo].[SINHVIEN] AS [t0]
WHERE [t0].[TENDN] = @p0',N'@p0 nvarchar(4000)',@p0=N'nva'
go
--cau g
go
declare @p3 int
set @p3=0
exec sp_executesql N'EXEC @RETURN_VALUE = [dbo].[SP_SEL_NHANVIEN] ',N'@RETURN_VALUE int output',@RETURN_VALUE=@p3 output
select @p3
--cau h
declare @p9 int
set @p9=0
exec sp_executesql N'EXEC @RETURN_VALUE = [dbo].[SP_INS_ENCRYPT_NHANVIEN] @MANV = @p0, @HOTEN = @p1, @EMAIL = @p2, @LUONG = @p3, @TENDN = @p4, @MATKHAU = @p5',N'@p0 nvarchar(4000),@p1 nvarchar(4000),@p2 varchar(8000),@p3 varchar(8000),@p4 nvarchar(4000),@p5 varchar(8000),@RETURN_VALUE int output',@p0=N'NV03',@p1=N'NGUYEN VAN C',@p2='NVC@',@p3='WGjoSIMG0//sE7sGswneEQ==',@p4=N'nvc',@p5='2f3309423fd7fc1100241b801fe95659465701c1',@RETURN_VALUE=@p9 output
select @p9
go
declare @p3 int
set @p3=0
exec sp_executesql N'EXEC @RETURN_VALUE = [dbo].[SP_SEL_NHANVIEN] ',N'@RETURN_VALUE int output',@RETURN_VALUE=@p3 output
select @p3
go

