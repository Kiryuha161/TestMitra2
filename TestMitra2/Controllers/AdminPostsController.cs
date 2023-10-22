using Microsoft.AspNetCore.Mvc;
using TestMitra2.Data;
using TestMitra2.Models.Domain;
using TestMitra2.Models.ViewModels;

namespace TestMitra2.Controllers
{
    public class AdminPostsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;

        public AdminPostsController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddPostsRequest addPostsRequest)
        {
            var post = new BlogPost
            {
                Heading = addPostsRequest.Heading,
                Content = addPostsRequest.Content,
                ShortDescription = addPostsRequest.ShortDescription,
                Author = addPostsRequest.Author,
                Tags = addPostsRequest.Tags
            };

            _blogDbContext.BlogPosts.Add(post);
            _blogDbContext.SaveChanges();
            
            return View();
        }
    }
}
