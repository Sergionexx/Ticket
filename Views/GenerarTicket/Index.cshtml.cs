using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crud.Views.GenerarTicket
{
    public class IndexModel : PageModel
    {
        public string Texto;
        public void OnGet()
        {
            Texto = "sfsdsdsds";
        }
    }
}
