using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellerPanel.Models
{
    public class product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public string Highlights { get; set; }

        public decimal ShippingWeight { get; set; }

        public string SKU { get; set; }

        public decimal PRICE { get; set; }

        public decimal Quantity { get; set; }

        public string Type { get; set; }

        public ProcessTime ProcessTime { get; set; }

        public CountryofOrigin CountryOfOrigin { get; set; }

        public brand BrandID { get; set; }

        public category Cat1 { get; set; }

        public category Cat2 { get; set; }

        public category Cat3 { get; set; }

        public Warranty Warrenty { get; set; }

        public bool Active { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public DateTime updatedOn { get; set; }

    }
  
    public class brand
    {
        public int ID { get; set; }

        public string BrandDesc { get; set; }

        public bool Active { get; set; }

    }

    public class category
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string description { get; set; }

        public int parent { get; set; }

    }

    public class CountryofOrigin
    {
        public int ID { get; set; }

        public string CountryDesc { get; set; }

        public bool active { get; set; }

    }

    public class ProcessTime
    {
        public int ID { get; set; }

        public string Description { get; set; }

    }

    public class Warranty
    {
        public int ID { get; set; }

        public string Description { get; set; }

    }
}