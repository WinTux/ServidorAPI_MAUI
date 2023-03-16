using ServidorAPI_MAUI.Contenido;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(
    op => op.UseSqlite(builder.Configuration.GetConnectionString("MiConexionLocalSQLite"))
    );
var app = builder.Build();
app.Run();