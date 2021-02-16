using personal_game_library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_game_library.Services
{
    interface IDialogService
    {
        void SaveData(IEnumerable<Userapp> userapps, string path);
        IEnumerable<Userapp> OpenData(string path);
    }
}
