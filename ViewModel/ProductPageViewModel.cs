using Costea_Maria_ClaudiaBakery.Models;
using Plugin.LocalNotification;
using System;
using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Input;

namespace Costea_Maria_ClaudiaBakery.ViewModel
{
    public class ProductPageViewModel
    {
        public ObservableCollection<Items> Items { get; set; }

        public ObservableCollection<Items> CartItems { get; set; }

        public Items SelectedItem { get; set; }

        public ICommand Itemclick { get; set; }
        public ICommand CartItemclick { get; set; }
        public ProductPageViewModel(INavigation navigation)
        {
            Items = new ObservableCollection<Items>
            {
                new Items
                {
                    Picture="biscuiti.png",
                    Name = "Biscuiti",
                    Quantity = "100 grame",
                    Price = "14 lei"
                },
                new Items
                {
                    Picture="briose.png",
                    Name = "Briose vegane",
                    Quantity = "1 bucata",
                    Price = "8 lei"
                },
                new Items
                {
                    Picture="ciocolata.png",
                    Name = "Ciocolata de casa",
                    Quantity = "100 grame",
                    Price = "16 lei"
                },
                new Items
                {
                    Picture="cocos.png",
                    Name = "Prajitura cocos",
                    Quantity = "1 bucata",
                    Price = "12 lei"
                },
                new Items
                {
                    Picture="mac.png",
                    Name = "Paine cu mac",
                    Quantity = "1 kilogram",
                    Price = "30 lei"
                },
                new Items
                {
                    Picture="neagra.png",
                    Name = "Paine neagra",
                    Quantity = "1 kilogram",
                    Price = "25 lei"
                },
                new Items
                {
                    Picture="tarta.png",
                    Name = "Tarta cu mere",
                    Quantity = "1 bucata",
                    Price = "12 lei"
                }
            };
            CartItems = new ObservableCollection<Items> { };
            Itemclick = new Command<Items>(executeitemclickcommand);
            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeitemclickcommand(Items item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new DetailsPage(this));
            var request = new NotificationRequest
            {
                NotificationId = 1337,
                Title = "Register to our website",
                Subtitle = "Hello",
                Description = "ClaudiaBakery",
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(1),
                    NotifyRepeatInterval = TimeSpan.FromDays(1),
                },

            };
            LocalNotificationCenter.Current.Show(request);
        }
    }

        
    }

