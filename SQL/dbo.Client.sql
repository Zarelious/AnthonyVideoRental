CREATE TABLE [dbo].[Client] (
    [IdClient]   INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (30) NOT NULL,
    [LastName]   VARCHAR (30) NOT NULL,
    [email]      VARCHAR (50) NOT NULL,
    [telefone]   VARCHAR (15) NOT NULL,
    [DOB]        DATE         NOT NULL,
    [Status]     VARCHAR (10) NOT NULL,
    [Address]    VARCHAR (50) NOT NULL,
    [ProoOfId]   VARCHAR (10) NOT NULL,
    [Qty]        INT          NOT NULL,
    [Idsucursal] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([IdClient] ASC),
    CONSTRAINT [FK_Client_ToSurcursal] FOREIGN KEY ([Idsucursal]) REFERENCES [dbo].[Sucursal] ([IdSucursal])
);

