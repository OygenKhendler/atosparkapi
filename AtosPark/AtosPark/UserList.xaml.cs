using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtosPark
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserList : ContentPage
	{
        ApplicationViewModel viewModel;
		public UserList ()
		{
			InitializeComponent ();
            viewModel = new ApplicationViewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;
        }
	}
}