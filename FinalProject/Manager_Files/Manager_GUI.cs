using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Manager_GUI : Form
    {
        public Manager_GUI()
        {
            InitializeComponent();
        }


        private void Workers_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_price_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Add_new_pr_btn_Click(object sender, EventArgs e)
        {
            Product_update product_Update = new Product_update();
            product_Update.Show();

        }

        private void Add_new_worker_btn_Click(object sender, EventArgs e)
        {
            Worker_update WU = new Worker_update();
            WU.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cancel_report_btn_Click(object sender, EventArgs e)
        {
             
        }

        private void Manager_GUI_Load(object sender, EventArgs e)
        {

        }

       
    }
}
