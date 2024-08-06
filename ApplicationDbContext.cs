using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Define tus DbSet aquí
    public DbSet<MiEntidad> MisEntidades { get; set; }
}

public class MiEntidad
{
    public int Id { get; set; }
    public string Nome{ get; set; }
    // Otras propiedades
}

