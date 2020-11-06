using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RelativeLayoutTest
{
    public partial class MainPage : ContentPage
    {
        double _credit = 11.95;
        public MainPage()
        {
            InitializeComponent();
            totalCredit.Text = $"${_credit}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _credit += 8.00;
            totalCredit.Text = $"${_credit}";
        }
    }
}
