using System;
using System.Collections.Generic;
using WickedDomainModels.Services;

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

        public int NumberOfActiveOffers { get; private set; }

        public Offer AssignOffer(OfferType offerType
            , IOfferValueCalculator offerValueCalculator)
        {
            var value = offerValueCalculator
                .CalculateValue(this, offerType);

            var dateExpiring = offerType.CalculateExpiration();
            
            var offer = new Offer(this, offerType, dateExpiring, value);

            _assignedOffers.Add(offer);
            NumberOfActiveOffers++;

            return offer;
        }
    }
}