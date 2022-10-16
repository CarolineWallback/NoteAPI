using Microsoft.EntityFrameworkCore;
using NoteAPI.Models;

namespace NoteAPI.Data
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext()
        {

        }

        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }

        //Mock Notes to Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(new Note { Id = 1, Title = "Viktigt", Content = "Ät upp din choklad"}); 
            modelBuilder.Entity<Note>().HasData(new Note { Id = 2, Title = "Kalas", Content = "Kalas på lekland lördag vecka 32"});
            modelBuilder.Entity<Note>().HasData(new Note { Id = 3, Title = "Semester", Content = "Sök semester från jobb vecka 28-32, boka resa!" });
            modelBuilder.Entity<Note>().HasData(new Note { Id = 4, Title = "Julafton", Content = "Hos farmor kl 12.30"});
        }
    }
}
