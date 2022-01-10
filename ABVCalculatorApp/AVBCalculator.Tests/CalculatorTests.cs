using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AVBCalculator.Tests
{
    public class CalculatorTests
    {
        // Figures taken from http://howtobrew.com/book/section-1/fermenting-your-first-beer/how-much-alcohol-will-there-be

        [Theory]
        // Table vales for starting SG of 1.030
        [InlineData(1.030, 0.998, 4.1)]  // Data Format: startSG, endSG, expected
        [InlineData(1.030, 1.000, 3.9)]
        [InlineData(1.030, 1.002, 3.6)]
        [InlineData(1.030, 1.004, 3.3)]
        [InlineData(1.030, 1.006, 3.1)]
        [InlineData(1.030, 1.008, 2.8)]
        [InlineData(1.030, 1.010, 2.6)]
        [InlineData(1.030, 1.012, 2.3)]
        [InlineData(1.030, 1.014, 2.0)]
        [InlineData(1.030, 1.016, 1.8)]
        [InlineData(1.030, 1.018, 1.5)]
        [InlineData(1.030, 1.020, 1.3)]
        [InlineData(1.030, 1.022, 1.0)]
        [InlineData(1.030, 1.024, 0.8)]

        // Table vales for starting SG of 1.035
        [InlineData(1.035, 0.998, 4.8)]
        [InlineData(1.035, 1.000, 4.5)]
        [InlineData(1.035, 1.002, 4.2)]
        [InlineData(1.035, 1.004, 4.0)]
        [InlineData(1.035, 1.006, 3.7)]
        [InlineData(1.035, 1.008, 3.5)]
        [InlineData(1.035, 1.010, 3.2)]
        [InlineData(1.035, 1.012, 2.9)]
        [InlineData(1.035, 1.014, 2.7)]
        [InlineData(1.035, 1.016, 2.4)]
        [InlineData(1.035, 1.018, 2.2)]
        [InlineData(1.035, 1.020, 1.9)]
        [InlineData(1.035, 1.022, 1.6)]
        [InlineData(1.035, 1.024, 1.4)]

        // Table vales for starting SG of 1.040
        [InlineData(1.040, 0.998, 5.4)]
        [InlineData(1.040, 1.000, 5.2)]
        [InlineData(1.040, 1.002, 4.9)]
        [InlineData(1.040, 1.004, 4.6)]
        [InlineData(1.040, 1.006, 4.4)]
        [InlineData(1.040, 1.008, 4.1)]
        [InlineData(1.040, 1.010, 3.8)]
        [InlineData(1.040, 1.012, 3.6)]
        [InlineData(1.040, 1.014, 3.3)]
        [InlineData(1.040, 1.016, 3.1)]
        [InlineData(1.040, 1.018, 2.8)]
        [InlineData(1.040, 1.020, 1.9)]
        [InlineData(1.040, 1.022, 1.6)]
        [InlineData(1.040, 1.024, 1.4)]


        // Table vales for starting SG of 1.045
        [InlineData(1.045, 0.998, 6.1)]
        [InlineData(1.045, 1.000, 5.8)]
        [InlineData(1.045, 1.002, 5.6)]
        [InlineData(1.045, 1.004, 5.3)]
        [InlineData(1.045, 1.006, 5.0)]
        [InlineData(1.045, 1.008, 4.8)]
        [InlineData(1.045, 1.010, 4.5)]
        [InlineData(1.045, 1.012, 4.2)]
        [InlineData(1.045, 1.014, 4.0)]
        [InlineData(1.045, 1.016, 3.7)]
        [InlineData(1.045, 1.018, 3.4)]
        [InlineData(1.045, 1.020, 3.2)]
        [InlineData(1.045, 1.022, 2.9)]
        [InlineData(1.045, 1.024, 2.7)]


        // Table vales for starting SG of 1.050
        [InlineData(1.050, 0.998, 6.8)]
        [InlineData(1.050, 1.000, 6.5)]
        [InlineData(1.050, 1.002, 6.2)]
        [InlineData(1.050, 1.004, 5.9)]
        [InlineData(1.050, 1.006, 5.7)]
        [InlineData(1.050, 1.008, 5.4)]
        [InlineData(1.050, 1.010, 5.1)]
        [InlineData(1.050, 1.012, 4.9)]
        [InlineData(1.050, 1.014, 4.6)]
        [InlineData(1.050, 1.016, 4.4)]
        [InlineData(1.050, 1.018, 4.1)]
        [InlineData(1.050, 1.020, 3.8)]
        [InlineData(1.050, 1.022, 3.6)]
        [InlineData(1.050, 1.024, 3.3)]


        // Table vales for starting SG of 1.055
        [InlineData(1.055, 0.998, 7.4)]
        [InlineData(1.055, 1.000, 7.1)]
        [InlineData(1.055, 1.002, 6.9)]
        [InlineData(1.055, 1.004, 6.6)]
        [InlineData(1.055, 1.006, 6.3)]
        [InlineData(1.055, 1.008, 6.1)]
        [InlineData(1.055, 1.010, 5.8)]
        [InlineData(1.055, 1.012, 5.5)]
        [InlineData(1.055, 1.014, 5.3)]
        [InlineData(1.055, 1.016, 5.0)]
        [InlineData(1.055, 1.018, 4.7)]
        [InlineData(1.055, 1.020, 4.5)]
        [InlineData(1.055, 1.022, 4.2)]
        [InlineData(1.055, 1.024, 4.0)]


        // Table vales for starting SG of 1.060
        [InlineData(1.060, 0.998, 8.1)]
        [InlineData(1.060, 1.000, 7.8)]
        [InlineData(1.060, 1.002, 7.5)]
        [InlineData(1.060, 1.004, 7.3)]
        [InlineData(1.060, 1.006, 7.0)]
        [InlineData(1.060, 1.008, 6.7)]
        [InlineData(1.060, 1.010, 6.5)]
        [InlineData(1.060, 1.012, 6.2)]
        [InlineData(1.060, 1.014, 5.9)]
        [InlineData(1.060, 1.016, 5.7)]
        [InlineData(1.060, 1.018, 5.4)]
        [InlineData(1.060, 1.020, 5.1)]
        [InlineData(1.060, 1.022, 4.9)]
        [InlineData(1.060, 1.024, 4.6)]


        // Table vales for starting SG of 1.065
        [InlineData(1.065, 0.998, 8.7)]
        [InlineData(1.065, 1.000, 8.5)]
        [InlineData(1.065, 1.002, 8.2)]
        [InlineData(1.065, 1.004, 7.9)]
        [InlineData(1.065, 1.006, 7.7)]
        [InlineData(1.065, 1.008, 7.4)]
        [InlineData(1.065, 1.010, 7.1)]
        [InlineData(1.065, 1.012, 6.8)]
        [InlineData(1.065, 1.014, 6.6)]
        [InlineData(1.065, 1.016, 6.3)]
        [InlineData(1.065, 1.018, 6.0)]
        [InlineData(1.065, 1.020, 5.8)]
        [InlineData(1.065, 1.022, 5.5)]
        [InlineData(1.065, 1.024, 5.2)]


        // Table vales for starting SG of 1.070
        [InlineData(1.070, 1.000, 9.4)]
        [InlineData(1.070, 1.002, 9.1)]
        [InlineData(1.070, 0.998, 8.9)]
        [InlineData(1.070, 1.004, 8.6)]
        [InlineData(1.070, 1.006, 8.3)]
        [InlineData(1.070, 1.008, 8.0)]
        [InlineData(1.070, 1.010, 7.8)]
        [InlineData(1.070, 1.012, 7.5)]
        [InlineData(1.070, 1.014, 7.2)]
        [InlineData(1.070, 1.016, 7.0)]
        [InlineData(1.070, 1.018, 6.7)]
        [InlineData(1.070, 1.020, 6.4)]
        [InlineData(1.070, 1.022, 6.2)]
        [InlineData(1.070, 1.024, 5.9)]


        // Table vales for starting SG of 1.75
        [InlineData(1.075, 0.998, 10.1)]
        [InlineData(1.075, 1.000, 9.8)]
        [InlineData(1.075, 1.002, 9.5)]
        [InlineData(1.075, 1.004, 9.3)]
        [InlineData(1.075, 1.006, 9.0)]
        [InlineData(1.075, 1.008, 8.7)]
        [InlineData(1.075, 1.010, 8.4)]
        [InlineData(1.075, 1.012, 8.2)]
        [InlineData(1.075, 1.014, 7.9)]
        [InlineData(1.075, 1.016, 7.6)]
        [InlineData(1.075, 1.018, 7.3)]
        [InlineData(1.075, 1.020, 7.1)]
        [InlineData(1.075, 1.022, 6.8)]
        [InlineData(1.075, 1.024, 6.5)]



        public void ShouldCalculateAbv(double startSG, double endSG, decimal expected)
        {
            // Arrange
            decimal result = 0;

            // Set upper and lower bounds.  If calculated result is within 0.1 of expected result,
            // calculated result is considered accurate.
            var upperbound = expected + 0.2M;
            var lowerbound = expected - 0.1M;


            // Act
            result = ABVCalculator.Tools.CalculateAbv(startSG, endSG);
            
           

            // Assert
            Assert.InRange(result, lowerbound, upperbound);
        }
    }
}
