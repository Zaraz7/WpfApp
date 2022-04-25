using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NLog;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public App()
        {
            logger.Info("Initialize App.xaml");
        }
    }
}
