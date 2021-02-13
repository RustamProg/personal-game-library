using personal_game_library.Services;
using personal_game_library.TabPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace personal_game_library.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        // Main fields and constructor
        private UserControl selectedTab;
        public ObservableCollection<UserControl> AllPages { get; set; }
        public MainWindowViewModel() 
        {
            AllPages = new ObservableCollection<UserControl>()
            {
                new LibraryControl(),
                new SettingsControl()
            };
            SelectedTab = AllPages[0];
        }

        // Attributes
        public UserControl SelectedTab
        {
            get { return selectedTab; }
            set
            {
                selectedTab = value;
                OnPropertyChanged("SelectedTab");
            }
        }

        //Commands

        private RelayCommand changeTabContentCommand;
        public ICommand ChangeTabContentCommand
        {
            get
            {
                return changeTabContentCommand ?? (changeTabContentCommand = new RelayCommand(obj =>
                {
                    SelectedTab = obj as UserControl;
                }));
            }
        }
        // Property changed event handler
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
