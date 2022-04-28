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
        private int index = 0;
        private Window[] windowsArray = new Pages.Exp1[5];
        public MainWindow()
        {
            InitializeComponent();
 
            for (int i = 0; i < 5; i++)
            {
                windowsArray[i] = new Pages.Exp1();
                windowsArray[i].Title = $"Окно №{i+1}";
            }
        }

        private void expression1(object sender, RoutedEventArgs e)
        {
            if (index == 5)
                index = 0;
            Debug.WriteLine("");
            foreach (Window w in windowsArray)
            {
                Debug.Write(w.Title);
            }
            
            //windowsArray[index].
            windowsArray[index].Show();
            index += 1;
            

        }

    }
}
