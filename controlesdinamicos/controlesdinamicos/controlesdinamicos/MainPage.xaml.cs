using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace controlesdinamicos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            boton.Clicked += Boton_Clicked;// creacion del evento del boton
		}

        private void Boton_Clicked(object sender, EventArgs e)
        {
            panel.Children.Add(new Button() {
                Text = $"boton{panel.Children.Count+1}"//formateada
            });
        }
    }
}
