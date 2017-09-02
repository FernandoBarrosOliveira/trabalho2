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

namespace Trabalho2
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class CadstroUsuario : Page
    {
       
        MainPage rootPage = MainPage.Current;

        public CadstroUsuario()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           // usuarioJson = (e.Parameter as string);
            
        }

        private Boolean ValidarDados()
        {
            if (!String.IsNullOrEmpty(edLogin.Text) &&
                !String.IsNullOrEmpty(edSenha.Password) &&
                !String.IsNullOrEmpty(edConfirmacaoSenha.Password)
                )
            {
                if (edSenha.Password.Equals(edConfirmacaoSenha.Password))
                {
                    return true;
                }
                return false;

            }
            else
            {
                return false;
            }

        }

        private async void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDados())
            {
                SalvarUsuario();
                this.Frame.GoBack();
            }else
            {
                var msgDialog = new MessageDialog("Dados incorretos");
                await msgDialog.ShowAsync();
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SalvarUsuario()
        {
            Usuario usuario = new Usuario(edLogin.Text, edSenha.Password);
            rootPage.usuarioJson = usuario.UsuarioToString();
        }
    }
}
