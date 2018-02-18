using System;
using System.Collections;
using System.Collections.Generic;

namespace AppTestes.Models
{
    public class Formatacao
    {
        public  static void DisplayTemperature(DateTime date, double temp)
        {

            var output = string.Format("Temperature at {0:t} on {0:d} is {1:N2}", date, temp);
        }
    }
}
