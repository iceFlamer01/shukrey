using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Menu
    {
        private string meal_name;
        private string picture_Src;
        private char category;
        private string description;
        private double meal_price;
        public Menu(string Meal_name, string PIC_Src, char Category, string Description, double Meal_price)
        {
            this.MEL_N = Meal_name;
            this.PIC_SRC = picture_Src;
            this.CAT = Category;
            this.DESC = Description;
            this.MEL_price = Meal_price;
        }
        public string MEL_N
        {
            get { return this.meal_name; }
            set { this.meal_name = value; }
        }
        public string PIC_SRC
        {
            get { return this.picture_Src; }
            set { this.picture_Src = value; }
        }
        public char CAT
        {
            get { return this.category; }
            set { this.category = value; }
        }
        public string DESC
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public double MEL_price
        {
            get { return this.meal_price; }
            set { this.meal_price = value; }
        }
    }
}
