using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1705Classes
{
    public static class CSVSerializer
    {
        public static string Serializer(Book obj)
        {
            Type bookType = typeof(Book);
            var propsToSerialize = bookType.GetProperties().
                                            Where(p => p.GetCustomAttributes(typeof(NoCsvAttribute), true).
                                            Length == 0);

            StringBuilder newString = new StringBuilder();
            foreach (var prop in propsToSerialize)
            {
                newString.Append(prop.GetValue(obj)).Append(",");
            }

            return newString.Remove(newString.Length - 1, 1).ToString();
        }

        public static Book DeSerializer(string str)
        {
            string[] array = str.Split(',');
            Type bookType = typeof(Book);
            var propsToSerialize = bookType.GetProperties().
                                            Where(p => p.GetCustomAttributes(typeof(NoCsvAttribute), true).
                                            Length == 0);
            var activator = Activator.CreateInstance(bookType);

            
            //}
            return new Book();
        }
        
    }
}
