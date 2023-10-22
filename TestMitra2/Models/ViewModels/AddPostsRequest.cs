using TestMitra2.Models.Domain;

namespace TestMitra2.Models.ViewModels
{
    public class AddPostsRequest
    {
        public string Heading { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string Author { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
