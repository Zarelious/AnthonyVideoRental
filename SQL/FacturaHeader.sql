--CREATE TABLE [dbo].[Client]
--(
--	[IdClient] INT NOT NULL PRIMARY KEY, 
--    [FirstName] VARCHAR(30) NOT NULL,
--	[LastName] varchar (30) not null,
--	[email] varchar (50) not null,
--	[telefone] varchar (15) not null, 
--    [DOB] DATE NOT NULL,
--	[Status] varchar (10) not null,
--	[Address] varchar (50) not null,
--	[ProoOfId] varchar (10) not null,
--	[Qty] int not null,
--	[Idsucursal] int not null, 
--    CONSTRAINT [FK_Client_ToSurcursal] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[Sucursal]([IdSucursal]),
	
	

--)

CREATE TABLE [dbo].[FacturaHeader]
( 
[IdFactura] INT NOT NULL PRIMARY KEY IDENTITY,
[Date] DATE NOT NULL,
[IdClient] INT NOT NULL,
[DateRent] DATE NOT NULL,
[Total] MONEY NOT NULL,
[IdSucursal] INT NOT NULL,

CONSTRAINT [FK_FacturaHeader] FOREIGN KEY (IdClient) REFERENCES dbo.Client (IdClient),

)