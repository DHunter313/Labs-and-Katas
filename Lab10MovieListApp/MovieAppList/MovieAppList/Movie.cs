using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppList
{
   public class Movie
    {
        public string title;
        public string category;

        public Movie (string v1, string v2)
        {
            this.title = v1;
            this.category = v2;
        }
        public bool hasCategory (string category)
        {
            return this.category == category;
        }
    }
}
