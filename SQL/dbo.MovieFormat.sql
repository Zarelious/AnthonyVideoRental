CREATE TABLE [dbo].[MovieFormat] (
    [IdMovie]  INT NOT NULL,
    [IdFormat] INT NOT NULL,
    [Qty]      INT NOT NULL,
    CONSTRAINT [FK_MovieFormat_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie] ([IdMovie]),
    CONSTRAINT [FK_MovieFormat_ToFormat] FOREIGN KEY ([IdFormat]) REFERENCES [dbo].[Format] ([IdFormat])
);

