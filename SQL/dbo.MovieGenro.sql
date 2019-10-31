CREATE TABLE [dbo].[MovieGenro] (
    [IdMovie]  INT NOT NULL,
    [IdGenero] INT NOT NULL,
    CONSTRAINT [FK_MovieGenro_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie] ([IdMovie]),
    CONSTRAINT [FK_MovieGenro_ToGenero] FOREIGN KEY ([IdGenero]) REFERENCES [dbo].[Genero] ([IdGenero])
);

