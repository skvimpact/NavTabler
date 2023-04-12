using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NavTabler.Models;

namespace MyApp.Namespace
{
    public class TableModel : PageModel
    {
        public List<Table> Items {get;set;} = new List<Table>();
       // public void OnGet() => OnGet("privet");
        public IActionResult OnGet(string tableType)
        {
            //
            Items.AddRange(
                new Table[]{
                    new Table{Name = tableType},
                    // new Table{Name = f},
                    new Table{Name = "ECS_Subdivision"},
                    new Table{Name = "MD_Contragent"},
                    new Table{Name = "DR_Country"},
                    new Table{Name = "CLI_Models"}
                }
            );
            // StatusCode
            return new PageResult();
        }
    }
}
