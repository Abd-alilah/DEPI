using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
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
            progressEnglish.Value = (int)numEnglish.Value;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            progressArabic.Value = (int)numArabic.Value;
        }
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
        
            string name = txtName.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy hh:mm:ss tt", new System.Globalization.CultureInfo("ar-EG"));
            string gender = rbMale.Checked ? "Male" : "Female";
            string status = cmbStatus.SelectedItem.ToString();

            List<string> hobbies = new List<string>();
            if (chkFootball.Checked) hobbies.Add("football");
            if (chkWatchTV.Checked) hobbies.Add("watch tv");
            if (chkSwimming.Checked) hobbies.Add("swimming");
            if (chkBodybuilding.Checked) hobbies.Add("bodybuilding");

            int english = (int)numEnglish.Value;
            int arabic = (int)numArabic.Value;

            string report = "------------- Your Information -------------\r\n";
            report += $"Name : {name}\r\n";
            report += $"date of birth : {birthDate}\r\n\r\n";
            report += $"Gender : {gender}\r\n";
            report += $"M Status : {status}\r\n";
            report += $"habites : {string.Join(" , ", hobbies)}\r\n";
            report += $"English language : {english}\r\n";
            report += $"Arabic lanuage : {arabic}\r\n";
            report += "------------------------ END ------------------------";

            rtbReport.Text = report;
        }

    }
}

