using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MY_Blog.Data;
using MY_Blog.Models;

namespace MY_Blog.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly BlogContext _context;

        public CreateModel(BlogContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        public void OnGet()
        {
            // Ýlk yüklemede hiçbir þey yapýlmayacak
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Veritabanýna yeni blog yazýsýný ekleyin
            _context.BlogPosts.Add(BlogPost);
            await _context.SaveChangesAsync();

            // Baþarýyla kaydedildikten sonra anasayfaya yönlendirin
            return RedirectToPage("/Index");
        }
    }
}
