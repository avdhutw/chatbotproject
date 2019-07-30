
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/29/2019 15:58:59
-- Generated from EDMX file: C:\Users\91878\Downloads\chatbotproject-master\chatbotproject-master\Models\Userdb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mobile_app];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Prepaid_Plan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prepaid_Plan];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Client_id] int IDENTITY(1,1) NOT NULL,
    [Phone_no] varchar(12)  NULL,
    [First_name] nvarchar(50)  NULL,
    [Last_name] nvarchar(50)  NULL,
    [Current_plan] int  NULL,
    [Lastthree_m] decimal(18,0)  NULL,
    [Lastsix_m] decimal(18,0)  NULL,
    [Lastone_yr] decimal(18,0)  NULL,
    [Typeof_user] varchar(4)  NULL,
    [DOB] datetime  NULL
);
GO

-- Creating table 'Prepaid_Plan'
CREATE TABLE [dbo].[Prepaid_Plan] (
    [Plan_id] int IDENTITY(1,1) NOT NULL,
    [Plan_name] nvarchar(50)  NULL,
    [Noof_day] nvarchar(10)  NULL,
    [Datalimit_per] nvarchar(10)  NULL,
    [Noof_sms] int  NULL,
    [Noof_calls] nchar(10)  NULL,
    [Isunlimitedcalling_enabled] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Client_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Client_id] ASC);
GO

-- Creating primary key on [Plan_id] in table 'Prepaid_Plan'
ALTER TABLE [dbo].[Prepaid_Plan]
ADD CONSTRAINT [PK_Prepaid_Plan]
    PRIMARY KEY CLUSTERED ([Plan_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------