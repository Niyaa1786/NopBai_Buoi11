using Buoi11_TranMinhThanh_ThiThu.Models;
using Microsoft.EntityFrameworkCore;

namespace Buoi11_TranMinhThanh_ThiThu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Course> Course { get; set; }
    }
}
