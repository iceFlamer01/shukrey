using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Worker
    {
        private int worker_id;
        private string First_Name;
        private string Last_Name;
        private DateTime Birthday;
        private double Salary;
        private bool status;
        private char role;
        private int password;
        public Worker(int id, string fname, string lname, DateTime BDay ,char Rl)
        {
            this.worker_id = id;
            this.First_Name = fname;
            this.Last_Name = lname;
            this.Birthday = BDay;
            this.status = true;
            this.Salary = 29.12;
            this.role = Rl;
        }
        public Worker()
        {
        }
        public int id
        {
            get { return this.worker_id; }
            set { this.worker_id = value; }
        }
        public string F_Name
        {
            get { return this.First_Name; }
            set { this.First_Name = value; }
        }
        public string L_Name
        {
            get { return this.Last_Name; }
            set { this.Last_Name = value; }
        }
        public DateTime age
        {
            get { return this.Birthday; }
            set { this.Birthday = value; }
        }
        public double Sal
        {
            get { return this.Salary; }
            set { this.Salary = value; }
        }
        public char Role
        {
            get { return this.role; }
            set { this.role = value; }
        }
        public bool sts
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public int pswrd
        {
            get { return this.password; }
            set { this.password = value; }
        }

    }
}
