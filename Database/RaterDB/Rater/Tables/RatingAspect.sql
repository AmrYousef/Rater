CREATE TABLE [Rater].[RatingAspect] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [Name]          NCHAR (10)       NOT NULL,
    [RatingFieldId] UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RatingField_RatingAspect] FOREIGN KEY ([RatingFieldId]) REFERENCES [Rater].[RatingField] ([Id])
);

