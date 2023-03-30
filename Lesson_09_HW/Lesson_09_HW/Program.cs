using System.Xml.Linq;

namespace Lesson_09_HW
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Author person1 = new Author(1, "J.J.Jackson", "J.J.Jackson is begginer in this sphere! He wrote only well-known 2 books", "");
            Author person2 = new Author(2,"B.B.Ben", "B.B.Ben is a big dog with a big 'B'! He's is a famous scientist and writer!", "");
            Author person3 = new Author(3, "M.M.Miki", "M.M.Miki is good boi! He just learn how to write books and wrote one small book.", "");

            person1.Age = 25;
            person2.Age = 3;
            person3.Age = 19;

            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            book1.Id = 1;
            book2.Id = 2;
            book3.Id = 3;

            book1.BookName = "How to be rich?";
            book2.BookName = "How to get Nobel Prize as dog.";
            book3.BookName = "How to write book?";

            Biography biography = new Biography();


            Author.PrintInfoStatic(person1.Name, person1.Age);
            Author.PrintInfoStatic(person1.Bio, book1.BookName);
            Author.PrintInfoStatic(person2.Name, person2.Age);
            Author.PrintInfoStatic(person2.Bio, book2.BookName);
            Author.PrintInfoStatic(person3.Name, person3.Age);
            Author.PrintInfoStatic(person3.Bio, book3.BookName);
        }

        public class Author
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Id { get; set; }
            public string Bio { get; set; }
            public string BookName { get; set; }

            public Author(int Id, string name, string bio, string bookName)
            {
                this.Id = Id;
                Name = name;
                Bio = bio;
                BookName = bookName;
            }

            public Author(string Name, int Age, string Bio, string BookName)
            {
                this.Name = Name;
                this.Age = Age;
                this.Bio = Bio;
                this.BookName = BookName;

            }

            public void PrintInfo() => Console.WriteLine();
            public static void PrintInfoStatic(string name, int age) => Console.WriteLine($"Name: {name}, Age: {age}");
            public static void PrintInfoStatic(string bio, string bookName) => Console.WriteLine($" Biography: {bio}\n Book Name: {bookName}");

        }

        public class Biography
        {
            public int Id { get; set; }
            public string Bio { get; set; }

        }

        public class Book
        {
            public int Id { get; set; }
            public string BookName { get; set; }
        }

    }

}