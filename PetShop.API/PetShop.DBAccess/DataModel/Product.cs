using System;
using System.ComponentModel.DataAnnotations;

namespace  PetShop.DBAccess
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
