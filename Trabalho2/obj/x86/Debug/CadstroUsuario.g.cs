﻿#pragma checksum "C:\Users\Fernando-DellWin10\source\repos\Trabalho2\Trabalho2\CadstroUsuario.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C80A3FEC295BD8AC06EF4596DB2A992"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trabalho2
{
    partial class CadstroUsuario : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.edLogin = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.edSenha = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 3:
                {
                    this.edConfirmacaoSenha = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4:
                {
                    this.btSalvar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\CadstroUsuario.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btSalvar).Click += this.btSalvar_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btCancelar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\CadstroUsuario.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btCancelar).Click += this.btCancelar_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

