using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int day, month, year;
        String lastname, firstname, middlename, gender;
        public void button1_Click(object sender, EventArgs e)
        {
            
            
            lastname = LastNameTB.Text;
            firstname = FirstNameTB.Text;
            middlename = MiddleNameTB.Text;
            
            if (lastname != "")
            {
                MessageBox.Show("Student Name: " + firstname + middlename + lastname +"\n"+ "Gender: "+ gender +"\n"+ "Date of Birth: "+ day + "/" + month +"/"+ year);

            }


        }

        private void DayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        public void Form1_Load(object sender, EventArgs e)
        {

             

            for (int i = 1; i <= 31; i++)
            {
                DayCB.Items.Add(i);
                day = i;
            }

            for (int i = 1; i <= 12; i++)
            {
                MonthCB.Items.Add(i);
                month = i;
            }

            for (int i = 1900; i <= 2025; i++)
            {
                YearCB.Items.Add(i);
                year = i;
            }

        }

        private void MonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void YearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DayCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DayCB.Items.Add("TEX" + i);
            }
        }

        private void FemaleRB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void NotToSayRB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Unknown";
        }

        private void MonthCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void YearCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void MaleRB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
    }
}
