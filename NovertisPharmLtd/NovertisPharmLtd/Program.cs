using System;

namespace NovertisPharmLtd
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("=======NOVERTIS PHARMACY LTD====== ");

			var medicine = new Medicine ("Paracetamol", "12221MT", "Orange Drugs Ltd", 4444, "12-04-2019", " 12-04-2020", "33333", 10M);

			var sales1 = new  Sales ("2234CD", 32, 50, 54, "Enugu");
			var sales2 = new  Sales ("name", 32, 60, 54, "Enugu");

			Console.WriteLine (medicine.print ());
			Console.WriteLine (sales1.Display ());
			Console.WriteLine (sales2.Display (232));

			Console.WriteLine (medicine.increaseQuantity ());
			Console.WriteLine (medicine.DisplayExpireDateAndMedicineName ());





		}
	}
}
