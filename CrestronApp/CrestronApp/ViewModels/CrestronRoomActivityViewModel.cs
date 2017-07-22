using Crestron.ActiveCNX;
using CrestronApp.Helpers;
using CrestronApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrestronApp.ViewModels
{
    public class CrestronRoomActivityViewModel : BaseViewModel
    {
        public ActiveCNX Device;

        public ObservableRangeCollection<ActivityMessage> Messages { get; set; }


        public CrestronRoomActivityViewModel(CrestronRoom room)
        {
            Device = new ActiveCNX(room.IpAddress, room.IpId, room.UserName, room.Password, room.Port, room.UseSsl);
            Device.onAnalog += Device_onAnalog;
            Device.onConnect += Device_onConnect;
            Device.onDigital += Device_onDigital;
            Device.onDisconnect += Device_onDisconnect;
            Device.onError += Device_onError;
            Messages = new ObservableRangeCollection<ActivityMessage>();
            Title = room.Name;
        }

        private void Device_onError(object sender, ActiveCNXErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Device_onDisconnect(object sender, ActiveCNXConnectionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Device_onAnalog(object sender, ActiveCNXEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Device_onDigital(object sender, ActiveCNXEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Device_onConnect(object sender, ActiveCNXConnectionEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void DeviceConnect()
        {
            //Device.Connect();
            Messages.Add(new ActivityMessage
            {
                Message = "Attempting to connect"
            });
        }

        public void DeviceDisconnect()
        {
            //Device.Disconnect();
            Messages.Add(new ActivityMessage
            {
                Message = "Attempting to disconnect"
            });
        }
    }
}
