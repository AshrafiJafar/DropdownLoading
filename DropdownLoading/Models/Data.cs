namespace DropdownLoading.Models
{
    public static class Data
    {
        public static List<Province> Provinces = new List<Province>() {
        new Province{ Id = 1, Name = "Azarbayjan Shargi" , Cities = {
                new City { Id = 1, Name = "Tabriz" },
                new City { Id = 2, Name = "Kaleybar" },
                new City { Id = 3, Name = "Marand" },
                new City { Id = 4, Name = "Ahar" },
            } },
        new Province{ Id = 2, Name = "Azarbayjan Gharbi" , Cities = {
                new City { Id = 5, Name = "Urmiya" },
                new City { Id = 6, Name = "Khoy" },
                new City { Id = 7, Name = "Maku" },
                new City { Id = 8, Name = "Mahabad" },
            } },
        };
    }
}
