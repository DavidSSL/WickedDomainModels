using System;

namespace WickedDomainModels.Model
{
	public class OfferType
	{
	    public OfferType(string name, ExpirationType expirationType, int daysValid, DateTime? beginDate)
	    {
	        Name = name;
	        ExpirationType = expirationType;
	        DaysValid = daysValid;
	        BeginDate = beginDate;
	    }

	    public string Name { get; set; }
		public ExpirationType ExpirationType { get; set; }
		public int DaysValid { get; set; }
		public DateTime? BeginDate { get; set; }
	}
}