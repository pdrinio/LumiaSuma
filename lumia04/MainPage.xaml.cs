using Windows.Media.SpeechSynthesis;
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
        public SpeechSynthesizer sinte = new SpeechSynthesizer();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            reta();


        }

        private void actualizaReto(operaciones _operacion)
        {
            this.txbOperando1.Text = _operacion.nOperando1.ToString();
            this.txbOperando2.Text = _operacion.nOperando2.ToString();
            this.txbResultado.Text = "?";
        }

        private void reta()
        {
            operaciones _operacion = new operaciones(); //creo el objeto
            _operacion.calculaSuma(); //que genere su juego de datos
            actualizaReto(_operacion); //muestro en pantalla

            dime("Cuál es el resultado?");
        }

        private async void dime(string message)
        {
            var stream = await sinte.SynthesizeTextToStreamAsync(message);
            media.SetSource(stream, stream.ContentType);
            media.Play();   

        }
    }
}
