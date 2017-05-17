using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson1705Classes
{
    public class Person
    {
        public int PersonId;
        public string FullName;
    }

    public class Car
    {
        public int CarId;
        public string Model;
        public int PersonId;
        public string Color;
        public DateTime CreationDate;
    }

    [Obsolete("Do not use the class")]
    [CLSCompliant(true)]// complient cls    
    class Test
    {
        public void test1()
        {

        }
    }
    [Serializable]
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 1705 classes");

            string str = "+38(050)1234567";
            Match a = Regex.Match(str, @"^\+38\([0-9]{3}\)[0-9]{7}$");
            Console.WriteLine(a.Success.ToString());

            //Test t = new Test();
            //Book b = new Book { Author = "Author1", Year = 1986, Text = "Some texet in the book" };

            //string s = CSVSerializer.Serializer(b);
            //Console.WriteLine(s);

            //string s2 = "Author2,1977,Some texet in the 2 nd cool book";
            //Book b2 = CSVSerializer.DeSerializer(s2);

            //Type bookType = typeof(Book);

            Console.ReadLine();
        }
    }
}
