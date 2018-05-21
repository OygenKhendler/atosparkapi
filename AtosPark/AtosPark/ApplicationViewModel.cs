using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AtosParkCL;



namespace AtosPark
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        //bool initialized = false;
        //User selectUser;
        
        public ObservableCollection<User> Users { get; set; }
        UserService userService = new UserService();
        public event PropertyChangedEventHandler PropertyChanged;
        public string EntryValue 
        {
            set
            {
                EntryValue = value;
            }
            get
            {
                return EntryValue;
            }
        }


        public ICommand CreateUserCommand { protected set; get; }

        public INavigation Navigation { set; get; }

        public ApplicationViewModel()
        {
            Users = new ObservableCollection<User>();
            CreateUserCommand = new Command(CreateUser);
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private async void CreateUser()
        {

            await userService.AddUser(new User { CarNumber = EntryValue });
        }

        
    }
}
