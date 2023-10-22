using Microsoft.AspNetCore.Mvc;
using TestMitra2.Data;
using TestMitra2.Models.Domain;
using TestMitra2.Models.ViewModels;

namespace TestMitra2.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;

        public AdminTagsController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
        
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        { //Сопоставление запроса на добавление тега с моделью тега
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            _blogDbContext.Tags.Add(tag);
            _blogDbContext.SaveChanges();

            return View("Add");
        }
    }
}
