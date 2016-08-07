CREATE TABLE [Rater].[Rating] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [Text]     NVARCHAR (200)   NULL,
    [Score]    SMALLINT         NOT NULL,
    [UserId]   UNIQUEIDENTIFIER NOT NULL,
    [AspectId] UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Aspect_Rating] FOREIGN KEY ([AspectId]) REFERENCES [Rater].[RatingAspect] ([Id]),
    CONSTRAINT [FK_User_Rating] FOREIGN KEY ([UserId]) REFERENCES [Common].[User] ([Id])
);

