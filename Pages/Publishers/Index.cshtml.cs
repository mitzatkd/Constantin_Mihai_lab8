﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Constantin_Mihai_lab8.Data;
using Constantin_Mihai_lab8.Models;

namespace Constantin_Mihai_lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Constantin_Mihai_lab8.Data.Constantin_Mihai_lab8Context _context;

        public IndexModel(Constantin_Mihai_lab8.Data.Constantin_Mihai_lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
