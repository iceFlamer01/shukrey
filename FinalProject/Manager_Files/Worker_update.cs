using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FinalProject.Classes;

namespace FinalProject
{
    public partial class Worker_update : Form
    {

        DBSql dBSql;


        public Worker_update()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Worker_update_Load(object sender, EventArgs e)
        {
            Status_lbl.Enabled = false;
            Status_txt.Enabled = false;
        }
        private Worker WGenerator(Worker w)
            //function  to create new worker
        {
            w.id =int.Parse(Id_txt.Text);
            w.F_Name =F_name_txt.Text;
            w.L_Name =L_name_txt.Text;
            w.Sal=double.Parse(Salary_txt.Text);
            w.age =BD_DP.Value;
            w.pswrd =int.Parse(Password_txt.Text);
            w.Role =char.Parse(Role_CB.Text);
            w.sts = true;
            return w;
        }
        private int CheckID(int id)
            //function to validate id number
        {
            int num = id;
            int count = 0;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            if (count != 9)
                return 0;
            return 1;

        }
        private int CheckName(string Fname,string Lname)
            //function to validate worker name
        {
            bool result;
            string Name = Fname + Lname;
           foreach (char c in Name)
            {
                result = char.IsLetter(c);
                if (!result)
                {
                    return 0;
                }
            }
            return 1;
        }
        private int CheckSal(double sal)
        //function to validate worker salary
        {
            if (sal < 29.12)
                return 0;
            return 1;
        }
        private int CheckAge(DateTime age)
        //function to validate worker age
        {
            DateTime now = DateTime.Today;
            if (now.Year - age.Year < 18)
                return 0;
            return 1;
        }
        private int CheckPass(int pass)
        //function to validate worker password
        {
            int count = 0;
            while (pass > 0)
            {
                count++;
                pass = pass / 10;
            }
            if (count != 6)
                return 0;
            return 1;
        }
        private int CheckWorker(Worker w)
            //function to validate worker 
        {
            int f = 0;
            if (CheckID(w.id) == 1)
                if (CheckAge(w.age) == 1)
                    if (CheckName(w.F_Name, w.L_Name) == 1)
                        if (CheckPass(w.pswrd) == 1)
                            if (CheckSal(w.Sal) == 1)
                                f = 1;
                            else throw new Exception("too low salary!");
                        else throw new Exception("you need to enter six digits password!");
                    else throw new Exception("you enterd wron name");
                else throw new Exception("you cant hire a worker in this age!");
            else throw new Exception("you need to enter nine digits id");
            if (f==1)
            {
                dBSql.insert_Worker_To_Data_Base(w);
                return 1;
            }
            else
                throw new Exception("Faild adding to the Data Base.");
            
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Worker w = new Worker();
                w =WGenerator(w);
                if (CheckWorker(w)==1)
                {
                    MessageBox.Show("Worker has been added succesfully.");
                    this.Close();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("An error occured please check the data.\n" + msg.Message);
                return;
            }
           
        }
    }
}
