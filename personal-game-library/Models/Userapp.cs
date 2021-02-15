using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace personal_game_library.Models
{
    public class Userapp
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Last_Using_Time { get; set; }

        public string Location { get; set; }

        public string Icon_Location { get; set; }

        public bool Is_Favourite { get; set; }

        public int Total_Using_Time_Minutes { get; set; }
    }
}
