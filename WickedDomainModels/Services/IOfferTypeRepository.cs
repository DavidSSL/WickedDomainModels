using System;
using WickedDomainModels.Model;

namespace WickedDomainModels.Services
{
    public interface IOfferTypeRepository
    {
        OfferType GetById(Guid id);
    }
}