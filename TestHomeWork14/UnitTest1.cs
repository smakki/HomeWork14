using HomeWork14;
using System.Collections.Generic;

namespace TestHomeWork14
{
    public class IEnumerableTop_Test
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<Person> list2 = new List<Person>()
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
        
        [Fact]
        public void RoundPercent()
        {
            Assert.Equal([9,8,7], list.Top(30));
        }

        [Fact]
        public void ArgumentExceptionTop()
        {
            Assert.Throws<ArgumentException>(()=> list.Top(101));
        } 
        
        [Fact]
        public void ArgumentExceptionBottom()
        {
            Assert.Throws<ArgumentException>(()=> list.Top(0));
        }

        [Fact]
        public void TopWithOrderAge()
        {
            Assert.Equal(35,list2.Top(10,i=>i.Age).FirstOrDefault()?.Age);
        }

        [Fact]
        public void TopWithOrderId()
        {
            Assert.Equal(10, list2.Top(10, i => i.Id).FirstOrDefault()?.Id);
        }
    }
}