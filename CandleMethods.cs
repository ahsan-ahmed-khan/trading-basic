using System;
using System.Collections.Generic;
using System.Linq;

namespace trading_basic
{
    public class CandleMethods : ICalculateCandles
    {
        private Candles[] candles_;

        public CandleMethods(Candles[] getData)
        {
            candles_ = getData;
        }

        public double CandleMaxima(Func<Candles, double>? selectors)
        {
            return candles_.Max(selectors);
        }

        public double CandleMinima(Func<Candles, double>? selectors)
        {
            return candles_.Min(selectors);
        }
    }
}
