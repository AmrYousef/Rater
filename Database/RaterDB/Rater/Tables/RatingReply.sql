CREATE TABLE [Rater].[RatingReply] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [RatingId] UNIQUEIDENTIFIER NOT NULL,
    [Text]     NVARCHAR (200)   NULL,
    [UserId]   UNIQUEIDENTIFIER NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rating_RatingReply] FOREIGN KEY ([RatingId]) REFERENCES [Rater].[Rating] ([Id]),
    CONSTRAINT [FK_User_RatingReply] FOREIGN KEY ([UserId]) REFERENCES [Common].[User] ([Id])
);

