using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace personal_game_library.Models
{
    class Userapp : INotifyPropertyChanged
    {
        private string title;
        private string description;
        private string author;
        private string last_using_time;
        private string location;
        private string icon_location;
        private bool is_favourite;
        private int total_using_time_minutes;
        [Key]
        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        public string LastUsingTime
        {
            get { return last_using_time; }
            set
            {
                last_using_time = value;
                OnPropertyChanged("LastUsingTime");
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }

        public string IconLocation
        {
            get { return icon_location; }
            set
            {
                icon_location = value;
                OnPropertyChanged("IconLocation");
            }
        }

        public bool IsFavourite
        {
            get { return is_favourite; }
            set
            {
                is_favourite = value;
                OnPropertyChanged("IsFavourite");
            }
        }

        public int TotalUsingTimeMinutes
        {
            get { return total_using_time_minutes; }
            set
            {
                total_using_time_minutes = value;
                OnPropertyChanged("TotalUsingTimeMinutes");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
