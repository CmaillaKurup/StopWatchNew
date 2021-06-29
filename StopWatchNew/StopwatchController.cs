using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StopWatchNew
{
    class StopwatchController
    {
        public event EventHandler Timer;

        Stopwatch sw = new Stopwatch(1, 5, 10);

        public StopwatchController()
        {
            Thread stopwatch = new Thread(SetTime);
            stopwatch.Start();
        }

        public void SetTime()
        {
            if (sw.oneMinut == 1)
            {
                Timer?.Invoke(this, new StopwatchEvent(sw));
                Thread.Sleep(5000);
            }
            if (sw.oneMinut == 5)
            {
                Timer?.Invoke(this, new StopwatchEvent(sw));
                Thread.Sleep(10000);
            }
            if (sw.oneMinut == 10)
            {
                Timer?.Invoke(this, new StopwatchEvent(sw));
                Thread.Sleep(20000);
            }
        }
    }
}
