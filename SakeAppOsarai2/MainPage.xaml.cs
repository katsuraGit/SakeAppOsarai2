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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SakeAppOsarai2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var sakeName = textBox.Text;
            if ( this.textBox.Text != "お酒の名前を入力してね" )
                {
                this.listView.Items.Add(sakeName);
                 } 
            else
            {
                await new MessageDialog("ちゃんと入力してください").ShowAsync();
            }
                 
//      
//            this.listView.Items.Add(sakeName);
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.listView.Items.Remove(this.listView.SelectedValue); 
        }
    }
}
