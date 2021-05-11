using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mah_Noor_S00199547Final_Exam;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestPricedecrease()

		{
			//Arange
			Game g1 = new Game("Halo 5", "Xbox", 84, 59.99m, "Peace has been devastated as colony worlds are unexpectedly attacked. What's more, when humanity's greatest hero goes missing, a new Spartan is assigned the task of hunting the Master Chief and solving a mystery that threatens the whole of the galaxy.");
			decimal finalPrice = 80m;

			//Act
			g1.DecreasePrice(.10);


			//Assert
			Assert.AreEqual(finalPrice, g1.Price);

		}
	}
}
