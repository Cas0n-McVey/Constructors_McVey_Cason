using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_McVey_Cason
{
    class Game
    {
        // Basic games have a title and a genre
        public string title, genre;

        // If any code don't have a title and genre will have that string
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            // To make it shorter and easier instead of titleParam  and genre Param
            title = titleParam;
            genre = genreParam;

        }

    }
}
