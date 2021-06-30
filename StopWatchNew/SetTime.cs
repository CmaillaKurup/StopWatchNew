using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchNew
{
    class SetTime
    {
        public bool oneMinut { get; set; }
        public bool fiveMinut { get; set; }
        public bool tenMinut { get; set; }

        public SetTime(bool oneMinut, bool fiveMinut, bool tenMinut)
        {
            this.oneMinut = oneMinut;
            this.fiveMinut = fiveMinut;
            this.tenMinut = tenMinut;            
        }
    }
}
