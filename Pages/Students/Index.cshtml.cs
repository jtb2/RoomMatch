using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoomMatch.Models;

namespace RoomMatch.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RoomMatch.Models.RoomMatchContext _context;

        public IndexModel(RoomMatch.Models.RoomMatchContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Movie.ToListAsync();
        }
    }
}
