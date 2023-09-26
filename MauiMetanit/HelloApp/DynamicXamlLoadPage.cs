using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class DynamicXamlLoadPage : ContentPage
    {
        private Label Header { get; set; }
        public DynamicXamlLoadPage()
        {
            string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n" +
                "xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\n" +
                "x:Class=\"HelloApp.StartPage\">\n" +
                "<VerticalStackLayout>\n" +
                "<Label x:Name=\"header\" Text=\"This XAML was loaded dynamically.\" FontSize=\"22\" />" +
                "<Button x:Name=\"dont_push_btn\" Text=\"Don't push!\" FontSize=\"22\" Clicked=\"OnDontPushBtnClicked\" />" +
                "</VerticalStackLayout>\n" +
                "</ContentPage>";

            this.LoadFromXaml(pageXAML);
            Header = this.FindByName<Label>("header");
            Header.Text += " And dynamically modified";
        }

        private void OnDontPushBtnClicked(object sender, EventArgs e)
        {
            string xaml = $"<Label Text=\"Button was pushed!\" FontSize=\"22\" />";
            Header.LoadFromXaml(xaml);
        } 

    }
}
