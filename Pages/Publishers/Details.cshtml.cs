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
    public class DetailsModel : PageModel
    {
        private readonly Constantin_Mihai_lab8.Data.Constantin_Mihai_lab8Context _context;

        public DetailsModel(Constantin_Mihai_lab8.Data.Constantin_Mihai_lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}