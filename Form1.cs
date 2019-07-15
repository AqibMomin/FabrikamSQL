using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FabrikamSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = DataLayer.DB.ConnectionString;
            DataLayer.DB.ApplicationName = "Fabrikam Student Data Tool";
            DataLayer.DB.ConnectionTimeout = 30;
            SqlConnection conn = DataLayer.DB.GetSqlConnection();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            DataLayer.Students students = new DataLayer.Students();
            DataLayer.Student student = students.GetStudent(FName.Text);

            studentID.Text = student.StudentId.ToString();
            LName.Text = student.LastName;
            Major.Text = student.Major;

            if(student.StudentId == 0 || student.LastName == null || student.Major == null)
            MessageBox.Show("Oops! Please check Student Name and try again.");
        }
        private void ClrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Students students = new DataLayer.Students();
                studentID.Text = "";
                FName.Text = "";
                LName.Text = "";
                Major.Text = "";
            }
            catch
            {
                MessageBox.Show("Nothing to clear!");
            }
        }
    }
}