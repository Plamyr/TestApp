using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestApp.BusinessLogicLayer.DataTransferObjects;
using TestApp.BusinessLogicLayer.Services.Interfaces;
using TestApp.DataAccessLayer.Entities;
using TestApp.PresentationLayer.ViewModels;

namespace TestApp.PresentationLayer.Pages
{
    public class ContactInfoPageModel : PageModel
    {
        private readonly IBaseService<ContactInfo> _service;
        private readonly IMapper _mapper;
        public ContactInfoPageModel(IBaseService<ContactInfo> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void OnGet()
        {
        }
        public void OnPost(ContactInfoViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = 1;
                var dtoModel = _mapper.Map<ContactInfoDTO>(model);
                _service.CreateEntity(dtoModel);
            }
        }
    }
}
