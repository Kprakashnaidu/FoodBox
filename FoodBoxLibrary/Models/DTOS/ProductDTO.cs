using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class ProductDTO
    {
        public int id_product { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double  value { get; set; }
        public DateTime expiration_date { get; set; }
        //public DateTime create_at { get; set; }
        //public DateTime update_at { get; set; }
        //public bool status { get; set; }
    }
}
