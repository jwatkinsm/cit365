﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.scriptures
{
    public class DetailsModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public DetailsModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

      public ScriptureNote ScriptureNote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ScriptureNote == null)
            {
                return NotFound();
            }

            var scripturenote = await _context.ScriptureNote.FirstOrDefaultAsync(m => m.ID == id);
            if (scripturenote == null)
            {
                return NotFound();
            }
            else 
            {
                ScriptureNote = scripturenote;
            }
            return Page();
        }
    }
}
