using AutoMapper;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.DataAccessLayer.Entities;

namespace TestApp.BusinessLogicLayer.AutoMapper
{
    public class PasswordModelProfile : Profile
    {
        public PasswordModelProfile()
        {
            CreateMap<Password, PasswordDTO>();
        }
    }
}
