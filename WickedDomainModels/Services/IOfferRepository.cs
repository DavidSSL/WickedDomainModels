using WickedDomainModels.Model;

namespace WickedDomainModels.Services
{
    public interface IOfferRepository
    {
        void Save(Offer offer);
    }
}