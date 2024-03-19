
namespace lab_2._2.Models
{
    public class LibraryDb  
    {
        private static LibraryDb instance;

        public List<Pet> Pets { get; set; }
        public List<Art> Arts { get; set; }

        public List<Movie> Movies { get; set; }
        private LibraryDb()
        {
            Pets = new List<Pet>();

            for (int i = 0; i < 100; i++)
            {
                Pets.Add(new Pet() { Id = i, Breed = $"Breed {i}", Name = $"Name {i}" });
            }

        

       
            Movies = new List<Movie>();

            for (int i = 0; i < 100; i++)
            {
                Movies.Add(new Movie() { Id = i, Title = $"Title {i}", Description = $"Description {i}" });
            }

       

       
            Arts = new List<Art>();

            for (int i = 0; i < 100; i++)
            {
                Arts.Add(new Art() { Id = i, Title = $"Title {i}" });
            }

        }

        public static LibraryDb Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LibraryDb();
                }
                return instance;
            }
        }
    }
}
