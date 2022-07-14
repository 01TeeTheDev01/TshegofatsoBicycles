using System;
using System.Reflection;
using System.Timers;
using System.Windows;

namespace TshegofatsoBicyclesGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Timer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new Timer()
            {
                Interval = 1000, Enabled = true
            };

            timer.Start();

            Loaded += MainWindow_Loaded;

            Unloaded += MainWindow_Unloaded;
        }

        private void MainWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            Title = string.Empty;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Start();
            Title = $"{GetAppName()} ver. {GetAppVersion()} - {DateTime.Now:t}";
        }

        private static string? GetAppName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        private static string? GetAppVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
