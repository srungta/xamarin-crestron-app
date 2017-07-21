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
    public partial class CrestronRoomActivityPage : ContentPage
    {
        private bool isConnected = false;
        private CrestronRoomActivityViewModel viewModel;

        public CrestronRoomActivityPage(CrestronRoomActivityViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        private void ConnectToRoom_Clicked(object sender, EventArgs args)
        {
            if (!isConnected) viewModel.DeviceConnect();
        }

        private void DisconnectFromRoom_Clicked(object sender, EventArgs args)
        {
            if (isConnected) viewModel.DeviceDisconnect();
        }
    }
}