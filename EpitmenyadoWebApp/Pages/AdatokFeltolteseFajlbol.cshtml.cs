using EpitmenyadoWebApp.Data;
using EpitmenyadoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EpitmenyadoWebApp.Pages
{
    public class AdatokFeltolteseFajlbolModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly EpitmenyadoDbContext _dbContext;

        public AdatokFeltolteseFajlbolModel(IWebHostEnvironment environment, EpitmenyadoDbContext context)
        {
            _environment = environment;
            _dbContext = context;
        }
        [BindProperty]
        public IFormFile FajlFeltoltes { get; set; }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var FajlFeltoltesEleresiUtja = Path.Combine(
                                                        _environment.ContentRootPath,
                                                        @"Files\Uploads",
                                                        FajlFeltoltes.FileName);

            using (var stream = new FileStream(FajlFeltoltesEleresiUtja, FileMode.Create))
            {
                await FajlFeltoltes.CopyToAsync(stream);
            }

            StreamReader sr = new StreamReader(FajlFeltoltesEleresiUtja);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine();
                var elemek = sor.Split();
                Epitmeny ujEpitmeny = new Epitmeny();
                ujEpitmeny.Tulajdonos = int.Parse(elemek[0]);
                ujEpitmeny.Utca = elemek[1];
                ujEpitmeny.Hazszam = elemek[2];
                ujEpitmeny.Adosav = char.Parse(elemek[3]);
                ujEpitmeny.Alapterulet = int.Parse(elemek[4]);
                _dbContext.Epitmenyek.Add(ujEpitmeny);
            }
            sr.Close();
            _dbContext.SaveChanges();
            
            return Page();
        }
    }
}
