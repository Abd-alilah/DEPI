namespace EmployeeDataApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            cmbName = new ComboBox();
            txtSearch = new TextBox();
            txtJob = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            btnShow = new Button();
            btnUpload = new Button();
            dgvEmployees = new DataGridView();
            picEmployee = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 115);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Job";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 148);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 206);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 237);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Search";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(113, 264);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(77, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(196, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(26, 229);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(208, 28);
            cmbName.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(349, 266);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(293, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(109, 112);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(198, 27);
            txtJob.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 27);
            txtName.TabIndex = 14;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(109, 145);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(198, 27);
            txtSalary.TabIndex = 15;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(661, 265);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 16;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(549, 185);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(77, 29);
            btnUpload.TabIndex = 17;
            btnUpload.Text = "...";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Bottom;
            dgvEmployees.Location = new Point(0, 321);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(800, 201);
            dgvEmployees.TabIndex = 18;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // picEmployee
            // 
            picEmployee.Location = new Point(472, 29);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(232, 139);
            picEmployee.TabIndex = 19;
            picEmployee.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(picEmployee);
            Controls.Add(dgvEmployees);
            Controls.Add(btnUpload);
            Controls.Add(btnShow);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtJob);
            Controls.Add(txtSearch);
            Controls.Add(cmbName);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEdit;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox cmbName;
        private TextBox txtSearch;
        private TextBox txtJob;
        private TextBox txtName;
        private TextBox txtSalary;
        private Button btnShow;
        private Button btnUpload;
        private DataGridView dgvEmployees;
        private PictureBox picEmployee;
    }
}
