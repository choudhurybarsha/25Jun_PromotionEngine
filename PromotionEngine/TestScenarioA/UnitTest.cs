using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace TestScenario
{
	[TestClass]
	public class TestScenarios
	{
		[TestMethod]
		public void TestScenarioA()
		{
			CalculateOrderValue cal = new CalculateOrderValue();
			int a = 1;
			int b = 1;
			int c = 1;
			int check = cal.calculateScenarioA(a, b, c);

			Assert.AreEqual(100, check);
		}

		[TestMethod]
		public void TestScenarioB()
		{
			CalculateOrderValue cal = new CalculateOrderValue();
			int a = 5;
			int b = 5;
			int c = 1;
			int check = cal.calculateScenarioB(a, b, c);

			Assert.AreEqual(370, check);
		}

		[TestMethod]
		public void TestScenarioC()
		{
			CalculateOrderValue cal = new CalculateOrderValue();
			int a = 3;
			int b = 5;
			int c = 1;
			int d = 1;
			int check = cal.calculateScenarioCD(a, b, c,d);

			Assert.AreEqual(280, check);
		}
	}
}
