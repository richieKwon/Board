using Microsoft.EntityFrameworkCore;
using Note.Model;

namespace Note.DAL.DataContext
{
    public class NoteDbContext : DbContext
    {
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=AspNote;User Id=sa;Password=richie1234Jen!;");
        }
    }
} 
  