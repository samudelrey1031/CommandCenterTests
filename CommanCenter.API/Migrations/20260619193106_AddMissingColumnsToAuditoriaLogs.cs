using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommanCenter.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingColumnsToAuditoriaLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Registrar la migración InitialCreate en el historial si no existe
            // (fue aplicada manualmente a través del script SQL)
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [__EFMigrationsHistory] WHERE [MigrationId] = '20260617194110_InitialCreate')
                BEGIN
                    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
                    VALUES ('20260617194110_InitialCreate', '9.0.0');
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // No se puede revertir - las tablas ya existen en producción
        }
    }
}
