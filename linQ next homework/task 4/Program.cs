using System;
using System.Collections.Generic;
using System.Linq;
using static task_4.Program;
using System.Xml.Linq;


namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //მოცემული გვაქვს კლასი Author(AuthorID, Name) და კლასი Book(BookID, Title და AuthorID), LINQ - ის
            //გამოყენებით დავაჯოინოთ მათი სიები, მონაცემები გავფილტროთ იმ წიგნებისთვის, რომელთა
            //სათაურის სიგრძეც > 10 და ანონიმური კლასის მეშვეობით მონაცემები დავასელექტოთ წიგნების
            //დასახელებებისა და მათი ავტორებისათვის.დაბრუნებული მონაცემები დავბეჭდოთ:




                                List<Author> authors = new List<Author>
                     {
                     new Author { AuthorID = 1, Name = "George Orwell" },
                     new Author { AuthorID = 2, Name = "Jane Austen" },
                     new Author { AuthorID = 3, Name = "J.K. Rowling" }
                                };



            // List of Books





            //მოცემული გვაქვს კლასი Author(AuthorID, Name) და კლასი Book(BookID, Title და AuthorID), LINQ - ის
            //გამოყენებით დავაჯოინოთ მათი სიები, მონაცემები გავფილტროთ იმ წიგნებისთვის, რომელთა
            //სათაურის სიგრძეც > 10 და ანონიმური კლასის მეშვეობით მონაცემები დავასელექტოთ წიგნების
            //დასახელებებისა და მათი ავტორებისათვის.დაბრუნებული მონაცემები დავბეჭდოთ:


            List<Book> books = new List<Book>
 {
 new Book { BookID = 1, Title = "1984", AuthorID = 1 },
 new Book { BookID = 2, Title = "Pride and Prejudice", AuthorID = 2 },
 new Book { BookID = 3, Title = "Harry Potter and the Sorcerer's Stone", AuthorID = 3 },
 new Book { BookID = 4, Title = "Animal Farm", AuthorID = 1 }
 };




            var query = from Sbooks in books
                        join Sauthors in authors
                        on Sbooks.BookID equals Sauthors.AuthorID

                        select new { 
                        
                        FullName = Sauthors.Name,



                        BooksId = Sbooks.BookID,

                            BookTitle = Sbooks.Title,



                        };


            foreach (var author in query) 
                Console.WriteLine(author.FullName + "  " +  author.BookTitle + " " + "id -" +  author.BooksId);

       


        }


        public class Author
        {
            public string Name { get; set; }
            public int AuthorID { get; set; }

        }


        public class Book
        {

            public int BookID { get; set; }
            public string Title { get; set; }

            public int AuthorID { get; set; }

        }

    }
}
