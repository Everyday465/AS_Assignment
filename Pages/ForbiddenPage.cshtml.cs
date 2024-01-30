using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AS_Assignment.Pages
{
    public class ForbiddenPageModel : PageModel
    {
        public IActionResult OnGet()
        {
            Forbid();
            return Page();
        }

    }
}
