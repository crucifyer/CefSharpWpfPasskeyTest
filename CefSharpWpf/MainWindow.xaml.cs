using CefSharp;
using CefSharp.Wpf;
using System;
using System.Windows;

namespace CefSharpWpf
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CefSettings settings = new CefSettings
            {
                LogSeverity = LogSeverity.Error,
                LogFile = Environment.CurrentDirectory + "\\dicotrans.cef.log",
                RootCachePath = Environment.CurrentDirectory + "\\cache",
                CachePath = Environment.CurrentDirectory + "\\cache\\default",
                PersistSessionCookies = true
            };
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            WB.Load(UrlBox.Text);
        }

        private void WB_Initialized(object sender, EventArgs e)
        {
            WB.Load(UrlBox.Text);
        }
    }
}
