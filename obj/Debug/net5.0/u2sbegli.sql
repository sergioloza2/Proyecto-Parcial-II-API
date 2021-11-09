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

CREATE TABLE [Usuario_1] (
    [UsuarioId] int NOT NULL IDENTITY,
    [NUsuario] nvarchar(max) NULL,
    [Contraseña] nvarchar(max) NULL,
    CONSTRAINT [PK_Usuario_1] PRIMARY KEY ([UsuarioId])
);
GO

CREATE TABLE [Nota_1] (
    [NotaId] int NOT NULL IDENTITY,
    [Contenido] nvarchar(max) NULL,
    [UsuarioId] int NOT NULL,
    CONSTRAINT [PK_Nota_1] PRIMARY KEY ([NotaId]),
    CONSTRAINT [FK_Nota_1_Usuario_1_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario_1] ([UsuarioId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Nota_1_UsuarioId] ON [Nota_1] ([UsuarioId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211108144911_AddModel', N'5.0.11');
GO

COMMIT;
GO

