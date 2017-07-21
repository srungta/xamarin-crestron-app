using CrestronApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrestronApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CrestronRoomDetailPage : ContentPage
	{
        CrestronRoomDetailViewModel viewModel;
		public CrestronRoomDetailPage ()
		{
			InitializeComponent ();
		}
        public CrestronRoomDetailPage(CrestronRoomDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
	}
}