
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2021 10:07:00
-- Generated from EDMX file: C:\Users\35389\Documents\Semester 4 Software development year 2\object orieneted development\Mah Noor_S00199547Final Exam\Mah Noor_S00199547Final Exam\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gamesinfo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GameInfoes'
CREATE TABLE [dbo].[GameInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Platform] nvarchar(max)  NOT NULL,
    [CriticsScore] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [GaneImage] nvarchar(max)  NOT NULL,
    [Decsription] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GameInfoes'
ALTER TABLE [dbo].[GameInfoes]
ADD CONSTRAINT [PK_GameInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------