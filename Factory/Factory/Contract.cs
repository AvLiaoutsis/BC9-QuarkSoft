using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBC9Factory
{
    class Contract
    {
		public Offer chosenOffer;
		public Organisation organisationID;
		public Supplier supplierID;

		private DateTime startDate;
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		private DateTime endDate;

		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}
		public Contract(Offer offer,Organisation organisation,Supplier supplier,DateTime startdate,DateTime enddate)
		{
			chosenOffer = offer;
			organisationID = organisation;
			supplierID = supplier;
			StartDate = startdate;
			EndDate = enddate;
		}
	}
}
