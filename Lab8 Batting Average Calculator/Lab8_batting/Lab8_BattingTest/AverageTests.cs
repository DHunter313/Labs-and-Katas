﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_batting;

namespace Lab8_BattingTest
{
    [TestClass]
    public class AverageTests
    {
        [TestMethod]
        public void TestBattingPercentageIs0WhenNoRuns()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;
            double average = Program.CalculateBattingAverage(battingSheet);
            Assert.AreEqual(0, average);
        }
            [TestMethod]
        public void TestBattingPercentageIs60()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;
            double average = Program.CalculateBattingAverage(battingSheet);
            Assert.AreEqual(0.6, average);

        }

        [TestMethod]
        public void TestSluggingAverage()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;
            double slugAverage = Program.CalculateSluggingAverage(battingSheet);
            Assert.AreEqual(1.4, slugAverage);
        }
    }
}
