using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace StopWatchNew
{
    class StopwatchEvent : EventArgs
    {
        public SetTime stopwatch { get; set; }

        public StopwatchEvent( SetTime stopwatch)
        {
            this.stopwatch = stopwatch;
        }
    }
}
