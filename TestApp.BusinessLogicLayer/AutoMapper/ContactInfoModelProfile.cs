using AutoMapper;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.DataAccessLayer.Entities;

namespace TestApp.BusinessLogicLayer.AutoMapper
{
    public class ContactInfoModelProfile : Profile
    {
        public ContactInfoModelProfile()
        {
            CreateMap<ContactInfoDTO, ContactInfo>();
        }
    }
}
