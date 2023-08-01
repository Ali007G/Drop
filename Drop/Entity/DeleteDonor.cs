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
    public partial class DeleteDonor : Form
    {
        function fn = new function();
        String query;
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textDonorID.Text == "")
            {
                textName.Clear();
                textFather.Clear();
                textMother.Clear();
                textDOB.ResetText();
                textMobile.Clear();
                textGender.ResetText();
                textEmail.Clear();
                textBloodGroup.ResetText();
                textCity.Clear();
                textAddress.Clear();
            }
        }

        private void DeleteDonor_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            if(textDonorID.Text != "")
            {
                query = "select * from newDonor where did = "+textDonorID.Text+"";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    textName.Text = ds.Tables[0].Rows[0][1].ToString();
                    textFather.Text = ds.Tables[0].Rows[0][2].ToString();
                    textMother.Text = ds.Tables[0].Rows[0][1].ToString();
                    textMobile.Text = ds.Tables[0].Rows[0][3].ToString();
                    textDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                    textMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                    textGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    textEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                    textBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                    textCity.Text = ds.Tables[0].Rows[0][9].ToString();
                    textAddress.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textDonorID.Clear();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK);
            {
                query = "delete from newDonor where did = "+textDonorID.Text+"";
                fn.setDate(query);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textDonorID.Clear();
        }
    }
}
