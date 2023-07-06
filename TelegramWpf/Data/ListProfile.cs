using System.Collections.ObjectModel;
using TelegramWpf.Models;

namespace TelegramWpf.Data
{
    public  class ListProfile
    {
        public static ObservableCollection<Profile> Profiles
        {
            get
            {
                return new ObservableCollection<Profile>()
                {
                    new Profile
                    {
                        ContactName = "John",
                        LastMessage = "Hello!",
                        DateTime = "2023-07-05 10:30:00",
                        ImageProfile = "profile1.jpg",
                        MessageCount= 5
                    },
                    new Profile
                    {
                        ContactName = "Emma",
                        LastMessage = "How are you?",
                        DateTime = "2023-07-04 15:45:00",
                        ImageProfile = "profile2.jpg",
                        MessageCount = 10
                    },
                    new Profile
                     {
                        ContactName = "Michael",
                        LastMessage = "Can we meet tomorrow?",
                        DateTime = "2023-07-03 18:20:00",
                        ImageProfile = "profile3.jpg",
                        MessageCount = 8
                    },
                    new Profile
                    {
                        ContactName = "Sophia",
                        LastMessage = "Where are you?",
                        DateTime = "2023-07-02 20:10:00",
                        ImageProfile = "profile4.jpg",
                        MessageCount = 2
                    }
                };
            }
        }
    }
}
