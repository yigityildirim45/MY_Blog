using Microsoft.AspNetCore.Mvc.RazorPages;
using MY_Blog.Data; // Veri ba�lam�n� ekleyin
using MY_Blog.Models; // BlogPost s�n�f�n�n bulundu�u namespace'i ekleyin
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
            BlogPosts = _context.BlogPosts.ToList(); // Veritaban�ndan blog yaz�lar�n� al�r
        }
    }
}
