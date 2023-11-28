using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Tarteeb.Importer.Models.Clients;

namespace Tarteeb.Importer.Brokers.Storages;

public class StorageBroker : EFxceptionsContext
{
    public DbSet<Client> Clients { get; set; }

    public StorageBroker()
    {
        this.Database.EnsureCreated();
    }

 
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data source = Tarteeb.db";
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        optionsBuilder.UseSqlite(connectionString);
    }
}