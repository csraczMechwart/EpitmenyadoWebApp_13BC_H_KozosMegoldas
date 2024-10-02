using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EpitmenyadoWebApp.Data;
using EpitmenyadoWebApp.Models;

namespace EpitmenyadoWebApp.Pages
{
    public class UjEpitmenyModel : PageModel
    {
        private readonly EpitmenyadoWebApp.Data.EpitmenyadoDbContext _context;

        public UjEpitmenyModel(EpitmenyadoWebApp.Data.EpitmenyadoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Epitmeny Epitmeny { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Epitmenyek.Add(Epitmeny);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
