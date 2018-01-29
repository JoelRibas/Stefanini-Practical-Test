CREATE TABLE [dbo].[Classification] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Classification] PRIMARY KEY CLUSTERED ([Id] ASC)
);

