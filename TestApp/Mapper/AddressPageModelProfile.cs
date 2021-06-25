using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.PresentationLayer.Pages;

namespace TestApp.PresentationLayer.Mapper
{
    public class AddressPageModelProfile : Profile
    {
        public AddressPageModelProfile()
        {
            CreateMap<AddressPageModel, AddressDTO>();
        }
    }
}
