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
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;


namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog _openDialog = new OpenFileDialog();
        private SaveFileDialog _saveDialog = new SaveFileDialog();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void NewExecute(object sender, ExecutedRoutedEventArgs e)
        {
            _saveDialog.FileName = "new_file.txt";
            if (_saveDialog.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(_saveDialog.FileName);
                writer.WriteLine(tbEditor.Text);
                writer.Close();
            }
        }

        private void OpenExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (_openDialog.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(_openDialog.FileName);
                tbEditor.Text = reader.ReadToEnd();
                reader.Close();
                _saveDialog.FileName = _openDialog.FileName;
            }
        }
        private void SaveExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (_saveDialog.FileName == "") {
                NewExecute(sender, e);
            }
        }
        private void CloseExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var resoult = MessageBox.Show("Сохранить изменения перед закрытием?", "Подверждение действия", MessageBoxButton.YesNoCancel);
            Debug.WriteLine(resoult);
            switch (resoult)
            {
                case MessageBoxResult.Yes:
                    SaveExecute(sender, e);
                    Close();
                    break;
                case MessageBoxResult.No:
                    Close();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
             
        }

        private void CutExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Cut");
        }
        private void CopyExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy");
        }
        private void PasteExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Paste");
        }
    }
}
