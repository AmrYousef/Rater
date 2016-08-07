CREATE TABLE [Rater].[RatingAttributes] (
    [Id]                           UNIQUEIDENTIFIER NOT NULL,
    [RatingAttributeCategoryValue] UNIQUEIDENTIFIER NULL,
    [RatingId]                     UNIQUEIDENTIFIER NOT NULL,
    [FreeTextRatingCategoryValue]  NVARCHAR (200)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rating_RatingAttributes] FOREIGN KEY ([RatingId]) REFERENCES [Rater].[Rating] ([Id]),
    CONSTRAINT [FK_RatingattributeCategoryValue_RatingAttributes] FOREIGN KEY ([RatingAttributeCategoryValue]) REFERENCES [Rater].[RatingattributeCategoryValue] ([Id])
);

