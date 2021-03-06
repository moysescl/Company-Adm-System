USE [master]
GO
/****** Object:  Database [HiTechDB]    Script Date: 2019-04-26 8:13:12 PM ******/
CREATE DATABASE [HiTechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HiTechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HiTechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HiTechDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HiTechDB] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTechDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HiTechDB', N'ON'
GO
ALTER DATABASE [HiTechDB] SET QUERY_STORE = OFF
GO
USE [HiTechDB]
GO
/****** Object:  Table [dbo].[AuthorBook]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorBook](
	[Isbn] [nvarchar](17) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[AuthorEmail] [nvarchar](50) NULL,
 CONSTRAINT [PK_AuthorBook] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC,
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Isbn] [nvarchar](17) NOT NULL,
	[BookTitle] [nvarchar](90) NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[YearPublished] [int] NOT NULL,
	[Qoh] [int] NOT NULL,
	[PublisherId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](10) NOT NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[FaxNumber] [nvarchar](15) NOT NULL,
	[CreditLimit] [float] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] NOT NULL,
	[FirstName] [nvarchar](40) NOT NULL,
	[LastName] [nvarchar](40) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderLine]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderLine](
	[OrderId] [int] NOT NULL,
	[Isbn] [nvarchar](17) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_orderLine] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[OrderUpdated] [date] NOT NULL,
	[RequiredDate] [date] NOT NULL,
	[ShippingDate] [date] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherId] [int] NOT NULL,
	[PublisherName] [nvarchar](50) NOT NULL,
	[WebSite] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2019-04-26 8:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'111-1-11111-111-1', 102, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'333-3-33333-333-3', 101, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'333-3-33333-333-3', 103, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'444-4-44444-444-4', 105, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'554-5-54554-554-5', 105, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'776-7-76776-776-7', 104, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'776-7-76776-776-7', 105, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'989-8-98989-898-9', 105, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'989-8-98989-898-9', 106, NULL)
INSERT [dbo].[AuthorBook] ([Isbn], [AuthorId], [AuthorEmail]) VALUES (N'989-8-98989-898-9', 107, NULL)
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (101, N'Paulo', N'Coelho')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (102, N'William', N'Shakespeare')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (103, N'Ellen', N'Ullman')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (104, N'Eric', N'Raymond')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (105, N'Donald', N'Knuth')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (106, N'Richard', N'Stallman')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (107, N'John', N'Muller')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (108, N'Justin', N'Trudeau')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (109, N'Marlon', N'Shepard')
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'000-6-00250-217-4', N'The Alchemist', 30, 1988, 25, 2)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'111-1-11111-111-1', N'Teste', 30, 1980, 50, 1)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'123-3-21123-321-1', N'Testing price', 30.54, 1990, 12, 4)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'212-1-21212-121-2', N'dsds', 50.3, 1980, 15, 2)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'321-7-43456-765-1', N'Computer Science', 40, 2017, 10, 1)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'332-3-32332-323-3', N'Testing 5', 21.35, 1984, 150, 7)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'333-3-33333-333-3', N'teste 3', 44, 1983, 32, 2)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'443-4-43443-443-3', N'Test 6', 14.35, 2017, 21, 2)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'444-4-44444-444-4', N'ggggg', 20, 1995, 50, 7)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'554-5-54554-554-5', N'Teste 6', 54.35, 2017, 45, 1)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'665-2-66598-432-3', N'Literary genres', 23, 2017, 50, 2)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'665-2-66598-554-3', N'Math', 55, 2016, 40, 2)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'765-1-88734-545-2', N'Learning C#', 60, 2009, 50, 1)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'776-7-76776-776-7', N'Teste 7', 54.33, 2018, 14, 4)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'978-3-56619-909-4', N'Statistic to Computer', 35, 2018, 50, 1)
INSERT [dbo].[Books] ([Isbn], [BookTitle], [UnitPrice], [YearPublished], [Qoh], [PublisherId]) VALUES (N'989-8-98989-898-9', N'Test 7', 56.75, 1981, 15, 7)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (11111, N'LaSalle College', N'2000 Saint-Catherine St W', N'Montreal', N'H3H 2T3', N'(514)939-2006', N'(514)9392007', 30000)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (22222, N'Concordia University', N'1455 Boulevard de Maisonneuve O', N'Montreal', N'H3G 1M8', N'(514)848-2424', N'(514)8482425', 70000)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (33333, N'College1', N'ddddd', N'Laval', N'ffff', N'gggg', N'hhhhh', 50000)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (55555, N'College2', N'ddddd', N'Laval', N'ffff', N'gggg', N'hhhhh', 50000)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (66666, N'College3', N'ddddd', N'Laval', N'ffff', N'gggg', N'hhhhh', 50000)
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (77777, N'College4', N'fddfd', N'Montreal', N'ffff', N'gggg', N'hhhhh', 50000)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1001, N'Henry', N'Brown', N'MIS Manager', N'henry@gmail.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1002, N'Thomas', N' Moore', N'Sales Manager', N'thomas@gmail.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1003, N'Mary', N' Brown ', N'Order Clerk', N'mary@gmail.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1004, N'Jennifer', N'Bouchard', N'Order Clerk', N'jennifer@gmail.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1005, N'Kim Hoa ', N' Nguyen', N'Accountant', N'kimhoa@gmail.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1006, N'Moyses', N'Lima', N'Inventory Controller', N'moysescl@gmail.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1007, N'Paul', N'dddd', N'Sales Manager', N'rerere@ffddf.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [Email]) VALUES (1008, N'Cristina', N'Silva', N'Inventory Controller', N'cristina@gmail.com')
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (1111, N'321-7-43456-765-1', 20)
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (1111, N'665-2-66598-432-3', 31)
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (6666, N'321-7-43456-765-1', 10)
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (6666, N'665-2-66598-432-3', 20)
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (6666, N'665-2-66598-554-3', 5)
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (6666, N'765-1-88734-545-2', 15)
INSERT [dbo].[orderLine] ([OrderId], [Isbn], [Quantity]) VALUES (6666, N'978-3-56619-909-4', 4)
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [OrderUpdated], [RequiredDate], [ShippingDate]) VALUES (1111, 77777, 1003, CAST(N'2019-01-20' AS Date), CAST(N'2019-04-26' AS Date), CAST(N'2019-06-12' AS Date), CAST(N'2019-06-09' AS Date))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [OrderUpdated], [RequiredDate], [ShippingDate]) VALUES (2222, 55555, 1003, CAST(N'2019-04-15' AS Date), CAST(N'2019-04-26' AS Date), CAST(N'2019-05-03' AS Date), CAST(N'2019-04-16' AS Date))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [OrderUpdated], [RequiredDate], [ShippingDate]) VALUES (4444, 55555, 1003, CAST(N'2019-04-15' AS Date), CAST(N'2019-04-15' AS Date), CAST(N'2019-04-29' AS Date), CAST(N'2019-04-26' AS Date))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [OrderUpdated], [RequiredDate], [ShippingDate]) VALUES (5555, 33333, 1003, CAST(N'2019-04-15' AS Date), CAST(N'2019-04-15' AS Date), CAST(N'2019-04-26' AS Date), CAST(N'2019-04-23' AS Date))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [OrderUpdated], [RequiredDate], [ShippingDate]) VALUES (6666, 22222, 1003, CAST(N'2019-04-17' AS Date), CAST(N'2019-04-25' AS Date), CAST(N'2019-06-28' AS Date), CAST(N'2019-06-25' AS Date))
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (1, N'Wrox', N'http://www.wrox.com/WileyCDA/')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (2, N'Pearson', N'https://www.pearson.com/ca/en.html')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (3, N'	ThomsonReuters', N'http://www.thomsonreuters.ca')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (4, N'Wolters Kluwer', N'http://www.wolters.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (5, N'Penguin Random House', N'http://www.penguin.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (6, N'McGraw-Hill Education', N'http://www.hilleducation.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebSite]) VALUES (7, N'Nova Editora', N'http://www.novaeditora.com')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1001, N'1001')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1002, N'1002')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1003, N'1003')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1004, N'1004')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1005, N'1005')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1006, N'1006')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1007, N'1007')
INSERT [dbo].[Users] ([UserName], [Password]) VALUES (1008, N'1008')
ALTER TABLE [dbo].[AuthorBook]  WITH CHECK ADD  CONSTRAINT [FK_AuthorBook_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[AuthorBook] CHECK CONSTRAINT [FK_AuthorBook_Authors]
GO
ALTER TABLE [dbo].[AuthorBook]  WITH CHECK ADD  CONSTRAINT [FK_AuthorBook_Books] FOREIGN KEY([Isbn])
REFERENCES [dbo].[Books] ([Isbn])
GO
ALTER TABLE [dbo].[AuthorBook] CHECK CONSTRAINT [FK_AuthorBook_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publishers] ([PublisherId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[orderLine]  WITH CHECK ADD  CONSTRAINT [FK_orderLine_Books] FOREIGN KEY([Isbn])
REFERENCES [dbo].[Books] ([Isbn])
GO
ALTER TABLE [dbo].[orderLine] CHECK CONSTRAINT [FK_orderLine_Books]
GO
ALTER TABLE [dbo].[orderLine]  WITH CHECK ADD  CONSTRAINT [FK_orderLine_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[orderLine] CHECK CONSTRAINT [FK_orderLine_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
USE [master]
GO
ALTER DATABASE [HiTechDB] SET  READ_WRITE 
GO
