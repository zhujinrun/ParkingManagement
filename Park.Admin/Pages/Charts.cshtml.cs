using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Park.Admin.Pages
{
    public class ChartsModel : BaseModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}