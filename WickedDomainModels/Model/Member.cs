using System.Collections.Generic;

namespace WickedDomainModels.Model
{
    public class Member : Entity
    {
        private readonly List<Offer> _assignedOffers;

        public Member(List<Offer> assignedOffers, string firstName, string lastName, string email)
        {
            _assignedOffers = assignedOffers;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
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
            NumberOfActiveOffers++;
        }
    }
}