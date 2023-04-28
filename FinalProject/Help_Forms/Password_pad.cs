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
    public partial class Password_pad : Form
    {
        string input = string.Empty;
        public Password_pad()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            Manager_start_page manager_Start_Page = new Manager_start_page();
            manager_Start_Page.Show();
        }
    }
}
