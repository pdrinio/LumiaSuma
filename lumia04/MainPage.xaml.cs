using Windows.Media.SpeechSynthesis;
using Windows.Media.SpeechRecognition;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lumia04
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public SpeechSynthesizer sinte = new SpeechSynthesizer(); //para el dime()
        datos _datos;   //objeto local de datos
        int nEspera = 1500; //tiempo en milisegundos de espera entre un reto y el otro


        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            reta();


        }

        private void actualizaReto(datos _datos)
        {
            this.txbOperando1.Text = _datos.nOperando1.ToString();
            this.txbOperando2.Text = _datos.nOperando2.ToString();
                        
            this.txbResultado.Text = "?";

            this.btnIzquierda.Content = _datos.nResultadosPosibles[0].ToString();
            this.btnCentro.Content = _datos.nResultadosPosibles[1].ToString();
            this.btnDerecha.Content = _datos.nResultadosPosibles[2].ToString();
                
        }


        private void reta()
        {
            _datos = new datos(); //creo el ojebto
            _datos.calculaValores(); // genero el juego de datos
            actualizaReto(_datos); // muestro en pantalla  

            dime("¿Cuál es el resultado?");
        }


        private async void dime(string message)
        {
            var stream = await sinte.SynthesizeTextToStreamAsync(message);
            media.SetSource(stream, stream.ContentType);
            media.Play();   

        }

        private void btnIzquierda_Click(object sender, RoutedEventArgs e)
        {
            //preguntarle al usuario...
            String szRespuesta = ((Button)sender).Content.ToString();
            dime("¿" + szRespuesta + "?");
            

            // y comprobarlo
            comprueba(Int32.Parse(((Button)sender).Content.ToString()));
        }



        private void btnCentro_Click(object sender, RoutedEventArgs e)
        {
            //preguntarle al usuario...
            String szRespuesta = ((Button)sender).Content.ToString();
            dime("¿" + szRespuesta + "?");

            // y comprobarlo
            comprueba(Int32.Parse(((Button)sender).Content.ToString()));

        }

        private void btnDerecha_Click(object sender, RoutedEventArgs e)
        {
            //preguntarle al usuario...
            String szRespuesta = ((Button)sender).Content.ToString();
            dime("¿" + szRespuesta + "?");

            // y comprobarlo
            comprueba(Int32.Parse(((Button)sender).Content.ToString()));
        }

        private async void comprueba(int nRespuesta)
        {
            if (nRespuesta == _datos.nResultadoCorrecto) {
                dime("Bien!!!!.");
                await espera(); //espera un poco, para dar impacto
                reta();         //y vuelve a empezar
            }
            else dime("Me temo que no.");
        }

        async Task espera()
        {
            await Task.Delay(nEspera);
        }

    }
}
