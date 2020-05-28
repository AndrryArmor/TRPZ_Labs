﻿using System.Runtime.Serialization;

namespace OrderingGoods.Models
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }

        public Good() { }
        public Good(string name, string model, string manufacturer, string description)
        {
            Name = name;
            Model = model;
            Manufacturer = manufacturer;
            Description = description;
        }
    }
}