using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace trading_basic
{
    public static class Sma
    {
        public static DateTime Date { get; set; }
        public static double SmaValue { get; set; }
    }

    public class SmaVal
    {
        private Candles[]? getData_;
        public SmaVal(Candles[]? getData)
        {
            getData_ = getData;
        }
        private double[] _cannopy;
        private DateTime[] _date;
        public void SMA_Slicing(int period, Func<Candles, double> delegate_, Func<Candles, DateTime> delegate__)
        {
            List<Candles> numberList = getData_.ToList();
            List<Candles> slice = numberList.GetRange(getData_.Length - period, period);
            _cannopy = slice.Select(delegate_).ToArray();
            _date = slice.Select(delegate__).ToArray();
            double average = _cannopy.Average();

            Sma.SmaValue = average;
            Sma.Date = DateTime.Now;
        }
    }
}