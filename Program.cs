using Tarteeb.Importer.Brokers.Storages;
using Tarteeb.Importer.Models.Clients;

namespace Tarteeb.Importer;

internal class Program
{
    static async Task Main(string[] args)
    {
        var client = new Client()
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Smith",
            PhoneNumber = "010 0808 0204",
            Email = "john@gmail.com",
            BirthDate = DateTimeOffset.UtcNow,
            GroupId = Guid.NewGuid(),
        };

        using (var storageBroker = new StorageBroker())
        {
            
        }
    }
}

