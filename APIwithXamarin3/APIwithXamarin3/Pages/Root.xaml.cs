using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIwithXamarin3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Root : ContentPage
    {
        public Root()
        {
            InitializeComponent();
        }
        public bool error { get; set; }
        public int statusCode { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
}