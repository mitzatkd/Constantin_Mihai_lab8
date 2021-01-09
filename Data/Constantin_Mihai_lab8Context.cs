using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Constantin_Mihai_lab8.Models;

namespace Constantin_Mihai_lab8.Data
{
    public class Constantin_Mihai_lab8Context : DbContext
    {
        public Constantin_Mihai_lab8Context (DbContextOptions<Constantin_Mihai_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Constantin_Mihai_lab8.Models.Book> Book { get; set; }

        public DbSet<Constantin_Mihai_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Constantin_Mihai_lab8.Models.Category> Category { get; set; }
    }
}
