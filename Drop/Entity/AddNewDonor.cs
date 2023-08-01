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
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" && textFatherName.Text != "" && textMotherName.Text != "" && textDOB.Text != "" && textMobile.Text != "" && textGender.Text != "" && textEmail.Text != "" && textBloodGroup.Text != "" && textCity.Text != "" && textAddress.Text != "")
            {
                String dname = textName.Text;
                String fname = textFatherName.Text;
                String maname = textMotherName.Text;
                String dob = textDOB.Text;
                Int64 mobile = Int64.Parse(textMobile.Text);
                String gender = textGender.Text;
                String email = textEmail.Text;
                String bloodgroup = textBloodGroup.Text;
                String city = textCity.Text;
                String daddress = textAddress.Text;

                String query = "insert into newDonor(dname,fname,maname,dob,mobile,gender,email,bloodgroup,city,daddress) values ('"+dname+"','"+fname+ "','"+maname+"','"+dob+"','"+mobile+"','"+gender+"','"+email+"','"+bloodgroup+"','"+city+"','"+daddress+"')";
                fn.setDate(query);
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textFatherName.Clear();
            textMotherName.Clear();
            textDOB.ResetText();
            textMobile.Clear();
            textGender.ResetText();
            textEmail.Clear();
            textBloodGroup.ResetText();
            textCity.Clear();
            textAddress.Clear();
        }
    }
}
