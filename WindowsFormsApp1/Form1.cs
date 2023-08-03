using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pERSONEL_TAKİP_LİSTDataSet.tbl_Person' table. You can move, or remove it, as needed.
            this.tbl_PersonTableAdapter.Fill(this.pERSONEL_TAKİP_LİSTDataSet.tbl_Person);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {


        } 

       

    }

   
}