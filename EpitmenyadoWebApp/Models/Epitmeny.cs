namespace EpitmenyadoWebApp.Models
{
    public class Epitmeny
    {
        public int Id { get; set; }
        public int Tulajdonos { get; set; }
        public string Utca { get; set; }
        public string Hazszam { get; set; }
        public char Adosav { get; set; }
        public int Alapterulet { get; set; }
    }
}
