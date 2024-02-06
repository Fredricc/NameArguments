namespace NameArguments
{
    public class Person
    {
        public Person(string name, int age, int luckyNumber = 7, string favoriteColor = "blue")
        {
            Name = name;
            Age = age;
            LuckyNumber = luckyNumber;
            FavoriteColor = favoriteColor;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int LuckyNumber { get; set; }
        public string FavoriteColor { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Jack", 19, 34);
            Person person1 = new Person(name: "Fred", age: 19, luckyNumber: 39, favoriteColor: "red");
            var person2 = new Person("Sam", luckyNumber: 34, age: 29);
            var person3 = new Person("Sam", age: 29);

            Console.WriteLine($"Name: {person.Name}, Age:{person.Age}, LuckyNumber: {person.LuckyNumber}, FavoriteColor={person.FavoriteColor}");
            Console.WriteLine($"Name: {person1.Name}, Age:{person1.Age}, LuckyNumber: {person1.LuckyNumber}, FavoriteColor={person1.FavoriteColor}");
            Console.WriteLine($"Name: {person2.Name}, Age:{person2.Age}, LuckyNumber: {person2.LuckyNumber}, FavoriteColor={person2.FavoriteColor}");
            Console.WriteLine($"Name: {person3.Name}, Age:{person3.Age}, LuckyNumber: {person3.LuckyNumber}, FavoriteColor={person3.FavoriteColor}");
        }
    }
}