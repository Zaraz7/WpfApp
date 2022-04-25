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
           
            calc.StartInfo.FileName = "win32calc.exe";
            calc.StartInfo.Arguments = "calc.txt";
        }

        private void clkShowLog(object sender, RoutedEventArgs e)
        {
        }

        private void clkCal(object sender, RoutedEventArgs e)
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("win32calc");
                proc[0].Kill();
            }
            catch
            {
            }
            Debug.WriteLine("Запуск кала");
            //Process.Start(@"C:\Windows\system32\win32calc.exe");
            calc.Start();
            Debug.WriteLine("Кал должен быть запущен");
        }
    }
}
/* 
﻿using System;
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
namespace _18
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
            Logger.WriteLog("Запуск главного окна");
            calc.StartInfo.FileName = "win32calc.exe";
            calc.StartInfo.Arguments = "calc.txt";
        }

        private void clkShowLog(object sender, RoutedEventArgs e)
        {
            tbLog.Text = Logger.ReadLog();
        }

        private void clkCal(object sender, RoutedEventArgs e)
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("win32calc");
                proc[0].Kill();
            }
            catch
            {
            }
            Debug.WriteLine("Запуск кала");
            //Process.Start(@"C:\Windows\system32\win32calc.exe");
            calc.Start();
            Debug.WriteLine("Кал должен быть запущен");
        }
    }
}
 */
