using System.Collections.Generic;

namespace HomeWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("30%: " + String.Join(",", list.Top(30)));
            Console.WriteLine("20%: " + String.Join(",", list.Top(20)));
            Console.WriteLine("10%: " + String.Join(",", list.Top(10)));
            Console.WriteLine("100%: " + String.Join(",", list.Top(100)));

            var list2 = new List<Person>()
            {
                new Person(){ Id = 1, Name = "Alex", Age = 35},
                new Person(){ Id = 2, Name = "Alice", Age = 20},
                new Person(){ Id = 3, Name = "Bob", Age = 10},
                new Person(){ Id = 4, Name = "Bella", Age = 17},
                new Person(){ Id = 5, Name = "Camila", Age = 25},
                new Person(){ Id = 6, Name = "Carl", Age = 15},
                new Person(){ Id = 7, Name = "Donna", Age = 27},
                new Person(){ Id = 8, Name = "Dmitry", Age = 21},
                new Person(){ Id = 9, Name = "Emma", Age = 18},
                new Person(){ Id = 10, Name = "Evgeniy", Age = 23},
            };

           var _list2 =  list2.Top<Person, List<Person>>(30,i=>i.Age);
            _list2.ForEach(p=> Console.WriteLine(String.Join("\r\n",$"ID : {p.Id}, name: {p.Name}, age: {p.Age}")));

        }
    }

    public class  Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
