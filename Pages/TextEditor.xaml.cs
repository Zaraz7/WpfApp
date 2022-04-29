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
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace WpfApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для TextEditor.xaml
    /// </summary>
    public partial class TextEditor : Window
    {
        private OpenFileDialog _openDialog = new OpenFileDialog();
        private SaveFileDialog _saveAsDialog = new SaveFileDialog();
        public TextEditor()
        {
            InitializeComponent();
        }

        private void clkOpen(object sender, RoutedEventArgs e)
        {
            if (_openDialog.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(_openDialog.FileName);
                tbEditor.Text = reader.ReadToEnd();
                reader.Close();
                _saveAsDialog.FileName = _openDialog.FileName;
            }
        }
        private void clkSaveAs(object sender, RoutedEventArgs e)
        {
            if (_saveAsDialog.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(_saveAsDialog.FileName);
                writer.WriteLine(tbEditor.Text);
                writer.Close();
            }
        }
        private void clkSave(object sender, RoutedEventArgs e)
        {
            if (_saveAsDialog.FileName == "") { 
                clkSaveAs(sender, e);
                return;
            }

            StreamWriter writer = new StreamWriter(_saveAsDialog.FileName);
            writer.WriteLine(tbEditor.Text);
            writer.Close();

        }
    }
}
