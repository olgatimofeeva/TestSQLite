using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TestSQLite.Tables;

namespace TestSQLite
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }

        public DbSet<Word> Words { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        public DbSet<PartOfSpeech> PartOfSpeeches { get; set; }

        public DbSet<ChildrenAge> ChildrenAges { get; set; }



    }
}
