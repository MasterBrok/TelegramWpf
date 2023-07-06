using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TelegramWpf.Models
{
    public class Profile
    {
        public string ContactName { get; set; }
        public string LastMessage { get; set; }
        public string DateTime{ get; set; }
        public string ImageProfile { get; set; }
        public int MessageCount{ get; set; }
        public Profile()
        {
            
        }

        public Profile(string contactName, string lastMessage, string dateTime, string imageProfile, int messageCount)
        {
            ContactName = contactName;
            LastMessage = lastMessage;
            DateTime = dateTime;
            ImageProfile = imageProfile;
            MessageCount = messageCount;
        }
    }
}
