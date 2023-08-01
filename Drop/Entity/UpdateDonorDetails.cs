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
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textDonorID.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textDonorID.Text.ToString());
            String query = "select * from newDonor where did = " +id+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count !=0)
            {
                textName.Text = ds.Tables[0].Rows[0][1].ToString();
                textFather.Text = ds.Tables[0].Rows[0][2].ToString();
                textMother.Text = ds.Tables[0].Rows[0][3].ToString();
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
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textDonorID_TextChanged(object sender, EventArgs e)
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String query = "update newDonor set dname = '"+textName.Text+"', fname = '"+textFather.Text+"', maname = '"+textMother.Text+"', dob = '"+textDOB.Text+"', mobile = '"+textMobile.Text+"', gender = '"+textGender.Text+ "', email = '"+textEmail.Text+"', bloodgroup = '"+textBloodGroup.Text+"', city = '"+textCity.Text+"', daddress = '"+textAddress.Text+"' where did = '"+textDonorID.Text+"' ";
            fn.setDate(query);
            UpdateDonorDetails_Load(this, null);
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            textDonorID.Clear();
        }
    }
}
