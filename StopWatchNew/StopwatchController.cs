using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StopWatchNew
{
    class StopwatchController
    {
        public event EventHandler Timer;

        SetTime sw = new SetTime(false, false, false);


        public StopwatchController()
        {
            Thread stopwatch = new Thread(SetTime);
            stopwatch.Start();
        }

        

        public void SetTime()
        {          
                Timer?.Invoke(this, new StopwatchEvent(sw));
                Thread.Sleep(5000);
           
        }     
    }
}
