using Microsoft.EntityFrameworkCore;

namespace RoomMatch.Models
{
    public class RoomMatchContext : DbContext
    {
        public RoomMatchContext(DbContextOptions<RoomMatchContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}