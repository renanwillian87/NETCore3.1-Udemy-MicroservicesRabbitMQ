using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MicroRabbit.Transfer.Data.Context;
namespace MicroRabbit.Transfer.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=MicroservicesRabbitMQ.TransferDB;User Id=cleanArchitecture;Password=N6Y+%$kl@;MultipleActiveResultSets=true");
            return new TransferDbContext(optionsBuilder.Options);
        }
    }
}