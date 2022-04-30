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
        private bool isDirty = false; // отвечает на вопрос, есть ли не сохранненые изменения?

        private Profiles Profile; // профиль
        public MainWindow()
        {
            InitializeComponent();

            var inputWindow = new InputWindow();
            inputWindow.ShowDialog();
            Profile = inputWindow.Profile;
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
            isDirty = false;
        }
        private void CloseExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (isDirty)
            {
                var resoult = MessageBox.Show("Сохранить изменения перед закрытием?", "Подверждение действия", MessageBoxButton.YesNoCancel);
                Debug.WriteLine(resoult);
                switch (resoult)
                {
                    case MessageBoxResult.Yes:
                        SaveExecute(sender, e);
                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        return;
                }
            }
            Close();
        }

        private void CutExecute(object sender, ExecutedRoutedEventArgs e) { }
        private void CopyExecute(object sender, ExecutedRoutedEventArgs e) { }
        private void PasteExecute(object sender, ExecutedRoutedEventArgs e) { }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            isDirty = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void IsTrial(object sender, CanExecuteRoutedEventArgs e)
        {
            if ((Profile & Profiles.Trial) == Profiles.Trial)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void IsPro(object sender, CanExecuteRoutedEventArgs e)
        {
            if ((Profile & Profiles.Pro) == Profiles.Pro)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }
    }
}
