CREATE TABLE [dbo].[UserRole] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (20) NOT NULL,
    [IsAdmin] BIT          NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED ([Id] ASC)
);

