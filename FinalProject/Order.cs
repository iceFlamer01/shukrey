using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Order
    {
        private int order_id;
        private int table_id;
        private int quantity;
        private double meal_price;
        public Order(int Order_id, int TBL_id,int Quantity,double Meal_price)
        {
            this.ORDR_ID = Order_id;
            this.TBL_id = table_id;
            this.Qntty = Quantity;
            this.MEAL_price = Meal_price;
        }
        public int ORDR_ID
        {
            get { return this.order_id; }
            set { this.order_id = value; }
        }
        public int TBL_id
        {
            get { return this.table_id; }
            set { this.table_id = value; }
        }
        public int Qntty
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public double MEAL_price
        {
            get { return this.meal_price; }
            set { this.meal_price = value; }
        }
    }
}
