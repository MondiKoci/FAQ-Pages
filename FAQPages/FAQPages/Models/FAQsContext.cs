using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQPages.Models
{
    public class FaqsContext : DbContext
    {
        public FaqsContext(DbContextOptions<FaqsContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = "gen", Name = "General" },
                    new Category { CategoryId = "hist", Name = "History" },
                    new Category { CategoryId = "tech", Name = "Technology" }
                );
            modelBuilder.Entity<Topic>().HasData(
                    new Topic { TopicId = "boot", Name = "Bootstrap" },
                    new Topic { TopicId = "cs", Name = "C#" },
                    new Topic { TopicId = "js", Name = "JavaScript" },
                    new Topic { TopicId = "academia", Name = "Academia" }
                );
            modelBuilder.Entity<FAQ>().HasData(
                    new FAQ
                    {
                        Id = 1,
                        Question = "When was Bootstrap released",
                        Answer = "In 2011",
                        TopicId = "boot",
                        CategoryId = "hist"
                    },
                    new FAQ
                    {
                        Id = 2,
                        Question = "When did Plato found the Academy?",
                        Answer = "In 387 BC, Classical Athens",
                        TopicId = "academia",
                        CategoryId = "hist"
                    },
                    new FAQ
                    {
                        Id = 3,
                        Question = "When was C# first released?",
                        Answer = "In 2002",
                        TopicId = "cs",
                        CategoryId = "hist"
                    },
                    new FAQ
                    {
                        Id = 4,
                        Question = "When was JavaScript first released?",
                        Answer = "In 1995",
                        TopicId = "js",
                        CategoryId = "hist"
                    },
                    new FAQ
                    {
                        Id = 5,
                        Question = "What is JavaScript",
                        Answer = "JavaScript is a general purpose scripting language that executes in the browser",
                        TopicId = "js",
                        CategoryId = "gen"
                    },
                    new FAQ
                    {
                        Id = 6,
                        Question = "What is C#?",
                        Answer = "A general purpose object-oriented language that uses concise java-like syntax",
                        TopicId = "cs",
                        CategoryId = "gen"

                    },
                    new FAQ
                    {
                        Id = 7,
                        Question = "What is Bootstrap?",
                        Answer = "A CSS framwork for creating responsive web applications for multiple screen sizes",
                        TopicId = "boot",
                        CategoryId = "gen"

                    },
                    new FAQ
                    {
                        Id = 8,
                        Question = "What is JavaScript?",
                        Answer = "A general purpose scripting language that executes in a web browser",
                        TopicId = "js",
                        CategoryId = "gen"

                    }
                );
        }

    }
}
