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
using System.Windows.Threading;

namespace StopWatchNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StopwatchController swc = new StopwatchController();
            //swc.Timer += StopwatchController;
        }

        /*
        private void StopwatchController(object sender, EventArgs e)
        {
            if (e is StopwatchEvent)
            {
                
                if (((StopwatchEvent)e).stopwatch.oneMinut)
                {
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                    {
                        TimeLeft.Content = ((StopwatchEvent)e).stopwatch.oneMinut;
                        
                    }));
                }
                if (((StopwatchEvent)e).stopwatch.twoMinut)
                {
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                    {
                        TimeLeft.Content = ((StopwatchEvent)e).stopwatch.twoMinut;

                    }));
                }
                if (((StopwatchEvent)e).stopwatch.threeMinut)
                {
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                    {
                        TimeLeft.Content = ((StopwatchEvent)e).stopwatch.threeMinut;

                    }));
                }
            }
        }
        */


        private void TimeLeftCounter(object sender, EventArgs e) 
        { 
        
            while (TimeLeft.Content != "00:00")
            {
                
            }
        }

        private void OneMinut_Click(object sender, RoutedEventArgs e)
        {
            //TimeLeft.Content = DateTime.Now.ToString("mm:ss");
            TimeLeft.Content = "01:00";
        }

        private void FiveMinuts_Click(object sender, RoutedEventArgs e)
        {
            //TimeLeft.Content = DateTime.Now.ToString("mm:ss");
            TimeLeft.Content = "05:00";
        }

        private void TenMinuts_Click(object sender, RoutedEventArgs e)
        {
            //TimeLeft.Content = DateTime.Now.ToString("mm:ss");
            TimeLeft.Content = "10:00";
        }

        private void StartTime_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
