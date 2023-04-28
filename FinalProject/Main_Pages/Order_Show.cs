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
    public partial class Order_Show : Form
    {
        public Order_Show()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintOrder printOrder = new PrintOrder();
            printOrder.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
