using System;

namespace NovertisPharmLtd
{
	public class Medicine
	{
		public string MedicineCode{ get; set; }

		public string MedicineName { get; set; }

		public string ManufactureName{ get; set; }

		public int quantityInStock;
		private decimal price;

		public string ManufactureDate{ get; set; }

		public string ExpireDate{ get; set; }

		public string BatchNumber { get; set; }
      
		// Constructor starts here...............................//

		public Medicine (string medName, string medCode, string manufName, int quantityInStock, string manufDate, string expireDate, string batchNumb, decimal price)
		{
			
			MedicineName = medName;
			MedicineCode = medCode;
			ManufactureName = manufName;
			QuantityInStock = quantityInStock;
			ManufactureDate = manufDate;
			ExpireDate = expireDate;
			BatchNumber = batchNumb;
			Price = price;


		}
		 
		// Constructor ends here ................//

		//Property setting starts here ......//
		public decimal Price {
			get{ return price; }

			set { 
				if (value >= 0) {

					price = value;
				} else {
					throw new ArgumentOutOfRangeException ("ActualSale  must not be negative");
				}
			}
		}

		public int QuantityInStock {
			get{ return quantityInStock; }

			set { 
				if (value >= 0) {

					quantityInStock = value;
				} else {
					throw new ArgumentOutOfRangeException ("QuantityInStocke Zero must not be negative");
				}
			}
		}

		//Property setting ends here ......//

		//  Method implimentations starts here.......//




		public string print ()
		{
			return string.Format ("====Medicine Department======: \nMedicineName: {0} \nMedicode: {1} \nManufactureName: {2} \nManufactureDate: {3} \nExpireDate: {4} \nBatchNumber: {5} \nPrice:{6} Naira", MedicineName, MedicineCode, ManufactureName, ManufactureDate, ExpireDate, BatchNumber, Price);
		}



		public int increaseQuantity ()
		{
			if (QuantityInStock == 0) {
				
				return (QuantityInStock + 50);
			} else {
				return QuantityInStock;
			}

		}

		public string DisplayExpireDateAndMedicineName ()
		{
			string selected_date = "23-March-2014";

			Console.WriteLine ("The Expiry date is {0}", selected_date);

			DateTime dt;

			if (DateTime.TryParse (selected_date, out dt)) {
				string format = ExpireDate;
				return " (dt.ToString(format))";
			} else {
				return    "Not a valid datetime";
			}

			return MedicineName;
		}





			
	}
}

