using CrestronApp.Helpers;
using CrestronApp.Models;
using CrestronApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrestronApp.ViewModels
{
    public class CrestronRoomsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<CrestronRoom> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public CrestronRoomsViewModel()
        {
            Title = "Browse Crestron Rooms";
            Items = new ObservableRangeCollection<CrestronRoom>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewCrestronRoomPage, CrestronRoom>(this, "AddCrestronRoom", async (obj, item) =>
            {
                var _item = item as CrestronRoom;
                Items.Add(_item);
                await CrestronDataStore.AddItemAsync(_item);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await CrestronDataStore.GetItemsAsync(true);
                Items.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load crestron rooms.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
