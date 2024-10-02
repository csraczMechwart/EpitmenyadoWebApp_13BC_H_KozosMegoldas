using EpitmenyadoWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EpitmenyadoWebApp.Pages
{
    public class FizetendoAdokModel : PageModel
    {
        private readonly EpitmenyadoDbContext _context;
        public FizetendoAdokModel(EpitmenyadoDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var epitmenyekListaja = _context.Epitmenyek.ToList();

            var fAdok = epitmenyekListaja.GroupBy(x => x.Tulajdonos).
                Select(x => new
                {
                    tulaj = x.Key,
                    ado = x.Sum(x => x.Alapterulet * 1)
                });
        }
    }
}
