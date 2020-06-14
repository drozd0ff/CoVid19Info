using CoVid19Info.Models;
using Microsoft.EntityFrameworkCore;

namespace CoVid19Info.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<AllCountriesModel> AllCountriesModels { get; set; }
    }
}