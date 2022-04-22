using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MenuLanguage language = new MenuLanguage();
        public MainWindow()
        {
            language.Ru();
            InitializeComponent();
            LocalUpdate();
            
        }
        private void clkRu(object sender, RoutedEventArgs e)
        {
            language.Ru();
            LocalUpdate();
        }
        private void clkEn(object sender, RoutedEventArgs e)
        {
            language.En();
            LocalUpdate();
        }
        private void LocalUpdate()
        {
            File.Header = language.File;
            Lang.Text = language.Lang;
            Info.Header = language.Info;
        }
    }
}
