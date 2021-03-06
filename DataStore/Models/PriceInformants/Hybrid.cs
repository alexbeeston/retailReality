using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
	public class Hybrid : PriceInformant
	{
		public float? quantity = null;
		public float? bulkPrice = null;

		public Hybrid(float individualPrice, float quantity, float bulkPrice)
		{
			type = PriceType.Hybrid;
			this.price = individualPrice;
			this.quantity = quantity;
			this.bulkPrice = bulkPrice;
		}

		public override void Validate()
		{
			if (quantity == null) throw new Exception("Quantity is unitialized"); // could replace by just passing a dictionary of strings to floats and looping over checking for null
			if (bulkPrice == null) throw new Exception("Total Price is unitialiazed");
			base.Validate();
		}

		public override float? price1 => quantity;
		public override float? price2 => bulkPrice;
	}
}
