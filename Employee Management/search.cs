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

namespace fileor
{
    public partial class search : Form
    {
        public static employee empupdate;
        public static employee empupdsrch;
        public long recordstart;
        public search()
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
        bool validate(employee emp)
        {
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

            string id = empidtextboxs.Text;
            string fname = fnametextboxs.Text;
            string lname = lnametextboxs.Text;
            string gender = gendertextboxs.Text;
            string address = addresstextboxs.Text;
            string tel = teltextboxs.Text;
            string position = positiontextboxs.Text;
            string department = departmenttextboxs.Text;
            string manager = managertextboxs.Text;
            string salary = salarytextboxs.Text;

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
        public employee readfromfile(ref BinaryReader br)
        {
            recordstart = br.BaseStream.Position;
            string Id = br.ReadString();//id
            string fname = br.ReadString();//fname
            string lname = br.ReadString();//lname
            string gender = br.ReadString();//gender
            string address = br.ReadString();//address
            string tel = br.ReadString();//tel
            string pos = br.ReadString();//pos
            string department = br.ReadString();//department
            string manager = br.ReadString();//manager
            string salary = br.ReadString();//salary
            employee retemp = new employee(Id, fname, lname, gender, address, tel, pos, department, manager, salary);
            retemp = Hashing.DecryptEmp(retemp);
            return retemp;
        }
        public bool isfound(string id)
        {

            FileStream file = new FileStream(Info.filename, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(file);
            BinaryWriter bw = new BinaryWriter(file);

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                employee recemp = readfromfile(ref br);//read one record
                if (recemp.id == id)
                {
                    empupdsrch = recemp;
                    file.Close();
                    br.Close();
                    bw.Close();
                    return true;
                }
            }
            file.Close();
            br.Close();
            bw.Close();
            return false;
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string id = empidtextboxs.Text;

            if (id.Trim() == "")
            {
                MessageBox.Show("the id is empty, please write an id", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isfound(id))
            {
                printtouser(empupdsrch);
                MessageBox.Show($"your employee with id={id} is found", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClearFields();
                MessageBox.Show($"your employee with id ={id} is not found", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearFields()
        {
            empidtextboxs.Text = "";
            fnametextboxs.Text = "";
            lnametextboxs.Text = "";
            gendertextboxs.Text = "";
            addresstextboxs.Text = "";
            teltextboxs.Text = "";
            positiontextboxs.Text = "";
            departmenttextboxs.Text = "";
            managertextboxs.Text = "";
            salarytextboxs.Text = "";
        }
        public void printtouser(employee emp)
        { 
            empidtextboxs.Text = emp.id;//id
            fnametextboxs.Text = emp.fname;//fname
            lnametextboxs.Text = emp.lname;//lname
            gendertextboxs.Text = emp.gender;//gender
            addresstextboxs.Text = emp.address;//addreaa
            teltextboxs.Text = emp.tel;//tel
            positiontextboxs.Text = emp.position;//pos
            departmenttextboxs.Text = emp.department;//department
            managertextboxs.Text = emp.manager;//manager
            salarytextboxs.Text = emp.salary;//salary
        }
        public void updateonfile()
        {

            FileStream file = new FileStream(Info.filename, FileMode.Open, FileAccess.ReadWrite);

            BinaryWriter br = new BinaryWriter(file);
            br.Seek((int)recordstart, SeekOrigin.Begin);
            br.Write(empupdate.id);
            br.Write(empupdate.fname);
            br.Write(empupdate.lname);
            br.Write(empupdate.gender);
            br.Write(empupdate.address);
            br.Write(empupdate.tel);
            br.Write(empupdate.position);
            br.Write(empupdate.department);
            br.Write(empupdate.manager);
            br.Write(empupdate.salary);
            br.Close();
            file.Close();
        }
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            empupdate = getdata();
            if (isfound(empupdate.id))
            {
                if (!validate(empupdate)) { return; }
                empupdate = Hashing.EncryptEmp(empupdate);
                updateonfile();
                MessageBox.Show("record updated successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empupdate = Hashing.DecryptEmp(empupdate);
                printtouser(empupdate); 
            }
            else
            {
                MessageBox.Show("ID not found", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
