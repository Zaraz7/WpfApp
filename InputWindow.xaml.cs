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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public Profiles Profile; 
        public InputWindow()
        {
            Profile = Profiles.None;
            InitializeComponent();

        }

        private void Activate(object sender, RoutedEventArgs e)
        {
            switch (tbKey.Text)
            {
                case "11112222": // Тестовая проверка ключей
                    Profile = Profiles.Trial;
                    this.DialogResult = true;
                    break;
                case "33334444":
                    Profile = Profiles.Trial | Profiles.Pro;
                    this.DialogResult = true;
                    break;
                default:
                    this.DialogResult = false;
                    break;
            }

        }
    }
}
