using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Cash_register
    {
        private int table_id;
        private int table_num;
        private double total_price;
        private int worker_id;
        private bool status;
        private DateTime open_date;
        public Cash_register(int Table_id, int Table_num,double Total_price,int Worker_id,bool Status,DateTime Open_date)
        {
            this.Tbl_Id = Table_id;
            this.Tbl_num = Table_num;
            this.TTL_price = Total_price;
            this.WorkerID = Worker_id;
            this.Stats = Status;
            this.Opn_date = Open_date;
        }
        public int Tbl_Id
        {
            get { return this.table_id; }
            set { this.table_id = value; }

        }
        public int Tbl_num
        {
            get { return this.table_num; }
            set { this.table_num = value; }
        }
        public double TTL_price
        {
            get { return this.total_price; }
            set { this.total_price = value; }
        }
        public int WorkerID
        {
            get { return this.worker_id; }
            set { this.worker_id = value; }
        }
        public bool Stats
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public DateTime Opn_date
        {
            get { return this.open_date; }
            set { this.open_date = value; }
        }
    }
}
