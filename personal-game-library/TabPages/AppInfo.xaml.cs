using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using personal_game_library.Models;
using personal_game_library.ViewModels;

namespace personal_game_library.TabPages
{
    /// <summary>
    /// Логика взаимодействия для AppInfo.xaml
    /// </summary>
    public partial class AppInfo : UserControl
    {
        public AppInfo()
        {
            InitializeComponent();
            this.DataContext = new AppInfoViewModel();
        }
    }
}
