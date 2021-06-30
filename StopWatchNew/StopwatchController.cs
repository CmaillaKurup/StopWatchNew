using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StopWatchNew
{
    class StopwatchController
    {

        //my EventHandler
        public event EventHandler Timer;



        //In my constructor I have one thread
        public StopwatchController()
        {
            Thread stopwatch = new Thread(StartTime);
            stopwatch.Start();
        }

        //an object of my SetTime - this could have been giving a better name
        SetTime st = new SetTime(false, false, false);

        //this metheod looks at the bools from my SetTime and if they are --- aah they dont really do any thing 
        //but the purpos was to make determ if we have on - five ore ten minuts
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
