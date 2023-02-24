﻿using Microsoft.Extensions.ObjectPool;
using OpenAutoBench_ng.Communication.Instrument;

namespace OpenAutoBench_ng.Communication.Radio.Motorola.RSSRepeaterBase
{
    public class RSSRepeaterBaseTestParams
    {
        public bool doRefoscTest = true;
        public bool doPowerTest = true;
        public bool doDeviationTest = true;
        public bool doRssiTest = true;

        public IBaseInstrument? instrument;
        public Action<string>? callback;
        public RSSRepeaterBase? radio;

        public RSSRepeaterBaseTestParams()
        {
        }


    }
}
