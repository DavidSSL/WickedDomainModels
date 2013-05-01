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

	    public DateTime CalculateExpiration()
	    {
	        var dateExpiring = new DateTime();

            if (ExpirationType == ExpirationType.Assignment)
                dateExpiring = DateTime.Now.AddDays(DaysValid);
            else if (ExpirationType == ExpirationType.Fixed)
            {
                if (BeginDate != null)
                {
                    dateExpiring = BeginDate.Value.AddDays(DaysValid);
                }
                // Notice that we haven't got the else throwing an InvalidOperationException
                // here because we are going to deal with this later.
            }
            else
            {
                throw new InvalidOperationException();
            }
	        return dateExpiring;
	    }
	}
}