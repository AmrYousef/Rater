CREATE TABLE [Rater].[RatingAttributeCategoryValueCountry] (
    [CountryId]                      UNIQUEIDENTIFIER NOT NULL,
    [RatingAttributeCategoryValueId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([RatingAttributeCategoryValueId] ASC, [CountryId] ASC),
    CONSTRAINT [FK_Country_RatingAttributeCategoryValueCountry] FOREIGN KEY ([CountryId]) REFERENCES [Common].[Country] ([Id]),
    CONSTRAINT [FK_RatingAttributeCategoryValue_RatingAttributeCategoryValueCountry] FOREIGN KEY ([RatingAttributeCategoryValueId]) REFERENCES [Rater].[RatingattributeCategoryValue] ([Id])
);

