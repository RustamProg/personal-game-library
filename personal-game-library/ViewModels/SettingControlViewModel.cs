using Microsoft.Win32;
using personal_game_library.Models;
using personal_game_library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace personal_game_library.ViewModels
{
    class SettingControlViewModel: INotifyPropertyChanged
    {
        // Fields
        private List<string> favouriteTypes;
        private string currentType;
        private string filePath;
        private string fileName;
        public SettingControlViewModel()
        {
            favouriteTypes = new List<string>()
            {
                "Not favourite",
                "Favourite"
            };
            currentType = favouriteTypes[0];
        }

        // Attributes
        public string CurrentType
        {
            get { return currentType; }
            set
            {
                currentType = value;
                OnPropertyChanged("CurrentType");
            }
        }

        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value;
                OnPropertyChanged("FilePath");
            }
        }

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                OnPropertyChanged("FileName");
            }
        }

        public List<string> FavouriteTypes
        {
            get { return favouriteTypes; }
            set
            {
                favouriteTypes = value;
                OnPropertyChanged("FavoutiteTypes");
            }
        }

        // Commands
        private RelayCommand openFilePathDialog;
        public RelayCommand OpenFilePathDialog
        {
            get
            {
                return openFilePathDialog ?? (openFilePathDialog = new RelayCommand(obj =>
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Json files|*.json";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        FilePath = saveFileDialog.FileName;
                        FileName = FilePath.Substring(FilePath.LastIndexOf('\\') + 1);
                    }
                }));
            }
        }

        private RelayCommand saveApplications;
        public RelayCommand SaveApplications
        {
            get
            {
                return saveApplications ?? (saveApplications = new RelayCommand(obj =>
                {
                    if (CurrentType == "Not favourite")
                    {
                        OpenSaveManagerService openSaveManagerService = new OpenSaveManagerService();
                        openSaveManagerService.SaveData(UserappsManager.Source.GetAppsList(), FilePath);
                    }
                    else if (CurrentType == "Favourite")
                    {
                        OpenSaveManagerService openSaveManagerService = new OpenSaveManagerService();
                        openSaveManagerService.SaveData(UserappsManager.Source.GetFavouriteAppsList(), FilePath);
                    }
                }));
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
