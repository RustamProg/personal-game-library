using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_game_library.Models
{
    public sealed class UserappsManager // Simple singleton class
    {
        private ApplicationContext db;
        private IEnumerable<Userapp> userapps;
        private UserappsManager() 
        {
            db = new ApplicationContext();
            db.Userapps.Load();
        }

        private static readonly Lazy<UserappsManager> lazy =
            new Lazy<UserappsManager>(() => new UserappsManager());
        public static UserappsManager Source { get { return lazy.Value; } }

        
        public IEnumerable<Userapp> GetAppsList()
        {
            userapps = db.Userapps.Local.ToBindingList();
            return userapps;
        }

        public IEnumerable<Userapp> GetFavouriteAppsList()
        {
            userapps = db.Userapps.Local.Where(v => v.Is_Favourite == true).ToList();
            return userapps;
        }
    }
}
