using Microsoft.AspNetCore.Mvc;
using TestMitra2.Data;
using TestMitra2.Models.ViewModels;

namespace TestMitra2.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDbContext _blogDbContext;

        public BlogController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
        
        public IActionResult Blogs()
        {
            var blogPosts = _blogDbContext.BlogPosts.ToList();

            var blogPostsViewModels = blogPosts.Select(post => new BlogPostViewModel
            {
                Heading = post.Heading,
                PageTitle = post.PageTitle,
                Content = post.Content,
                ShortDescription = post.ShortDescription,
                Author = post.Author,
                FeaturedImageUrl = post.FeaturedImageUrl,
                UrlHandle = post.UrlHandle,
                PublishDate = post.PublishDate
            }).ToList();
            
            return View(blogPostsViewModels);
        }
    }
}
