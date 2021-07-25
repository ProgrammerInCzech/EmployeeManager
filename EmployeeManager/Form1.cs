using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        StreamWriter sw = new StreamWriter("Employee.txt");
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            if(TxtName.Text == ""|| TxtSurname.Text == "" || ComBoxJob.Text == "")
            {
                Label[] Required = { LblRequired1, LblRequired2 };
                for (int i = 0; i <= 1; i++)
                {
                    Required[i].Visible = true;
                }
            }
            else
            {

                if(ComBoxJob.SelectedIndex == 0)
                {
                    try
                    {
                        Developer Dev = new Developer(ComBoxLevel.Text, TxtName.Text, TxtSurname.Text, txtTitle.Text);
                        string value = Dev.Level(ComBoxLevel.Text);
                        LblLevel.Text = "Level: " + ComBoxLevel.Text + " has c. " + value + " Kč";
                        MessageBox.Show("Employee added", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ComBoxEmployee.Items.Add(Dev.Title + Dev.Name + Dev.Surname);
                        sw.WriteLine(Dev.Title + Dev.Name + Dev.Surname);
                        sw.Flush();
                    
                    }
                    catch
                    {
                        MessageBox.Show("Error 0x01 \n Adding developer failed","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                          
                }
                if(ComBoxJob.SelectedIndex == 1)
                {
                    try
                    {
                        Administrators Admin = new Administrators(ComBoxLevel.Text, TxtName.Text, TxtSurname.Text, txtTitle.Text);
                        string value = Admin.Level(ComBoxLevel.Text);
                        LblLevel.Text = "Level: " + ComBoxLevel.Text + " has c. " + value + " Kč";
                        MessageBox.Show("Employee added", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ComBoxEmployee.Items.Add(Admin.Title + Admin.Name + Admin.Surname);
                        sw.WriteLine(Admin.Title + Admin.Name + Admin.Surname);
                        sw.Flush();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Error 0x02 \n Adding administrator failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(ComBoxJob.SelectedIndex == 2 || ComBoxJob.SelectedIndex == 3)
                {
                    try
                    {
                        ITandOthers ITOthers = new ITandOthers(TxtName.Text, TxtSurname.Text, txtTitle.Text);
                        ComBoxEmployee.Items.Add(ITOthers.Title + ITOthers.Name + ITOthers.Surname);
                        MessageBox.Show("Employee added", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LblLevel.Text = "Level: " + ComBoxLevel.Text + " has c. " + " 25000 Kč";
                        sw.WriteLine(ITOthers.Title + ITOthers.Name + ITOthers.Surname);
                        sw.Flush();
                    }
                    catch
                    {
                        MessageBox.Show("Error 0x03 \n Adding emploeeye failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
             
            }
           
        }
 
        private void TmrCheck_Tick(object sender, EventArgs e)
        {
            if(ComBoxJob.SelectedIndex == 2 || ComBoxJob.SelectedIndex == 3)
            {
                ComBoxLevel.Enabled = false;
            }
            else
            {
                ComBoxLevel.Enabled = true;
            }

            LblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnExtract_Click(object sender, EventArgs e)
        {
            Process.Start("Employee.txt");
        }


        /*
         * Nedokočená myšlenka
         * Metoda s návrátovou hodnout měla sloužit pouze na to, aby se zjistilo, zda soubor existuje či nikoli
         
        public void Files()
        {
            if (File.Exists("Employee.txt"))
            {

            }
            else
            {
                
            }
        }
        */
    }
}
