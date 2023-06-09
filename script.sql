USE [master]
GO
/****** Object:  Database [DuLieu_BanHang]    Script Date: 03/10/22 10:17:31 AM ******/
CREATE DATABASE [DuLieu_BanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DuLieu_BanHang', FILENAME = N'D:\Học_Tập\C#\PhanMen_BanHang\Phan_Mem_Thuc_Tap\SQL\DuLieu_BanHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DuLieu_BanHang_log', FILENAME = N'D:\Học_Tập\C#\PhanMen_BanHang\Phan_Mem_Thuc_Tap\SQL\DuLieu_BanHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DuLieu_BanHang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DuLieu_BanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DuLieu_BanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DuLieu_BanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DuLieu_BanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DuLieu_BanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DuLieu_BanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET RECOVERY FULL 
GO
ALTER DATABASE [DuLieu_BanHang] SET  MULTI_USER 
GO
ALTER DATABASE [DuLieu_BanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DuLieu_BanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DuLieu_BanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DuLieu_BanHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DuLieu_BanHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DuLieu_BanHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DuLieu_BanHang', N'ON'
GO
ALTER DATABASE [DuLieu_BanHang] SET QUERY_STORE = OFF
GO
USE [DuLieu_BanHang]
GO
/****** Object:  Table [dbo].[CHITIETHD]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHD](
	[MaHDBan] [nvarchar](100) NOT NULL,
	[MaHang] [nvarchar](100) NOT NULL,
	[SoLuong] [nvarchar](100) NOT NULL,
	[DonGia] [float] NOT NULL,
	[GiamGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANG]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG](
	[MaHang] [nvarchar](100) NOT NULL,
	[TenHang] [nvarchar](100) NOT NULL,
	[MaTH] [nvarchar](100) NOT NULL,
	[SoLuong] [nvarchar](100) NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[DonGiaBan] [float] NOT NULL,
	[GhiChu] [nvarchar](800) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONBAN]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONBAN](
	[MaHDBan] [nvarchar](100) NOT NULL,
	[MaNV] [nvarchar](100) NOT NULL,
	[NgayBan] [date] NOT NULL,
	[MaKH] [nvarchar](100) NOT NULL,
	[TongTien] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](100) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[HoTen] [nvarchar](100) NOT NULL,
	[TK] [nvarchar](100) NOT NULL,
	[MK] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](100) NOT NULL,
	[XacNhanMK] [nvarchar](100) NOT NULL,
	[Quyen] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](100) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](800) NOT NULL,
	[DienThoai] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUONGHIEU]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUONGHIEU](
	[MaTH] [nvarchar](100) NOT NULL,
	[TenTH] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHD] ([MaHDBan], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB031022_101029', N'MH095510_031022', N'1', 11000000, 2, 10780000)
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [MaTH], [SoLuong], [DonGiaNhap], [DonGiaBan], [GhiChu]) VALUES (N'MH095510_031022', N'RYZEN 5 5600X & RADEON RX 6500XT', N'AMD', N'9', 10000000, 11000000, N'Với vi kiến trúc "Zen 3" mới, thay đổi cấp cao lớn nhất với CCD là việc AMD mở rộng CCX để hiện có tới tám lõi (về cơ bản chiếm toàn bộ CCD). Hiện có một CCX 8 lõi cho mỗi CCD. Lợi tức lớn nhất của sự thay đổi này phải được cải thiện độ trễ giữa các lõi vì tám lõi hiện chia sẻ cùng một bộ nhớ đệm L3; cổ tức lớn khác phải là kích thước bộ nhớ cache. Mỗi lõi trên CCD hiện có quyền truy cập vào L3 32 MB đầy đủ, do đó, các khối lượng công việc được phân luồng nhẹ sẽ thấy hiệu suất tăng lên.')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [MaTH], [SoLuong], [DonGiaNhap], [DonGiaBan], [GhiChu]) VALUES (N'MH095648_031022', N'Màn hình Asus Proart PA248QV 24″ 1920×1200 IPS 75Hz HDMI', N'ASUS', N'10', 6200000, 6500000, N'Màn hình ProArt PA248QV được ASUS thiết kế theo phong cách hiện đại, được thiết kế đáp ứng nhu cầu các chuyên gia sáng tạo, từ chỉnh sửa ảnh và video cho đến thiết kế đồ họa.
Bạn có thể dễ dàng điều chỉnh màn hình theo chiều cao lên xuống, trục xoay, độ nghiêng giúp bạn làm việc sáng tạo và dễ dàng hơn.
Màn hình ProArt cung cấp 100% sRGB tiên chuẩn công nghiệp và 100% Rec.')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [MaTH], [SoLuong], [DonGiaNhap], [DonGiaBan], [GhiChu]) VALUES (N'MH100503_031022', N'AORUS GeForce RTX™ 3090 XTREME WATERFORCE 24G', N'GGB', N'10', 114000000, 115000000, N'NVIDIA Ampere Streaming Multiprocessors
2nd Generation RT Cores
3rd Generation Tensor Cores
Powered by GeForce RTX™ 3090
Integrated with 24GB GDDR6X 384-bit memory interface
WATERFORCE all-in-one cooling system
240mm radiator with 2x 120mm ARGB fans
RGB Fusion 2.0
6 Outputs
Protection metal back plate
4 Years Warranty (Online registration required)
1785 MHz (Reference Card: 1695 MHz)')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [MaTH], [SoLuong], [DonGiaNhap], [DonGiaBan], [GhiChu]) VALUES (N'MH100556_031022', N'CPU Intel Core i9 11900', N'INT', N'10', 10600000, 10700000, N'Bộ xử lý: I9 11900
Bộ nhớ đệm: 16 MB Cache
Tần số cơ sở của bộ xử lý: 2.50 GHz
Tần số turbo tối đa: 5.20 GHz
Hỗ trợ socket: FCLGA1200
Số lõi: 8, Số luồng: 16
TDP: 65 W
Đồ họa tích hợp: Intel® UHD Graphics 750')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [MaTH], [SoLuong], [DonGiaNhap], [DonGiaBan], [GhiChu]) VALUES (N'MH100731_031022', N'Bàn phím cơ Logitech G913 TKL WIRELESS RGB', N'LGT', N'10', 4190000, 4200000, N'Được chế tạo tỉ mỉ từ các vật liệu cao cấp, G913 TKL có thiết kế tinh xảo với vẻ đẹp, sức mạnh và hiệu suất vô song. G913 TKL có các công nghệ tiên tiến tương tự như G915 ,nhưng nhỏ gọn hơn, phù hợp với những người có bàn làm việc nhỏ ,phải di chuyển nhiều hay đơn giản là chỉ thích sự nhỏ gọn.Thiết kế cực kỳ mỏng nhưng có độ bền cao cùng với sự thoải mái ,G913 TKL luôn sẵn sàng cho những màn chơi game cường độ cao, G913 TKL thực sự là thế hệ bàn phím cơ chơi game của tương lai.')
GO
INSERT [dbo].[HOADONBAN] ([MaHDBan], [MaNV], [NgayBan], [MaKH], [TongTien]) VALUES (N'HDB031022_101029', N'NV100927_031022', CAST(N'2022-03-10' AS Date), N'KH101008_031022', 10780000)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai]) VALUES (N'KH101008_031022', N'Khách Hàng A', N'Gò Công', N'(012) 365-9999')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [DienThoai], [NgaySinh]) VALUES (N'NV100927_031022', N'Nhân Viên A', N'Nam', N'Gò Công', N'(033) 961-5130', CAST(N'1999-06-15' AS Date))
GO
INSERT [dbo].[THUONGHIEU] ([MaTH], [TenTH]) VALUES (N'AMD', N'Advanced Micro Devices (AMD)')
INSERT [dbo].[THUONGHIEU] ([MaTH], [TenTH]) VALUES (N'ASUS', N'AsusTek Computer Inc.')
INSERT [dbo].[THUONGHIEU] ([MaTH], [TenTH]) VALUES (N'DELL', N'Dell (Inc) International country.')
INSERT [dbo].[THUONGHIEU] ([MaTH], [TenTH]) VALUES (N'GGB', N'Gigabyte Technology')
INSERT [dbo].[THUONGHIEU] ([MaTH], [TenTH]) VALUES (N'INT', N'Intel (Integrated Electronics)')
INSERT [dbo].[THUONGHIEU] ([MaTH], [TenTH]) VALUES (N'LGT', N'Logitech International S.A.')
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANG] ([MaHang])
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD FOREIGN KEY([MaHDBan])
REFERENCES [dbo].[HOADONBAN] ([MaHDBan])
GO
ALTER TABLE [dbo].[HANG]  WITH CHECK ADD FOREIGN KEY([MaTH])
REFERENCES [dbo].[THUONGHIEU] ([MaTH])
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
/****** Object:  StoredProcedure [dbo].[SP_AuthoLogin]    Script Date: 03/10/22 10:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_AuthoLogin]
@Username nvarchar(100),
@Password nvarchar(100)
as
begin
    if exists (select * from Login where TK = @Username and MK = @Password and Quyen = 1)	-- 1 ==> Nhân Viên
        select 1 as code
    else if exists (select * from Login where TK = @Username and MK = @Password and Quyen = 0) -- 0 ==> Quản lý 
        select 0 as code
    else if exists(select * from Login where TK != @Username and MK != @Password) 
        select 2 as code
    else select 3 as code
end
GO
USE [master]
GO
ALTER DATABASE [DuLieu_BanHang] SET  READ_WRITE 
GO
