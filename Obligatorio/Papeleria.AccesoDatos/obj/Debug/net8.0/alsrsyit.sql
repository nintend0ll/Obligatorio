IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Articulos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [Descripcion] nvarchar(max) NOT NULL,
    [Codigo] int NOT NULL,
    [PrecioVenta] int NOT NULL,
    [Stock] int NOT NULL,
    CONSTRAINT [PK_Articulos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [RazonSocial] nvarchar(max) NOT NULL,
    [Rut] int NOT NULL,
    [Direccion_Calle] nvarchar(max) NOT NULL,
    [Direccion_Numero] int NOT NULL,
    [Direccion_Ciudad] nvarchar(max) NOT NULL,
    [Direccion_Distancia] int NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NOT NULL,
    [NombreCompleto_Nombre] nvarchar(max) NOT NULL,
    [NombreCompleto_Apellido] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [Rol] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Pedidos] (
    [Id] int NOT NULL IDENTITY,
    [Fecha] datetime2 NOT NULL,
    [clienteId] int NOT NULL,
    [Discriminator] nvarchar(13) NOT NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pedidos_Clientes_clienteId] FOREIGN KEY ([clienteId]) REFERENCES [Clientes] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Pedidos_clienteId] ON [Pedidos] ([clienteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240415162629_init', N'8.0.4');
GO

COMMIT;
GO

