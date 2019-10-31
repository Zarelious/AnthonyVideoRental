CREATE TABLE [dbo].[FacturaDetail]
(
	[IdFacturaDetail] INT NOT NULL PRIMARY KEY IDENTITY,
	[IdFactura] int not null,
	[IdMovie] int not null,
	[Qty] int not null,
	[Cost] money not null, 
    CONSTRAINT [FK_FacturaDetail_ToFactura] FOREIGN KEY ([IdFactura]) REFERENCES [FacturaHeader]([IdFactura])
)
