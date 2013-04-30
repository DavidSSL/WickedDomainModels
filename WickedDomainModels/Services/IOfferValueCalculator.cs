using WickedDomainModels.Model;

namespace WickedDomainModels.Services
{
    public interface IOfferValueCalculator
    {
        int CalculateValue(Member member, OfferType offerType);
    }
}