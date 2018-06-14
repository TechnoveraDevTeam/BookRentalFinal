using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderModel
/// </summary>
public class OrderModel
{
    public string InsertOrder(Order Order)
    {
        try
        {
            BookRentalEntities db = new BookRentalEntities();
            db.Orders.Add(Order);
            db.SaveChanges();

            return Order.order_date + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateOrder(int id, Order Order)
    {
        try
        {
            BookRentalEntities db = new BookRentalEntities();

            //fetch object from db
            Order o = db.Orders.Find(id);

            o.isInCart = Order.isInCart;
            o.isInCart = Order.isInCart;
            o.order_price = Order.order_price;
            o.order_quantity = Order.order_quantity;
            o.order_terms = Order.order_terms;
            o.user_id = Order.user_id;
            o.book_id = Order.book_id;

            db.SaveChanges();

            return Order.order_date + "was successfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteOrder(int id)
    {
        try
        {
            BookRentalEntities db = new BookRentalEntities();
            Order o = db.Orders.Find(id);
            db.Orders.Attach(o);
            db.Orders.Remove(o);
            db.SaveChanges();

            return o.order_date + "was successfully Deleted";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
} 