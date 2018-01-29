CREATE TABLE [dbo].[Customer] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [Phone]            VARCHAR (50) NOT NULL,
    [GenderId]         INT          NOT NULL,
    [CityId]           INT          NULL,
    [RegionId]         INT          NULL,
    [LastPurchase]     DATE         NULL,
    [ClassificationId] INT          NULL,
    [UserId]           INT          NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

