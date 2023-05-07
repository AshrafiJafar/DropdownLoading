namespace DropdownLoading.Models
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Township> TownShipes { get; set; } = new HashSet<Township>();
    }

    public class Township
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
