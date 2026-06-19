-- Este script registra la migración InitialCreate como aplicada manualmente
-- Ejecutar esto si la tabla __EFMigrationsHistory no tiene registrada la migración

USE [dateteamdb];  -- Reemplazar con el nombre de tu BD
GO

IF NOT EXISTS (SELECT 1 FROM [__EFMigrationsHistory] WHERE [MigrationId] = '20260617194110_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES ('20260617194110_InitialCreate', '9.0.0');
END
GO
