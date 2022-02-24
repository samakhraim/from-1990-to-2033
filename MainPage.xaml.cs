using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

        }
        public void ButtonClicked(object c, EventArgs e)
        {
            string[] arr = new string[2033];

            for (int i = 1990; i < 2034; i++)
            {
                Console.WriteLine(lable.Text += i.ToString() + "  ");
            };
          
        }

    }
}
