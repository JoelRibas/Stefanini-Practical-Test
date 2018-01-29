CREATE TABLE [dbo].[City] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (20) NOT NULL,
    [RegionId] INT          NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_City_Region] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([Id])
);

