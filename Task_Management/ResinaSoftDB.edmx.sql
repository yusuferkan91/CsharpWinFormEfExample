
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2021 02:43:07
-- Generated from EDMX file: C:\Users\YusufPC\source\repos\ResinaSoft_WinForm\ResinaSoft_WinForm\ResinaSoftDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ResinaSoftDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonPersonAddresses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonAddresses] DROP CONSTRAINT [FK_PersonPersonAddresses];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonPersonelTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonelTask] DROP CONSTRAINT [FK_PersonPersonelTask];
GO
IF OBJECT_ID(N'[dbo].[FK_TaskPersonelTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonelTask] DROP CONSTRAINT [FK_TaskPersonelTask];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[PersonAddresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonAddresses];
GO
IF OBJECT_ID(N'[dbo].[PersonelTask]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonelTask];
GO
IF OBJECT_ID(N'[dbo].[Task]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Task];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonAddresses'
CREATE TABLE [dbo].[PersonAddresses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonId] int  NOT NULL,
    [AddressType] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CityId] int  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonelTask'
CREATE TABLE [dbo].[PersonelTask] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonelId] int  NOT NULL,
    [TaskId] int  NOT NULL,
    [TaskStatus] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Task'
CREATE TABLE [dbo].[Task] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Deadline] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonAddresses'
ALTER TABLE [dbo].[PersonAddresses]
ADD CONSTRAINT [PK_PersonAddresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonelTask'
ALTER TABLE [dbo].[PersonelTask]
ADD CONSTRAINT [PK_PersonelTask]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Task'
ALTER TABLE [dbo].[Task]
ADD CONSTRAINT [PK_Task]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonId] in table 'PersonAddresses'
ALTER TABLE [dbo].[PersonAddresses]
ADD CONSTRAINT [FK_PersonPersonAddresses]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[Person]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPersonAddresses'
CREATE INDEX [IX_FK_PersonPersonAddresses]
ON [dbo].[PersonAddresses]
    ([PersonId]);
GO

-- Creating foreign key on [PersonelId] in table 'PersonelTask'
ALTER TABLE [dbo].[PersonelTask]
ADD CONSTRAINT [FK_PersonPersonelTask]
    FOREIGN KEY ([PersonelId])
    REFERENCES [dbo].[Person]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPersonelTask'
CREATE INDEX [IX_FK_PersonPersonelTask]
ON [dbo].[PersonelTask]
    ([PersonelId]);
GO

-- Creating foreign key on [TaskId] in table 'PersonelTask'
ALTER TABLE [dbo].[PersonelTask]
ADD CONSTRAINT [FK_TaskPersonelTask]
    FOREIGN KEY ([TaskId])
    REFERENCES [dbo].[Task]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TaskPersonelTask'
CREATE INDEX [IX_FK_TaskPersonelTask]
ON [dbo].[PersonelTask]
    ([TaskId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------