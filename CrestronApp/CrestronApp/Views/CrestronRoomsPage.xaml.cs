using CrestronApp.Models;
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
    public partial class CrestronRoomsPage : ContentPage
    {
        CrestronRoomsViewModel viewModel;
        public CrestronRoomsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CrestronRoomsViewModel();
        }

        async void OnRoomSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as CrestronRoom;
            if (item == null)
                return;

            await Navigation.PushAsync(new CrestronRoomDetailPage(new CrestronRoomDetailViewModel(item)));

            // Manually deselect item
            RoomsListView.SelectedItem = null;
        }

        async void AddRoom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCrestronRoomPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                RoomsListView.ItemsSource = viewModel.Items;
            else
                RoomsListView.ItemsSource = viewModel.Items.Where(i => i.Name.IndexOf(e.NewTextValue, StringComparison.OrdinalIgnoreCase) != -1);
        }
    }
}