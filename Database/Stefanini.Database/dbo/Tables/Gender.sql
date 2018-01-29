CREATE TABLE [dbo].[Gender] (
    [Id]   INT        IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (10) NOT NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED ([Id] ASC)
);

