using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ToledoCW.Services.Domain.Entidades;
using ToledoCW.Services.Infraestructure.Entidades;

namespace ToledoCW.Services.Infraestructure;

public class ToledoCWContext : DbContext
{
    public ToledoCWContext() : base()
    {
        
    }
    
    public ToledoCWContext(DbContextOptions<DbContext> dbcontext) : base(dbcontext)
    {
        
    }
    
    protected static readonly ILoggerFactory Logger = LoggerFactory.Create(builder =>
    {
        builder.AddFilter
            (
                (category, level) => category == DbLoggerCategory.Database.Command.Name &&
                                     (level is LogLevel.Information or LogLevel.Error)
            );
    });


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseMySQL("Server=localhost;Database=toledocw;Uid=root;Pwd=448228;");
        
        optionsBuilder.UseLoggerFactory(Logger)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Atendente>(builder =>
        {
            builder.ToTable("atendente");
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Estabelecimento).IsRequired();

            builder.HasOne(x => x.EstabelecimentoObj).WithMany().HasForeignKey(x => x.Estabelecimento).IsRequired();
        });

        modelBuilder.Entity<Estabelecimento>(builder =>
        {
            builder.ToTable("estabelecimento");
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();

            builder.HasData(new Estabelecimento
            {
                Id = 1,
                Nome = "Estabelecimento 1"
            },
            new Estabelecimento
            {
                Id = 2,
                Nome = "Estabelecimento 2"
            }
            );
        });
        modelBuilder.Entity<Cliente>(builder =>
        {
            builder.ToTable("cliente");
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired().HasColumnName("dt_nascimento");
        }
        );
    }
}