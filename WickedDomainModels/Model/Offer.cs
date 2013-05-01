using System;

namespace WickedDomainModels.Model
{
	public class Offer : Entity
	{
	    public Offer(Member memberAssigned, OfferType type, DateTime dateExpiring, int value)
	    {
	        MemberAssigned = memberAssigned;
	        Type = type;
	        DateExpiring = dateExpiring;
	        Value = value;
	    }

	    public Member MemberAssigned { get; set; }
		public OfferType Type { get; set; }
		public DateTime DateExpiring { get; set; }
		public int Value { get; set; }
	}
}