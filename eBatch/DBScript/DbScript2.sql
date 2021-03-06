USE [master]
GO
/****** Object:  Database [NorthPoint]    Script Date: 11/1/2018 5:38:00 PM ******/
CREATE DATABASE [NorthPoint]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NorthPoint', FILENAME = N'D:\Program Files(x86)\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\NorthPoint.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NorthPoint_log', FILENAME = N'D:\Program Files(x86)\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\NorthPoint_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NorthPoint] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NorthPoint].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NorthPoint] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NorthPoint] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NorthPoint] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NorthPoint] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NorthPoint] SET ARITHABORT OFF 
GO
ALTER DATABASE [NorthPoint] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NorthPoint] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NorthPoint] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NorthPoint] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NorthPoint] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NorthPoint] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NorthPoint] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NorthPoint] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NorthPoint] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NorthPoint] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NorthPoint] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NorthPoint] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NorthPoint] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NorthPoint] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NorthPoint] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NorthPoint] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NorthPoint] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NorthPoint] SET RECOVERY FULL 
GO
ALTER DATABASE [NorthPoint] SET  MULTI_USER 
GO
ALTER DATABASE [NorthPoint] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NorthPoint] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NorthPoint] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NorthPoint] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NorthPoint] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NorthPoint] SET QUERY_STORE = OFF
GO
USE [NorthPoint]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [NorthPoint]
GO
/****** Object:  Table [dbo].[tblAttachments]    Script Date: 11/1/2018 5:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAttachments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fileid] [int] NOT NULL,
	[attachment] [varbinary](max) NULL,
	[createddate] [datetime] NULL,
	[createdby] [int] NULL,
	[udpatedby] [int] NULL,
	[updateddate] [datetime] NULL,
	[active] [bit] NULL,
 CONSTRAINT [PK_tblAttachments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAuditTrail]    Script Date: 11/1/2018 5:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAuditTrail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[batchid] [int] NULL,
	[invoiceid] [int] NULL,
	[assignedto] [int] NULL,
	[assignedby] [int] NULL,
	[status] [int] NULL,
	[verifiedby] [int] NULL,
	[comments] [nvarchar](max) NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
 CONSTRAINT [PK_tblAuditTrail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBatch]    Script Date: 11/1/2018 5:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBatch](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NULL,
	[status] [int] NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblBatch] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBatch_Invoice]    Script Date: 11/1/2018 5:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBatch_Invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[batchid] [int] NOT NULL,
	[invoiceid] [int] NOT NULL,
	[status] [int] NULL,
	[reason] [varchar](max) NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblBatch_Invoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCodeCategory]    Script Date: 11/1/2018 5:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCodeCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [varchar](50) NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblCodeCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCodeValue]    Script Date: 11/1/2018 5:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCodeValue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[categoryid] [int] NOT NULL,
	[codevalue] [varchar](100) NULL,
	[description] [varchar](100) NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
	[parentId] [int] NULL,
	[codeShortValue] [varchar](10) NULL,
	[sortorder] [int] NULL,
 CONSTRAINT [PK_tblCodeValue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEbatchDetails]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEbatchDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[invoiceid] [int] NULL,
	[batchid] [int] NULL,
	[userid] [int] NULL,
	[invoiceamount] [money] NULL,
	[refplan] [nvarchar](1000) NULL,
	[dealerplan] [nvarchar](1000) NULL,
	[items] [nvarchar](max) NULL,
	[shipto] [nvarchar](max) NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[udpatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblEbatchDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFilelist]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFilelist](
	[id] [int] NOT NULL,
	[supplierid] [int] NULL,
	[receiptdate] [datetime] NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblFilelist] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblInvoice]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInvoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supplierid] [int] NULL,
	[invoicename] [varchar](50) NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblInvoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblInvoice_user]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInvoice_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[invoiceid] [int] NULL,
	[userid] [int] NULL,
	[status] [int] NULL,
	[active] [bit] NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblInvoice_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoleModule]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoleModule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[roleid] [int] NULL,
	[moduleid] [int] NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[modifiedby] [int] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_tblRoleModule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[id] [int] NOT NULL,
	[suppliername] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[difficult_level] [int] NULL,
	[approval_number] [varchar](50) NULL,
	[active] [bit] NULL,
	[invoice_type] [int] NULL,
	[createddate] [datetime] NULL,
	[createdby] [int] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblSupplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbluser_module]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbluser_module](
	[userid] [int] NOT NULL,
	[moduleid] [varchar](50) NOT NULL,
	[active] [bit] NULL,
	[createddate] [datetime] NULL,
	[createdby] [int] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbluser_role]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbluser_role](
	[userid] [int] NOT NULL,
	[roleid] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[difficult_level] [int] NULL,
	[active] [bit] NULL,
	[createdby] [int] NULL,
	[createddate] [datetime] NULL,
	[updatedby] [int] NULL,
	[updateddate] [datetime] NULL,
 CONSTRAINT [PK_tblUsersNew] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCodeCategory] ON 

INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (1, N'Module', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (2, N'SubModule', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (3, N'DifficultyLevel', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (4, N'InvoiceStatus', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (5, N'UserRole', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (6, N'InvoiceType', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (7, N'InvoiceRejectReason', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblCodeCategory] ([id], [category], [createdby], [createddate], [updatedby], [updateddate]) VALUES (8, N'InvoiceResearchReason', 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblCodeCategory] OFF
SET IDENTITY_INSERT [dbo].[tblCodeValue] ON 

INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (1, 1, N'Admin', N'Admin Module', 1, CAST(N'2018-11-01T15:12:29.927' AS DateTime), 1, CAST(N'2018-11-01T15:12:29.927' AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (2, 1, N'Data Prep', N'Data Prep Module', 1, CAST(N'2018-11-01T15:12:38.267' AS DateTime), 1, CAST(N'2018-11-01T15:12:38.267' AS DateTime), NULL, NULL, 2)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (3, 1, N'Data Entry', N'Data Entry Module', 1, CAST(N'2018-11-01T15:12:47.623' AS DateTime), 1, CAST(N'2018-11-01T15:12:47.623' AS DateTime), NULL, NULL, 3)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (4, 1, N'Verification', N'Verification Module', 1, CAST(N'2018-11-01T15:13:00.607' AS DateTime), 1, CAST(N'2018-11-01T15:13:00.607' AS DateTime), NULL, NULL, 4)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (5, 1, N'Research & Reject', N'Research and Reject Module', 1, CAST(N'2018-11-01T15:14:20.883' AS DateTime), 1, CAST(N'2018-11-01T15:14:20.883' AS DateTime), NULL, NULL, 5)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (6, 1, N'Disbursement', N'Disbursement Module', 1, CAST(N'2018-11-01T15:14:37.587' AS DateTime), 1, CAST(N'2018-11-01T15:14:37.587' AS DateTime), NULL, NULL, 6)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (7, 1, N'Report', N'Report Module', 1, CAST(N'2018-11-01T15:14:44.940' AS DateTime), 1, CAST(N'2018-11-01T15:14:44.940' AS DateTime), NULL, NULL, 7)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (8, 5, N'Admin', N'Admin User', 1, CAST(N'2018-11-01T15:26:53.060' AS DateTime), 1, CAST(N'2018-11-01T15:26:53.060' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (9, 5, N'Super User', N'Super User', 1, CAST(N'2018-11-01T15:27:11.840' AS DateTime), 1, CAST(N'2018-11-01T15:27:11.840' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (10, 5, N'End User', N'End User', 1, CAST(N'2018-11-01T15:27:30.543' AS DateTime), 1, CAST(N'2018-11-01T15:27:30.543' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (11, 3, N'1', N'difficulty level - 1', 1, CAST(N'2018-11-01T15:55:40.930' AS DateTime), 1, CAST(N'2018-11-01T15:55:40.930' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (12, 3, N'2', N'difficulty level - 2', 1, CAST(N'2018-11-01T15:55:48.497' AS DateTime), 1, CAST(N'2018-11-01T15:55:48.497' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (13, 3, N'3', N'difficulty level - 3', 1, CAST(N'2018-11-01T15:55:58.220' AS DateTime), 1, CAST(N'2018-11-01T15:55:58.220' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (14, 3, N'4', N'difficulty level - 4', 1, CAST(N'2018-11-01T15:56:10.653' AS DateTime), 1, CAST(N'2018-11-01T15:56:10.653' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[tblCodeValue] ([id], [categoryid], [codevalue], [description], [createdby], [createddate], [updatedby], [updateddate], [parentId], [codeShortValue], [sortorder]) VALUES (15, 3, N'5', N'difficulty level - 5', 1, CAST(N'2018-11-01T15:56:19.020' AS DateTime), 1, CAST(N'2018-11-01T15:56:19.020' AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblCodeValue] OFF
SET IDENTITY_INSERT [dbo].[tblRoleModule] ON 

INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (1, 8, 1, 1, CAST(N'2018-11-01T15:45:11.677' AS DateTime), 1, CAST(N'2018-11-01T15:45:11.677' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (2, 8, 2, 1, CAST(N'2018-11-01T15:45:29.247' AS DateTime), 1, CAST(N'2018-11-01T15:45:29.247' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (3, 8, 3, 1, CAST(N'2018-11-01T15:45:31.230' AS DateTime), 1, CAST(N'2018-11-01T15:45:31.230' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (4, 8, 4, 1, CAST(N'2018-11-01T15:45:33.307' AS DateTime), 1, CAST(N'2018-11-01T15:45:33.307' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (5, 8, 5, 1, CAST(N'2018-11-01T15:45:35.770' AS DateTime), 1, CAST(N'2018-11-01T15:45:35.770' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (6, 8, 6, 1, CAST(N'2018-11-01T15:45:38.113' AS DateTime), 1, CAST(N'2018-11-01T15:45:38.113' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (7, 10, 3, 1, CAST(N'2018-11-01T15:46:52.903' AS DateTime), 1, CAST(N'2018-11-01T15:46:52.903' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (8, 10, 2, 1, CAST(N'2018-11-01T15:46:59.120' AS DateTime), 1, CAST(N'2018-11-01T15:46:59.120' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (9, 8, 7, 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tblRoleModule] ([id], [roleid], [moduleid], [createdby], [createddate], [modifiedby], [modifieddate]) VALUES (10, 9, 1, 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblRoleModule] OFF
INSERT [dbo].[tbluser_module] ([userid], [moduleid], [active], [createddate], [createdby], [updatedby], [updateddate]) VALUES (1, N'7', 1, CAST(N'2018-11-01T15:58:08.797' AS DateTime), 1, 1, CAST(N'2018-11-01T15:58:08.797' AS DateTime))
INSERT [dbo].[tbluser_role] ([userid], [roleid]) VALUES (1, 10)
INSERT [dbo].[tbluser_role] ([userid], [roleid]) VALUES (2, 9)
SET IDENTITY_INSERT [dbo].[tblUsers] ON 

INSERT [dbo].[tblUsers] ([id], [username], [difficult_level], [active], [createdby], [createddate], [updatedby], [updateddate]) VALUES (1, N'Ironman', 15, 1, 1, CAST(N'2018-11-01T15:57:11.737' AS DateTime), 1, CAST(N'2018-11-01T15:57:11.737' AS DateTime))
INSERT [dbo].[tblUsers] ([id], [username], [difficult_level], [active], [createdby], [createddate], [updatedby], [updateddate]) VALUES (2, N'Thor', 14, 1, 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, CAST(N'2018-11-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblUsers] OFF
ALTER TABLE [dbo].[tblAttachments]  WITH CHECK ADD  CONSTRAINT [FK_tblAttachments_tblFilelist] FOREIGN KEY([fileid])
REFERENCES [dbo].[tblFilelist] ([id])
GO
ALTER TABLE [dbo].[tblAttachments] CHECK CONSTRAINT [FK_tblAttachments_tblFilelist]
GO
ALTER TABLE [dbo].[tblAuditTrail]  WITH CHECK ADD  CONSTRAINT [FK_tblAuditTrail_tblBatch] FOREIGN KEY([batchid])
REFERENCES [dbo].[tblBatch] ([id])
GO
ALTER TABLE [dbo].[tblAuditTrail] CHECK CONSTRAINT [FK_tblAuditTrail_tblBatch]
GO
ALTER TABLE [dbo].[tblAuditTrail]  WITH CHECK ADD  CONSTRAINT [FK_tblAuditTrail_tblInvoice] FOREIGN KEY([invoiceid])
REFERENCES [dbo].[tblInvoice] ([id])
GO
ALTER TABLE [dbo].[tblAuditTrail] CHECK CONSTRAINT [FK_tblAuditTrail_tblInvoice]
GO
ALTER TABLE [dbo].[tblAuditTrail]  WITH CHECK ADD  CONSTRAINT [FK_tblAuditTrail_tblUsers] FOREIGN KEY([assignedto])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tblAuditTrail] CHECK CONSTRAINT [FK_tblAuditTrail_tblUsers]
GO
ALTER TABLE [dbo].[tblAuditTrail]  WITH CHECK ADD  CONSTRAINT [FK_tblAuditTrail_tblUsers1] FOREIGN KEY([assignedby])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tblAuditTrail] CHECK CONSTRAINT [FK_tblAuditTrail_tblUsers1]
GO
ALTER TABLE [dbo].[tblAuditTrail]  WITH CHECK ADD  CONSTRAINT [FK_tblAuditTrail_tblUsers2] FOREIGN KEY([verifiedby])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tblAuditTrail] CHECK CONSTRAINT [FK_tblAuditTrail_tblUsers2]
GO
ALTER TABLE [dbo].[tblBatch]  WITH CHECK ADD  CONSTRAINT [FK_tblBatch_tblCodeValue] FOREIGN KEY([status])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblBatch] CHECK CONSTRAINT [FK_tblBatch_tblCodeValue]
GO
ALTER TABLE [dbo].[tblBatch]  WITH CHECK ADD  CONSTRAINT [FK_tblBatch_tblUsers] FOREIGN KEY([userid])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tblBatch] CHECK CONSTRAINT [FK_tblBatch_tblUsers]
GO
ALTER TABLE [dbo].[tblBatch]  WITH CHECK ADD  CONSTRAINT [FK_tblBatch_tblUsers1] FOREIGN KEY([userid])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tblBatch] CHECK CONSTRAINT [FK_tblBatch_tblUsers1]
GO
ALTER TABLE [dbo].[tblBatch_Invoice]  WITH CHECK ADD  CONSTRAINT [FK_tblBatch_Invoice_tblCodeValue] FOREIGN KEY([status])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblBatch_Invoice] CHECK CONSTRAINT [FK_tblBatch_Invoice_tblCodeValue]
GO
ALTER TABLE [dbo].[tblBatch_Invoice]  WITH CHECK ADD  CONSTRAINT [FK_tblBatch_Invoice_tblInvoice] FOREIGN KEY([invoiceid])
REFERENCES [dbo].[tblInvoice] ([id])
GO
ALTER TABLE [dbo].[tblBatch_Invoice] CHECK CONSTRAINT [FK_tblBatch_Invoice_tblInvoice]
GO
ALTER TABLE [dbo].[tblCodeValue]  WITH CHECK ADD  CONSTRAINT [FK_tblCodeValue_tblCodeCategory] FOREIGN KEY([categoryid])
REFERENCES [dbo].[tblCodeCategory] ([id])
GO
ALTER TABLE [dbo].[tblCodeValue] CHECK CONSTRAINT [FK_tblCodeValue_tblCodeCategory]
GO
ALTER TABLE [dbo].[tblEbatchDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblEbatchDetails_tblBatch] FOREIGN KEY([batchid])
REFERENCES [dbo].[tblBatch] ([id])
GO
ALTER TABLE [dbo].[tblEbatchDetails] CHECK CONSTRAINT [FK_tblEbatchDetails_tblBatch]
GO
ALTER TABLE [dbo].[tblEbatchDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblEbatchDetails_tblInvoice] FOREIGN KEY([invoiceid])
REFERENCES [dbo].[tblInvoice] ([id])
GO
ALTER TABLE [dbo].[tblEbatchDetails] CHECK CONSTRAINT [FK_tblEbatchDetails_tblInvoice]
GO
ALTER TABLE [dbo].[tblEbatchDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblEbatchDetails_tblUsers] FOREIGN KEY([userid])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tblEbatchDetails] CHECK CONSTRAINT [FK_tblEbatchDetails_tblUsers]
GO
ALTER TABLE [dbo].[tblFilelist]  WITH CHECK ADD  CONSTRAINT [FK_tblFilelist_tblSupplier] FOREIGN KEY([supplierid])
REFERENCES [dbo].[tblSupplier] ([id])
GO
ALTER TABLE [dbo].[tblFilelist] CHECK CONSTRAINT [FK_tblFilelist_tblSupplier]
GO
ALTER TABLE [dbo].[tblFilelist]  WITH CHECK ADD  CONSTRAINT [FK_tblFilelist_tblSupplier1] FOREIGN KEY([supplierid])
REFERENCES [dbo].[tblSupplier] ([id])
GO
ALTER TABLE [dbo].[tblFilelist] CHECK CONSTRAINT [FK_tblFilelist_tblSupplier1]
GO
ALTER TABLE [dbo].[tblInvoice]  WITH CHECK ADD  CONSTRAINT [FK_tblInvoice_tblSupplier] FOREIGN KEY([supplierid])
REFERENCES [dbo].[tblSupplier] ([id])
GO
ALTER TABLE [dbo].[tblInvoice] CHECK CONSTRAINT [FK_tblInvoice_tblSupplier]
GO
ALTER TABLE [dbo].[tblInvoice_user]  WITH CHECK ADD  CONSTRAINT [FK_tblInvoice_user_tblBatch_Invoice] FOREIGN KEY([invoiceid])
REFERENCES [dbo].[tblBatch_Invoice] ([id])
GO
ALTER TABLE [dbo].[tblInvoice_user] CHECK CONSTRAINT [FK_tblInvoice_user_tblBatch_Invoice]
GO
ALTER TABLE [dbo].[tblInvoice_user]  WITH CHECK ADD  CONSTRAINT [FK_tblInvoice_user_tblCodeValue] FOREIGN KEY([status])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblInvoice_user] CHECK CONSTRAINT [FK_tblInvoice_user_tblCodeValue]
GO
ALTER TABLE [dbo].[tblInvoice_user]  WITH CHECK ADD  CONSTRAINT [FK_tblInvoice_user_tblEbatchDetails] FOREIGN KEY([invoiceid])
REFERENCES [dbo].[tblEbatchDetails] ([id])
GO
ALTER TABLE [dbo].[tblInvoice_user] CHECK CONSTRAINT [FK_tblInvoice_user_tblEbatchDetails]
GO
ALTER TABLE [dbo].[tblRoleModule]  WITH CHECK ADD  CONSTRAINT [FK_tblRoleModule_tblCodeValue] FOREIGN KEY([roleid])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblRoleModule] CHECK CONSTRAINT [FK_tblRoleModule_tblCodeValue]
GO
ALTER TABLE [dbo].[tblRoleModule]  WITH CHECK ADD  CONSTRAINT [FK_tblRoleModule_tblCodeValue1] FOREIGN KEY([moduleid])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblRoleModule] CHECK CONSTRAINT [FK_tblRoleModule_tblCodeValue1]
GO
ALTER TABLE [dbo].[tblSupplier]  WITH CHECK ADD  CONSTRAINT [FK_tblSupplier_tblCodeValue] FOREIGN KEY([invoice_type])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblSupplier] CHECK CONSTRAINT [FK_tblSupplier_tblCodeValue]
GO
ALTER TABLE [dbo].[tblSupplier]  WITH CHECK ADD  CONSTRAINT [FK_tblSupplier_tblCodeValue_difflevel] FOREIGN KEY([difficult_level])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblSupplier] CHECK CONSTRAINT [FK_tblSupplier_tblCodeValue_difflevel]
GO
ALTER TABLE [dbo].[tblSupplier]  WITH CHECK ADD  CONSTRAINT [FK_tblSupplier_tblCodeValue1] FOREIGN KEY([difficult_level])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblSupplier] CHECK CONSTRAINT [FK_tblSupplier_tblCodeValue1]
GO
ALTER TABLE [dbo].[tbluser_module]  WITH CHECK ADD  CONSTRAINT [FK_tbluser_module_tblUsers] FOREIGN KEY([userid])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tbluser_module] CHECK CONSTRAINT [FK_tbluser_module_tblUsers]
GO
ALTER TABLE [dbo].[tbluser_role]  WITH CHECK ADD  CONSTRAINT [FK_tbluser_role_tblUsers] FOREIGN KEY([userid])
REFERENCES [dbo].[tblUsers] ([id])
GO
ALTER TABLE [dbo].[tbluser_role] CHECK CONSTRAINT [FK_tbluser_role_tblUsers]
GO
ALTER TABLE [dbo].[tblUsers]  WITH CHECK ADD  CONSTRAINT [FK_tblUsers_tblCodeValue] FOREIGN KEY([difficult_level])
REFERENCES [dbo].[tblCodeValue] ([id])
GO
ALTER TABLE [dbo].[tblUsers] CHECK CONSTRAINT [FK_tblUsers_tblCodeValue]
GO
/****** Object:  StoredProcedure [dbo].[GetAccess]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAccess] (@username varchar(100)) as 
begin
select b.rolename,a.username from tblusers a inner join tblRoles b on
a.UserRole = b.id where username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[GetMenu]    Script Date: 11/1/2018 5:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetMenu]
(@userid int)
as begin
select userid,moduleid,modulename from
(select UR.userid ,RM.moduleid, cv.codevalue as modulename, cv.sortorder 
from tblUsers U 
JOIN  tbluser_role UR ON U.id= UR.userid
JOIN  tblrolemodule RM ON UR.roleid=RM.roleid
JOIN tblCodeValue cv ON cv.id= RM.moduleid
where u.id = @userid
UNION ALL
Select  userid, moduleid,  cv.codevalue as modulename,cv.sortorder from  tbluser_module um
JOIN tblCodeValue cv ON cv.id= um.moduleid
where um.userid = @userid) A
order by sortorder
end
GO
USE [master]
GO
ALTER DATABASE [NorthPoint] SET  READ_WRITE 
GO
