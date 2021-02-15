using personal_game_library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace personal_game_library.ViewModels
{
    class AppInfoViewModel : INotifyPropertyChanged
    {
        // Fields
        private Userapp currentUserApp;
        public AppInfoViewModel()
        {
            
        }

        //Attributes
        public Userapp CurrentUserApp
        {
            get { return currentUserApp; }
            set
            {
                currentUserApp = value;
                OnPropertyChanged("CurrentUserApp");
            }
        }


        //Commands



        // Property changed event handler
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
