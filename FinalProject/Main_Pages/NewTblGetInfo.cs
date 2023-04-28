using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Main_Pages
{
    public partial class NewTblGetInfo : Form
    {
        public NewTblGetInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TblNum_TextChanged(object sender, EventArgs e)
        {
            Num_pad numPD = new Num_pad();
            numPD.Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            PrintOrder ptrordr = new PrintOrder();
            ptrordr.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DinnersNum_TextChanged(object sender, EventArgs e)
        {
            Num_pad numPD = new Num_pad();
            numPD.Show();
        }
    }
}
