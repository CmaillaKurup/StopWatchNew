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
            Thread stopwatch = new Thread(StartTime);
            stopwatch.Start();
        }

        SetTime st = new SetTime(false, false, false);
        public void StartTime()
        {
            while (true) 
            {
                if (st.oneMinut)
                {
                    st.oneMinut = true;
                    Thread.Sleep(1000);
                    Timer?.Invoke(this, new StopwatchEvent(st));

                }
                if (st.fiveMinut)
                {
                    st.fiveMinut = true;
                    Thread.Sleep(2000);
                    Timer?.Invoke(this, new StopwatchEvent(st));

                }
                if (st.tenMinut)
                {
                    st.tenMinut = true;
                    Thread.Sleep(3000);
                    Timer?.Invoke(this, new StopwatchEvent(st));

                }
            }
        }
    }
}
