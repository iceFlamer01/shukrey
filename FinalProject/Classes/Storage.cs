using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Storage
    {
        private int product_id;
        private string product_name;
        private int units_in_stock;
        private double unit_price;
        private char product_cat;
        private DateTime Expired_date;
        public Storage(int Product_ID, string Product_Name,int Units_in_stock,double Unit_Price,char Product_Cat,DateTime expired_Date)
        {
            this.PRDCT_ID = Product_ID;
            this.PRDCT_N = Product_Name;
            this.UNTS_STC = Units_in_stock;
            this.UNIT_PRC = unit_price;
            this.PRDCT_CAT = Product_Cat;
            this.EXPIRE = expired_Date;

        }
        public int PRDCT_ID
        {
            get { return this.product_id; }
            set { this.product_id = value; }
        }
        public string PRDCT_N
        {
            get { return this.product_name; }
            set { this.product_name = value; }
        }
        public int UNTS_STC
        {
            get { return this.units_in_stock; }
            set { this.units_in_stock = value; }
        }
        public double UNIT_PRC
        {
            get { return this.unit_price; }
            set { this.unit_price = value; }
        }
        public char PRDCT_CAT
        {
            get { return this.product_cat; }
            set { this.product_cat = value; }
        }
        public DateTime EXPIRE
        {
            get { return this.Expired_date; }
            set { this.Expired_date = value; }
        }
    }
}
