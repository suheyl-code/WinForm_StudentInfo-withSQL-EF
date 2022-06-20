using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo_withDatabase
{
    public partial class Form1 : Form
    {
        StudentDal _studentDal = new StudentDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxUpdate.Visible = true;
            tbxNameUpdate.Text = dgwStudents.CurrentRow.Cells[1].Value.ToString();
            tbxAgeUpdate.Text = dgwStudents.CurrentRow.Cells[2].Value.ToString();
            tbxPhoneUpdate.Text = dgwStudents.CurrentRow.Cells[3].Value.ToString();
            tbxMarkUpdate.Text = dgwStudents.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = false;
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentDal.GetAll(); 
        }

        private void CheckDataInput(TextBox textBox)
        {
            
            if (!int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show("Mark should be an Integer between 0 and 100");
                Environment.Exit(1);
            }
            else
            {
                if(textBox == tbxMark || textBox == tbxMarkUpdate)
                {
                    int textboxRecord = Convert.ToInt32(textBox.Text);
                    if (textboxRecord > 100 || textboxRecord < 0)
                    {
                        MessageBox.Show("Mark cannot be negative or above 100!");
                        Environment.Exit(1);
                    }
                }
                else if(textBox == tbxAge || textBox == tbxAgeUpdate)
                {
                    int textboxRecord = Convert.ToInt32(textBox.Text);
                    if (textboxRecord > 150 || textboxRecord < 0)
                    {
                        MessageBox.Show("Age cannot be negative or above 150!");
                        Environment.Exit(1);
                    }
                }
                

            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = false;
            CheckDataInput(tbxMark);
            CheckDataInput(tbxAge);
            _studentDal.Add(new Student
            {
                Name = tbxName.Text,
                Age = Convert.ToInt32(tbxAge.Text),
                PhoneNumber = tbxPhone.Text,
                Mark = Convert.ToSByte(tbxMark.Text)
            });
            LoadStudents();
            MessageBox.Show("Record Added!");
            tbxName.Text = "";
            tbxAge.Text = "";
            tbxPhone.Text = "";
            tbxMark.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckDataInput(tbxMarkUpdate);
            CheckDataInput(tbxAgeUpdate);
            _studentDal.Update(new Student
            {
                ID = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Age = Convert.ToInt32(tbxAgeUpdate.Text),
                PhoneNumber = tbxPhoneUpdate.Text,
                Mark = Convert.ToSByte(tbxMarkUpdate.Text)
            });
            LoadStudents();
            MessageBox.Show("Record Updated!");
            groupBoxUpdate.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are You Sure?", "Caution", MessageBoxButtons.OKCancel);
            if(message == DialogResult.OK)
            {
                _studentDal.Delete(new Student
                {
                    ID = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value),
                    Name = tbxNameUpdate.Text,
                    Age = Convert.ToInt32(tbxAgeUpdate.Text),
                    PhoneNumber = tbxPhoneUpdate.Text,
                    Mark = Convert.ToSByte(tbxMarkUpdate.Text)
                });
                LoadStudents();
                MessageBox.Show("Record Deleted!");
            }
            groupBoxUpdate.Visible = false;
            
        }
    }
}
