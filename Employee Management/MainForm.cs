using System.Diagnostics.Eventing.Reader;

namespace fileor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NumOfRec.Visible = false;
            countRec.Visible = false;

            if (Info.filename != "-1" && Info.filename != "")
            {
                filelabel.Text = Info.filename;
                NumOfRec.Visible = true;
                countRec.Visible = true;
                countRec.Text = Info.culc_count().ToString();
            }

            filetxtbox.ReadOnly = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Info.selectfile();
            if (Info.filename == "-1" || Info.filename == "") return;
            File.Delete(Info.filename);
            MessageBox.Show("File is deleted successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Info.filename = "";
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            Info.crtfile();

            if (Info.filename == "" || Info.filename == "-1") return;
            if (File.Exists(Info.filename))
            { MessageBox.Show("File Exist", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                var file = File.Create(Info.filename);

                MessageBox.Show("File is Created successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //filelabel.Visible = true;
                //filetxtbox.Visible = true
                filetxtbox.Text = Info.filename;
                NumOfRec.Visible = true;
                countRec.Visible = true;
                countRec.Text = Info.culc_count().ToString();
                file.Close();
            }

        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            Info.selectfile();
            if (Info.filename == "-1") return;
            filelabel.Visible = true;
            filetxtbox.Visible = true;
            filetxtbox.Text = Info.filename;
            NumOfRec.Visible = true;
            countRec.Visible = true;
            countRec.Text = Info.culc_count().ToString();


        }

        private void veiwAllEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Info.filename == "")
            { MessageBox.Show("please select a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            this.Hide();
            var allEmp = new datagrid();
            allEmp.ReturnData();
            allEmp.Show();
            //var allEmpnew = new ShowAllEmp();
            //allEmpnew.ReturnData();
            //allEmpnew.Show();
        }
        public bool fileselected()
        {
            return Info.filename != "" && Info.filename != "-1";
        }
        public void errorfile()
        {
            MessageBox.Show("please select a file", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
        }
        private void addAnEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileselected())
            { errorfile(); return; }
            this.Hide();
            new insertform().Show();
        }

        private void searchForEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileselected())
            { errorfile(); return; }
            this.Hide();
            new search().Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
