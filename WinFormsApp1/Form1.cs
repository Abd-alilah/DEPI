using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string name;
        string birthDate;
        string gender;
        string status;
        int en;
        int ar;
        string report;
        List<string> hobbies = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {
             
        }

        

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            progressArabic.Value = (int)numArabic.Value;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressEnglish.Value = (int)numEnglish.Value;

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            birthDate = dtpBirthDate.Value.ToShortDateString();
            gender = rbMale.Checked ? "Male" : "Female";
            status = cbStatus.Text;



            if (chkFootball.Checked) hobbies.Add("football");
            if (chkWatchTV.Checked) hobbies.Add("watch tv");
            if (chkSwimming.Checked) hobbies.Add("swimming");
            if (chkBodybuilding.Checked) hobbies.Add("bodybuilding");

            en = (int)numEnglish.Value;
            ar = (int)numArabic.Value;

            report = "------------------ Your Information ------------------\n";
            report += $"Name : {name}\r\n";
            report += $"date of birth : {birthDate}\n";
            report += $"Gender : {gender}\n";
            report += $"M Status : {status}\n";
            report += $"habites : {string.Join(" , ", hobbies)}\n";
            report += $"English language : {en}%\n";
            report += $"Arabic lanuage : {ar}%\n";
            report += "------------------------ END ------------------------";

            rtbReport.Text = report;
            hobbies.Clear();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDocument1.Print();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbReport.Text, new Font ("Tahoma", 16), Brushes.Blue, new Point(100, 100));
        }

        private void printDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pageSetupDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}

