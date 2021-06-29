using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchNew
{
    class Stopwatch
    {
        public int oneMinut { get; private set; }
        public int fiveMinut { get; private set; }
        public int tenMinut { get; private set; }

        public Stopwatch(int oneMinut, int fiveMinut, int tenMinut)
        {
            this.oneMinut = oneMinut;
            this.fiveMinut = fiveMinut;
            this.tenMinut = tenMinut;
        }
    }
}
