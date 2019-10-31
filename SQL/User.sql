CREATE TABLE [dbo].[User]
(
	[IdUser] INT NOT NULL PRIMARY KEY,
	[FirstName] VARCHAR(25) NOT NULL,
	[LastName] VARCHAR(25) NOT NULL,
	[Profile] VARCHAR(25) NOT NULL,
	[Password] VARBINARY(50) NOT NULL,
	[IdSucursal] INT NOT NULL, 
    CONSTRAINT [FK_User_ToSucursal] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[Sucursal]([IdSucursal])
)
