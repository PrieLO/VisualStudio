CREATE TABLE [dbo].[Table] (
    [Id]      INT            NOT NULL IDENTITY,
    [url]     NVARCHAR (MAX) NOT NULL,
    [depht]   INT            NOT NULL,
    [content] NVARCHAR (MAX) NOT NULL,
    [type]    NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

