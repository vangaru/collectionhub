using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class SortItems : PageModel
    {
        public string Name { get; set; }
        
        public void OnGet(string name)
        {
            Name = name;
        }
    }
}