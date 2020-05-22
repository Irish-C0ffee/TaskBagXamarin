using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace TaskBag
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class geolocationXaml : ContentPage
    {
        public geolocationXaml()
        {
            InitializeComponent();
            Map map = new Map();
            Content = map;
        }
        private  async void button_push(object sender, System.EventArgs e)
        {
            
        }
    }
}