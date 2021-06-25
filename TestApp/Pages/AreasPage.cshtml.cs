using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestApp.BusinessLogicLayer.Services.Interfaces;

namespace TestApp.PresentationLayer.Pages
{
    public class AreasPageModel : PageModel
    {
        private readonly IBaseService<AreasPageModel> _service;
        private readonly IMapper _mapper;

        public int Id { get; set; }
        public string BusinessAreas { get; set; }
        public string Comment { get; set; }
        public int ContactInfoId { get; set; }

        public AreasPageModel(IBaseService<AreasPageModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void OnGet()
        {
        }
        public void OnPost(AreasPageModel model)
        {
            if (ModelState.IsValid)
            {
                _service.CreateEntity(model);
            }
        }
    }
}
