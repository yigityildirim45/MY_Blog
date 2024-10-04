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
            // �lk y�klemede hi�bir �ey yap�lmayacak
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Veritaban�na yeni blog yaz�s�n� ekleyin
            _context.BlogPosts.Add(BlogPost);
            await _context.SaveChangesAsync();

            // Ba�ar�yla kaydedildikten sonra anasayfaya y�nlendirin
            return RedirectToPage("/Index");
        }
    }
}
