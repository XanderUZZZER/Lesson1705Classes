using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1705Classes
{
    public class Book
    {
        public string Author { get; set; }
        public int Year { get; set; }

        [NoCsv]
        public string Text { get; set; }
    }

}
