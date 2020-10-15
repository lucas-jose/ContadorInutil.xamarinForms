using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAppTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"Você clicou {count} vezes.";
            if (count > 20)
            {
                ((Button)sender).Text = $"Você clicou + de 20x.";
                count = 0;
                ((Button)sender).Text = $"Iniciar contagem novamente";
                return;
            }


        }
    }
}
