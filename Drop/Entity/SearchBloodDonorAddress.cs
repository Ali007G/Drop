using Drop.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drop.Entity
{
    public partial class SearchBloodDonorAddress : Form
    {
        function fn = new function();
        public SearchBloodDonorAddress()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBloodDonorAddress_Load(object sender, EventArgs e)
        {
            String query = "Select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            if(textAddress.Text != "")
            {
                String query = "select * from newDonor where city like '" + textAddress.Text + "%' or daddress like '" + textAddress.Text+ "%' ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                String query = "select * from newDonor";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
