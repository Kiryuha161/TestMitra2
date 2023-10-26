using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestMitra2.Data;
using TestMitra2.Models.Domain;
using TestMitra2.Models.ViewModels;

namespace TestMitra2.Controllers
{
    public class AdminPostsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        private readonly UserManager<User> _userManager;

        public AdminPostsController(BlogDbContext blogDbContext, UserManager<User> userManager)
        {
            _blogDbContext = blogDbContext;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPostsRequest addPostsRequest)
        {
                var post = new BlogPost
                {
                    Heading = addPostsRequest.Heading,
                    PageTitle = addPostsRequest.Id.ToString(),
                    Content = addPostsRequest.Content,
                    ShortDescription = addPostsRequest.ShortDescription,
                    Author = User.Identity.Name,
                    FeaturedImageUrl = addPostsRequest.FeaturedImageUrl,
                    UrlHandle = $"/Views/{addPostsRequest.Id.ToString()}",
                    PublishDate = DateTime.Now
                };

                _blogDbContext.BlogPosts.Add(post);
                _blogDbContext.SaveChanges();
            
            
            return RedirectToAction("Index", "Home");
        } //Этот контроллер и всё, что с ним связано, я не успел доделать
    }
}
            
           

           
            
            
