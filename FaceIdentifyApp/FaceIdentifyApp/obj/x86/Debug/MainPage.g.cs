﻿#pragma checksum "C:\Users\A8859\Desktop\VS Desktop\Visual C#\Microsoft Cognitive API\FaceIdentifyApp\FaceIdentifyApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "387EFDB9785D55641BFFC79B5B80701E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceIdentifyApp
{
    partial class MainPage : 
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
                    this.identityTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.emotionTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.startCaptureButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.startCaptureButton).Click += this.StartCapturePreview_Click;
                    #line default
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.CapturePhoto_Click;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Browse_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.capturePreview = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 7:
                {
                    this.imagePreview = (global::Windows.UI.Xaml.Controls.Image)(target);
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

