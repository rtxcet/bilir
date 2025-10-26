﻿using System.ComponentModel.DataAnnotations.Schema;

namespace bilir.Models
{
    public class PopularCategoryViewModel
    {
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
