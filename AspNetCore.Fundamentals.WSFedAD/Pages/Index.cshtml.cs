﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.Fundamentals.WSFedAD.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var user = this.User;
        }
    }
}
