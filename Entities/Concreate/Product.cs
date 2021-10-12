using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        //[Required]      Bu kod (DataAnnotations) zorunluluk tanımlamak için 
        //[MaxLength(2)]  Yani validasyon kuralları gibi düşünebiliriz.
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
