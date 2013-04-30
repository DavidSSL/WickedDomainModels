using System.Collections.Generic;

namespace WickedDomainModels.Model
{
	public class Member : Entity
	{
	    private readonly List<Offer> _assignedOffers;

	    public Member()
		{
            _assignedOffers = new List<Offer>();
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public IEnumerable<Offer> AssignedOffers
		{
		    get { return _assignedOffers; }
		}

	    public int NumberOfActiveOffers { get; set; }

	    public void AssignOffer(Offer offer)
	    {
            _assignedOffers.Add(offer);
	    }
	}
}