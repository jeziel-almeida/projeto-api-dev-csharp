using VoeAirlines.Entities;
using VoeAirlines.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace VoeAirlines.Contexts;

public class VoeAirlinesContext: DbContext
{
    private readonly IConfiguration _configuration;

    public VoeAirlinesContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
    public DbSet<Piloto> Pilotos => Set<Piloto>();
    public DbSet<Voo> Voos => Set<Voo>();
    public DbSet<Cancelamento> Cancelamentos => Set<Cancelamento>();
    public DbSet<Manutencao> Manutencoes => Set<Manutencao>();
    public DbSet<Login> Logins => Set<Login>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        var builder = new SqlConnectionStringBuilder(
            _configuration.GetConnectionString("VoeAirlines"));
        builder.Password = _configuration.GetSection("DBPassword").Value;

        var connectionString = builder.ConnectionString;

        optionsBuilder.UseSqlServer(connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AeronaveConfiguration());
        modelBuilder.ApplyConfiguration(new PilotoConfiguration());
        modelBuilder.ApplyConfiguration(new VooConfiguration());
        modelBuilder.ApplyConfiguration(new CancelamentoConfiguration());
        modelBuilder.ApplyConfiguration(new ManutencaoConfiguration());
        modelBuilder.ApplyConfiguration(new LoginConfiguration());
    }
}
