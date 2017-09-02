using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Trabalho2.Classes;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class CalculaMEdiaPage : Page
    {
        private const string MEDIA_SIMPLES = "Média aritmética simples";
        private const string MEDIA_PONDERADA = "Média aritmética ponderada";       
        private const string MEDIA_HARMONICA = "Média harmônica";

        ObservableCollection<String> tiposMedia = new ObservableCollection<String>();
        ObservableCollection<String> listaAdicao = new ObservableCollection<String>();
        List<Media> listaMedia = new List<Media>();
        
        public ObservableCollection<string> TiposMedia { get => tiposMedia; set => tiposMedia = value; }
        public ObservableCollection<string> ListaAdicao { get => listaAdicao; set => listaAdicao = value; }

        public CalculaMEdiaPage()
        {
            this.InitializeComponent();

            tiposMedia.Add(MEDIA_SIMPLES);
            tiposMedia.Add(MEDIA_PONDERADA);           
            tiposMedia.Add(MEDIA_HARMONICA);
            cbTipoMedia.SelectedItem = 0;
        }

        private Boolean ValidarDados()
        {

            if (cbTipoMedia.Items[cbTipoMedia.SelectedIndex].Equals(MEDIA_PONDERADA) &&
                !String.IsNullOrEmpty(edNumero.Text) &&
                !String.IsNullOrEmpty(edPeso.Text))
            {
                return true;
            }
            else if (!String.IsNullOrEmpty(edNumero.Text))
            {
                return true;
            }else
            {
                return false;
            }

        }


        private void btnAdiciona_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDados())
            {
                if (cbTipoMedia.Items[cbTipoMedia.SelectedIndex].Equals(MEDIA_PONDERADA)){
                    listaMedia.Add(new Media(
                        Convert.ToDouble(edNumero.Text),
                        Convert.ToDouble(edPeso.Text)));
                    listaAdicao.Add("Nota: " + edNumero.Text + " Peso: " + edPeso.Text);
                }
                else
                {
                    listaMedia.Add(new Media(
                        Convert.ToDouble(edNumero.Text)));
                    listaAdicao.Add("Nota: " + edNumero.Text);
                }

            }

            edPeso.Text = "";
            edNumero.Text = "";

        }

        private void btMEdia_Click(object sender, RoutedEventArgs e)
        {
            listaAdicao.Clear();
            string combotexto = cbTipoMedia.SelectedItem.ToString();
            listaAdicao.Add("A " + cbTipoMedia.SelectedItem.ToString() + " é " + CalculaMedia(listaMedia, cbTipoMedia.SelectedItem.ToString()));
        }


        private double CalculaMedia(List<Media> listaMedia, string TipoMedia)
        {
                       
            if (tiposMedia.Equals(MEDIA_PONDERADA))
            {
                return CalculaMediaPonderada(listaMedia);
            }
                
            else if (tiposMedia.Equals(MEDIA_HARMONICA))
            {
                return CalculaMediaHarmonica(listaMedia);
            }
            else
            {
                return CalculaMediaSimples(listaMedia);

            }            
            
        }
        private double CalculaMediaSimples(List<Media> listaMedia)
        {
            double soma = 0;
            for (int i = 0; i < listaMedia.Count; i++)
            {
                soma = soma + listaMedia[i].Nota;
            }
            return soma / listaMedia.Count;
         }

        private double CalculaMediaPonderada(List<Media> listaMedia)
        {
            double soma = 0;
            double somaPesso = 0;
            for (int i = 0; i < listaMedia.Count; i++)
            {
                soma = listaMedia[i].Nota* listaMedia[i].Peso;
                somaPesso = listaMedia[i].Peso;

            }
            return soma / somaPesso;
        }

        private double CalculaMediaHarmonica(List<Media> listaMedia)
        {
            double somaInverso = 0;
            for (int i = 0; i < listaMedia.Count; i++)
            {
                somaInverso = somaInverso + 1 / listaMedia[i].Nota;
            }
            return listaMedia.Count/ somaInverso;
        }

        private void cbTipoMedia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTipoMedia.SelectedItem.Equals(MEDIA_PONDERADA))
            {
                lbPeso.Visibility = Visibility.Visible;
                edPeso.Visibility = Visibility.Visible;
            }
            else
            {
                lbPeso.Visibility = Visibility.Collapsed;
                edPeso.Visibility = Visibility.Collapsed;
            }




        }
    }
}
