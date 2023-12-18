using LeetCodeTraining.BuildingH2O;
using System;
using System.Text;
using Xunit;

namespace LeetCodeTraining.Tests
{
    public class H2OTests
    {
        [Theory]
        [InlineData("HOH", "HHO")]
        [InlineData("OOHHHH", "HHOHHO")]
        public void TestWaterMolecule(string input, string expectedOutput)
        {
            var h2o = new H2O();
            var sb = new StringBuilder();

            Action<char> releaseHydrogenOrOxygen = (c) => sb.Append(c);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'H')
                    new Thread(() => h2o.Hydrogen(() => releaseHydrogenOrOxygen('H'))).Start();
                else
                    new Thread(() => h2o.Oxygen(() => releaseHydrogenOrOxygen('O'))).Start();
            }

            Thread.Sleep(100);

            Assert.Equal(expectedOutput, sb.ToString());
        }
    }
}