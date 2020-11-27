using System;
using System.Collections.Generic;
using System.Text;

namespace Records
{
    public record DailyTemperature(double HighTemp, double LowTemp)
    { 
        public double Mean => (HighTemp + LowTemp) / 2.0;
    }
}
