﻿using Microsoft.Extensions.ObjectPool;
using OpenAutoBench_ng.Communication.Instrument;

namespace OpenAutoBench_ng.Communication.Radio.Motorola.XCMPRadioBase
{
    public class XCMPRadioTestParams
    {
        public bool doRefoscTest = true;
        public bool doPowerTest = true;
        public bool doDeviationTest = true;
        public bool doRssiTest = true;
        public bool doTxBer = true;
        public bool doRxBer = true;

        public IBaseInstrument? instrument;
        public Action<string>? callback;
        public MotorolaXCMPRadioBase? radio;

        public XCMPRadioTestParams()
        {
        }


    }
}
