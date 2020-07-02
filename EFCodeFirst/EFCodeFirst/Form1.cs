using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirst
{
    public partial class Form1 : Form
    {
         List<Employee> emp = Employee.getAll();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Employees";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Salary
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // THIS IS THE ADD BUTTON
            try
            {
                using (var db = new CodeFirstContext())
                {
                    Employee objEmployee = new Employee();
                    objEmployee.Name = textBox2.Text;
                    objEmployee.Salary = int.Parse(textBox3.Text);
                    objEmployee.JobTitle = textBox4.Text;
                    db.Employees.Add(objEmployee);
                    db.SaveChanges();
                }
                MessageBox.Show("New employee has been added to the database.", "Success!");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops - Something went wrong.");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Name
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Job Title
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete",buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int delete = listBox1.SelectedIndex;
                    var employee = emp[delete];
                    using (var db = new CodeFirstContext())
                    {
                        db.Employees.Attach(employee);
                        db.Employees.Remove(employee);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to Delete - Contact your administrator");
                }
            }
            listBox1.DataSource = Employee.displayEmployees();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Employee.displayEmployees();
            label13.Text = "$" + Employee.totalSalary() + ".00";
            label14.Text = Employee.total();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int income = int.Parse(textBox1.Text);
                int salaries = int.Parse(Employee.totalSalary());
                string total = (income - salaries).ToString();
                if (income > salaries)
                {
                    label12.Text = "$" + total + ".00";
                }
                else
                {
                    MessageBox.Show("You may want to consider lowering your expenses or raising your income.", "DANGER");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please try again.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
