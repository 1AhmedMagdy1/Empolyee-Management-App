namespace fileor
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            createbtn = new Button();
            deletebtn = new Button();
            selectbtn = new Button();
            filetxtbox = new TextBox();
            filelabel = new Label();
            menuStrip1 = new MenuStrip();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            addAnEmployeeToolStripMenuItem = new ToolStripMenuItem();
            veiwAllEmployeesToolStripMenuItem = new ToolStripMenuItem();
            searchForEmployeeToolStripMenuItem = new ToolStripMenuItem();
            Exit = new Button();
            NumOfRec = new Label();
            countRec = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // createbtn
            // 
            createbtn.Location = new Point(133, 277);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(94, 29);
            createbtn.TabIndex = 0;
            createbtn.Text = "Create";
            createbtn.UseVisualStyleBackColor = true;
            createbtn.Click += createbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackgroundImage = (Image)resources.GetObject("deletebtn.BackgroundImage");
            deletebtn.Location = new Point(434, 277);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 1;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // selectbtn
            // 
            selectbtn.Location = new Point(275, 277);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(94, 29);
            selectbtn.TabIndex = 2;
            selectbtn.Text = "Select";
            selectbtn.UseVisualStyleBackColor = true;
            selectbtn.Click += selectbtn_Click;
            // 
            // filetxtbox
            // 
            filetxtbox.Location = new Point(111, 168);
            filetxtbox.Name = "filetxtbox";
            filetxtbox.Size = new Size(258, 27);
            filetxtbox.TabIndex = 3;
            // 
            // filelabel
            // 
            filelabel.AutoSize = true;
            filelabel.Location = new Point(12, 171);
            filelabel.Name = "filelabel";
            filelabel.Size = new Size(72, 20);
            filelabel.TabIndex = 4;
            filelabel.Text = "FileName";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { employeesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAnEmployeeToolStripMenuItem, veiwAllEmployeesToolStripMenuItem, searchForEmployeeToolStripMenuItem });
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(95, 24);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
            // 
            // addAnEmployeeToolStripMenuItem
            // 
            addAnEmployeeToolStripMenuItem.Name = "addAnEmployeeToolStripMenuItem";
            addAnEmployeeToolStripMenuItem.Size = new Size(227, 26);
            addAnEmployeeToolStripMenuItem.Text = "Add an Employee";
            addAnEmployeeToolStripMenuItem.Click += addAnEmployeeToolStripMenuItem_Click;
            // 
            // veiwAllEmployeesToolStripMenuItem
            // 
            veiwAllEmployeesToolStripMenuItem.Name = "veiwAllEmployeesToolStripMenuItem";
            veiwAllEmployeesToolStripMenuItem.Size = new Size(227, 26);
            veiwAllEmployeesToolStripMenuItem.Text = "Veiw All Employees";
            veiwAllEmployeesToolStripMenuItem.Click += veiwAllEmployeesToolStripMenuItem_Click;
            // 
            // searchForEmployeeToolStripMenuItem
            // 
            searchForEmployeeToolStripMenuItem.Name = "searchForEmployeeToolStripMenuItem";
            searchForEmployeeToolStripMenuItem.Size = new Size(227, 26);
            searchForEmployeeToolStripMenuItem.Text = "search for employee";
            searchForEmployeeToolStripMenuItem.Click += searchForEmployeeToolStripMenuItem_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(595, 277);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // NumOfRec
            // 
            NumOfRec.AutoSize = true;
            NumOfRec.Location = new Point(453, 171);
            NumOfRec.Name = "NumOfRec";
            NumOfRec.Size = new Size(140, 20);
            NumOfRec.TabIndex = 7;
            NumOfRec.Text = "Number Of Records";
            // 
            // countRec
            // 
            countRec.AutoSize = true;
            countRec.Location = new Point(612, 171);
            countRec.Name = "countRec";
            countRec.Size = new Size(17, 20);
            countRec.TabIndex = 8;
            countRec.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(countRec);
            Controls.Add(NumOfRec);
            Controls.Add(Exit);
            Controls.Add(filelabel);
            Controls.Add(filetxtbox);
            Controls.Add(selectbtn);
            Controls.Add(deletebtn);
            Controls.Add(createbtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createbtn;
        private Button deletebtn;
        private Button selectbtn;
        private TextBox filetxtbox;
        private Label filelabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem addAnEmployeeToolStripMenuItem;
        private ToolStripMenuItem veiwAllEmployeesToolStripMenuItem;
        private ToolStripMenuItem searchForEmployeeToolStripMenuItem;
        private Button Exit;
        private Label NumOfRec;
        private Label countRec;
    }
}
