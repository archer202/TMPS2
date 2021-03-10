using System;
using CoffeLand.Models.Enums;

namespace CoffeLand.Models
{
    public class Coffe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Intensity Intensity { get; set; }
        public Quantity Quantity { get; set; }

    }
}
