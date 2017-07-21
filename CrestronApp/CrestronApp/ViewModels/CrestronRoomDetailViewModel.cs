using CrestronApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrestronApp.ViewModels
{
    public class CrestronRoomDetailViewModel : BaseViewModel
    {
        public CrestronRoom Room { get; set; }
        public CrestronRoomDetailViewModel(CrestronRoom item = null)
        {
            Title = item.Name;
            Room = item;
        }

        int quantity = 1;
        public int Quantity
        {
            get { return quantity; }
            set { SetProperty(ref quantity, value); }
        }
    }
}
