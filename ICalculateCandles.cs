using System;
using System.Collections.Generic;
using System.Linq;
namespace trading_basic
{
    public interface ICalculateCandles
    {
        public double CandleMaxima(Func<Candles, double>? selectors);
        public double CandleMinima(Func<Candles, double>? selectors);
    }
}