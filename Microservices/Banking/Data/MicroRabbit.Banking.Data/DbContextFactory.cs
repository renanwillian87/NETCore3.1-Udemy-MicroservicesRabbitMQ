using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MicroRabbit.Banking.Data.Context;
namespace MicroRabbit.Banking.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=MicroservicesRabbitMQ.BankingDB;User Id=cleanArchitecture;Password=N6Y+%$kl@;MultipleActiveResultSets=true");
            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}