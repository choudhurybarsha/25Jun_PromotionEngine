using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
	public class CalculateOrderValue
	{

		ProductQty pq = new ProductQty();
		public int calculateScenarioA(int a, int b, int c)
		{
			pq.QtyA = a;
			pq.QtyB = b;
			pq.QtyC = c;
			pq.QtyD = 0;
			int finalOrderValueA = calculateOrderValueA(pq.QtyA, ProductPrice.unitPriceA, ProductPrice.promotionA);
			int finalOrderValueB = calculateOrderValueB(pq.QtyB, ProductPrice.unitPriceB, ProductPrice.promotionB);
			int finalOrderValueCD = calculateOrderValueCD(pq.QtyC, pq.QtyD, ProductPrice.unitPriceC, ProductPrice.unitPriceD, ProductPrice.promotionCD);
			int finalOrderValue = finalOrderValueA + finalOrderValueB + finalOrderValueCD;
			return finalOrderValue;

		}
		public int calculateScenarioB(int a, int b, int c)
		{
			pq.QtyA = a;
			pq.QtyB = b;
			pq.QtyC = c;
			pq.QtyD = 0;
			int finalOrderValueA = calculateOrderValueA(pq.QtyA, ProductPrice.unitPriceA, ProductPrice.promotionA);
			int finalOrderValueB = calculateOrderValueB(pq.QtyB, ProductPrice.unitPriceB, ProductPrice.promotionB);
			int finalOrderValueCD = calculateOrderValueCD(pq.QtyC, pq.QtyD, ProductPrice.unitPriceC, ProductPrice.unitPriceD, ProductPrice.promotionCD);
			int finalOrderValue = finalOrderValueA + finalOrderValueB + finalOrderValueCD;
			return finalOrderValue;
		}

		public int calculateScenarioCD(int a, int b, int c, int d)
		{
			pq.QtyA = a;
			pq.QtyB = b;
			pq.QtyC = c;
			pq.QtyD = d;
			int finalOrderValueA = calculateOrderValueA(pq.QtyA, ProductPrice.unitPriceA, ProductPrice.promotionA);
			int finalOrderValueB = calculateOrderValueB(pq.QtyB, ProductPrice.unitPriceB, ProductPrice.promotionB);
			int finalOrderValueCD = calculateOrderValueCD(pq.QtyC, pq.QtyD, ProductPrice.unitPriceC, ProductPrice.unitPriceD, ProductPrice.promotionCD);
			int finalOrderValue = finalOrderValueA + finalOrderValueB + finalOrderValueCD;
			return finalOrderValue;
		}

		int calculateOrderValueA(int a, int priceA, int promotionA)
		{
			int q = a / 3;
			int r = a % 3;
			int orderValueA = (q * promotionA) + (r * priceA);
			return orderValueA;
		}

		int calculateOrderValueB(int b, int priceB, int promotionB)
		{
			int q = b / 2;
			int r = b % 2;
			int orderValueB = (q * promotionB) + (r * priceB);
			return orderValueB;
		}

		int calculateOrderValueCD(int c, int d, int priceC, int priceD, int promotionCD)
		{
			int orderValueCD = 0;
			if (c == 0 && d != 0)
			{
				orderValueCD = d * priceD;
			}

			if (c != 0 && d == 0)
			{
				orderValueCD = c * priceC;
			}

			if (c == 0 && d == 0)
			{
				orderValueCD = 0;
			}

			if (c != 0 && d != 0)
			{
				int totalCD = c + d;
				if (c > d)
					orderValueCD = (totalCD - c) * promotionCD + (c - d) * priceC;
				if (d > c)
					orderValueCD = (totalCD - d) * promotionCD + (d - c) * priceD;
				if (c == d)
					orderValueCD = c * promotionCD;
			}

			return orderValueCD;
		}

		static void Main()
		{
			Console.WriteLine("in main method");
		}

	}
}

