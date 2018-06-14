﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Address
{
    public int address_id { get; set; }
    public string address_street { get; set; }
    public string address_city { get; set; }
    public string address_province { get; set; }
    public string address_country { get; set; }
    public string address_postalCode { get; set; }
}

public partial class Author
{
    public int auther_id { get; set; }
    public string auther_name { get; set; }
    public string auther_surname { get; set; }
}

public partial class Book
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Book()
    {
        this.Orders = new HashSet<Order>();
    }

    public int book_id { get; set; }
    public string title { get; set; }
    public string ISBN { get; set; }
    public string category { get; set; }
    public string author_name { get; set; }
    public string publisher_name { get; set; }
    public string publisher_year { get; set; }
    public byte[] picture { get; set; }
    public Nullable<decimal> price { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Order> Orders { get; set; }
}

public partial class Location
{
    public int location_id { get; set; }
    public string location_name { get; set; }
    public string location_street { get; set; }
    public string location_city { get; set; }
    public string location_postalCode { get; set; }
}

public partial class Order
{
    public int order_id { get; set; }
    public System.DateTime order_date { get; set; }
    public int order_quantity { get; set; }
    public int order_terms { get; set; }
    public decimal order_price { get; set; }
    public int book_id { get; set; }
    public int user_id { get; set; }
    public bool isInCart { get; set; }

    public virtual Book Book { get; set; }
}

public partial class Publisher
{
    public int publisher_id { get; set; }
    public string publisher_name { get; set; }
    public string publisher_surname { get; set; }
    public string publisher_contactNumber { get; set; }
}

public partial class User
{
    public int user_id { get; set; }
    public string user_name { get; set; }
    public string user_surname { get; set; }
    public string user_email { get; set; }
    public string user_password { get; set; }
    public string user_contactNumber { get; set; }
    public string user_role { get; set; }
}
