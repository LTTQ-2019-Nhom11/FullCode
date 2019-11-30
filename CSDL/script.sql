USE [QuanLyNhaHang]
GO
/****** Object:  UserDefinedFunction [dbo].[sinhmaCTHD]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[sinhmaCTHD]()
Returns nvarchar(10)
As
Begin
 declare @s nvarchar(10),@max int
 select @max=max(cast(substring(SoHD,3,2) as int)) from tblHoaDon
 if(@max is null) set @max = 1
set @s='00'+ltrim(rtrim(cast(@max as char(2))))
Set @s='HD'+substring(@s,len(@s)-1,2)
Return @s
End
GO
/****** Object:  UserDefinedFunction [dbo].[sinhmaHD]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[sinhmaHD]()
Returns nvarchar(10)
As
Begin
 declare @s nvarchar(10),@max int
 select @max=max(cast(substring(SoHD,3,2) as int))+1 from tblHoaDon
 if(@max is null) set @max = 1
set @s='00'+ltrim(rtrim(cast(@max as char(2))))
Set @s='HD'+substring(@s,len(@s)-1,2)
Return @s
End
GO
/****** Object:  UserDefinedFunction [dbo].[sinhmaNCC]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[sinhmaNCC]()
Returns nvarchar(10)
As
Begin
 declare @s nvarchar(10),@max int
 select @max=max(cast(substring(MaNCC,4,2) as int))+1 from tblNCC
 if(@max is null) set @max = 1
set @s='00'+ltrim(rtrim(cast(@max as char(2))))
Set @s='NCC'+substring(@s,len(@s)-1,2)
Return @s
End
GO
/****** Object:  UserDefinedFunction [dbo].[sinhmaND]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[sinhmaND]()
Returns nvarchar(10)
As
Begin
 declare @s nvarchar(10),@max int
 select @max=max(cast(substring(MaNguoiDung,3,2) as int))+1 from tblNguoiDung
 if(@max is null) set @max = 1
set @s='00'+ltrim(rtrim(cast(@max as char(2))))
Set @s='ND'+substring(@s,len(@s)-1,2)
Return @s
End
GO
/****** Object:  UserDefinedFunction [dbo].[sinhmaNL]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[sinhmaNL]()
Returns nvarchar(10)
As
Begin
 declare @s nvarchar(10),@max int
 select @max=max(cast(substring(MaNL,3,2) as int))+1 from tblNguyenLieu
 if(@max is null) set @max = 1
set @s='00'+ltrim(rtrim(cast(@max as char(2))))
Set @s='NL'+substring(@s,len(@s)-1,2)
Return @s
End
GO
/****** Object:  UserDefinedFunction [dbo].[sinhmaTD]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[sinhmaTD]()
Returns nvarchar(10)
As
Begin
 declare @s nvarchar(10),@max int
 select @max=max(cast(substring(MaThucDon,3,2) as int))+1 from tblThucDon
 if(@max is null) set @max = 1
set @s='00'+ltrim(rtrim(cast(@max as char(2))))
Set @s='TD'+substring(@s,len(@s)-1,2)
Return @s
End
GO
/****** Object:  Table [dbo].[tblBanAn]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBanAn](
	[MaBanAn] [int] NOT NULL,
	[SoGhe] [int] NULL,
 CONSTRAINT [PK_tblBanAn] PRIMARY KEY CLUSTERED 
(
	[MaBanAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTHD]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTHD](
	[SoHD] [nvarchar](10) NULL,
	[MaThucDon] [nvarchar](10) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGoiMon1]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGoiMon1](
	[MaBanAn] [int] NOT NULL,
	[MaThucDon] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[XacNhan] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[SoHD] [nvarchar](10) NOT NULL,
	[MaBanAn] [int] NULL,
	[ThoiGianLap] [datetime] NULL,
	[SoKhach] [int] NULL,
	[MaNVLap] [nvarchar](10) NULL,
	[TongTien] [numeric](18, 0) NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNCC]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNCC](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](11) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNguoiDung]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNguoiDung](
	[MaNguoiDung] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[SDT] [nvarchar](11) NULL,
	[TenDangNhap] [nvarchar](30) NULL,
	[MatKhau] [nvarchar](30) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNguyenLieu]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNguyenLieu](
	[MaNL] [nvarchar](10) NOT NULL,
	[TenNL] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[MaNVNhap] [nvarchar](10) NULL,
	[DonViTinh] [nchar](10) NULL,
	[DonGia] [numeric](18, 0) NULL,
 CONSTRAINT [PK_tblNguyenLieu_1] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhapNL]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhapNL](
	[MaNL] [nvarchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[SoLuong] [int] NULL,
	[XacNhan] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThucDon]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThucDon](
	[MaThucDon] [nvarchar](10) NOT NULL,
	[Loai] [nvarchar](50) NULL,
	[TenThucDon] [nvarchar](50) NULL,
	[DonViTinh] [nchar](10) NULL,
	[DonGia] [numeric](18, 0) NULL,
 CONSTRAINT [PK_tblThucDon] PRIMARY KEY CLUSTERED 
(
	[MaThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblXuatNL]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXuatNL](
	[MaNL] [nvarchar](10) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYC_MuaNL]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYC_MuaNL](
	[MaNL] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[XacNhan] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYeuCauNL]    Script Date: 11/29/2019 4:20:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYeuCauNL](
	[MaNL] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[XacNhan] [nvarchar](20) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCTHD]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHD_tblHoaDon] FOREIGN KEY([SoHD])
REFERENCES [dbo].[tblHoaDon] ([SoHD])
GO
ALTER TABLE [dbo].[tblCTHD] CHECK CONSTRAINT [FK_tblCTHD_tblHoaDon]
GO
ALTER TABLE [dbo].[tblGoiMon1]  WITH CHECK ADD  CONSTRAINT [FK_tblGoiMon1_tblBanAn] FOREIGN KEY([MaBanAn])
REFERENCES [dbo].[tblBanAn] ([MaBanAn])
GO
ALTER TABLE [dbo].[tblGoiMon1] CHECK CONSTRAINT [FK_tblGoiMon1_tblBanAn]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblBanAn] FOREIGN KEY([MaBanAn])
REFERENCES [dbo].[tblBanAn] ([MaBanAn])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblBanAn]
GO
ALTER TABLE [dbo].[tblNguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_tblNguyenLieu_tblNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNCC] ([MaNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblNguyenLieu] CHECK CONSTRAINT [FK_tblNguyenLieu_tblNCC]
GO
ALTER TABLE [dbo].[tblNguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_tblNguyenLieu_tblNguoiDung] FOREIGN KEY([MaNVNhap])
REFERENCES [dbo].[tblNguoiDung] ([MaNguoiDung])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblNguyenLieu] CHECK CONSTRAINT [FK_tblNguyenLieu_tblNguoiDung]
GO
