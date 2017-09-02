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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Trabalho2
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage Current;

        public List<string> listaUsariosJson = new List<string>();
        public string usuarioJson;
        public MainPage()
        {
            Current = this;
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }


        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            this.usuarioJson = "";
        }

        private void btCadastro_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CadstroUsuario));
        }

        private async void btEntra_Click(object sender, RoutedEventArgs e)
        {
            if (validaUsuario(usuarioJson))
            {
                this.Frame.Navigate(typeof(HomePage));
            }else
            {
                var msgDialog = new MessageDialog("Login ou senha incorretas");
                await msgDialog.ShowAsync();
            }            
        }

        private Boolean validaUsuario(string usuarioJson)
        {
            if (!String.IsNullOrEmpty(edLogin.Text) &&
                !String.IsNullOrEmpty(edSenha.Password) &&
                !String.IsNullOrEmpty(usuarioJson))
            {
                Usuario usuario = new Usuario(usuarioJson);
                if (usuario.Login.Equals(edLogin.Text) &&
                    usuario.Senha.Equals(edSenha.Password))
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

            return false;

        }
    }
}
