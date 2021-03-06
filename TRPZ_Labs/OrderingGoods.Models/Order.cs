﻿using System;
using System.Runtime.Serialization;

namespace OrderingGoods.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public DateTime Date { get; set; }
        public int Term { get; set; }

        public Order() { }
        public Order(Item item, DateTime date, int term)
        {
            Item = item;
            Date = date;
            Term = term;
        }
    }
}
