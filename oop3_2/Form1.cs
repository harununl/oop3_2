using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class personnel
        {
            public string name { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public int Age { get; set; }

            
            public int YY { get; set; }


            public personnel() { YY = 0; }
            
            public personnel(int yy)
            {
               
               
                this.YY = yy;
            }

           
            public int calcAge()
            {
                Age = 2022 - YY;
                return Age;
               

            }

        }
        public class employee : personnel
        {
            public int ID { get; set; }
          
            public double hour { get; set; }
            public double perHourSalary { get; set; }
            public double YS { get; set; }

            public employee() {hour = 0; perHourSalary = 0; }
            public employee(double hour, double perHourSalary) { this.hour = hour; this.perHourSalary = perHourSalary; }

            public double calcSalary()
            {
                YS = (hour * perHourSalary * 20 * 12);
                return YS;
            }
           
            
        }

        public class student : personnel
        {
            public int RegistNo { get; set; }

            public double GPA { get; set; }

            public double  MTE { get; set; }         
            public double FE { get; set; }

            public student() {   MTE = 0; FE = 0; }
            public student(double MTE, double FE) {  this.FE = FE; this.MTE = MTE; }
           
             public double calcGpa()
            {
                GPA = ((MTE * 0.40) + (FE * 0.60))/25;
                

                if (GPA >= 3.40 && GPA <= 4.00)
                    MessageBox.Show("YOU GOT A");
                
                else if (GPA >= 2.80 && GPA <= 3.39)
                    MessageBox.Show("YOU GOT B");
               
                else if (GPA >= 2.40 && GPA <= 2.79)
                    MessageBox.Show("YOU GOT C");
               
                else if (GPA >= 2.00 && GPA <= 2.39)
                    MessageBox.Show("YOU GOT D");
               
                else 
                    MessageBox.Show("YOU GOT F");

                return GPA;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double hour;
            double perHour;
            double ıd;
            double midterm;
            double final;
            double registNo;
            string name;
            string midName;
            string lastName;
            
            int year;


            double.TryParse(textBox1.Text,out ıd);
            double.TryParse(textBox2.Text,out hour);
            double.TryParse(textBox3.Text, out perHour);
            double.TryParse(textBox7.Text, out midterm);
            double.TryParse(textBox8.Text,out final);
            double.TryParse(textBox9.Text,out registNo);
             name = Convert.ToString(textBox4.Text);
            midName = Convert.ToString(textBox5.Text);
            lastName = Convert.ToString(textBox6.Text);
          
            year = Convert.ToInt32(textBox10.Text);



            personnel prs;
            prs = new personnel(year);

           

            employee emp;
            emp = new employee(hour,perHour);

            student std;
            std = new student(midterm, final);

            double GPA = std.calcGpa();

           

            double AGE = prs.calcAge();

            double ys = emp.calcSalary();

            richTextBox1.Text += "   ---PERSONNEL---   " + Environment.NewLine;
            richTextBox1.Text += "NAME :" + name + Environment.NewLine;
            richTextBox1.Text += "MIDDLE NAME :" + midName + Environment.NewLine;
            richTextBox1.Text += "LAST NAME :" + lastName + Environment.NewLine;
            


            richTextBox1.Text += "    ---EMPLOYEE---    " + Environment.NewLine;
            richTextBox1.Text += "ID :" + ıd.ToString() + Environment.NewLine;
            richTextBox1.Text += "YEARLY SALARY :" + ys.ToString() + Environment.NewLine;

            richTextBox1.Text += "   ---STUDENT---   " + Environment.NewLine;
            richTextBox1.Text += "REGİSTIRATION :" + registNo.ToString() + Environment.NewLine;
            richTextBox1.Text += " GPA :" + GPA.ToString() + Environment.NewLine;
            richTextBox1.Text += "AGE :" + AGE.ToString() + Environment.NewLine;

        }
    }
}
