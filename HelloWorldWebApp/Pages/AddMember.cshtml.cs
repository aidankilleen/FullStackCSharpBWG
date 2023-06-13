using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages
{
    public class AddMemberModel : PageModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public void OnGet()
        {

        }
    }
}
