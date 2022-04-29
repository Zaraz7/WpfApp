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
    /// Логика взаимодействия для Exp12.xaml
    /// </summary>
    public partial class Exp12 : Window
    {
        public Exp12()
        {
            InitializeComponent();
            Left = Properties.Settings.Default.Exp12.Left;
            Top = Properties.Settings.Default.Exp12.Top;

            Width = Properties.Settings.Default.Exp12.Width;
            Height = Properties.Settings.Default.Exp12.Height;
        }



        // Вместо того, чтобы закрывать окна, они становяться скрытыми
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Сохранение разрешения в пользовательсикх настройках
            Properties.Settings.Default.Exp12 = this.RestoreBounds;
            Properties.Settings.Default.Save();

            // Вместо того, чтобы закрывать окна, они становяться скрытыми
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
