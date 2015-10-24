using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialLinq
{
    class Program
    {
        static void Main(string[] args)
        {
           // var sample = "Hooray, another tutorial uber sofittware";

            var people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe", Age = 25 },
                new Person {FirstName = "Jane", LastName = "Doe", Age = 26 },
                new Person {FirstName = "John", LastName = "Willams", Age = 40 },
                new Person {FirstName = "Samantha", LastName = "Doe", Age = 35 },
                new Person {FirstName = "Bob", LastName = "Walters", Age = 12 },
            };

            //var result = from c in sample.ToLower()
            //             where c == 'a' || c == 'e'|| c == 'i' || c == 'o' || c == 'u'
            //             orderby c
            //             group c by c;

            var result = from p in people
                         orderby p.LastName descending
                         group p by p.LastName;
                        

            foreach (var item in result)
            {
                /// with group, you need key
                Console.WriteLine(item.Key + " - " + item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}",p.LastName, p.FirstName);
                }
               // Console.WriteLine("{0} - {1}", item.LastName, item.FirstName);
                Console.ReadKey();
             
                
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}

