using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SellerPanel.Models;
using System.Data;

public class DAC
{
    clsdac objdac = new clsdac();
    public List<product> getproducts()
    {
        List<product> products = new List<product>();
        DataTable dt = objdac.GetDataTable("select ID,Name,Model,Description,SKU,Quantity,PRICE,updatedOn from dbo.product"); //inline qry
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            product prod = new product()
            {
                ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString()),
                Name = dt.Rows[i]["Name"].ToString(),
                Model = dt.Rows[i]["Model"].ToString(),
                Description = dt.Rows[i]["Description"].ToString(),
                SKU = dt.Rows[i]["SKU"].ToString(),
                Quantity = Convert.ToDecimal(dt.Rows[i]["Quantity"].ToString()),
                PRICE = Convert.ToDecimal(dt.Rows[i]["PRICE"].ToString()),
                updatedOn = Convert.ToDateTime(dt.Rows[i]["updatedOn"].ToString())
            };

            products.Add(prod);
        }
        return products;
    }
}
