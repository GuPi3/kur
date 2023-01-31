using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kur
{
    public partial class App : Application
    {

        public static ObservableCollection<order> orders = new ObservableCollection<order>();
        public App()
        {
            InitializeComponent();
            if (Application.Current.Properties.TryGetValue("db", out object value) == true)
            {
                var list = JsonConvert.DeserializeObject<List<order>>(value.ToString());
                App.orders = new ObservableCollection<order>(list);
            }
            else
            {
                string json = JsonConvert.SerializeObject(orders);
                Application.Current.Properties["db"] = json;
                Application.Current.SavePropertiesAsync();
            }

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            string json = JsonConvert.SerializeObject(orders);
            Application.Current.Properties["db"] = json;
            Application.Current.SavePropertiesAsync();
        }

        protected override void OnResume()
        {
        }

    }
}
