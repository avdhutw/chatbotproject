USE [mobile_app]
GO
/****** Object:  Table [dbo].[Prepaid_Plan]    Script Date: 09-08-2019 17:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prepaid_Plan](
	[Plan_id] [int] IDENTITY(1,1) NOT NULL,
	[Plan_name] [nvarchar](50) NULL,
	[Noof_day] [nvarchar](10) NULL,
	[Datalimit_per] [nvarchar](10) NULL,
	[Noof_sms] [int] NULL,
	[Noof_calls] [nchar](10) NULL,
	[Isunlimitedcalling_enabled] [bit] NULL,
 CONSTRAINT [PK_Prepaid_Plan] PRIMARY KEY CLUSTERED 
(
	[Plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shows]    Script Date: 09-08-2019 17:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shows](
	[channel_id] [int] IDENTITY(1,1) NOT NULL,
	[channel_name] [nvarchar](50) NULL,
	[show_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_shows] PRIMARY KEY CLUSTERED 
(
	[channel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09-08-2019 17:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Client_id] [int] IDENTITY(1,1) NOT NULL,
	[Phone_no] [varchar](12) NULL,
	[First_name] [nvarchar](50) NULL,
	[Last_name] [nvarchar](50) NULL,
	[Current_plan] [int] NULL,
	[Lastthree_m] [decimal](18, 0) NULL,
	[Lastsix_m] [decimal](18, 0) NULL,
	[Lastone_yr] [decimal](18, 0) NULL,
	[Typeof_user] [varchar](12) NULL,
	[DOB] [datetime] NULL,
	[Plan_id] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Prepaid_Plan] ON 

INSERT [dbo].[Prepaid_Plan] ([Plan_id], [Plan_name], [Noof_day], [Datalimit_per], [Noof_sms], [Noof_calls], [Isunlimitedcalling_enabled]) VALUES (1, N'Unlimited Calls/Sms 149/-', N'28', N'1.5', 10, N'Unlimited ', 1)
INSERT [dbo].[Prepaid_Plan] ([Plan_id], [Plan_name], [Noof_day], [Datalimit_per], [Noof_sms], [Noof_calls], [Isunlimitedcalling_enabled]) VALUES (2, N'Unlimited Calls/sms 189/-', N'45', N'1.5', 20, N'Unlimited ', 1)
INSERT [dbo].[Prepaid_Plan] ([Plan_id], [Plan_name], [Noof_day], [Datalimit_per], [Noof_sms], [Noof_calls], [Isunlimitedcalling_enabled]) VALUES (3, N'Unlimited Calls/sms 249/-', N'60', N'2', 20, N'Unlimited ', 1)
INSERT [dbo].[Prepaid_Plan] ([Plan_id], [Plan_name], [Noof_day], [Datalimit_per], [Noof_sms], [Noof_calls], [Isunlimitedcalling_enabled]) VALUES (4, N'Sachet Pack 19/-', N'1', N'1', 0, N'No Calls  ', 0)
INSERT [dbo].[Prepaid_Plan] ([Plan_id], [Plan_name], [Noof_day], [Datalimit_per], [Noof_sms], [Noof_calls], [Isunlimitedcalling_enabled]) VALUES (5, N'Sachet Pack 29/_', N'1', N'2', 0, N'No Calls  ', 0)
SET IDENTITY_INSERT [dbo].[Prepaid_Plan] OFF
SET IDENTITY_INSERT [dbo].[shows] ON 

INSERT [dbo].[shows] ([channel_id], [channel_name], [show_name]) VALUES (1, N'SET', N'SuperStar Singer |Reality Show')
INSERT [dbo].[shows] ([channel_id], [channel_name], [show_name]) VALUES (2, N'SAB', N'Tenali Ram | Comedy')
INSERT [dbo].[shows] ([channel_id], [channel_name], [show_name]) VALUES (3, N'SONY MARATHI', N'Kon Honaar Crorepati | Game Show')
INSERT [dbo].[shows] ([channel_id], [channel_name], [show_name]) VALUES (4, N'LIV FOOD', N'India Unlimited | Cookery')
INSERT [dbo].[shows] ([channel_id], [channel_name], [show_name]) VALUES (5, N'Liv Music', N'Arjit singh Hits')
SET IDENTITY_INSERT [dbo].[shows] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Client_id], [Phone_no], [First_name], [Last_name], [Current_plan], [Lastthree_m], [Lastsix_m], [Lastone_yr], [Typeof_user], [DOB], [Plan_id]) VALUES (27, N'9822763405', N'Avdhut', N'Wakchaure', 149, CAST(132 AS Decimal(18, 0)), CAST(245 AS Decimal(18, 0)), CAST(542 AS Decimal(18, 0)), N'Prepaid', CAST(N'1993-06-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Users] ([Client_id], [Phone_no], [First_name], [Last_name], [Current_plan], [Lastthree_m], [Lastsix_m], [Lastone_yr], [Typeof_user], [DOB], [Plan_id]) VALUES (28, N'9822172776', N'Swapnil', N'Wakchaure', 189, CAST(211 AS Decimal(18, 0)), CAST(319 AS Decimal(18, 0)), CAST(641 AS Decimal(18, 0)), N'Prepaid', CAST(N'1993-06-11T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Users] ([Client_id], [Phone_no], [First_name], [Last_name], [Current_plan], [Lastthree_m], [Lastsix_m], [Lastone_yr], [Typeof_user], [DOB], [Plan_id]) VALUES (30, N'8788501510', N'Avi', N'Sharma', 249, CAST(289 AS Decimal(18, 0)), CAST(653 AS Decimal(18, 0)), CAST(894 AS Decimal(18, 0)), N'Prepaid', CAST(N'1993-06-10T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Users] ([Client_id], [Phone_no], [First_name], [Last_name], [Current_plan], [Lastthree_m], [Lastsix_m], [Lastone_yr], [Typeof_user], [DOB], [Plan_id]) VALUES (31, N'9822121212', N'manoj', N'kumar', 1, CAST(12 AS Decimal(18, 0)), CAST(241 AS Decimal(18, 0)), CAST(545 AS Decimal(18, 0)), N'prepaid', CAST(N'1994-06-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Users] ([Client_id], [Phone_no], [First_name], [Last_name], [Current_plan], [Lastthree_m], [Lastsix_m], [Lastone_yr], [Typeof_user], [DOB], [Plan_id]) VALUES (32, N'9822121314', N'ajinkya', N'mane', 0, CAST(45 AS Decimal(18, 0)), CAST(241 AS Decimal(18, 0)), CAST(322 AS Decimal(18, 0)), N'Prepaid', CAST(N'1994-06-14T00:00:00.000' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
