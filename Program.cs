namespace NameArguments
{
    public class Person
    {
        public Person(string name, int age, int luckyNumber)
        {
            Name = name;
            Age = age;
            LuckyNumber = luckyNumber;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int LuckyNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Jack", 19, 34);
            var person1 = new Person(name: "Fred", age: 19, luckyNumber: 34);
            var person2 = new Person("Sam", luckyNumber: 34, age: 29);

            Console.WriteLine($"Name: {person.Name}, Age:{person.Age}, LuckyNumber: {person.LuckyNumber}");
            Console.WriteLine($"Name: {person1.Name}, Age:{person1.Age}, LuckyNumber: {person1.LuckyNumber}");
            Console.WriteLine($"Name: {person2.Name}, Age:{person2.Age}, LuckyNumber: {person2.LuckyNumber}");
        }
    }
}