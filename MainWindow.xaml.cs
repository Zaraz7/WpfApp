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
using System.Diagnostics;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void clkMenu(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            Debug.WriteLine(menu.Header.ToString());
            tbEditor.FontFamily = new FontFamily(menu.Header.ToString());
        }

        private void imageDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("imageDowm");
            Image img = (Image)sender;
            // h
            Debug.WriteLine($"img.Source = {img.Source}");
            DragDrop.DoDragDrop(img, img.Source, DragDropEffects.Copy);
        }

        private void imgDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("imgDrop");
            Debug.WriteLine(e.OriginalSource);
            Debug.WriteLine($"e.Data = {e.Data}");
            var img2 = e.OriginalSource as Image;
            var img = e.Source as Image;
            Debug.WriteLine($"img = {img}");
            Debug.WriteLine($"img.Source = {img.Source}");
            Debug.WriteLine($"img2.Source = {img2.Source}");
            //Debug.WriteLine();
            ((Image)sender).Source = img.Source as ImageSource;
        }

    }
}
