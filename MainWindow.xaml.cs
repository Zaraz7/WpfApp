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
using System.IO;
using System.Diagnostics;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Process calc = new Process();
        public MainWindow()
        {
            InitializeComponent();
           
            calc.StartInfo.FileName = "calc";
        }

        private void clkShowLog(object sender, RoutedEventArgs e)
        {
        }

        private void clkCal(object sender, RoutedEventArgs e)
        {
            try
            {
                if (calc.Id > 1)
                    return;
            }
            catch
            {

            }
            calc.Start();
            Debug.WriteLine(calc.Id);
            Debug.WriteLine("Кал должен быть запущен");
        }
    }
}
