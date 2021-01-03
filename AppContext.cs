using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp1
{
    class AppContext : DbContext
    {
        public DbSet<Word> Words { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
