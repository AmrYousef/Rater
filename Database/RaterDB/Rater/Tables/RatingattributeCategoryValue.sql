CREATE TABLE [Rater].[RatingattributeCategoryValue] (
    [Id]                        UNIQUEIDENTIFIER NOT NULL,
    [Value]                     NVARCHAR (200)   NOT NULL,
    [RatingattributeCategoryId] UNIQUEIDENTIFIER NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RatingattributeCategory_RatingattributeCategoryValue] FOREIGN KEY ([RatingattributeCategoryId]) REFERENCES [Rater].[RatingattributeCategory] ([Id])
);

