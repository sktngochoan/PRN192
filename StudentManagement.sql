USE [master]
GO
/****** Object:  Database [student_management]    Script Date: 7/19/2022 12:58:24 AM ******/
CREATE DATABASE [student_management]
GO
ALTER DATABASE [student_management] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [student_management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [student_management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [student_management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [student_management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [student_management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [student_management] SET ARITHABORT OFF 
GO
ALTER DATABASE [student_management] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [student_management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [student_management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [student_management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [student_management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [student_management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [student_management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [student_management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [student_management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [student_management] SET  ENABLE_BROKER 
GO
ALTER DATABASE [student_management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [student_management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [student_management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [student_management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [student_management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [student_management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [student_management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [student_management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [student_management] SET  MULTI_USER 
GO
ALTER DATABASE [student_management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [student_management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [student_management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [student_management] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [student_management] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [student_management] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [student_management] SET QUERY_STORE = OFF
GO
USE [student_management]
GO
/****** Object:  Table [dbo].[class]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[class_id] [int] IDENTITY(1,1) NOT NULL,
	[semester_id] [int] NULL,
	[class_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grade]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade](
	[grade_id] [int] IDENTITY(1,1) NOT NULL,
	[grade_category_id] [int] NULL,
	[grade_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[grade_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grade_category]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade_category](
	[grade_category_id] [int] IDENTITY(1,1) NOT NULL,
	[grade_category_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[grade_category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lecturers]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lecturers](
	[lecturer_id] [int] IDENTITY(1,1) NOT NULL,
	[lecturer_name] [nvarchar](255) NULL,
	[lecturer_email] [nvarchar](255) NULL,
	[lecturer_pass] [nvarchar](255) NULL,
	[lecturer_img] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[lecturer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[room]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room](
	[room_id] [int] IDENTITY(1,1) NOT NULL,
	[room_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedule]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedule](
	[schedule_id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[slot_id] [int] NULL,
	[lecturer_id] [int] NULL,
	[subject_id] [int] NULL,
	[class_id] [int] NULL,
	[schedule_date] [date] NULL,
	[status] [bit] NULL,
	[day] [nvarchar](1) NULL,
	[week_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[schedule_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[semester]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[semester](
	[semester_id] [int] IDENTITY(1,1) NOT NULL,
	[semester_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[semester_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[slot]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[slot](
	[slot_id] [int] IDENTITY(1,1) NOT NULL,
	[slot_time] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[slot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[class_id] [int] NULL,
	[student_name] [nvarchar](255) NULL,
	[student_bofd] [date] NULL,
	[student_address] [nvarchar](255) NULL,
	[student_email] [nvarchar](255) NULL,
	[student_gender] [bit] NULL,
	[student_img] [nvarchar](255) NULL,
	[student_code] [nvarchar](50) NULL,
	[student_pass] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_attended]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_attended](
	[student_attended_id] [int] IDENTITY(1,1) NOT NULL,
	[schedule_id] [int] NULL,
	[student_id] [int] NULL,
	[student_attended_date] [date] NULL,
	[student_status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[student_attended_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_grade]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_grade](
	[student_id] [int] NULL,
	[subject_id] [int] NULL,
	[grade_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject](
	[subject_id] [int] IDENTITY(1,1) NOT NULL,
	[lecturer_id] [int] NULL,
	[semester_id] [int] NULL,
	[class_id] [int] NULL,
	[subject_code] [nvarchar](255) NULL,
	[subject_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[subject_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[week]    Script Date: 7/19/2022 12:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[week](
	[week_id] [int] IDENTITY(1,1) NOT NULL,
	[week_date] [nvarchar](255) NULL,
	[end_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[week_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[class] ON 

INSERT [dbo].[class] ([class_id], [semester_id], [class_name]) VALUES (2, 3, N'SE1610')
INSERT [dbo].[class] ([class_id], [semester_id], [class_name]) VALUES (3, 3, N'SE1611')
INSERT [dbo].[class] ([class_id], [semester_id], [class_name]) VALUES (4, 3, N'SE1612')
SET IDENTITY_INSERT [dbo].[class] OFF
GO
SET IDENTITY_INSERT [dbo].[lecturers] ON 

INSERT [dbo].[lecturers] ([lecturer_id], [lecturer_name], [lecturer_email], [lecturer_pass], [lecturer_img]) VALUES (1, N'Nguyen Ngoc Hoan', N'hoan@gmai.com', N'123', NULL)
INSERT [dbo].[lecturers] ([lecturer_id], [lecturer_name], [lecturer_email], [lecturer_pass], [lecturer_img]) VALUES (2, N'Pham Minh Giang', N'giang@gmail.com', N'123', NULL)
INSERT [dbo].[lecturers] ([lecturer_id], [lecturer_name], [lecturer_email], [lecturer_pass], [lecturer_img]) VALUES (3, N'Nguyen Phong Hao', N'hao@gmail.com', N'123', NULL)
SET IDENTITY_INSERT [dbo].[lecturers] OFF
GO
SET IDENTITY_INSERT [dbo].[room] ON 

INSERT [dbo].[room] ([room_id], [room_name]) VALUES (1, N'DE-C301')
SET IDENTITY_INSERT [dbo].[room] OFF
GO
SET IDENTITY_INSERT [dbo].[schedule] ON 

INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (5, 1, 2, 1, 1, 2, CAST(N'2022-01-01' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (6, 1, 3, 1, 2, 2, CAST(N'2022-01-01' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (7, 1, 1, 2, 3, 2, CAST(N'2022-01-02' AS Date), 1, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (8, 1, 4, 2, 4, 2, CAST(N'2022-01-02' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (9, 1, 1, 2, 4, 2, CAST(N'2022-01-03' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (10, 1, 3, 2, 4, 2, CAST(N'2022-01-03' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (11, 1, 2, 1, 1, 2, CAST(N'2022-01-04' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (12, 1, 3, 2, 2, 2, CAST(N'2022-01-04' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (13, 1, 1, 2, 3, 2, CAST(N'2022-01-04' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (14, 1, 4, 2, 4, 2, CAST(N'2022-01-05' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (15, 1, 2, 1, 1, 2, CAST(N'2022-01-05' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (16, 1, 5, 1, 1, 2, CAST(N'2022-01-06' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (17, 1, 4, 2, 4, 2, CAST(N'2022-01-06' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (18, 1, 3, 1, 2, 2, CAST(N'2022-01-07' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (19, 1, 1, 2, 3, 2, CAST(N'2022-01-07' AS Date), 0, N'0', 1)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (20, 1, 2, 1, 1, 2, CAST(N'2022-01-08' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (21, 1, 3, 1, 2, 2, CAST(N'2022-01-08' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (22, 1, 1, 2, 3, 2, CAST(N'2022-01-09' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (23, 1, 4, 2, 4, 2, CAST(N'2022-01-09' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (24, 1, 1, 2, 4, 2, CAST(N'2022-01-10' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (25, 1, 3, 2, 4, 2, CAST(N'2022-01-10' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (26, 1, 2, 1, 1, 2, CAST(N'2022-01-11' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (27, 1, 3, 2, 4, 2, CAST(N'2022-01-11' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (28, 1, 4, 2, 4, 2, CAST(N'2022-01-11' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (29, 1, 1, 2, 3, 2, CAST(N'2022-01-12' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (30, 1, 4, 2, 4, 2, CAST(N'2022-01-12' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (31, 1, 3, 2, 2, 2, CAST(N'2022-01-13' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (32, 1, 1, 2, 4, 2, CAST(N'2022-01-13' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (33, 1, 4, 2, 4, 2, CAST(N'2022-01-14' AS Date), 0, N'0', 2)
INSERT [dbo].[schedule] ([schedule_id], [room_id], [slot_id], [lecturer_id], [subject_id], [class_id], [schedule_date], [status], [day], [week_id]) VALUES (34, 1, 3, 2, 4, 2, CAST(N'2022-01-14' AS Date), 0, N'0', 2)
SET IDENTITY_INSERT [dbo].[schedule] OFF
GO
SET IDENTITY_INSERT [dbo].[semester] ON 

INSERT [dbo].[semester] ([semester_id], [semester_name]) VALUES (1, N'Fall2021')
INSERT [dbo].[semester] ([semester_id], [semester_name]) VALUES (2, N'Spring2022')
INSERT [dbo].[semester] ([semester_id], [semester_name]) VALUES (3, N'Summer2022')
SET IDENTITY_INSERT [dbo].[semester] OFF
GO
SET IDENTITY_INSERT [dbo].[slot] ON 

INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (1, N'7:30 - 9:00')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (2, N'9:10 - 10:40')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (3, N'10:50 - 12:20')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (4, N'12:50 - 14:20')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (5, N'14:30 - 16:00')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (6, N'16:10 - 17:40')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (7, N'17:50 - 19:20')
INSERT [dbo].[slot] ([slot_id], [slot_time]) VALUES (8, N'19:30 - 21:00')
SET IDENTITY_INSERT [dbo].[slot] OFF
GO
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (1, 2, N'Nguyen Ngoc Hoan', CAST(N'2001-12-21' AS Date), N'Hanoi', N'hoannnhe151308@fpt.edu.vn', 1, N'hoanonfire.jpg', N'HE151308', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (2, 2, N'Nguyen Phong Hao', CAST(N'2001-12-21' AS Date), N'Hanoi', N'haonphe153211@fpt.edu.vn', 1, N'hao.jpg', N'HE154212', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (3, 2, N'Pham Minh Giang', CAST(N'2001-12-21' AS Date), N'Hanoi', N'giangpmhe15363@fpt.edu.vn', 1, N'captain1.jpg', N'HE176321', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (4, 2, N'Kieu Minh Dat', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 0, N'hulk.jpg', N'HE123412', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (5, 2, N'Nguyen Phong Hoan', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 0, N'Ironman.jpg', N'HE156321', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (6, 2, N'Nguyen Ngoc Khoa', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 1, N'khoa.jpg', N'HE158263', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (7, 2, N'Pham Xuan Truong', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 1, N'truong.jpg', N'HE158231', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (8, 2, N'Nguyen Ngoc Giang', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 1, N'wintersoldier.jpg', N'HR183712', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (9, 2, N'Kieu Minh Hao', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 0, N'captain.jpg', N'HE156312', N'123')
INSERT [dbo].[student] ([student_id], [class_id], [student_name], [student_bofd], [student_address], [student_email], [student_gender], [student_img], [student_code], [student_pass]) VALUES (10, 2, N'Nguyen Xuan Hao', CAST(N'2001-12-21' AS Date), N'Hanoi', N'dat@gmail.com', 0, N'blackpanther.jpg', N'HE156371', N'123')
SET IDENTITY_INSERT [dbo].[student] OFF
GO
SET IDENTITY_INSERT [dbo].[student_attended] ON 

INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (495, 7, 1, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (496, 7, 2, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (497, 7, 3, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (498, 7, 4, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (499, 7, 5, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (500, 7, 6, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (501, 7, 7, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (502, 7, 8, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (503, 7, 9, CAST(N'2022-07-16' AS Date), 1)
INSERT [dbo].[student_attended] ([student_attended_id], [schedule_id], [student_id], [student_attended_date], [student_status]) VALUES (504, 7, 10, CAST(N'2022-07-16' AS Date), 1)
SET IDENTITY_INSERT [dbo].[student_attended] OFF
GO
SET IDENTITY_INSERT [dbo].[subject] ON 

INSERT [dbo].[subject] ([subject_id], [lecturer_id], [semester_id], [class_id], [subject_code], [subject_name]) VALUES (1, 1, 3, 2, N'PRN211', N'Basic Cross-Platform Application Programming With .NET')
INSERT [dbo].[subject] ([subject_id], [lecturer_id], [semester_id], [class_id], [subject_code], [subject_name]) VALUES (2, 1, 3, 2, N'SWP391', N'Application development project')
INSERT [dbo].[subject] ([subject_id], [lecturer_id], [semester_id], [class_id], [subject_code], [subject_name]) VALUES (3, 2, 3, 2, N'SWR302', N'Software Requirement')
INSERT [dbo].[subject] ([subject_id], [lecturer_id], [semester_id], [class_id], [subject_code], [subject_name]) VALUES (4, 2, 3, 2, N'SWT301', N'Software Testing')
SET IDENTITY_INSERT [dbo].[subject] OFF
GO
SET IDENTITY_INSERT [dbo].[week] ON 

INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (1, N'11/7 - 17/7', CAST(N'2022-07-17T00:00:00.000' AS DateTime))
INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (2, N'18/7 - 24/7', CAST(N'2022-07-24T00:00:00.000' AS DateTime))
INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (3, N'25/7 - 31/7', CAST(N'2022-07-31T00:00:00.000' AS DateTime))
INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (4, N'1/8 - 7/8', CAST(N'2022-08-07T00:00:00.000' AS DateTime))
INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (5, N'8/8 - 14/8', CAST(N'2022-08-14T00:00:00.000' AS DateTime))
INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (6, N'15/8 - 21/8', CAST(N'2022-08-21T00:00:00.000' AS DateTime))
INSERT [dbo].[week] ([week_id], [week_date], [end_date]) VALUES (7, N'22/8 - 28/8', CAST(N'2022-08-28T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[week] OFF
GO
ALTER TABLE [dbo].[class]  WITH CHECK ADD FOREIGN KEY([semester_id])
REFERENCES [dbo].[semester] ([semester_id])
GO
ALTER TABLE [dbo].[grade]  WITH CHECK ADD FOREIGN KEY([grade_category_id])
REFERENCES [dbo].[grade_category] ([grade_category_id])
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[class] ([class_id])
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD FOREIGN KEY([lecturer_id])
REFERENCES [dbo].[lecturers] ([lecturer_id])
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD FOREIGN KEY([room_id])
REFERENCES [dbo].[room] ([room_id])
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD FOREIGN KEY([slot_id])
REFERENCES [dbo].[slot] ([slot_id])
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD FOREIGN KEY([subject_id])
REFERENCES [dbo].[subject] ([subject_id])
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD FOREIGN KEY([week_id])
REFERENCES [dbo].[week] ([week_id])
GO
ALTER TABLE [dbo].[student]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[class] ([class_id])
GO
ALTER TABLE [dbo].[student_attended]  WITH CHECK ADD FOREIGN KEY([schedule_id])
REFERENCES [dbo].[schedule] ([schedule_id])
GO
ALTER TABLE [dbo].[student_attended]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])
GO
ALTER TABLE [dbo].[student_grade]  WITH CHECK ADD FOREIGN KEY([grade_id])
REFERENCES [dbo].[grade] ([grade_id])
GO
ALTER TABLE [dbo].[student_grade]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])
GO
ALTER TABLE [dbo].[student_grade]  WITH CHECK ADD FOREIGN KEY([subject_id])
REFERENCES [dbo].[subject] ([subject_id])
GO
ALTER TABLE [dbo].[subject]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[class] ([class_id])
GO
ALTER TABLE [dbo].[subject]  WITH CHECK ADD FOREIGN KEY([lecturer_id])
REFERENCES [dbo].[lecturers] ([lecturer_id])
GO
ALTER TABLE [dbo].[subject]  WITH CHECK ADD FOREIGN KEY([semester_id])
REFERENCES [dbo].[semester] ([semester_id])
GO
USE [master]
GO
ALTER DATABASE [student_management] SET  READ_WRITE 
GO
