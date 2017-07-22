using System;
using System.Collections.Generic;
using System.Text;

namespace CrestronApp.Models
{
    public class ActivityMessage
    {
        private string message;
        private DateTime timestamp = DateTime.Now;

        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}
