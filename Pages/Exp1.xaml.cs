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
using System.Windows.Shapes;

namespace WpfApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Exp1.xaml
    /// </summary>
    public partial class Exp1 : Window
    {
        public string textCheck;
        public Exp1()
        {
            InitializeComponent();
        }
        // Вместо того, чтобы закрывать окна, они становяться скрытыми
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
