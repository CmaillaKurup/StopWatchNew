﻿using System;
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

        private void StopwatchController(EventArgs e)
        {
            
        }

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
       
        private void StartTime_Click(object sender, RoutedEventArgs e, EventArgs ee)
        {

            if (((StopwatchEvent)ee).stopwatch.oneMinut)
            {
                DateTime endTime = DateTime.Now.AddMinutes(1);


                while (endTime.ToString() != "00:00")
                {
                    int secondsRemaining = (int)(endTime - DateTime.Now).TotalSeconds;
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                    {
                        TimeLeft.Content = secondsRemaining.ToString();
                    }));

                }
            }
            // StopwatchController(((StopwatchEvent)e).stopwatch.oneMinut);
        }
        
    }
}
