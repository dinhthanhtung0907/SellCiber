﻿using System.Collections.Generic;

namespace BackEnd.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptiom { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
