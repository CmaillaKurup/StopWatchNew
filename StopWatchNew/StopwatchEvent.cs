using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchNew
{
    class StopwatchEvent : EventArgs
    {
        public Stopwatch stopwatch { get; set; }

        public StopwatchEvent( Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }
    }
}
