using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchNew
{
    class SetTime
    {
        public bool oneMinut { get; private set; }
        public bool twoMinut { get; private set; }
        public bool threeMinut { get; private set; }

        public SetTime(bool oneMinut, bool twoMinut, bool threeMinut)
        {
            this.oneMinut = oneMinut;
            this.twoMinut = twoMinut;
            this.threeMinut = threeMinut;            
        }
    }
}
