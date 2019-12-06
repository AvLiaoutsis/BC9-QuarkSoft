using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBC9Factory
{
    class Offer
    {
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		private double quantity;

		public double Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		private double amount;

		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		public Supplier supplierOfOffer;

		public Offer(double price,double quantity,double amount)
		{
			Price = price;
			Quantity = quantity;
			Amount = amount;
		}
	}
}
