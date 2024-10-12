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
    public partial class datagrid : Form
    {
        Dictionary<string, employee> map = new Dictionary<string, employee>();
        public datagrid()
        {
            InitializeComponent();
        }

        private void datagrid_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add("4", "ahmed ", "magdy", "M", "egypt", "1544", "SW", "SWD", "none", "15000");
            //dataGridView1.Rows.Add("3", "ahmed", "magdy", "M", "egypt", "1544", "SW", "SWD", "none", "15000");
            //dataGridView1.Rows.Add("2", "ahmed ", "magdy", "M", "egypt", "1544", "SW", "SWD", "none", "15000");
            //dataGridView1.Rows.Add("1", "ahmed ", "magdy", "M", "egypt", "1544", "SW", "SWD", "none", "15000");
        }
        public void ReturnData()
        {
            FileStream file = new FileStream(Info.filename, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(file);
            BinaryWriter bw = new BinaryWriter(file);

            // read all file
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
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
                employee emp = new employee(Id, fname, lname, gender, address, tel, pos, department, manager, salary);
                emp = Hashing.DecryptEmp(emp);
                map.TryAdd(emp.id, emp);
            }

            br.Close();
            bw.Close();
            file.Close();

            var sortedMap = map.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in sortedMap)
            {
                object[] rowData = {item.Value.id, item.Value.fname, item.Value.lname,item.Value.gender,
            item.Value.tel, item.Value.address, item.Value.position,
            item.Value.department, item.Value.manager, item.Value.salary};

                dataGridView1.Rows.Add(rowData);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
