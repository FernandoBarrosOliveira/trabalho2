﻿#pragma checksum "C:\Users\Fernando-DellWin10\source\repos\Trabalho2\Trabalho2\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFBF51B41CAB18A0FCAC581EC2CDA9E5"
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
    partial class HomePage : 
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
                    this.MySplitview = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.BtnListagem = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnListagem).Click += this.BtnListagem_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.BtnMedia = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnMedia).Click += this.BtnMedia_click;
                    #line default
                }
                break;
            case 4:
                {
                    this.BtnTabuada = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnTabuada).Click += this.BtnTabuada_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnOpenMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOpenMenu).Click += this.btnOpenMenu_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.FrameConteudo = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

