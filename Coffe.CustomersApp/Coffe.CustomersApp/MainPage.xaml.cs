﻿using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Coffe.CustomersApp
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonAddCustomer_click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Customer added!");
            await messageDialog.ShowAsync();
        }
    }
}
