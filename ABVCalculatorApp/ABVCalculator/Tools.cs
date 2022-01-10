using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABVCalculator
{
    public static class Tools
    {
        public static decimal CalculateAbv(double startSG, double endSG)
        {
            double output = 0;

            // Formula to calculate Alcohol By Volume
            // abv = (76.08 * (original in SG - final in SG) / (1.775 - original in SG)) *(final in SG / 0.794)

            // NOTE: Original table only shows single digit results, so calculation is rounded to 1 decimal place.

            var result = (76.08 * (startSG - endSG) / (1.775 - startSG) * (endSG / 0.794));

            output = Math.Round(result,1);

            return (decimal)output;
        }
    }
}
