using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kur
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pageAdd : ContentPage
    {
        private order currentProduct {get; set;}
        public pageAdd()
        {
            InitializeComponent();
        }

        private void Button_Add(object sender, EventArgs e)
        {
            App.orders.Add(new order { Name = nameProduct.Text, sumOrder = Convert.ToInt32(sum.Text), sumPrepayment = Convert.ToInt32(sumPrep.Text), costInstal = Convert.ToInt32(sumInst.Text), Expemses = Convert.ToInt32(Expems.Text) });
            Navigation.PopAsync();
        }

        private void Button_Change(object sender, EventArgs e)
        {

        }

        private void Button_Del(object sender, EventArgs e)
        {

        }
    }
}