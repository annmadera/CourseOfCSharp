using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1.Models
{
    public class Order
    {
        public int Id { get; private set; }
    }

    public Order(int id)
    {
        Id = id;
    }
}
