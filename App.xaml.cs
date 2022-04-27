using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void clkMenu(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            string font = menu.Header.ToString();
            Debug.WriteLine(font);
            //var rd = new ResourceDictionary();
            //rd.Add("Editor")
        }
    }
}
