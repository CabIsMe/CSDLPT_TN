USE [master]
GO
/****** Object:  Database [TN_CSDLPT]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE DATABASE [TN_CSDLPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TN_CSDLPT', FILENAME = N'D:\sql_install\rootDir\MSSQL13.SERVER1\MSSQL\DATA\TN_CSDLPT.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TN_CSDLPT_log', FILENAME = N'D:\sql_install\rootDir\MSSQL13.SERVER1\MSSQL\DATA\TN_CSDLPT_log.ldf' , SIZE = 335872KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TN_CSDLPT] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TN_CSDLPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TN_CSDLPT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET ARITHABORT OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TN_CSDLPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TN_CSDLPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TN_CSDLPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TN_CSDLPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET RECOVERY FULL 
GO
ALTER DATABASE [TN_CSDLPT] SET  MULTI_USER 
GO
ALTER DATABASE [TN_CSDLPT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TN_CSDLPT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TN_CSDLPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TN_CSDLPT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TN_CSDLPT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TN_CSDLPT', N'ON'
GO
ALTER DATABASE [TN_CSDLPT] SET QUERY_STORE = OFF
GO
USE [TN_CSDLPT]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [TN_CSDLPT]
GO
/****** Object:  User [TH234]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE USER [TH234] FOR LOGIN [DVT] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [TH123]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE USER [TH123] FOR LOGIN [PVH] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [TH101]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE USER [TH101] FOR LOGIN [KDT] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sinhvien]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE USER [sinhvien] FOR LOGIN [sinhvien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [HTKN]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [TRUONG]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE ROLE [TRUONG]
GO
/****** Object:  DatabaseRole [SV]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE ROLE [SV]
GO
/****** Object:  DatabaseRole [GIANGVIEN]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE ROLE [GIANGVIEN]
GO
/****** Object:  DatabaseRole [COSO]    Script Date: 10-Jun-22 13:42:31 ******/
CREATE ROLE [COSO]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [TH234]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TH234]
GO
ALTER ROLE [COSO] ADD MEMBER [TH123]
GO
ALTER ROLE [db_owner] ADD MEMBER [TH123]
GO
ALTER ROLE [TRUONG] ADD MEMBER [TH101]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [TH101]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [TH101]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TH101]
GO
ALTER ROLE [SV] ADD MEMBER [sinhvien]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [sinhvien]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [TRUONG]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [TRUONG]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TRUONG]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [SV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GIANGVIEN]
GO
ALTER ROLE [db_owner] ADD MEMBER [COSO]
GO
/****** Object:  UserDefinedFunction [dbo].[checkDaThi]    Script Date: 10-Jun-22 13:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkDaThi] (@maMH nchar(5),
	@lan int,
	@maLop nchar(15))

RETURNS VARCHAR(50) 
AS

BEGIN

DECLARE @checked VARCHAR(50);
DECLARE  @count INT = 0;

 SELECT @count = COUNT(*) FROM BANGDIEM, SINHVIEN WHERE BANGDIEM.MAMH=@maMH 
 and BANGDIEM.LAN = @lan and BANGDIEM.MASV = SINHVIEN.MASV and SINHVIEN.MALOP = @maLop;

IF @count > 0
 SET @checked = 'X';
 ELSE
 SET @checked = '';

RETURN @checked;

END;
GO
/****** Object:  UserDefinedFunction [dbo].[checkDaThi_DSDK]    Script Date: 10-Jun-22 13:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[checkDaThi_DSDK](@maMH nchar(5),
	@lan int,
	@maLop nchar(15))

RETURNS VARCHAR(50) 
AS

BEGIN

DECLARE @checked VARCHAR(50);
DECLARE  @count INT = 0;

 SELECT @count = COUNT(*) FROM BANGDIEM, SINHVIEN WHERE BANGDIEM.MAMH=@maMH 
 and BANGDIEM.LAN = @lan and BANGDIEM.MASV = SINHVIEN.MASV and SINHVIEN.MALOP = @maLop;

IF @count > 0
 SET @checked = 'X';
 ELSE
 SET @checked = '';

RETURN @checked;

END;

GO
/****** Object:  UserDefinedFunction [dbo].[DiemToDiemChu]    Script Date: 10-Jun-22 13:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DiemToDiemChu](@Number float)
RETURNS nvarchar(20) AS 
BEGIN
	DECLARE @sNumber nvarchar(20)
	DECLARE @Return	nvarchar(20)
	DECLARE @mLen int
	DECLARE @i int

	DECLARE @mDigit char(1)
	DECLARE @mTemp nvarchar(20)
	DECLARE @mNumText nvarchar(20)

	SELECT @sNumber=LTRIM(cast(@Number as nvarchar))
	SELECT @mLen = Len(@sNumber)

	if @mLen =2
		BEGIN
			SELECT @Return = N'Mười'
			RETURN @Return
		END
	SELECT @i=1
	SELECT @mTemp=''

	WHILE @i <= @mLen
		BEGIN

		SELECT @mDigit=SUBSTRING(@sNumber, @i, 1)

		IF @mDigit='0' SELECT @mNumText=N'không'
		ELSE
			BEGIN
			IF @mDigit='1' SELECT @mNumText=N'một'
			ELSE
			IF @mDigit='2' SELECT @mNumText=N'hai'
			ELSE
			IF @mDigit='3' SELECT @mNumText=N'ba'
			ELSE
			IF @mDigit='4' SELECT @mNumText=N'bốn'
			ELSE
			IF @mDigit='5' SELECT @mNumText=N'năm'
			ELSE
			IF @mDigit='6' SELECT @mNumText=N'sáu'
			ELSE
			IF @mDigit='7' SELECT @mNumText=N'bảy'
			ELSE
			IF @mDigit='8' SELECT @mNumText=N'tám'
			ELSE
			IF @mDigit='9' SELECT @mNumText=N'chín'
			ELSE 
			IF @mDigit='.' SELECT @mNumText=N'phẩy'
			END

		SELECT @mTemp = @mTemp + ' ' + @mNumText

		IF (@mLen = @i) BREAK
		
		SELECT @i=@i+1
		END

	--'Bỏ ký tự space

	SELECT @mTemp = LTrim(@mTemp)

	--'Ucase ký tự đầu tiên

	SELECT @Return=UPPER(Left(@mTemp, 1)) + SUBSTRING(@mTemp,2, 20)

	RETURN @Return
END
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 10-Jun-22 13:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](5) NOT NULL,
	[TENMH] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_TENMH] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UN_TENMH] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN_DANGKY]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN_DANGKY](
	[MAGV] [char](8) NULL,
	[MAMH] [char](5) NOT NULL,
	[MALOP] [nchar](15) NOT NULL,
	[TRINHDO] [char](1) NULL,
	[NGAYTHI] [datetime] NULL,
	[LAN] [smallint] NOT NULL,
	[SOCAUTHI] [smallint] NULL,
	[THOIGIAN] [smallint] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GIAOVIEN_DANGKY] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC,
	[MALOP] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[f_CHECKMONTHI]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_CHECKMONTHI]
( @malop nchar(15))
returns table
as
return(
	SELECT dbo.MONHOC.MAMH, dbo.MONHOC.TENMH, dbo.GIAOVIEN_DANGKY.NGAYTHI, dbo.GIAOVIEN_DANGKY.LAN, dbo.GIAOVIEN_DANGKY.MALOP, dbo.GIAOVIEN_DANGKY.THOIGIAN
	FROM dbo.GIAOVIEN_DANGKY INNER JOIN dbo.MONHOC 
	ON dbo.GIAOVIEN_DANGKY.MAMH = dbo.MONHOC.MAMH AND GIAOVIEN_DANGKY.MALOP=@malop
	)

GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT PUBS.description AS TENCS, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
WHERE  (PUBS.description LIKE N'Cơ sở%')
GO
/****** Object:  Table [dbo].[BAITHI]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAITHI](
	[CauHoi] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[CauSo] [int] NOT NULL,
	[NoiDung] [ntext] NULL,
	[A] [ntext] NULL,
	[B] [ntext] NULL,
	[C] [ntext] NULL,
	[D] [ntext] NULL,
	[DapAn] [nchar](1) NOT NULL,
	[DaChon] [nchar](1) NULL,
	[MaBD] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[MASV] [char](8) NULL,
 CONSTRAINT [PK_BAITHI] PRIMARY KEY CLUSTERED 
(
	[CauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGDIEM](
	[MASV] [char](8) NOT NULL,
	[MAMH] [char](5) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[NGAYTHI] [datetime] NULL,
	[DIEM] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_BANGDIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BODE]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BODE](
	[CAUHOI] [int] NOT NULL,
	[MAMH] [char](5) NULL,
	[TRINHDO] [char](1) NULL,
	[NOIDUNG] [ntext] NULL,
	[A] [ntext] NULL,
	[B] [ntext] NULL,
	[C] [ntext] NULL,
	[D] [ntext] NULL,
	[DAP_AN] [char](1) NULL,
	[MAGV] [char](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_BODE] PRIMARY KEY CLUSTERED 
(
	[CAUHOI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COSO]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COSO](
	[MACS] [nchar](3) NOT NULL,
	[TENCS] [nvarchar](50) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_COSO] PRIMARY KEY CLUSTERED 
(
	[MACS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MAGV] [char](8) NOT NULL,
	[HO] [nvarchar](50) NULL,
	[TEN] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [nchar](8) NOT NULL,
	[TENKH] [nvarchar](50) NOT NULL,
	[MACS] [nchar](3) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](15) NOT NULL,
	[TENLOP] [nvarchar](50) NOT NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UN_TENLOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](8) NOT NULL,
	[HO] [nvarchar](50) NULL,
	[TEN] [nvarchar](10) NULL,
	[NGAYSINH] [date] NULL,
	[DIACHI] [nvarchar](100) NULL,
	[MALOP] [nchar](15) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[PASSWORD] [char](20) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_565577053]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_565577053] ON [dbo].[BANGDIEM]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_597577167]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_597577167] ON [dbo].[BODE]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_629577281]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_629577281] ON [dbo].[COSO]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_661577395]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_661577395] ON [dbo].[GIAOVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_693577509]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_693577509] ON [dbo].[GIAOVIEN_DANGKY]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_725577623]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_725577623] ON [dbo].[KHOA]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_757577737]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_757577737] ON [dbo].[LOP]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_MONHOC]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE NONCLUSTERED INDEX [IX_MONHOC] ON [dbo].[MONHOC]
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_789577851]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_789577851] ON [dbo].[MONHOC]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_MALOP]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE NONCLUSTERED INDEX [IX_MALOP] ON [dbo].[SINHVIEN]
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_821577965]    Script Date: 10-Jun-22 13:42:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_821577965] ON [dbo].[SINHVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BAITHI] ADD  CONSTRAINT [MSmerge_df_rowguid_6CFAB7D3B00E43EEBBFBEB5F847FE53E]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[BANGDIEM] ADD  CONSTRAINT [MSmerge_df_rowguid_AE3DD2F4FF7E44A7A669EDA20688E03D]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[BODE] ADD  CONSTRAINT [MSmerge_df_rowguid_4002E15BAC194433A9415567EA99BD5A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[COSO] ADD  CONSTRAINT [MSmerge_df_rowguid_D73F6E528B8C4564B1DF44E774760C7F]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GIAOVIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_D570778552584A7CA47197279C4396CA]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] ADD  CONSTRAINT [MSmerge_df_rowguid_20A6D5FD506D4DBBB2F56E4AE6D6EDC8]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KHOA] ADD  CONSTRAINT [MSmerge_df_rowguid_9866CFD81C254E5EB53EE334DDA10576]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [MSmerge_df_rowguid_073F47B6084148CF8A592880B3760ED6]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [MSmerge_df_rowguid_8E1380E8BEF2401C8B423C396FD0A77A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_CE57747682B44C62AAC75DF3F9244063]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[BAITHI]  WITH NOCHECK ADD  CONSTRAINT [FK_BAITHI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BAITHI] CHECK CONSTRAINT [FK_BAITHI_SINHVIEN]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_BANGDIEM_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_MONHOC]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_BANGDIEM_SINHVIEN1] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_SINHVIEN1]
GO
ALTER TABLE [dbo].[BODE]  WITH NOCHECK ADD  CONSTRAINT [FK_BODE_GIAOVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [FK_BODE_GIAOVIEN]
GO
ALTER TABLE [dbo].[BODE]  WITH NOCHECK ADD  CONSTRAINT [FK_BODE_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [FK_BODE_MONHOC]
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_GIAOVIEN_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [FK_GIAOVIEN_KHOA]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [FK_GIAOVIEN_DANGKY_GIAOVIEN1] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK_GIAOVIEN_DANGKY_GIAOVIEN1]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [FK_GIAOVIEN_DANGKY_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK_GIAOVIEN_DANGKY_LOP]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [FK_GIAOVIEN_DANGKY_MONHOC1] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK_GIAOVIEN_DANGKY_MONHOC1]
GO
ALTER TABLE [dbo].[KHOA]  WITH NOCHECK ADD  CONSTRAINT [FK_KHOA_COSO] FOREIGN KEY([MACS])
REFERENCES [dbo].[COSO] ([MACS])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[KHOA] CHECK CONSTRAINT [FK_KHOA_COSO]
GO
ALTER TABLE [dbo].[LOP]  WITH NOCHECK ADD  CONSTRAINT [FK_LOP_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM] CHECK NOT FOR REPLICATION (([DIEM]>=(0) AND [DIEM]<=(10)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_DIEM]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_LANTHI] CHECK NOT FOR REPLICATION (([LAN]>=(1) AND [LAN]<=(2)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_LANTHI]
GO
ALTER TABLE [dbo].[BODE]  WITH NOCHECK ADD  CONSTRAINT [CK_BODE] CHECK NOT FOR REPLICATION (([TRINHDO]='A' OR [TRINHDO]='B' OR [TRINHDO]='C'))
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [CK_BODE]
GO
ALTER TABLE [dbo].[BODE]  WITH NOCHECK ADD  CONSTRAINT [CK_DAPAN] CHECK NOT FOR REPLICATION (([DAP_AN]='D' OR ([DAP_AN]='C' OR ([DAP_AN]='B' OR [DAP_AN]='A'))))
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [CK_DAPAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [CK_LAN] CHECK NOT FOR REPLICATION (([LAN]>=(1) AND [LAN]<=(2)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_LAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [CK_SOCAUTHI] CHECK NOT FOR REPLICATION (([SOCAUTHI]>=(10) AND [SOCAUTHI]<=(100)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_SOCAUTHI]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [CK_THOIGIAN] CHECK NOT FOR REPLICATION (([THOIGIAN]>=(15) AND [THOIGIAN]<=(60)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_THOIGIAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH NOCHECK ADD  CONSTRAINT [CK_TRINHDO] CHECK NOT FOR REPLICATION (([TRINHDO]='C' OR ([TRINHDO]='B' OR [TRINHDO]='A')))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_TRINHDO]
GO
/****** Object:  StoredProcedure [dbo].[sp_BangDiemMonHoc]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BangDiemMonHoc] @MAMH char(5),
	 @LAN smallint,
	 @MALOP char(8)
AS
SELECT sv.MASV, sv.HO, sv.TEN, bd.DIEM,  (dbo.DiemToDiemChu(bd.DIEM)) as DIEMCHU 
FROM (SELECT MASV,HO, TEN FROM SINHVIEN WITH(INDEX=IX_MALOP)
WHERE MALOP = @MALOP) sv, (SELECT MASV,DIEM FROM BANGDIEM WHERE MAMH = @MAMH and LAN = @LAN) bd
WHERE sv.MASV = bd.MASV

GO
/****** Object:  StoredProcedure [dbo].[SP_CHAMDIEM]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHAMDIEM] @MASV CHAR(8), @MAMH CHAR(5), @LAN INT
AS
DECLARE @maLop nchar(15), @soCauThi smallint, @dapAnDung smallint, @Diem float

SELECT @maLop=SINHVIEN.MALOP FROM SINHVIEN WHERE MASV=@MASV
IF EXISTS (SELECT SOCAUTHI FROM GIAOVIEN_DANGKY WHERE MALOP=@maLop AND MAMH=@MAMH AND LAN=@LAN)
	SELECT @soCauThi=SOCAUTHI FROM GIAOVIEN_DANGKY WHERE MALOP=@maLop AND MAMH=@MAMH AND LAN=@LAN
	IF((SELECT DIEM FROM BANGDIEM WHERE MASV=@MASV AND MAMH=@MAMH AND LAN=@LAN) is NULL)
		SELECT @dapAnDung=count(DaChon) FROM BAITHI WHERE DaChon=DapAn AND MaBD=CONCAT(RTRIM(@MASV), RTRIM(@MAMH),@LAN)
		SELECT @Diem=(10/CAST(@soCauThi AS float))*@dapAnDung
		SELECT @Diem=ROUND(@Diem,1)
		UPDATE BANGDIEM
		SET DIEM=@Diem WHERE MAMH=@MAMH AND MASV=@MASV AND LAN=@LAN
		SELECT @Diem

GO
/****** Object:  StoredProcedure [dbo].[sp_checkCauHoi1Exist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_checkCauHoi1Exist]
  @X int
AS
 IF  (exists(select CAUHOI from  dbo.BODE  where CAUHOI = @X))
	SELECT '1'
 ELSE
 IF  (exists(select CAUHOI from  LINK0.TN_CSDLPT.dbo.BODE  where CAUHOI = @X))
	SELECT '1'
  ELSE  -- không có khoa
     SELECT '0'
GO
/****** Object:  StoredProcedure [dbo].[sp_checkCauHoiExist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_checkCauHoiExist]
  @X int
AS
 IF  exists(select CAUHOI from  dbo.BODE  where CAUHOI =@X)
	SELECT '1'
 ELSE
 IF  exists(select CAUHOI from  LINK0.TN_CSDLPT.dbo.BODE  where CAUHOI =@X)
	SELECT '1'
  ELSE  -- không có khoa
     SELECT '0'
GO
/****** Object:  StoredProcedure [dbo].[sp_checkDaThi]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_checkDaThi]
	@maMH nchar(5),
	@lan int,
	@maLop nchar(15)
AS
DECLARE @checked VARCHAR(50);
DECLARE  @count INT = 0;

 SELECT @count = COUNT(*) FROM BANGDIEM, SINHVIEN WHERE BANGDIEM.MAMH=@maMH 
 and BANGDIEM.LAN = @lan and BANGDIEM.MASV = SINHVIEN.MASV and SINHVIEN.MALOP = @maLop;

IF @count > 0
 select '1'
 ELSE
 select '0'
GO
/****** Object:  StoredProcedure [dbo].[sp_checkGiaoVienExist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_checkGiaoVienExist]
  @X nchar(8)
AS
 IF  exists(select MAGV from  dbo.GIAOVIEN  where MAGV =@X)
	SELECT '1'
 ELSE
 IF  exists(select MAGV from  LINK0.TN_CSDLPT.dbo.GIAOVIEN  where MAGV =@X)
	SELECT '1'
  ELSE  -- không có khoa
     SELECT '0'
GO
/****** Object:  StoredProcedure [dbo].[sp_checkKhoaExist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_checkKhoaExist]
  @X nchar(8)
AS
 IF  exists(select MAKH from  dbo.KHOA  where MAKH =@X)
	SELECT '1'
 ELSE
 IF  exists(select MAKH from  LINK0.TN_CSDLPT.dbo.KHOA  where MAKH =@X)
	SELECT '1'
  ELSE  -- không có khoa
     SELECT '0'
GO
/****** Object:  StoredProcedure [dbo].[sp_checkLopExist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_checkLopExist]
  @X nchar(15)
AS
 IF  exists(select MALOP from  dbo.LOP  where MALOP =@X)
	SELECT '1'
 ELSE
 IF  exists(select MALOP from  LINK0.TN_CSDLPT.dbo.LOP  where MALOP =@X)
	SELECT '1'
  ELSE  -- không có khoa
     SELECT '0'
GO
/****** Object:  StoredProcedure [dbo].[sp_checkMonHocExist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_checkMonHocExist]
  @X nchar(5)
AS
 IF  exists(select MAMH from  dbo.MONHOC  where MAMH =@X)
	SELECT '1'
 ELSE
	SELECT '0'

GO
/****** Object:  StoredProcedure [dbo].[sp_checkSinhVienExist]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_checkSinhVienExist]
  @X nchar(8)
AS
 IF  exists(select MASV from  dbo.SINHVIEN  where MASV =@X)
	SELECT '1'
 ELSE
 IF  exists(select MASV from  LINK0.TN_CSDLPT.dbo.SINHVIEN  where MASV =@X)
	SELECT '1'
  ELSE  -- không có khoa
     SELECT '0'
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP_GV]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP_GV]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
	--Trả về tên user lúc tạo, thường nó là mã gv hoặc mã sv

 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM GIAOVIEN  WHERE MAGV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP_SV]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DANGNHAP_SV]
@MaSv char(8), @Password nvarchar(20)
as
SELECT MASV=(SELECT MASV FROM SINHVIEN  WHERE MASV = @MaSv and PASSWORD=@Password ),
  HOTEN = (SELECT HO+ ' '+ TEN FROM SINHVIEN  WHERE MASV = @MaSv and PASSWORD=@Password ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME='sinhvien'))
GO
/****** Object:  StoredProcedure [dbo].[SP_INKETQUATHI]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INKETQUATHI] @maSv nchar(8), @maMh char(5), @lan smallint
AS
DECLARE @MaBD nvarchar(50)
IF EXISTS (SELECT* FROM BANGDIEM WHERE MASV= @maSv AND MAMH =@maMh AND LAN =@lan)
BEGIN
	SELECT @MaBD=(RTRIM(CAST(MASV AS nvarchar(10)))+RTRIM(CAST(MAMH AS nvarchar(10)))+RTRIM(CAST(LAN AS nvarchar(1)))) FROM BANGDIEM 
	WHERE MASV=@maSv AND MAMH=@maMh AND LAN=@lan
	SELECT CauSo, NoiDung, A,B,C,D, DapAn, DaChon
	FROM BAITHI 
	WHERE MaBD=@MaBD
END
ElSE 
BEGIN
	RAISERROR('Sai mã sinh viên hoặc môn học hoặc lần thi!',16,1)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KTLANTHI]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KTLANTHI]
@MASV CHAR(8), @MAMH CHAR(5), @LAN INT
AS

IF EXISTS (SELECT * FROM BANGDIEM WHERE MASV= @MASV AND MAMH =@MAMH AND LAN =@LAN)
	raiserror ('Sinh viên đã thi lần này, không được thi lại',16,1)

GO
/****** Object:  StoredProcedure [dbo].[SP_KtSoCauThi]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_KtSoCauThi] @Socauthi int, @TrinhDo char(1), @MonHoc char(5)
AS

	DECLARE  @SoCauCoSan int, @SoCauLoaiThapHon int
--	SELECT @SoCauCoSan = count(*) FROM BODE WHERE TRINHDO = @TrinhDo
	set @SoCauCoSan = (select count(*) FROM BODE WHERE TRINHDO = @TrinhDo and MAMH = @MonHoc)
	
	IF (@TrinhDo = 'C' and @SoCauCoSan >= @Socauthi)
			BEGIN 
				SELECT '1'
			END
	ELSE IF (@TrinhDo = 'C' and @SoCauCoSan < @Socauthi)
			BEGIN 
				SELECT N'Thiếu ' + CAST((@Socauthi - @SoCauCoSan) as varchar(10)) + N' câu trình độ ' + @TrinhDo 
			END

	ELSE IF (@TrinhDo = 'B' and @SoCauCoSan >= @Socauthi)
			BEGIN 
				SELECT '1'
			END
	ELSE IF (@TrinhDo = 'B' and @SoCauCoSan <  @Socauthi)
			BEGIN 
			SELECT @SoCauLoaiThapHon = count(*) FROM BODE WHERE TRINHDO = 'C' and MAMH = @MonHoc
			IF(@SoCauCoSan < FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon >= FLOOR(@Socauthi * 0.3))
				BEGIN
				SELECT N'Thiếu ' + CAST((FLOOR(@Socauthi * 0.7) - @SoCauCoSan)as varchar(10)) + N' câu trình độ ' + @TrinhDo 
				END
			IF (@SoCauCoSan >= FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon >= (@Socauthi- @SoCauCoSan))
				BEGIN 
				SELECT '1'
				END
			IF(@SoCauCoSan >= FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon < (@Socauthi - @SoCauCoSan))
				BEGIN
				SELECT N'Thiếu ' + CAST((@Socauthi - (@SoCauCoSan + @SoCauLoaiThapHon))as varchar(10)) + N' câu trình độ C hoặc B'
				END
			IF(@SoCauCoSan < FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon < FLOOR(@Socauthi * 0.3))
				BEGIN
				SELECT N'Thiếu ' + CAST((FLOOR(@Socauthi * 0.7) - @SoCauCoSan)as varchar(10)) + N' câu trình độ B và '+ CAST((@Socauthi - (FLOOR(@Socauthi * 0.7) + @SoCauLoaiThapHon))as varchar(10)) + N' câu trình độ C hoặc B'
				END
			END			
	ELSE IF (@TrinhDo = 'A' and @SoCauCoSan <  @Socauthi)
			BEGIN 
			SELECT @SoCauLoaiThapHon = count(*) FROM BODE WHERE TRINHDO = 'B' and MAMH = @MonHoc
			IF(@SoCauCoSan < FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon >= FLOOR(@Socauthi * 0.3))
				BEGIN
				SELECT N'Thiếu ' + CAST((FLOOR(@Socauthi * 0.7) - @SoCauCoSan)as varchar(10)) + N' câu trình độ ' + @TrinhDo 
				END
			IF (@SoCauCoSan >= FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon >= (@Socauthi- @SoCauCoSan))
				BEGIN 
				SELECT '1'
				END
			IF(@SoCauCoSan >= FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon < (@Socauthi - @SoCauCoSan))
				BEGIN
				SELECT N'Thiếu ' + CAST((@Socauthi - (@SoCauCoSan + @SoCauLoaiThapHon))as varchar(10)) + N'  câu trình độ B hoặc A'
				END
			IF(@SoCauCoSan < FLOOR(@Socauthi * 0.7) and @SoCauLoaiThapHon < FLOOR(@Socauthi * 0.3))
				BEGIN
				SELECT N'Thiếu ' + CAST((FLOOR(@Socauthi * 0.7) - @SoCauCoSan)as varchar(10)) + N' câu trình độ A và '+ CAST((@Socauthi - (FLOOR(@Socauthi * 0.7) + @SoCauLoaiThapHon))as varchar(10)) + N' câu trình độ B hoặc A'
				END
			END	
	ELSE IF (@TrinhDo = 'A' and @SoCauCoSan >= @Socauthi)
			BEGIN 
				SELECT '1'
			END	
GO
/****** Object:  StoredProcedure [dbo].[sp_LanDangKy]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_LanDangKy]
	 @MALOP char(8),
	 @MAMH  char(5)
AS
SELECT gvdk.LAN
FROM GIAOVIEN_DANGKY as gvdk
WHERE gvdk.MALOP = @MALOP and gvdk.MAMH = @MAMH
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYBAITHI]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYBAITHI] @maLop nchar(8),@maSV nchar(8), @maMH nchar(5), @lan smallint
AS
	DECLARE @ngayThi datetime, @soCauThi int, @trinhDo nchar(1), @maBD nvarchar(50), @res int, @subRes INT, @TDDuoi nchar(1),
		 @CauTDDuoi INT, @CauTDDuoi2 INT ,@CauCungTD INT

	
		-- res: so cau tim duoc trong BO DE
		SET XACT_ABORT ON
		BEGIN TRANSACTION

		BEGIN TRY
		   -- select GIAOVIEN_DANGKI
			SELECT  @ngayThi = NGAYTHI, @soCauThi = SOCAUTHI, @trinhDo = TRINHDO FROM GIAOVIEN_DANGKY WHERE MAMH = @maMH AND MALOP = @maLop AND LAN = @lan
		
			--insert bang diem
			SAVE TRANSACTION _BANGDIEM

			INSERT INTO BANGDIEM(MASV, MAMH, LAN, NGAYTHI)
			VALUES (@maSV, @maMH, @lan, @ngayThi);
			SELECT @maBD = CONCAT(RTRIM(@maSV),RTRIM(@maMH),@lan) FROM SINHVIEN

			-- random cau hoi + insert bai thi
			--Trình độ A
			IF(@trinhDo = 'A')
			BEGIN 
				SET @TDDuoi = 'B'
			END
			--Trình độ B
			ELSE IF(@trinhDo = 'B')
			BEGIN 
				SET @TDDuoi = 'C'
			END

			--Trình độ C
			IF(@trinhDo = 'C')
			BEGIN
			SELECT @res = COUNT(CAUHOI) FROM BODE 
			WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  

				IF(@res >= @soCauThi)
				BEGIN
					INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
					SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID()

					-- Trả về kết quả 
					SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD

				END
				else if(@res < @soCauThi)
				BEGIN
					SELECT @subRes = COUNT(CAUHOI) FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
				
					if(@subRes < @soCauThi - @res)
						BEGIN
								ROLLBACK TRANSACTION _BANGDIEM
							--RAISERROR('Không đủ số câu để tạo đề!', 16, 1)
							SELECT N'Không đủ số câu để tạo đề!' 
						END
					else if(@subRes >= @soCauThi - @res)
					BEGIN 
						INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
						SELECT TOP (@res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
						WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						ORDER BY  NEWID()
		
						INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
						SELECT TOP (@soCauThi - @res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
						WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						ORDER BY  NEWID()
					
						-- trả về kết quả
						SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD
					END
				END
			END
			-- trình độ A hoặc B
			ELSE 
			BEGIN
				-- đổ câu hỏi vào bảng tạm,lấy toàn bộ trình độ A
				SELECT  CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD INTO #DETHI FROM BODE 
				WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  

				SELECT @res = COUNT(CAUHOI) FROM BODE --lưu Số lượng trình độ A
				WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
		
				IF(@res >= @soCauThi)--if(A>=100%)
				BEGIN
					INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
					SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD FROM #DETHI -- lấy dữ liệu random từ bảng tạm #dethi
					ORDER BY  NEWID()

					-- Trả về kết quả để in câu hỏi thi ra màn hình
					SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD
				END

				ELSE if(@res >= @soCauThi*0.7) -- if(A>=70%)
				BEGIN
					insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- Lưu B
					SELECT  TOP (@soCauThi - @res) CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD  FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID() --random

					SELECT @CauTDDuoi = COUNT(CAUHOI) FROM BODE -- Lấy số lượng B
					WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					
					IF(@CauTDDuoi >= @soCauThi - @res)-- B >= 100% - A
						BEGIN 
							INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
							SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
							ORDER BY  NEWID()--random

							SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
						END
					ELSE --chuyển cơ sở
						BEGIN
							insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD ) -- Lấy A2
							SELECT TOP (@soCauThi - @res - @CauTDDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
							WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
							ORDER BY  NEWID() --random

							SELECT @CauCungTD = COUNT(CAUHOI) FROM BODE -- lưu số lượng câu A2
							WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							SELECT @CauTDDuoi2 = COUNT(CAUHOI) FROM BODE --Lưu số Lượng B2
							WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							IF(@CauCungTD >= @soCauThi - @res - @CauTDDuoi ) --if(A2 >= 100-A-B)
							BEGIN
								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END

							ELSE IF(@CauTDDuoi2 > @soCauThi - @res - @CauCungTD - @CauTDDuoi)-- If( B2 >= 100 -A - A2 - B)
							BEGIN
								insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B2
								SELECT TOP (@soCauThi - @res - @CauCungTD - @CauTDDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
								WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
								ORDER BY  NEWID() --random

								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD) -- đổ dữ  liệu vào bài thi
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END 

							ELSE 
							BEGIN
								ROLLBACK TRANSACTION _BANGDIEM
								SELECT N'Không đủ số câu để tạo đề!' 
							END

						END
				END
				ELSE 
				BEGIN -- đề cùng loại ở cơ sở gốc không đủ
					insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD ) -- Lấy A2
					SELECT  TOP (@soCauThi - @res) CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD  FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID() --random

					SELECT @CauCungTD = COUNT(CAUHOI) FROM BODE --Lưu số câu A2
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					
					IF(@CauCungTD >= @soCauThi - @res)-- A2 >= 100% - A
						BEGIN 
							INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
							SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
							ORDER BY  NEWID()--random

							SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
						END
					ELSE IF(@CauCungTD >= @soCauThi*0.7 - @res) -- If(A2 >= 70%-A)
					BEGIN
							insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B cùng cs
							SELECT TOP (@soCauThi - @res - @CauCungTD) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
							WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV  IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
							ORDER BY  NEWID() --random

							SELECT @CauTDDuoi = COUNT(CAUHOI) FROM BODE -- Lưu số lượng B
							WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							SELECT @CauTDDuoi2 = COUNT(CAUHOI) FROM BODE --Lưu số lượng B2
							WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							IF(@CauTDDuoi >= @soCauThi - @res - @CauCungTD ) --if(B >= 100-A-A2)
							BEGIN
								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END

							ELSE IF(@CauTDDuoi2 > @soCauThi - @res - @CauCungTD - @CauTDDuoi)-- If( B2 >= 100 -A - A2 - B)
							BEGIN
								insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B2
								SELECT TOP (@soCauThi - @res - @CauCungTD - @CauTDDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
								WHERE MAMH = @maMH AND TRINHDO = @TDDuoi AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
								ORDER BY  NEWID() --random

								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD) -- đổ dữ  liệu vào bài thi
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END 

							ELSE 
							BEGIN
								ROLLBACK TRANSACTION _BANGDIEM
								SELECT N'Không đủ số câu để tạo đề!' 
							END

					END
					ELSE 
					BEGIN
						ROLLBACK TRANSACTION _BANGDIEM
						SELECT N'Không đủ số câu để tạo đề!' 
					END
				END
			END-- end trình độ A hoặc B
			if exists (select MaBD from BAITHI where MABD=@maBD)
				begin
					update BAITHI
					set MASV=@maSV
				end
	COMMIT
		END TRY
		BEGIN CATCH
		   ROLLBACK
		   DECLARE @ErrorMessage VARCHAR(2000)
		   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
		   --RAISERROR(@ErrorMessage, 16, 1)
		END CATCH

GO
/****** Object:  StoredProcedure [dbo].[sp_LopDangKy]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_LopDangKy]
AS
SELECT l.TENLOP,l.MALOP 
FROM LOP as l, GIAOVIEN_DANGKY as gvdk
WHERE l.MALOP = gvdk.MALOP
GO
/****** Object:  StoredProcedure [dbo].[sp_MonHocDangKy]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_MonHocDangKy]
	 @MALOP char(8)
AS
SELECT mh.TENMH,mh.MAMH 
FROM MONHOC as mh, GIAOVIEN_DANGKY as gvdk
WHERE mh.MAMH = gvdk.MAMH and gvdk.MALOP = @MALOP
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TN_CSDLPT'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'TRUONG' OR @ROLE= 'COSO'
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    --EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END
RETURN 0  -- THANH CONG

GO
/****** Object:  StoredProcedure [dbo].[SP_THI_THU]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_THI_THU] @maLop nchar(8),@maGV nchar(8), @maMH nchar(5), @lan smallint
AS
	DECLARE @ngayThi datetime, @soCauThi int, @trinhDo nchar(1), @maBD nvarchar(50), @res int, @subRes INT, @TrinhDoDuoi nchar(1),
		 @CauDuoi INT, @CauDuoi2 INT ,@CauCUng INT

	
		-- res: so cau tim duoc trong BO DE
		SET XACT_ABORT ON
		BEGIN TRANSACTION

		BEGIN TRY
		   -- select GIAOVIEN_DANGKI
			SELECT  @ngayThi = NGAYTHI, @soCauThi = SOCAUTHI, @trinhDo = TRINHDO FROM GIAOVIEN_DANGKY WHERE MAMH = @maMH AND MALOP = @maLop AND LAN = @lan
		
			--insert bang diem
			SAVE TRANSACTION _BANGDIEM

			SELECT @maBD = CONCAT(RTRIM(@maGV),RTRIM(@maMH),@lan)

			-- random cau hoi + insert bai thi
			--Trình độ A
			IF(@trinhDo = 'A')
			BEGIN 
				SET @TrinhDoDuoi = 'B'
			END
			--Trình độ B
			ELSE IF(@trinhDo = 'B')
			BEGIN 
				SET @TrinhDoDuoi = 'C'
			END

			--Trình độ C
			IF(@trinhDo = 'C')
			BEGIN
			SELECT @res = COUNT(CAUHOI) FROM BODE 
			WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  

				IF(@res >= @soCauThi)
				BEGIN
					INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
					SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID()

					-- Trả về kết quả 
					SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD

				END
				else if(@res < @soCauThi)
				BEGIN
					SELECT @subRes = COUNT(CAUHOI) FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
				
					if(@subRes < @soCauThi - @res)
						BEGIN
								ROLLBACK TRANSACTION _BANGDIEM
							--RAISERROR('Không đủ số câu để tạo đề!', 16, 1)
							SELECT N'Không đủ số câu để tạo đề!' 
						END
					else if(@subRes >= @soCauThi - @res)
					BEGIN 
						INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
						SELECT TOP (@res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
						WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						ORDER BY  NEWID()
		
						INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
						SELECT TOP (@soCauThi - @res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
						WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						ORDER BY  NEWID()
					
						-- trả về kết quả
						SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD
					END
				END
			END
			-- trình độ A hoặc B
			ELSE 
			BEGIN
				-- đổ câu hỏi vào bảng tạm,lấy toàn bộ trình độ A
				SELECT  CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD INTO #DETHI FROM BODE 
				WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  

				SELECT @res = COUNT(CAUHOI) FROM BODE --lưu Số lượng trình độ A
				WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
		
				IF(@res >= @soCauThi)--if(A>=100%)
				BEGIN
					INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
					SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD FROM #DETHI -- lấy dữ liệu random từ bảng tạm #dethi
					ORDER BY  NEWID()

					-- Trả về kết quả để in câu hỏi thi ra màn hình
					SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD
				END

				ELSE if(@res >= @soCauThi*0.7) -- if(A>=70%)
				BEGIN
					insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- Lưu B
					SELECT  TOP (@soCauThi - @res) CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD  FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID() --random

					SELECT @CauDuoi = COUNT(CAUHOI) FROM BODE -- Lấy số lượng B
					WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					
					IF(@CauDuoi >= @soCauThi - @res)-- B >= 100% - A
						BEGIN 
							INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
							SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
							ORDER BY  NEWID()--random

							SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
						END
					ELSE --chuyển cơ sở
						BEGIN
							insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD ) -- Lấy A2
							SELECT TOP (@soCauThi - @res - @CauDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
							WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
							ORDER BY  NEWID() --random

							SELECT @CauCUng = COUNT(CAUHOI) FROM BODE -- lưu số lượng câu A2
							WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							SELECT @CauDuoi2 = COUNT(CAUHOI) FROM BODE --Lưu số Lượng B2
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							IF(@CauCUng >= @soCauThi - @res - @CauDuoi ) --if(A2 >= 100-A-B)
							BEGIN
								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END

							ELSE IF(@CauDuoi2 > @soCauThi - @res - @CauCUng - @CauDuoi)-- If( B2 >= 100 -A - A2 - B)
							BEGIN
								insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B2
								SELECT TOP (@soCauThi - @res - @CauCUng - @CauDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
								WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
								ORDER BY  NEWID() --random

								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD) -- đổ dữ  liệu vào bài thi
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END 

							ELSE 
							BEGIN
								ROLLBACK TRANSACTION _BANGDIEM
								SELECT N'Không đủ số câu để tạo đề!' 
							END

						END
				END
				ELSE 
				BEGIN -- đề cùng loại ở cơ sở gốc không đủ
					insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD ) -- Lấy A2
					SELECT  TOP (@soCauThi - @res) CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD  FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID() --random

					SELECT @CauCUng = COUNT(CAUHOI) FROM BODE --Lưu số câu A2
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					
					IF(@CauCUng >= @soCauThi - @res)-- A2 >= 100% - A
						BEGIN 
							INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
							SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
							ORDER BY  NEWID()--random

							SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
						END
					ELSE IF(@CauCUng >= @soCauThi*0.7 - @res) -- If(A2 >= 70%-A)
					BEGIN
							insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B cùng cs
							SELECT TOP (@soCauThi - @res - @CauCUng) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV  IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
							ORDER BY  NEWID() --random

							SELECT @CauDuoi = COUNT(CAUHOI) FROM BODE -- Lưu số lượng B
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							SELECT @CauDuoi2 = COUNT(CAUHOI) FROM BODE --Lưu số lượng B2
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							IF(@CauDuoi >= @soCauThi - @res - @CauCUng ) --if(B >= 100-A-A2)
							BEGIN
								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD)
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END

							ELSE IF(@CauDuoi2 > @soCauThi - @res - @CauCUng - @CauDuoi)-- If( B2 >= 100 -A - A2 - B)
							BEGIN
								insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B2
								SELECT TOP (@soCauThi - @res - @CauCUng - @CauDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
								WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
								ORDER BY  NEWID() --random

								INSERT INTO BAITHI (CauSo, NoiDung, A, B, C, D,DapAn, MaBD) -- đổ dữ  liệu vào bài thi
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random

								SELECT CauHoi,CauSo,NoiDung, A,B,C,D, DapAn, MaBD FROM BAITHI WHERE MaBD = @maBD -- In kết quả để thi
							END 

							ELSE 
							BEGIN
								ROLLBACK TRANSACTION _BANGDIEM
								SELECT N'Không đủ số câu để tạo đề!' 
							END

					END
					ELSE 
					BEGIN
						ROLLBACK TRANSACTION _BANGDIEM
						SELECT N'Không đủ số câu để tạo đề!' 
					END
				END
			END-- end trình độ A hoặc B
	COMMIT
		END TRY
		BEGIN CATCH
		   ROLLBACK
		   DECLARE @ErrorMessage VARCHAR(2000)
		   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
		   --RAISERROR(@ErrorMessage, 16, 1)
		END CATCH

GO
/****** Object:  StoredProcedure [dbo].[SP_THONGTIN_BANGKETQUA]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONGTIN_BANGKETQUA]
@maSv nchar(8), @maMh char(5), @lan smallint
AS
SELECT SINHVIEN.MALOP, HOTEN=(SINHVIEN.HO+''+SINHVIEN.TEN),MONHOC.TENMH,CAST(BANGDIEM.NGAYTHI AS date), BANGDIEM.LAN FROM BANGDIEM INNER JOIN MONHOC ON MONHOC.MAMH=BANGDIEM.MAMH
INNER JOIN SINHVIEN ON SINHVIEN.MASV=BANGDIEM.MASV
WHERE BANGDIEM.MASV=@maSv AND BANGDIEM.MAMH=@maMh AND BANGDIEM.LAN=@lan

GO
/****** Object:  StoredProcedure [dbo].[SP_THONGTIN_SINHVIEN]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONGTIN_SINHVIEN]
@MaSv char(8), @Password nvarchar(20)
as
SELECT SINHVIEN.MALOP, LOP.TENLOP
FROM SINHVIEN
INNER JOIN LOP
ON SINHVIEN.MALOP=LOP.MALOP
WHERE MASV = @MaSv and PASSWORD=@Password

GO
/****** Object:  StoredProcedure [dbo].[SP_xemDSDK]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_xemDSDK] @fromDate datetime,
@toDate datetime
AS
	SELECT DISTINCT LOP.TENLOP, MONHOC.TENMH,
	CONCAT(GIAOVIEN.HO,' ',GIAOVIEN.TEN) AS HOTEN_GVDK,
	GVDK.SOCAUTHI, CONVERT(DATE, GVDK.NGAYTHI) AS NGAYTHI, 
	dbo.[checkDaThi](GVDK.MAMH,GVDK.LAN,GVDK.MALOP) AS DATHI  
	FROM (SELECT MALOP,MAMH,MAGV,SOCAUTHI,LAN,NGAYTHI FROM GIAOVIEN_DANGKY WHERE NGAYTHI BETWEEN @fromDate AND @toDate) GVDK,
	LOP,MONHOC,GIAOVIEN
	WHERE lOP.MALOP = GVDK.MALOP and GVDK.MAMH = MONHOC.MAMH and GVDK.MAGV = GIAOVIEN.MAGV
	
	ORDER BY NGAYTHI ASC

GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 10-Jun-22 13:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
  
AS
  EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME

GO
USE [master]
GO
ALTER DATABASE [TN_CSDLPT] SET  READ_WRITE 
GO
