using CrestronApp.Models;
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
    public partial class NewCrestronRoomPage : ContentPage
    {
        public CrestronRoom Room { get; set; }
        public NewCrestronRoomPage()
        {
            InitializeComponent();
            Room = new CrestronRoom
            {
                Name = "Room name",
                IpAddress = "This is a nice room"
            };

            BindingContext = this;
        }

        private async Task Save_ClickedAsync(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddCrestronRoom", Room);
            await Navigation.PopToRootAsync();
        }
    }
}