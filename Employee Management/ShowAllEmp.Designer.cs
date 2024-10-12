namespace fileor
{
    partial class ShowAllEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllEmp));
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            fName = new DataGridViewTextBoxColumn();
            lName = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            tele = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            positoin = new DataGridViewTextBoxColumn();
            depart = new DataGridViewTextBoxColumn();
            manager = new DataGridViewTextBoxColumn();
            salary = new DataGridViewTextBoxColumn();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, fName, lName, gender, tele, address, positoin, depart, manager, salary });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1302, 388);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // fName
            // 
            fName.HeaderText = "fName";
            fName.MinimumWidth = 6;
            fName.Name = "fName";
            fName.ReadOnly = true;
            fName.Width = 125;
            // 
            // lName
            // 
            lName.HeaderText = "lName";
            lName.MinimumWidth = 6;
            lName.Name = "lName";
            lName.ReadOnly = true;
            lName.Width = 125;
            // 
            // gender
            // 
            gender.HeaderText = "gender";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 125;
            // 
            // tele
            // 
            tele.HeaderText = "tele";
            tele.MinimumWidth = 6;
            tele.Name = "tele";
            tele.ReadOnly = true;
            tele.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 125;
            // 
            // positoin
            // 
            positoin.HeaderText = "positoin";
            positoin.MinimumWidth = 6;
            positoin.Name = "positoin";
            positoin.ReadOnly = true;
            positoin.Width = 125;
            // 
            // depart
            // 
            depart.HeaderText = "depart";
            depart.MinimumWidth = 6;
            depart.Name = "depart";
            depart.ReadOnly = true;
            depart.Width = 125;
            // 
            // manager
            // 
            manager.HeaderText = "manager";
            manager.MinimumWidth = 6;
            manager.Name = "manager";
            manager.ReadOnly = true;
            manager.Width = 125;
            // 
            // salary
            // 
            salary.HeaderText = "salary";
            salary.MinimumWidth = 6;
            salary.Name = "salary";
            salary.ReadOnly = true;
            salary.Width = 125;
            // 
            // Back
            // 
            Back.Location = new Point(1130, 409);
            Back.Name = "Back";
            Back.Size = new Size(148, 29);
            Back.TabIndex = 1;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // ShowAllEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1302, 450);
            Controls.Add(Back);
            Controls.Add(dataGridView1);
            Name = "ShowAllEmp";
            Text = "ShowAllEmp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn fName;
        private DataGridViewTextBoxColumn lName;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn tele;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn positoin;
        private DataGridViewTextBoxColumn depart;
        private DataGridViewTextBoxColumn manager;
        private DataGridViewTextBoxColumn salary;
        private Button Back;
    }
}