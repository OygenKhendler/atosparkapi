using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace AtosPark
{
	public partial class LoginPage : ContentPage
	{
        public User Model { get; private set; }
        public ApplicationViewModel ViewModel { get; private set; }
		public LoginPage(User model, ApplicationViewModel viewModel)
		{
            InitializeComponent();
            Model = model;
            ViewModel = viewModel;
            this.BindingContext = this;
		}
        public void ButtonClicked(object sender, EventArgs args)
        {
            
        }
	}
}
