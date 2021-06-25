using AutoMapper;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.PresentationLayer.ViewModels;

namespace TestApp.PresentationLayer.Mapper
{
    public class ContactInfoViewModelProfile : Profile
    {
        public ContactInfoViewModelProfile()
        {
            CreateMap<ContactInfoViewModel, ContactInfoDTO>();
        }
    }
}
