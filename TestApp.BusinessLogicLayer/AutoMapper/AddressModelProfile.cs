using AutoMapper;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.DataAccessLayer.Entities;

namespace TestApp.BusinessLogicLayer.AutoMapper
{
    public class AddressModelProfile : Profile
    {
        public AddressModelProfile()
        {
            CreateMap<Address, AddressDTO>();
        }
    }
}
