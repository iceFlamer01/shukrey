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
    public partial class Manager_start_page : Form
    {
        public Manager_start_page()
        {
            InitializeComponent();
        }

        private void Passwordd_txt_TextChanged(object sender, EventArgs e)
        {
            Password_pad password = new Password_pad();
            password.Show();
        }

        private void Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            Password_pad password = new Password_pad();
            password.Show(this);
        }
    }
}
