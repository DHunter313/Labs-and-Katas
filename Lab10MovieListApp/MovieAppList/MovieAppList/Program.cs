using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieAppList
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;
            Console.WriteLine("Welcome to the Movie List Application\n\n\n");
            Console.WriteLine("There are 100 movies in this list\n\n");

            do
            {
                Console.Clear();
            Console.WriteLine( "The categories are: comedy, drama, musical, scifi, horror, animated\n\n");

                Console.Write("What category are you interested in?: ");
                string movieCategory = Console.ReadLine();
                Console.WriteLine();
                List<Movie> Catalog = MovieList.default_MovieCatalog;

                foreach (Movie movie in Catalog)
                {
                    if (movie.category == movieCategory)
                    {
                        Console.WriteLine(movie.title);

                    }

                }

                Console.WriteLine("\n\nWould you like to search again? enter 'y' or 'n'");
                cont = Console.ReadLine();
            } while (cont == "y" || cont == "Y");
        }
    }
}
