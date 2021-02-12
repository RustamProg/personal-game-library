using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_game_library.Models
{
    class ApplicationContext: DbContext
    {
        public ApplicationContext(): base("SqliteConnection") { }

        public DbSet<Userapp> Userapps { get; set; }
    }
}
