﻿using System.Net.Http;
using System;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON

{
    public class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();
        }
    }
}
