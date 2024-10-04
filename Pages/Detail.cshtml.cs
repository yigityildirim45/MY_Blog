using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MY_Blog.Data;
using MY_Blog.Models;

namespace MY_Blog.Pages
{
    public class DetailModel : PageModel
    {
        private readonly BlogContext _context;

        public DetailModel(BlogContext context)
        {
            _context = context;
        }

        public BlogPost BlogPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            BlogPost = await _context.BlogPosts.FindAsync(id);

            if (BlogPost == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
