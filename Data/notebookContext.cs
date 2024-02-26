using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using notebook.Models;

namespace notebook.Data
{
    public class notebookContext : IdentityDbContext
    {
        public notebookContext (DbContextOptions<notebookContext> options)
            : base(options)
        {
        }
        public DbSet<Note> Note { get; set; } = default!;
    }
}
