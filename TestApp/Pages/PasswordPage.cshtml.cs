using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestApp.BusinessLogicLayer.Services.Interfaces;

namespace TestApp.PresentationLayer.Pages
{
    public class PasswordPageModel : PageModel
    {
        private readonly IBaseService<PasswordPageModel> _service;
        private readonly IMapper _mapper;

        public int Id { get; set; }
        public string Pass { get; set; }
        public int ContactInfoId { get; set; }
        public PasswordPageModel(IBaseService<PasswordPageModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void OnGet()
        {
        }
        public void OnPost(PasswordPageModel model)
        {
            if (ModelState.IsValid)
            {
                _service.CreateEntity(model);
            }
        }
    }
}
