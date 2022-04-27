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
        private Random r = new Random(); // Содание модуля рандома
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void clkBig(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Big Button");
            // sender = это по сути и есть та кнопка с которой и произодиться нажатие
            Button currentButton = sender as Button;
            Debug.WriteLine((byte)r.Next(0, 255));
            // Изменение цвета по рандому, с помощью SolidColorBrush
            // Как оказалось, оно принимает только байтовые значение, по этому каждое значение и приходилось конвертировать 
            currentButton.Background = new SolidColorBrush(Color.FromArgb(90, (byte)r.Next(0, 255), (byte)r.Next(0, 255), (byte)r.Next(0, 255)));
        }

    }
}
