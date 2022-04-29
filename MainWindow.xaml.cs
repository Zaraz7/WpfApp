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
        // Индекс окна
        private int index = 0;
        // Массив окон
        private Window[] windowsArray = new Window[3];
        public MainWindow()
        {
            InitializeComponent();
 
            
        }

        private void expression1(object sender, RoutedEventArgs e)
        {
            // Наполнение массива окон объектами и их переименовывание
            windowsArray[0] = new Pages.Exp1();
            windowsArray[1] = new Pages.Exp12();
            windowsArray[2] = new Pages.Exp13();

            // Не позволяем открывать больще 5 окон
            foreach (Window w in windowsArray)
                w.Show();
            
            //windowsArray[index].
            windowsArray[index].Show();
            index += 1;
            

        }

    }
}
