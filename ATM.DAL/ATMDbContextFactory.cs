using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
    public class ATMDbContextFactory : IDesignTimeDbContextFactory<ATMDbContext>
    {
        public ATMDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<ATMDbContext>();
            var ConnectionString = @"Data Source=CHARLES\MYDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=EFCoreATM";
            OptionBuilder.UseSqlServer(ConnectionString);
            return new ATMDbContext(OptionBuilder.Options);
        }
    }
}
