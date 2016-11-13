using HospitalDb;
using HospitalDb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHospital
{
    public partial class Hospital : Form
    {

        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string address = string.Empty;
        private string email = string.Empty;
        private string dateOfBird = string.Empty;
        private bool hasMedicalInsurance;

        public Hospital()
        {
            InitializeComponent();

        }


        public HPContext context = new HPContext();
        public int Id;
        public string name = string.Empty;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Id = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = context.Patients.FirstOrDefault(x => x.Id == Id).FirstName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            form.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                hasMedicalInsurance = true;
            }
            else
            {
                hasMedicalInsurance = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\VALENTIN\Desktop\b.jpg");
            pictureBox1.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            dateOfBird = textBox8.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox5.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            address = textBox3.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            email = textBox9.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Email = email,
                DateOfBirth = DateTime.Parse(dateOfBird),
                HasMedicalInsurance = hasMedicalInsurance
            };
            context.Patients.AddOrUpdate(p => p.Email, patient);
            context.SaveChanges();

        }
    }
}
