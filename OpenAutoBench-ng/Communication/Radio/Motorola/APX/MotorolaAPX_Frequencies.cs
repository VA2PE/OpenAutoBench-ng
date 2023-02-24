﻿using OpenAutoBench_ng.Communication.Radio.Motorola.XCMPRadioBase;

namespace OpenAutoBench_ng.Communication.Radio.Motorola.APX
{
    public class MotorolaAPX_Frequencies
    {
        public static int[] TxFrequencies(MotorolaXCMPRadioBase radio)
        {
            List<int> TxFrequencies = new List<int>();
            /*
             * PORTABLES
             */

            // 900 APX4000
            if (radio.ModelNumber.Contains("H51W"))
            {
                TxFrequencies.Add(896012500);
                TxFrequencies.Add(899012500);
                TxFrequencies.Add(901987500);
                TxFrequencies.Add(935012500);
                TxFrequencies.Add(938012500);
                TxFrequencies.Add(940937500);
            }

            // 8/900 APX4000XH
            else if (radio.ModelNumber.Contains("H51V"))
            {
                TxFrequencies.Add(806012500);
                TxFrequencies.Add(820987500);
                TxFrequencies.Add(824987500);
                TxFrequencies.Add(851012500);
                TxFrequencies.Add(865987500);
                TxFrequencies.Add(869987500);
                TxFrequencies.Add(896012500);
                TxFrequencies.Add(901987500);
                TxFrequencies.Add(935012500);
                TxFrequencies.Add(940987500);
            }

                     // 7/800 APX900
            else if (radio.ModelNumber.Contains("H92U") ||
                     // 7/800 APX6000AN
                     radio.ModelNumber.Contains("H98U"))
            {
                TxFrequencies.Add(764012500);
                TxFrequencies.Add(769012500);
                TxFrequencies.Add(775987500);
                TxFrequencies.Add(794012500);
                TxFrequencies.Add(809012500);
                TxFrequencies.Add(823987500);
                TxFrequencies.Add(851012500);
                TxFrequencies.Add(860012500);
                TxFrequencies.Add(869887500);
            }

                     // UHF2 APX4000
            else if (radio.ModelNumber.Contains("H51S") ||
                     // UHF2 APX6000AN
                     radio.ModelNumber.Contains("H98S"))
            {
                TxFrequencies.Add(450025000);
                TxFrequencies.Add(460025000);
                TxFrequencies.Add(471025000);
                TxFrequencies.Add(484975000);
                TxFrequencies.Add(485025000);
                TxFrequencies.Add(495025000);
                TxFrequencies.Add(506025000);
                TxFrequencies.Add(511975000);
            }

            // UHF1 APX3000
            else if (radio.ModelNumber.Contains("H59Q"))
            {
                TxFrequencies.Add(380025000);
                TxFrequencies.Add(390025000);
                TxFrequencies.Add(400025000);
                TxFrequencies.Add(411025000);
                TxFrequencies.Add(424925000);
                TxFrequencies.Add(435025000);
                TxFrequencies.Add(444975000);
                TxFrequencies.Add(445025000);
                TxFrequencies.Add(457025000);
                TxFrequencies.Add(469925000);
            }

            /*
             * MULTIBAND PORTABLES
             */

            // APX7000
            else if (radio.ModelNumber.Contains("H49T") ||
                     radio.ModelNumber.Contains("H97T"))
            {
                MotorolaBand[] bands = radio.GetBands();

                if (bands.Contains(MotorolaBand.BAND_7800))
                {
                    TxFrequencies.Add(764012500);
                    TxFrequencies.Add(769012500);
                    TxFrequencies.Add(775987500);
                    TxFrequencies.Add(794012500);
                    TxFrequencies.Add(809012500);
                    TxFrequencies.Add(823987500);
                    TxFrequencies.Add(851012500);
                    TxFrequencies.Add(860012500);
                    TxFrequencies.Add(869887500);
                }

                if (bands.Contains(MotorolaBand.BAND_UHF2))
                {
                    TxFrequencies.Add(450025000);
                    TxFrequencies.Add(460025000);
                    TxFrequencies.Add(471025000);
                    TxFrequencies.Add(484975000);
                    TxFrequencies.Add(485025000);
                    TxFrequencies.Add(495025000);
                    TxFrequencies.Add(506025000);
                    TxFrequencies.Add(511975000);
                }

                if (bands.Contains(MotorolaBand.BAND_UHF1))
                {
                    throw new Exception("I don't know your 7000's frequencies");
                }

                if (bands.Contains(MotorolaBand.BAND_VHF))
                {
                    TxFrequencies.Add(136025000);
                    TxFrequencies.Add(142125000);
                    TxFrequencies.Add(154225000);
                    TxFrequencies.Add(160125000);
                    TxFrequencies.Add(168075000);
                    TxFrequencies.Add(173975000);
                }
            }

            // APX8000
            else if (radio.ModelNumber.Contains("H91U"))
            {
                // VHF
                TxFrequencies.Add(136012500);
                TxFrequencies.Add(136012500);
                TxFrequencies.Add(136012500);

                // UHF
                TxFrequencies.Add(380012500);
                TxFrequencies.Add(425012500);
                TxFrequencies.Add(469987500);
                TxFrequencies.Add(470012500);
                TxFrequencies.Add(495012500);
                TxFrequencies.Add(519987500);

                // 7/800
                TxFrequencies.Add(764012500);
                TxFrequencies.Add(785012500);
                TxFrequencies.Add(805987500);
                TxFrequencies.Add(806012500);
                TxFrequencies.Add(838012500);
                TxFrequencies.Add(869887500);
            }

            /*
             * MOBILES
             */


            // UHF2 APX4500
            else if (radio.ModelNumber.Contains("M22S"))
            {
                TxFrequencies.Add(450012500);
                TxFrequencies.Add(455012500);
                TxFrequencies.Add(465012500);
                TxFrequencies.Add(470012500);
                TxFrequencies.Add(484987500);
                TxFrequencies.Add(485012500);
                TxFrequencies.Add(498012500);
                TxFrequencies.Add(511987500);
                TxFrequencies.Add(512012500);
                TxFrequencies.Add(519987500);
            }

            // VHF 6500
            else if (radio.ModelNumber.Contains("M25K"))
            {
                TxFrequencies.Add(136012500);
                TxFrequencies.Add(140762500);
                TxFrequencies.Add(145512500);
                TxFrequencies.Add(150262500);
                TxFrequencies.Add(154987500);
                TxFrequencies.Add(155012500);
                TxFrequencies.Add(159762500);
                TxFrequencies.Add(164512500);
                TxFrequencies.Add(169262500);
                TxFrequencies.Add(173987500);
            }

            // all else, error out
            else
            {
                throw new Exception($"I don't know frequencies for your model {radio.ModelNumber}");
            }

            return TxFrequencies.ToArray();
        }
    }
}
