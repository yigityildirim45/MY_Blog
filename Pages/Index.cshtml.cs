using Microsoft.AspNetCore.Mvc.RazorPages;
using MY_Blog.Data; // Veri baðlamýný ekleyin
using MY_Blog.Models; // BlogPost sýnýfýnýn bulunduðu namespace'i ekleyin
using System.Collections.Generic;
using System.Linq;

namespace MY_Blog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogContext _context;

        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPosts { get; set; }

        public void OnGet()
        {
            BlogPosts = _context.BlogPosts.ToList(); // Veritabanýndan blog yazýlarýný alýr
        }
    }
}
