using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestApp.BusinessLogicLayer.Services.Interfaces;

namespace TestApp.PresentationLayer.Pages
{
    public class AddressPageModel : PageModel
    {
        private readonly IBaseService<AddressPageModel> _service;
        private readonly IMapper _mapper;

        public int Id { get; set; }
        public string Country { get; set; }
        public string OfficeName { get; set; }
        public string Adds { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ContactInfoId { get; set; }

        public AddressPageModel(IBaseService<AddressPageModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void OnGet()
        {
        }
        public void OnPost(AddressPageModel model)
        {
            if (ModelState.IsValid)
            {
                _service.CreateEntity(model);
            }
        }
    }
}
