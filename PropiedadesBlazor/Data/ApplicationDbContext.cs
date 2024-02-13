using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropiedadesBlazor.Modelos;

namespace PropiedadesBlazor.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //Agregar modelos que corresponden a cada tabla de la base de datos
    public DbSet<Categoria> Categoria { get; set; }

    public DbSet<Propiedad> Propiedad { get; set; }

    public DbSet<ImagenPropiedad> ImagenPropiedad { get; set; }
}