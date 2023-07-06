using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TelegramWpf.Models;

namespace TelegramWpf.Data
{
    public class ListProfile
    {
        public static ObservableCollection<Profile> Profiles
        {
            get
            {
                return new ObservableCollection<Profile>()
                {
                    new Profile
                    {
                        ContactName = "Mohammad",
                        LastMessage = "Hello!",
                        DateTime = "2023-07-05 10:30:00",
                        ImageProfile = "Resources/Images/Img2.jpg",
                        MessageCount = 5
                    },
                    new Profile
                    {
                        ContactName = "Hani",
                        LastMessage = "How are you?",
                        DateTime = "2023-07-04 15:45:00",
                        ImageProfile = "Resources/Images/Img1.jpg",
                        MessageCount = 10
                    },
                    new Profile
                     {
                        ContactName = "Michael",
                        LastMessage = "Can we meet tomorrow?",
                        DateTime = "2023-07-03 18:20:00",
                        ImageProfile = "Resources/Images/Img3.jpg",
                        MessageCount = 8
                    },
                    new Profile
                    {
                        ContactName = "Brok",
                        LastMessage = "Where are you?",
                        DateTime = "2023-07-02 20:10:00",
                        ImageProfile = "Resources/Images/Img4.jpg",
                        MessageCount = 2
                    }
                };
            }
        }
    }
}
