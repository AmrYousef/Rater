CREATE TABLE [Common].[User] (
    [Id]                   UNIQUEIDENTIFIER NOT NULL,
    [Email]                NVARCHAR (200)   NOT NULL,
    [Name]                 NVARCHAR (200)   NULL,
    [CountryOfPereference] UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Country_User] FOREIGN KEY ([CountryOfPereference]) REFERENCES [Common].[Country] ([Id])
);

