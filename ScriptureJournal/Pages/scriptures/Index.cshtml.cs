using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<ScriptureNote> ScriptureNote { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string KeyWordSearchString { get; set; }

        public SelectList Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookSection { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SortMethod { get; set; }
        public List<SelectListItem> SortList { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from s in _context.ScriptureNote
                                           orderby s.Book
                                           select s.Book;
            SortList = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "None"},
                new SelectListItem{ Value = "2", Text = "Book"},
                new SelectListItem{ Value = "3", Text = "Date Added"}
            };

            var scriptures = from s in _context.ScriptureNote
                             select s;
            switch (SortMethod)
            {
                case 1:
                    break;
                case 2:
                    scriptures = from n in _context.ScriptureNote
                            orderby n.Book, n.Chapter, n.Verse
                            select n;
                    break;
                case 3:
                    scriptures = from n in _context.ScriptureNote
                            orderby n.DateAdded
                            select n;
                    break;
            }


            if (!string.IsNullOrEmpty(KeyWordSearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(KeyWordSearchString));
            }

            if (!string.IsNullOrEmpty(BookSection))
            {
                scriptures = scriptures.Where(s => s.Book == BookSection);
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            ScriptureNote = await scriptures.ToListAsync();
        }
    }
}
