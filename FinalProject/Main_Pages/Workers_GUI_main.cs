using FinalProject.Main_Pages;
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
    public partial class Workers_GUI_main : Form
    {
        public Workers_GUI_main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recive_btn_Click(object sender, EventArgs e)
        {

        }

        private void New_table_btn_Click(object sender, EventArgs e)
        {
            NewTblGetInfo newTbl = new NewTblGetInfo();
            newTbl.Show();

        }

        private void Open_table_btn_Click(object sender, EventArgs e)
        {
            Order_Show order_Show = new Order_Show();
            order_Show.Show();
        }


        private void WorkersShiftBtn_Click(object sender, EventArgs e)
        {
            Worker_shift worker_Shift = new Worker_shift();
            worker_Shift.Show();
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            Manager_GUI manager_GUI = new Manager_GUI();
            manager_GUI.Show();
        }
    }
}
