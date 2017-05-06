
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2017 20:44:47
-- Generated from EDMX file: F:\Projekty 2017\Repozytorium\SkyReg\DataLayer\DLModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [edo_skyreg]; --USE [db_skyreg];
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

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UsersNr] int  NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [SurName] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [CertificateNr] nvarchar(max)  NULL,
    [CertificateDate] datetime  NULL,
    [Street] nvarchar(max)  NULL,
    [ZipCode] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [Phone] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Facebook] nvarchar(max)  NULL,
    [FlightElement_Id] int  NOT NULL,
    [TandemOrderPilot_Id] int  NOT NULL,
    [TandemOrderPassenger_Id] int  NOT NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] float  NULL,
    [Camera] bit  NOT NULL,
    [TandemPilot] bit  NOT NULL,
    [TandemPassenger] bit  NOT NULL,
    [SpecialType] int  NOT NULL,
    [User_Id] int  NOT NULL,
    [FlightElement_Id] int  NOT NULL
);
GO

-- Creating table 'Setting'
CREATE TABLE [dbo].[Setting] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AssemblyValue] float  NOT NULL,
    [CameraValue] float  NOT NULL
);
GO

-- Creating table 'Airplane'
CREATE TABLE [dbo].[Airplane] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Seats] int  NOT NULL,
    [Flight_Id] int  NOT NULL
);
GO

-- Creating table 'Flight'
CREATE TABLE [dbo].[Flight] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [Altitude] float  NULL
);
GO

-- Creating table 'FlightElement'
CREATE TABLE [dbo].[FlightElement] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Flight_Id] int  NOT NULL
);
GO

-- Creating table 'TandemOrder'
CREATE TABLE [dbo].[TandemOrder] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SuggestDateTime] datetime  NOT NULL,
    [FlightElement_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Setting'
ALTER TABLE [dbo].[Setting]
ADD CONSTRAINT [PK_Setting]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Airplane'
ALTER TABLE [dbo].[Airplane]
ADD CONSTRAINT [PK_Airplane]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Flight'
ALTER TABLE [dbo].[Flight]
ADD CONSTRAINT [PK_Flight]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FlightElement'
ALTER TABLE [dbo].[FlightElement]
ADD CONSTRAINT [PK_FlightElement]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TandemOrder'
ALTER TABLE [dbo].[TandemOrder]
ADD CONSTRAINT [PK_TandemOrder]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_Id] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [FK_UsersRoles]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersRoles'
CREATE INDEX [IX_FK_UsersRoles]
ON [dbo].[Role]
    ([User_Id]);
GO

-- Creating foreign key on [Flight_Id] in table 'Airplane'
ALTER TABLE [dbo].[Airplane]
ADD CONSTRAINT [FK_AirplaneFlight]
    FOREIGN KEY ([Flight_Id])
    REFERENCES [dbo].[Flight]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AirplaneFlight'
CREATE INDEX [IX_FK_AirplaneFlight]
ON [dbo].[Airplane]
    ([Flight_Id]);
GO

-- Creating foreign key on [Flight_Id] in table 'FlightElement'
ALTER TABLE [dbo].[FlightElement]
ADD CONSTRAINT [FK_FlightFlightElement]
    FOREIGN KEY ([Flight_Id])
    REFERENCES [dbo].[Flight]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FlightFlightElement'
CREATE INDEX [IX_FK_FlightFlightElement]
ON [dbo].[FlightElement]
    ([Flight_Id]);
GO

-- Creating foreign key on [FlightElement_Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_UserFlightElement]
    FOREIGN KEY ([FlightElement_Id])
    REFERENCES [dbo].[FlightElement]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFlightElement'
CREATE INDEX [IX_FK_UserFlightElement]
ON [dbo].[User]
    ([FlightElement_Id]);
GO

-- Creating foreign key on [FlightElement_Id] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [FK_RoleFlightElement]
    FOREIGN KEY ([FlightElement_Id])
    REFERENCES [dbo].[FlightElement]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleFlightElement'
CREATE INDEX [IX_FK_RoleFlightElement]
ON [dbo].[Role]
    ([FlightElement_Id]);
GO

-- Creating foreign key on [TandemOrderPilot_Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_TandemOrderUser]
    FOREIGN KEY ([TandemOrderPilot_Id])
    REFERENCES [dbo].[TandemOrder]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TandemOrderUser'
CREATE INDEX [IX_FK_TandemOrderUser]
ON [dbo].[User]
    ([TandemOrderPilot_Id]);
GO

-- Creating foreign key on [FlightElement_Id] in table 'TandemOrder'
ALTER TABLE [dbo].[TandemOrder]
ADD CONSTRAINT [FK_FlightElementTandemOrder]
    FOREIGN KEY ([FlightElement_Id])
    REFERENCES [dbo].[FlightElement]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FlightElementTandemOrder'
CREATE INDEX [IX_FK_FlightElementTandemOrder]
ON [dbo].[TandemOrder]
    ([FlightElement_Id]);
GO

-- Creating foreign key on [TandemOrderPassenger_Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_UserTandemOrder]
    FOREIGN KEY ([TandemOrderPassenger_Id])
    REFERENCES [dbo].[TandemOrder]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTandemOrder'
CREATE INDEX [IX_FK_UserTandemOrder]
ON [dbo].[User]
    ([TandemOrderPassenger_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------