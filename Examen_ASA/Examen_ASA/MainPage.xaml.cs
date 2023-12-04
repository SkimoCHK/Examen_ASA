using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_ASA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void Button_ClickedResultado(object sender, EventArgs e)
        {
            int duracion = Convert.ToInt32(DuracionEntry.Text);
            double peso = Convert.ToInt32(Peso.Text);

            double caloriasquemadas = duracion * 10 * peso / 200;

            

            if (caloriasquemadas <= 250)
            {
                Resultado.Text = $"Perdiste {caloriasquemadas} calorias, Pero Debes correr mas papito";
            }
            else if (caloriasquemadas >= 250 && caloriasquemadas <= 499)
            {
                Resultado.Text = $"Perdiste {caloriasquemadas} calorias Vas bien, pero echale mas ganas papi";
            }
            else 
            {
                Resultado.Text = $"Perdiste {caloriasquemadas} calorias Sigue asi ya eres fitnes";
                //MotivacionImagen.Resources = "motivacion.png";
            }



        }
    }
}
