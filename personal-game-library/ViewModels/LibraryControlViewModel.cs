using personal_game_library.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace personal_game_library.ViewModels
{
    class LibraryControlViewModel: INotifyPropertyChanged
    {
        // Fields and constructor
        private ApplicationContext db;
        private Userapp userapp;
        private IEnumerable<Userapp> userapps;
        public LibraryControlViewModel()
        {
            db = new ApplicationContext();
            db.Userapps.Load();
            userapps = db.Userapps.Local.ToBindingList();
            userapp = userapps.First();
        }
        
        // Attributes
        public Userapp Userapp
        {
            get { return userapp; }
            set
            {
                userapp = value;
                OnPropertyChanged("Userapp");
            }
        }
        public IEnumerable<Userapp> Userapps
        {
            get { return userapps; }
            set
            {
                userapps = value;
                OnPropertyChanged("Userapps");
            }
        }

        // Proprty Changed Event Handler
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
