using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson9_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.studentdatabase' table. You can move, or remove it, as needed.
            this.studentdatabaseTableAdapter.Fill(this.studentDBDataSet.Student);
            {
                var db = new dbLesson9Entities1();
                var select = from s in db.Students select s;
                String st = "";
                foreach (var item in select)
                {
                    st = st + "ID: " + item.studentID.ToString() + System.Environment.NewLine;
                    st = st + "Name: " + item.studentName.ToString() +
                    System.Environment.NewLine;
                    st = st + "Gender: " + item.studentGender.ToString() +
                    System.Environment.NewLine;
                    st = st + "Address: " + item.Address_.ToString() + System.Environment.NewLine;
                }
                this.textBox1.Text = st;
                
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            {
                var db = new dbLesson9Entities1();
                Student aStudent;
                aStudent = db.Students.Where(d => d.studentID == 5).First() as Student;
                aStudent.studentGender = "Nguyen Van Linh";
                db.SaveChanges();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var db = new dbLesson9Entities1();
            Student aStudent;
            if (db.Students.Find(5) == null)
            {
                aStudent = new Student();
                aStudent.studentID = 5;
                aStudent.studentName = "Nguyen Tri Dung";
                aStudent.studentGender = "Male";
                aStudent.Address_ = " 11 Le Lai";
                db.Students.Add(aStudent);
                db.SaveChanges();
            }
            Form1_Load(sender, e);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var db = new dbLesson9Entities1();
            Student aStudent;
            aStudent = db.Students.Where(d => d.studentID == 5).First() as Student;
            db.Students.Remove(aStudent);
            db.SaveChanges();
            Form1_Load(sender , e); 
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            using (dbLesson9Entities1 db = new dbLesson9Entities1())
            {
                Student aStudent;
                // add
                aStudent = new Student();
                aStudent.studentID = 5;
                aStudent.studentName = "Nguyen Tri Dung";
                aStudent.studentGender = "Male";
                aStudent.Address_ = " 11 Le Lai";
                db.Students.Add(aStudent);
                // update
                aStudent = db.Students.Where(d => d.studentID == 4).First() as Student;
                aStudent.studentName = "Nguyen Van Linh";
                //delete
                aStudent = db.Students.Where(d => d.studentID == 4).First() as Student;
                db.Students.Remove(aStudent);
                db.SaveChanges();
            }
            Form1_Load(sender, e);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
