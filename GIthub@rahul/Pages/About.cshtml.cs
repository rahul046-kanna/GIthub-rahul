using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GIthub_rahul.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet()
        {
            // Read the ViewData set by the MVC controller if available
            if (ViewData.ContainsKey("Message"))
            {
                Message = ViewData["Message"]?.ToString();
            }
            else
            {
                Message = "Your application description page.";
            }
        }
    }
}
