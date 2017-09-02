using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Trabalho2.ViewConteudo;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Trabalho2
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void BtnTabuada_Click(object sender, RoutedEventArgs e)
        {
            BtnTabuada.BorderBrush = new SolidColorBrush(Colors.Blue);
            BtnTabuada.BorderThickness = new Thickness(5, 0, 0, 0);

            BtnMedia.BorderBrush = new SolidColorBrush(Colors.Transparent);           
            BtnListagem.BorderBrush = new SolidColorBrush(Colors.Transparent);
            FrameConteudo.Navigate(typeof(TabuadaPage));
        }

        private void BtnMedia_click(object sender, RoutedEventArgs e)
        {
            BtnMedia.BorderBrush = new SolidColorBrush(Colors.Blue);
            BtnMedia.BorderThickness = new Thickness(5, 0, 0, 0);

            BtnTabuada.BorderBrush = new SolidColorBrush(Colors.Transparent);
            BtnListagem.BorderBrush = new SolidColorBrush(Colors.Transparent);

            FrameConteudo.Navigate(typeof(CalculaMEdiaPage));
        }

        private void BtnListagem_Click(object sender, RoutedEventArgs e)
        {
            BtnListagem.BorderBrush = new SolidColorBrush(Colors.Blue);
            BtnListagem.BorderThickness = new Thickness(5, 0, 0, 0);

            BtnMedia.BorderBrush = new SolidColorBrush(Colors.Transparent);
            BtnTabuada.BorderBrush = new SolidColorBrush(Colors.Transparent);

            FrameConteudo.Navigate(typeof(ListaDica));
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen;
        }
    }
}
