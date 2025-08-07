namespace WinFormsApp1
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
            txtName = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label3 = new Label();
            cmbStatus = new ComboBox();
            groupBox2 = new GroupBox();
            chkBodybuilding = new CheckBox();
            chkSwimming = new CheckBox();
            chkWatchTV = new CheckBox();
            chkFootball = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            progressEnglish = new ProgressBar();
            progressArabic = new ProgressBar();
            btnshow = new Button();
            groupBox3 = new GroupBox();
            btnpage = new Button();
            btnpreview = new Button();
            btnprint = new Button();
            rtbReport = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            dtpBirthDate = new DateTimePicker();
            numEnglish = new NumericUpDown();
            numArabic = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArabic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 67);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "birth day";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(32, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = " Gender :";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(133, 26);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(28, 26);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 189);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Mstatus :";
            label3.Click += label3_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "متزوج", "اعزب", "ارمل", "مطلق" });
            cmbStatus.Location = new Point(129, 189);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(192, 28);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkBodybuilding);
            groupBox2.Controls.Add(chkSwimming);
            groupBox2.Controls.Add(chkWatchTV);
            groupBox2.Controls.Add(chkFootball);
            groupBox2.Location = new Point(32, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 125);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Habits";
            // 
            // chkBodybuilding
            // 
            chkBodybuilding.AutoSize = true;
            chkBodybuilding.Location = new Point(160, 85);
            chkBodybuilding.Name = "chkBodybuilding";
            chkBodybuilding.Size = new Size(116, 24);
            chkBodybuilding.TabIndex = 3;
            chkBodybuilding.Text = "bodybulding";
            chkBodybuilding.UseVisualStyleBackColor = true;
            chkBodybuilding.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // chkSwimming
            // 
            chkSwimming.AutoSize = true;
            chkSwimming.Location = new Point(32, 85);
            chkSwimming.Name = "chkSwimming";
            chkSwimming.Size = new Size(101, 24);
            chkSwimming.TabIndex = 2;
            chkSwimming.Text = "Swimming";
            chkSwimming.UseVisualStyleBackColor = true;
            chkSwimming.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkWatchTV
            // 
            chkWatchTV.AutoSize = true;
            chkWatchTV.Location = new Point(160, 26);
            chkWatchTV.Name = "chkWatchTV";
            chkWatchTV.Size = new Size(88, 24);
            chkWatchTV.TabIndex = 1;
            chkWatchTV.Text = "Watch tv";
            chkWatchTV.UseVisualStyleBackColor = true;
            // 
            // chkFootball
            // 
            chkFootball.AutoSize = true;
            chkFootball.Location = new Point(32, 26);
            chkFootball.Name = "chkFootball";
            chkFootball.Size = new Size(86, 24);
            chkFootball.TabIndex = 0;
            chkFootball.Text = "Football";
            chkFootball.UseVisualStyleBackColor = true;
            chkFootball.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 376);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "English :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 412);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 7;
            label5.Text = "Arabic :";
            label5.Click += label5_Click;
            // 
            // progressEnglish
            // 
            progressEnglish.ForeColor = Color.LimeGreen;
            progressEnglish.Location = new Point(207, 374);
            progressEnglish.Name = "progressEnglish";
            progressEnglish.Size = new Size(186, 29);
            progressEnglish.TabIndex = 8;
            progressEnglish.Click += progressBar1_Click;
            // 
            // progressArabic
            // 
            progressArabic.ForeColor = Color.LimeGreen;
            progressArabic.Location = new Point(207, 412);
            progressArabic.Name = "progressArabic";
            progressArabic.Size = new Size(186, 29);
            progressArabic.TabIndex = 9;
            progressArabic.Click += progressBar2_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(129, 481);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(160, 29);
            btnshow.TabIndex = 12;
            btnshow.Text = "Show Result";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnpage);
            groupBox3.Controls.Add(btnpreview);
            groupBox3.Controls.Add(btnprint);
            groupBox3.Controls.Add(rtbReport);
            groupBox3.Location = new Point(512, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(426, 491);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Report";
            // 
            // btnpage
            // 
            btnpage.Location = new Point(20, 456);
            btnpage.Name = "btnpage";
            btnpage.Size = new Size(94, 29);
            btnpage.TabIndex = 14;
            btnpage.Text = "Page Setup";
            btnpage.UseVisualStyleBackColor = true;
            btnpage.Click += button2_Click;
            // 
            // btnpreview
            // 
            btnpreview.Location = new Point(165, 456);
            btnpreview.Name = "btnpreview";
            btnpreview.Size = new Size(94, 29);
            btnpreview.TabIndex = 15;
            btnpreview.Text = "Preview";
            btnpreview.UseVisualStyleBackColor = true;
            btnpreview.Click += button3_Click;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(313, 456);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(94, 29);
            btnprint.TabIndex = 16;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            // 
            // rtbReport
            // 
            rtbReport.Location = new Point(20, 39);
            rtbReport.Name = "rtbReport";
            rtbReport.Size = new Size(387, 398);
            rtbReport.TabIndex = 0;
            rtbReport.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 415);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 14;
            label6.Text = "  %";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 379);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 15;
            label7.Text = "  %";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(129, 62);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(264, 27);
            dtpBirthDate.TabIndex = 16;
            // 
            // numEnglish
            // 
            numEnglish.Location = new Point(101, 374);
            numEnglish.Name = "numEnglish";
            numEnglish.Size = new Size(48, 27);
            numEnglish.TabIndex = 17;
            numEnglish.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numArabic
            // 
            numArabic.Location = new Point(101, 414);
            numArabic.Name = "numArabic";
            numArabic.Size = new Size(48, 27);
            numArabic.TabIndex = 18;
            numArabic.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // Form1
            // 
            AcceptButton = btnshow;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(966, 554);
            Controls.Add(numArabic);
            Controls.Add(numEnglish);
            Controls.Add(dtpBirthDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(btnshow);
            Controls.Add(progressArabic);
            Controls.Add(progressEnglish);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArabic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label3;
        private ComboBox cmbStatus;
        private GroupBox groupBox2;
        private CheckBox chkBodybuilding;
        private CheckBox chkSwimming;
        private CheckBox chkWatchTV;
        private CheckBox chkFootball;
        private Label label4;
        private Label label5;
        private ProgressBar progressEnglish;
        private ProgressBar progressArabic;
        private Button btnshow;
        private GroupBox groupBox3;
        private RichTextBox rtbReport;
        private Button btnpreview;
        private Button btnprint;
        private Button btnpage;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private NumericUpDown numEnglish;
        private NumericUpDown numArabic;
    }
}
