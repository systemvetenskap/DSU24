namespace DSU24.Models
{
    public class DisplaySportViewModel
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Sports { get; set; }
        // visa bara de saker som ska vara publika
        public DisplaySportViewModel(Sport sport)
        {
                Price = sport.Price;
        }
        public DisplaySportViewModel()
        {
            Sports = new List<string>() { "Golf", "Handboll", "Klättring" };
        }
    }
}
