using System;

namespace WickedDomainModels.Model
{
	public class ExpirationType : Enumeration
	{
        private ExpirationType(int value, string displayName)
            : base(value, displayName)
        {
        }
        public static readonly ExpirationType Assignment = new ExpirationType(1, "Assignment");
        public static readonly ExpirationType Fixed = new ExpirationType(1, "Fixed");

	    public DateTime CalculateExpiration(OfferType offerType)
	    {
            var dateExpiring = new DateTime();

            if (this == Assignment)
                dateExpiring = DateTime.Now.AddDays(offerType.DaysValid);
            else if (this == Fixed)
            {
                if (offerType.BeginDate != null)
                {
                    dateExpiring = offerType.BeginDate.Value.AddDays(offerType.DaysValid);
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