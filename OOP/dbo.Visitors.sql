CREATE TABLE [dbo].[Visitors] (
    [Id]          INT         NOT NULL,
    [First_Name]  NVARCHAR(50) NOT NULL,
    [Second_Name] NCHAR (256) NOT NULL,
    [Patronymic]  NCHAR (256) NULL,
    [Comment]     NCHAR (256) NULL,
    [Room_Number] INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Visitors_ToRooms] FOREIGN KEY ([Room_Number]) REFERENCES [dbo].[Rooms] ([Number])
);

