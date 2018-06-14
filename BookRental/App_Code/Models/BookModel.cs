using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookModel
/// </summary>
public class BookModel
{
    public BookModel()
    {
        //
        // TODO: Add constructor logic here
        //

    }

    public string InsertBook(Book book)
    {
        try
        {
            BookRentalEntities db = new BookRentalEntities();
            db.Books.Add(book);
            db.SaveChanges();

            return book.title + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateBook(int id, Book book)
    {
        try
        {
            BookRentalEntities db = new BookRentalEntities();

            //fetch object from db
            Book b = db.Books.Find(id);

            b.title = book.title;
            b.picture = book.picture;
            b.ISBN = book.ISBN;
            b.category = book.category;
            b.author_name = book.author_name;
            b.publisher_name = book.publisher_name;
            b.price = book.price;

            db.SaveChanges();

            return book.title + "was successfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteBook(int id)
    {
        try
        {
            BookRentalEntities db = new BookRentalEntities();
            Book b = db.Books.Find(id);
            db.Books.Attach(b);
            db.Books.Remove(b);
            db.SaveChanges();

            return b.title + "was successfully Deleted";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}