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
using WpfApp;

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
            App.logger.Info("Initialize MainWindow");
            calc.StartInfo.FileName = "calc";

        }

        private void clkShowLog(object sender, RoutedEventArgs e)
        {
            App.logger.Info("Button pressed");
            tbLog.Text = "";
            StreamReader sr = new StreamReader(".\\logs\\2022-04-25.log", Encoding.UTF8);
            string line = sr.ReadLine();
            while (line != null)
            {
                tbLog.Text += line + "\n";
                line = sr.ReadLine();
            }
            
        }

        private void clkCal(object sender, RoutedEventArgs e)
        {
            try
            {
                if (calc.Id > 1) {
                    App.logger.Info($"ID Calc.exe: {calc.Id}");
                    return;
                }
            }
            catch (Exception error)
            {
                App.logger.Error(error);
            }
            App.logger.Info("Execute Call");
            calc.Start();
            App.logger.Info($"ID Calc.exe: {calc.Id}");
        }
    }
}
