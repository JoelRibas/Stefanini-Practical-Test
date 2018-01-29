CREATE TABLE [dbo].[UserSys] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Login]      VARCHAR (20) NOT NULL,
    [Email]      VARCHAR (50) NOT NULL,
    [Password]   VARCHAR (40) NOT NULL,
    [UserRoleId] INT          NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);

