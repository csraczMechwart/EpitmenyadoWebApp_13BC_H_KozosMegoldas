using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EpitmenyadoWebApp.Data;
using EpitmenyadoWebApp.Models;

namespace EpitmenyadoWebApp.Pages
{
    public class EpitmenyeListajaModel : PageModel
    {
        private readonly EpitmenyadoWebApp.Data.EpitmenyadoDbContext _context;

        public EpitmenyeListajaModel(EpitmenyadoWebApp.Data.EpitmenyadoDbContext context)
        {
            _context = context;
        }

        public IList<Epitmeny> Epitmeny { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Epitmeny = await _context.Epitmenyek.ToListAsync();
        }
    }
}
