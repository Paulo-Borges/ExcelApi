using Microsoft.EntityFrameworkCore;

namespace ExcelApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
    }
}
