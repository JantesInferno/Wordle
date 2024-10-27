using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Data.Domain.Entities;

namespace Wordle.Data.Data.Contexts
{
    public class WordleDbContext : DbContext
    {
        public WordleDbContext() { }

        public WordleDbContext(DbContextOptions<WordleDbContext> options) : base(options) 
        {
            //Database.EnsureCreated();
            //Database.Migrate();
        }

        public DbSet<Word> Words { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite();

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Seed the database with initial words
        //    modelBuilder.Entity<Word>().HasData(
        //        new Word("apple"),
        //        new Word("broke"),
        //        new Word("chair"),
        //        new Word("donut"),
        //        new Word("elder"),
        //        new Word("found"),
        //        new Word("ghoul"),
        //        new Word("harsh"),
        //        new Word("index"),
        //        new Word("juice"),
        //        new Word("karma"),
        //        new Word("liver"),
        //        new Word("mount"),
        //        new Word("novel"),
        //        new Word("offer"),
        //        new Word("query"),
        //        new Word("round"),
        //        new Word("south"),
        //        new Word("timer"),
        //        new Word("under"),
        //        new Word("vocal"),
        //        new Word("worth"),
        //        new Word("xerox"),
        //        new Word("yield"),
        //        new Word("zebra")
        //    );
        //}
    }
}
