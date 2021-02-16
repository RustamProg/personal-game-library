using Microsoft.Win32;
using personal_game_library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace personal_game_library.Services
{
    class OpenSaveManagerService : IDialogService
    {
        public IEnumerable<Userapp> OpenData(string path)
        {
            throw new NotImplementedException();
        }

        public void SaveData(IEnumerable<Userapp> userapps, string path)
        {
            string fullPath = path;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(IEnumerable<Userapp>));
            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                jsonSerializer.WriteObject(fs, userapps);
            }
        }
    }
}
