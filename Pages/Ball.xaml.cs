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
    /// Логика взаимодействия для Ball.xaml
    /// </summary>
    public partial class Ball : Window
    {
        private List<string> Predictions = new List<string>();
        public Ball()
        {
            Predictions.Add("Нет");
            Predictions.Add("Да");
            Predictions.Add("Наверное");
            Predictions.Add("50%");
            Predictions.Add("Че?");
            Predictions.Add("ААХХААХХАХАХА");
            Predictions.Add("Лучше не спрашивай");
            Predictions.Add("...");
            
            InitializeComponent();

            Left = Properties.Settings.Default.BallPosition.Left;
            Top = Properties.Settings.Default.BallPosition.Top;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.BallPosition = RestoreBounds;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void mouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Prediction(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            textBox.Text = "";
            textButton.Text = Predictions[r.Next(8)];
            
        }
    }
}
