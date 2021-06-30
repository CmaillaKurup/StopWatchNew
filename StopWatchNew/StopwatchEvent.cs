using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace StopWatchNew
{
    class StopwatchEvent : EventArgs
    {
        //my EventArgs that takes SetTime and make a event on this
        public SetTime stopwatch { get; set; }

        public StopwatchEvent( SetTime stopwatch)
        {
            this.stopwatch = stopwatch;
        }
    }
}
