using System.Collections.Generic;
using Advanced.Generics;

namespace Advanced.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title 1", Price = 5 },
                new Book() { Title = "Title 2", Price = 7 },
                new Book() { Title = "Title 3", Price = 17 }
            };
        }

        
        public List<Book> getCheapBooks(List<Book> books)
        {
            /*
             * A predicate is a delegate which points to a method that gets a <Type>, in this case Book,
             * and returns a boolean value specifying if a given condition (IsCheaperThan10Dollars) was satisfied.
             *
             *  FindAll will iterate the Book collection and for each book it will pass it to IsCheaperThan100Dollars
             *  to determine if the condition is satisfied. If it is, it will return the given book in the list of results
             *  
             */
            //return books.FindAll(IsCheaperThan10Dollars);
            
            //?Lambdas alternative to the previous comment:
            return books.FindAll(book => book.Price < 10);
        }

        private bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        
    }
}