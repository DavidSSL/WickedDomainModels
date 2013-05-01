using System;

namespace WickedDomainModels.Model
{
	public abstract class ExpirationType : Enumeration
	{
        private ExpirationType(int value, string displayName)
            : base(value, displayName)
        {
        }
        
        public static readonly ExpirationType Assignment = 
            new AssignmentType();
        public static readonly ExpirationType Fixed = 
            new FixedType();

	    public abstract DateTime CalculateExpiration(OfferType offerType);

        private class AssignmentType: ExpirationType{
            public AssignmentType() 
                : base(1, "Assignment")
            {
            }

            public override DateTime CalculateExpiration(OfferType offerType)
            {
                return DateTime.Now.AddDays(offerType.DaysValid);
            }
        }

        private class FixedType : ExpirationType
        {
            public FixedType()
                : base(2, "Fixed")
            {
            }

            public override DateTime CalculateExpiration(OfferType offerType)
            {
                return offerType.BeginDate.Value.AddDays(offerType.DaysValid);
            }
        }
	}
}