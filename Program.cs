// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using trading_basic;

Console.WriteLine("OHLC");
Console.WriteLine("open hua hai 20");
Console.WriteLine("12 pm tak 30 ");
Console.WriteLine("2 pm 15");
Console.WriteLine("closing 25");

String[] lines = File.ReadAllLines("C:\\Users\\AHSAN\\RiderProjects\\trading-basic\\CandleData.json");


var getData = JsonConvert.DeserializeObject<Candles[]>(string.Join("", lines));

Console.WriteLine(getData?.Max(d => d.Close));

CandleMethods candle0 = new CandleMethods(getData);

Console.WriteLine(candle0?.CandleMaxima(d => d.Close));
Console.WriteLine(candle0?.CandleMinima(d => d.Close));

SmaVal noice = new SmaVal(getData);

noice.SMA_Slicing(10,d => d.High, d => d.Date);

Console.WriteLine($"SMA Value: {Sma.SmaValue} \n" +
                  $"Date : {Sma.Date}");

public class Candles
{
    public double Open { get; set; }
    public double High { get; set; }
    public double Low { get; set; }
    public double Close { get; set; }
    public DateTime Date { get; set; }
}

