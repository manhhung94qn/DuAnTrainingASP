USE [master]
GO
/****** Object:  Database [GasStation]    Script Date: 2016/03/15 10:34:19 ******/
CREATE DATABASE [GasStation] ON  PRIMARY 
( NAME = N'GasStation', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\GasStation.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GasStation_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\GasStation_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GasStation] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GasStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GasStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GasStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GasStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GasStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GasStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [GasStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GasStation] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GasStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GasStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GasStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GasStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GasStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GasStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GasStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GasStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GasStation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GasStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GasStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GasStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GasStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GasStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GasStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GasStation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GasStation] SET  MULTI_USER 
GO
ALTER DATABASE [GasStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GasStation] SET DB_CHAINING OFF 
GO
USE [GasStation]
GO
/****** Object:  Table [dbo].[GasStation]    Script Date: 2016/03/15 10:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GasStation](
	[GasStationId] [bigint] IDENTITY(1,1) NOT NULL,
	[GasStationName] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[District] [bigint] NOT NULL,
	[OpeningTime] [nvarchar](50) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[Rating] [varchar](5) NULL,
	[InsertedAt] [datetime] NOT NULL,
	[InsertedBy] [bigint] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	[UpdatedBy] [bigint] NOT NULL,
	[DeletedAt] [datetime] NULL,
	[DeletedBy] [bigint] NULL,
 CONSTRAINT [PK_GasStation_1] PRIMARY KEY CLUSTERED 
(
	[GasStationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GasStationFeedback]    Script Date: 2016/03/15 10:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GasStationFeedback](
	[GasStationFeedbackId] [bigint] IDENTITY(1,1) NOT NULL,
	[GasStationId] [bigint] NOT NULL,
	[Feedback] [nvarchar](500) NOT NULL,
	[FeedbackAt] [datetime] NOT NULL,
	[FeedbackBy] [bigint] NULL,
 CONSTRAINT [PK_GasStationFeedback] PRIMARY KEY CLUSTERED 
(
	[GasStationFeedbackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GasStationGasType]    Script Date: 2016/03/15 10:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GasStationGasType](
	[GasStationGasTypeId] [bigint] IDENTITY(1,1) NOT NULL,
	[GasStationId] [bigint] NULL,
	[GasType] [varchar](5) NULL,
 CONSTRAINT [PK_GasStationGasType] PRIMARY KEY CLUSTERED 
(
	[GasStationGasTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[M_District]    Script Date: 2016/03/15 10:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_District](
	[DistrictId] [bigint] IDENTITY(1,1) NOT NULL,
	[DistrictName] [nvarchar](50) NULL,
 CONSTRAINT [PK_M_District] PRIMARY KEY CLUSTERED 
(
	[DistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[M_Type]    Script Date: 2016/03/15 10:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[M_Type](
	[TypeId] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeCode] [varchar](5) NOT NULL,
	[TypeText] [nvarchar](50) NOT NULL,
	[TypeType] [int] NOT NULL,
 CONSTRAINT [PK_M_Type] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 2016/03/15 10:34:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[UserType] [varchar](5) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[GasStation] ON 

INSERT [dbo].[GasStation] ([GasStationId], [GasStationName], [Address], [District], [OpeningTime], [Longitude], [Latitude], [Rating], [InsertedAt], [InsertedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (2, N'Cây xăng ABC', N'Số 123, Đường DEF', 1, N'24h', 10.369977, 10.213456568, N'00001', CAST(0x0000A5C600000000 AS DateTime), 1, CAST(0x0000A5C600000000 AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[GasStation] OFF
SET IDENTITY_INSERT [dbo].[GasStationFeedback] ON 

INSERT [dbo].[GasStationFeedback] ([GasStationFeedbackId], [GasStationId], [Feedback], [FeedbackAt], [FeedbackBy]) VALUES (3, 2, N'Cây xăng tốt', CAST(0x0000A5C600000000 AS DateTime), NULL)
INSERT [dbo].[GasStationFeedback] ([GasStationFeedbackId], [GasStationId], [Feedback], [FeedbackAt], [FeedbackBy]) VALUES (4, 2, N'Cây xăng khá OK', CAST(0x0000A5C600000000 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[GasStationFeedback] OFF
SET IDENTITY_INSERT [dbo].[GasStationGasType] ON 

INSERT [dbo].[GasStationGasType] ([GasStationGasTypeId], [GasStationId], [GasType]) VALUES (1, 2, N'00001')
INSERT [dbo].[GasStationGasType] ([GasStationGasTypeId], [GasStationId], [GasType]) VALUES (2, 2, N'00002')
INSERT [dbo].[GasStationGasType] ([GasStationGasTypeId], [GasStationId], [GasType]) VALUES (3, 2, N'00004')
SET IDENTITY_INSERT [dbo].[GasStationGasType] OFF
SET IDENTITY_INSERT [dbo].[M_District] ON 

INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (1, N'Quận 1')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (2, N'Quận 2')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (3, N'Quận 3')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (4, N'Quận 4')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (5, N'Quận 5')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (6, N'Quận 6')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (7, N'Quận 7')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (8, N'Quận 8')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (9, N'Quận 9')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (10, N'Quận 10')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (11, N'Quận 11')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (12, N'Quận 12')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (13, N'Quận Tân Bình')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (14, N'Quận Tân Phú')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (15, N'Quận Bình Tân')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (16, N'Quận Thủ Đức')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (17, N'Quận Hóc Môn')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (18, N'Quận Củ Chi')
INSERT [dbo].[M_District] ([DistrictId], [DistrictName]) VALUES (19, N'Quận Gò Vấp')
SET IDENTITY_INSERT [dbo].[M_District] OFF
SET IDENTITY_INSERT [dbo].[M_Type] ON 

INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (1, N'00001', N'Administator', 1)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (2, N'00002', N'User', 1)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (3, N'00001', N'Error', 2)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (4, N'00002', N'Info', 2)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (5, N'00003', N'Warning', 2)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (6, N'00004', N'Question', 2)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (7, N'00001', N'A92', 3)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (8, N'00002', N'A95', 3)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (9, N'00003', N'M83', 3)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (10, N'00004', N'E5', 3)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (11, N'00001', N'Good', 4)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (12, N'00002', N'Mid', 4)
INSERT [dbo].[M_Type] ([TypeId], [TypeCode], [TypeText], [TypeType]) VALUES (13, N'00003', N'Bad', 4)
SET IDENTITY_INSERT [dbo].[M_Type] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Email], [Password], [UserType]) VALUES (1, N'admin@hpb.com', N'123', N'00001')
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  Index [IX_GasStationFeedback]    Script Date: 2016/03/15 10:34:19 ******/
CREATE NONCLUSTERED INDEX [IX_GasStationFeedback] ON [dbo].[GasStationFeedback]
(
	[GasStationFeedbackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GasStationFeedback]  WITH CHECK ADD  CONSTRAINT [FK_GasStationFeedback_GasStation1] FOREIGN KEY([GasStationId])
REFERENCES [dbo].[GasStation] ([GasStationId])
GO
ALTER TABLE [dbo].[GasStationFeedback] CHECK CONSTRAINT [FK_GasStationFeedback_GasStation1]
GO
ALTER TABLE [dbo].[GasStationGasType]  WITH CHECK ADD  CONSTRAINT [FK_GasStationGasType_GasStation1] FOREIGN KEY([GasStationId])
REFERENCES [dbo].[GasStation] ([GasStationId])
GO
ALTER TABLE [dbo].[GasStationGasType] CHECK CONSTRAINT [FK_GasStationGasType_GasStation1]
GO
USE [master]
GO
ALTER DATABASE [GasStation] SET  READ_WRITE 
GO
