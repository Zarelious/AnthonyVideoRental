CREATE TABLE [dbo].[Rental]
(
	[IdMovie] INT NOT NULL,
	[IdClient] INT NOT NULL,
	[DateRent] DATE NOT NULL,
	[DateVencimiento] DATE NOT NULL, 
    CONSTRAINT [FK_Rental_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie]([IdMovie]), 
    CONSTRAINT [FK_Rental_ToClient] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[Client]([IdClient])
)
