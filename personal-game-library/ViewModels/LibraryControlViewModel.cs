﻿using personal_game_library.Models;
using personal_game_library.Services;
using personal_game_library.TabPages;
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
using System.Windows.Input;

namespace personal_game_library.ViewModels
{
    class LibraryControlViewModel: INotifyPropertyChanged
    {
        // Fields and constructor
        private Userapp userapp;
        private IEnumerable<Userapp> userapps;
        public LibraryControlViewModel()
        {
            UserappsManager userappsManager= UserappsManager.Source;
            userapps = userappsManager.GetAppsList();
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

        //Commands

        private RelayCommand startApp;
        public RelayCommand StartApp
        {
            get
            {
                return startApp ?? (startApp = new RelayCommand(obj =>
                {
                    string link = obj.ToString();
                    System.Diagnostics.Process.Start(link);
                }));
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
