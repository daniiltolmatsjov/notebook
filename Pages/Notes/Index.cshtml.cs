using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using notebook.Data;
using notebook.Models;

namespace notebook.Pages.Notes
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly notebook.Data.notebookContext _context;

        public IndexModel(notebook.Data.notebookContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Note != null)
            {
                Note = await _context.Note.ToListAsync();
            }
        }
    }
}
