CREATE TABLE [dbo].[Rooms] (
    [Id]       INT        NOT NULL,
    [Comfort]  NCHAR (10) NOT NULL,
    [Capacity] NCHAR (10) NOT NULL,
    [Price]    NCHAR (10) NOT NULL,
    [Number]   INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Number]), 
   
);

