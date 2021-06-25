using AutoMapper;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.DataAccessLayer.Entities;

namespace TestApp.BusinessLogicLayer.AutoMapper
{
    public class AreasModelProfile : Profile
    {
        public AreasModelProfile()
        {
            CreateMap<Areas, AreasDTO>();
        }
    }
}
