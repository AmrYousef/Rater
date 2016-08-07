CREATE TABLE [Rater].[RatingattributeCategory] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [Name]          NVARCHAR (200)   NOT NULL,
    [RatingFieldId] UNIQUEIDENTIFIER NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RatingField_RatingattributeCategory] FOREIGN KEY ([RatingFieldId]) REFERENCES [Rater].[RatingField] ([Id])
);

