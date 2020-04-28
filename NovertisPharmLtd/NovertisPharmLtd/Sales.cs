using System;
using System.Globalization;

namespace NovertisPharmLtd
{
	public class Sales
	{
		public string MedicineCode{ get; set; }

		public int quantotySold;

		private int plannedSales;
		private  int actualSales;

		public string Region{ get; set; }


		public Sales (string medCode, int qtySold, int plannedSales, int actualSales, string region)
		{
			MedicineCode = medCode;
			QuantotySold = qtySold;
			PlannedSales = plannedSales;
			ActualSales = actualSales;
			Region = region;

		}


		public int PlannedSales {
			get{ return plannedSales; }

			set { 
				if (value >= 0) {
					
					plannedSales = value;
				} else {
					throw new ArgumentOutOfRangeException ("Planned Zero must not be negative");
				}
			}
		}

		public int QuantotySold {
			get{ return quantotySold; }

			set { 
				if (value >= 0) {

					quantotySold = value;
				} else {
					throw new ArgumentOutOfRangeException ("ActualSale Zero must not be negative");
				}
			}
		}




		public int ActualSales {
			get{ return actualSales; }

			set { 
				if (value >= 0) {

					actualSales = value;
				} else {
					throw new ArgumentOutOfRangeException ("ActualSale Zero must not be negative");
				}
			}
		}

		public  string Display ()
		{
			return string.Format ("=====Sales Department======: \nMedicineCode: {0}  \nQuantitySold: {1} \nRegion: {2} \nPlannedSales: {3} \nActualSaes:{4}", MedicineCode, QuantotySold, Region, PlannedSales, ActualSales);
		}

		public int Display (int MedCode)
		{
			if (PlannedSales > ActualSales) {
				return PlannedSales - ActualSales;

			} else {
				return  ActualSales - PlannedSales;
			}


		}
	}


}


