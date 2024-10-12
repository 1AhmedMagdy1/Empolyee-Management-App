using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileor
{
    public partial class insertform : Form
    {
        public insertform()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public bool IsString2ToInt(string input)
        {
            if (int.TryParse(input, out int result)) // Try to parse the string to an integer
            {
                if (result > 0) // Check if the resulting integer is greater than zero
                {
                    return true; // The string can be converted to an integer and is greater than zero
                }
            }

            return false; // The string cannot be converted to an integer or is not greater than zero
        }

        bool validate(employee emp) {
            if (!IsString2ToInt(emp.id))
            {
                MessageBox.Show("id must be integer and greater than 0", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (!IsString2ToInt(emp.salary))
            {
                MessageBox.Show("salary must be integer and greater than 0", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (emp.fname == "" || emp.gender == "" || emp.position == "" || emp.salary == "" || emp.manager == "")
            {
                MessageBox.Show("Fill the neccesarry fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private employee getdata()
        {

            // int id = int.Parse(empidtextbox.Text);
            // no need for Pading Right because the length of string after encryption is 24; 

            string id = empidtextbox.Text;
           
            string fname = fnametextbox.Text;
            string lname = lnametextbox.Text;
            string gender = gendertextbox.Text;
            string address = addresstextbox.Text;
            string tel = teltextbox.Text;
            string position = positiontextbox.Text;
            string department = departmenttextbox.Text;
            string manager = managertextbox.Text;
            string salary = salarytextbox.Text;

            // take fixed length from text fields;
            fname = fname.Substring(0, Math.Min(15, fname.Length));
            lname = lname.Substring(0, Math.Min(15, lname.Length));
            gender = gender.Substring(0, Math.Min(1, gender.Length));
            address = address.Substring(0, Math.Min(24, address.Length));
            tel = tel.Substring(0, Math.Min(11, tel.Length));
            position = position.Substring(0, Math.Min(15, position.Length));
            department = department.Substring(0, Math.Min(15, department.Length));
            manager = manager.Substring(0, Math.Min(15, manager.Length));

            // return data;
            employee retemp = new employee(id, fname, lname, gender, address, tel, position, department, manager, salary);
            return retemp;

        }
        public void insert(employee emp)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(Info.filename, FileMode.Open, FileAccess.Write));
            int len = (int)bw.BaseStream.Length;
            bw.Seek(len, SeekOrigin.Begin);
            bw.Write(emp.id);
            bw.Write(emp.fname);
            bw.Write(emp.lname);
            bw.Write(emp.gender);
            bw.Write(emp.address);
            bw.Write(emp.tel);
            bw.Write(emp.position);
            bw.Write(emp.department);
            bw.Write(emp.manager);
            bw.Write(emp.salary);
            bw.Close();
        }
        private void insertbtn_Click(object sender, EventArgs e)
        {
            employee emp = getdata(); //collect data from user
            if (!validate(emp)) { return; }
            emp = Hashing.EncryptEmp(emp);
            insert(emp);//insert data in the file
            MessageBox.Show("record inserted successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
        }

        public void ClearFields()
        {
            empidtextbox.Text = "";
            fnametextbox.Text = "";
            lnametextbox.Text = "";
            gendertextbox.Text = "";
            addresstextbox.Text = "";
            teltextbox.Text = "";
            positiontextbox.Text = "";
            departmenttextbox.Text = "";
            managertextbox.Text = "";
            salarytextbox.Text = "";
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }
    }
}
