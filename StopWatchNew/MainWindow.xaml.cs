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

        //Thees minuts clickers is all working the same way. 
        //they has a varaible set as new DaateTime and when an event happens they determ the TimeLeft
        private void OneMinut_Click(object sender, RoutedEventArgs e)
        {
            var startTime = new DateTime();

            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
            {
                TimeLeft.Content = startTime.ToString("01:00");
            }));        
        }

        private void FiveMinuts_Click(object sender, RoutedEventArgs e)
        {
            var startTime = new DateTime();

            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
            {
                TimeLeft.Content = startTime.ToString("05:00");
            }));
        }

        private void TenMinuts_Click(object sender, RoutedEventArgs e)
        {
            var startTime = new DateTime();
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
            {
                TimeLeft.Content = startTime.ToString("10:00");
            }));
        }
       
        //purpose of this metheod is that when you click on Start Time after chosen a time spec
        //it will start the count down
        //This does not work at all
        private void StartTime_Click(object sender, RoutedEventArgs e)
        {
            //The endTime should not be =DateTime.Now.AddMinutes(1)
            //but I cant figure out at the moment what it acctually should be
            DateTime endTime = DateTime.Now.AddMinutes(1);

            //This loop is supose to check if endTime hass reace 00:00
            //as long as it hasn't it is supose to show the TimeLeft counting down
            //I have not a clue if this would work if I got my endTime correct
            //But I belive that something is missing - I just can't see what yet
            while (endTime.ToString() != "00:00")
            {
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                {
                    int secondsRemaining = (int)(endTime - DateTime.Now).TotalSeconds;
                    TimeLeft.Content = secondsRemaining.ToString();
                }));

            }
            
            // StopwatchController(((StopwatchEvent)e).stopwatch.oneMinut);
        }
        
    }
}
