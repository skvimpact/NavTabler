using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DetailsModel : PageModel
    {
        public string F {get;set;}
        public void OnGet()
        {
            // var f = Url.Page("Details");
            //this
            F = $"{Url.Page("/Table", new{tableType="a"})} - {"zzz"}";
        }
    }
}
