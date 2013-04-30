using System;
using WickedDomainModels.Model;

namespace WickedDomainModels.Services
{
    public interface IMemberRepository
    {
        Member GetById(Guid id);
    }
}