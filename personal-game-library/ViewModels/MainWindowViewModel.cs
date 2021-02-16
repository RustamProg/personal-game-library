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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace personal_game_library.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        // Main fields and constructor
        private UserControl selectedTab;
        private WindowState windowStateNow;
        public ObservableCollection<UserControl> AllPages { get; set; }
        public MainWindowViewModel() 
        {
            windowStateNow = WindowState.Normal;
            AllPages = new ObservableCollection<UserControl>()
            {
                new LibraryControl(),
                new SettingsControl(),
                new FavouriteAppsControl()
            };
            SelectedTab = AllPages[0];
        }

        // Attributes
        public WindowState WindowStateNow
        {
            get { return windowStateNow; }
            set
            {
                windowStateNow = value;
                OnPropertyChanged("WindowStateNow");
            }
        }

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

        private RelayCommand closeApp;
        public RelayCommand CloseApp
        {
            get
            {
                return closeApp ?? (closeApp = new RelayCommand(obj =>
                {
                    Application.Current.Shutdown();
                }));
            }
        }

        private RelayCommand openFullScreen;
        public RelayCommand OpenFullScreen
        {
            get
            {
                return openFullScreen ?? (openFullScreen = new RelayCommand(obj =>
                {
                    windowStateNow = WindowState.Maximized;
                }));
            }
        }

        private RelayCommand minimizeScreen;
        public RelayCommand MinimizeScreen
        {
            get
            {
                return minimizeScreen ?? (minimizeScreen = new RelayCommand(obj =>
                {
                    windowStateNow = WindowState.Minimized;
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
