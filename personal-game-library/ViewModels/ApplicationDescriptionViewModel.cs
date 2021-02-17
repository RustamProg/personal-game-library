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
    class ApplicationDescriptionViewModel : INotifyPropertyChanged
    {

        private Userapp currentUserApp;
        public ApplicationDescriptionViewModel()
        {

        }

        public Userapp CurrentUserApp
        {
            get { return currentUserApp; }
            set
            {
                currentUserApp = value;
                OnPropertyChanged("CurrentUserApp");
            }
        }

        // Property Changed Event Handler
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
