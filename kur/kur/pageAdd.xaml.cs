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
        private product currentProduct {get; set;}
        public pageAdd()
        {
            InitializeComponent();
        }

        private void Button_Add(object sender, EventArgs e)
        {
            
        }

        private void Button_Change(object sender, EventArgs e)
        {

        }

        private void Button_Del(object sender, EventArgs e)
        {

        }
    }
}