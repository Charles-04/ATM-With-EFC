using Microsoft.EntityFrameworkCore;

namespace ATM.DAL
{
    public class ATMDbContext : DbContext
    {
        public ATMDbContext(DbContextOptions<ATMDbContext> options):base(options)
        {

        }
    }
}