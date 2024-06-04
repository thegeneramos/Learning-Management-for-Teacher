using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class StudentRecords : Form
    {
        List<Student> lststudents = new List<Student>();
        public StudentRecords()
        {
            InitializeComponent();
        }

        private void StudentRecords_Load(object sender, EventArgs e)
        {
            lststudents.Add(new Student() { Sid = 1, Name = "Ted Mosby", GPA = 3.2F, });
            lststudents.Add(new Student() { Sid = 2, Name = "Barney Stinson", GPA = 3.0F, });
            lststudents.Add(new Student() { Sid = 3, Name = "Robin Scherbatsky", GPA = 3.8F, });
            lststudents.Add(new Student() { Sid = 4, Name = "Marshall Eriksen", GPA = 4.0F, });
            lststudents.Add(new Student() { Sid = 5, Name = "Lily Aldrin", GPA = 3.1F, });
            lststudents.Add(new Student() { Sid = 6, Name = "Zoey Pierson", GPA = 3.9F, });
            lststudents.Add(new Student() { Sid = 7, Name = "Gary Blauman", GPA = 3.5F, });
            lststudents.Add(new Student() { Sid = 8, Name = "Quinn Garvey", GPA = 3.0F, });
            lststudents.Add(new Student() { Sid = 9, Name = "Sandy Rivers", GPA = 3.1F, });
            lststudents.Add(new Student() { Sid = 10, Name = "Brad Morris", GPA = 3.8F, });
            lststudents.Add(new Student() { Sid = 11, Name = "James Stinson", GPA = 3.4F, });
            lststudents.Add(new Student() { Sid = 12, Name = "John Krasinski", GPA = 3.7F, });
            lststudents.Add(new Student() { Sid = 13, Name = "Creed Bratton", GPA = 2.9F, });
            lststudents.Add(new Student() { Sid = 14, Name = "Jenna Fischer", GPA = 3.3F, });
            lststudents.Add(new Student() { Sid = 15, Name = "Angela Kinsey", GPA = 3.8F, });
            stuGrid.DataSource = lststudents;
            grpStu.Visible = true;
            this.Show();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtName.Text != string.Empty && txtGPA.Text != string.Empty)
            {
                var newStu = new Student();
                newStu.Sid = int.Parse(txtId.Text);
                newStu.Name = txtName.Text;
                newStu.GPA = float.Parse(txtGPA.Text);
                lststudents.Add(newStu);
                MessageBox.Show("New Student Added!");
                RefreshData();
            }
        }
        private void RefreshData()
        {
            txtId.Clear();
            txtName.Clear();
            txtGPA.Clear();
            stuGrid.DataSource = null;
            stuGrid.DataSource = lststudents;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to EXPEL selected student?", "HOLD ON", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lststudents.RemoveAt(stuGrid.CurrentRow.Index);
            }
            RefreshData();
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (txtId.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtId.Text, out val))
                {
                    MessageBox.Show("Please enter Student ID");
                    e.Cancel = true;
                    txtId.Clear();
                }
                else if (Int32.Parse(txtId.Text) == 16 || Int32.Parse(txtId.Text) > 500)
                {
                    MessageBox.Show("Please enter a new Student ID");
                    e.Cancel = true;
                    txtId.Clear();
                }

            }
        }

        private void txtGPA_Validating(object sender, CancelEventArgs e)
        {
            if (txtGPA.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtGPA.Text, out val))
                {
                    MessageBox.Show("Please enter Student GPA");
                    e.Cancel = true;
                    txtGPA.Clear();
                }
                else if (float.Parse(txtGPA.Text) == 0f || float.Parse(txtGPA.Text) > 4.0f)
                {
                    MessageBox.Show("Please enter a new Student GPA");
                    e.Cancel = true;
                    txtGPA.Clear();
                }

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            string path = @"C:\PCAD11\Assignments\20483\Assignment 4.2\";
            //string filename = Console.ReadLine();
            string filename = path + "SelectedStudent.txt";
            StreamWriter streamWriter = null;
            if (!File.Exists(filename))
            {
                File.Create(filename);
                
            }
            else
            {
                //File.AppendAllText(filename, "Text");
                File.WriteAllText(filename, GetHighestGPA());
                //MessageBox.Show(stuGrid.SelectedCells.ToString());
            }
            File.WriteAllText(filename, GetHighestGPA());

        }
        public string GetHighestGPA()
        {
            lststudents.Sort(new GPAComparison());
            string beststudent= $"Best student in Infinite Academy is: Student ID: {lststudents[0].Sid}, Student Name: {lststudents[0].Name}, with a GPA of: {lststudents[0].GPA}";
            return beststudent;
        }
    }
}
