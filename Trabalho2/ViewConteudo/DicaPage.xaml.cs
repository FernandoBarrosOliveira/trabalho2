using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Trabalho2.Classes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Trabalho2.ViewConteudo
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class DicaPage : Page
    {
       

        Dica dica;
        public DicaPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            dica = (e.Parameter as Dica);
            VicularDados(dica);
        }        

        private void VicularDados(Dica dica)
        {
            edTitulo.Text = dica.Titulo;
            edConteudo.Text = dica.Conteudo;
        }


        private Boolean ValidarDados()
        {
            if (!String.IsNullOrEmpty(edTitulo.Text) &&
                !String.IsNullOrEmpty(edConteudo.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private async void btLer_Click(object sender, RoutedEventArgs e)
        {
            MediaElement media = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(edConteudo.Text);
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }

        private  void btVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
