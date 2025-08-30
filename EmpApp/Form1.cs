using System.Data;
using System.Windows.Forms;
using EmployeeDataApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace EmployeeDataApp
{
    public partial class Form1 : Form
    {

        AppDbContext _context = new AppDbContext();
        byte[] _photo = null;



        public Form1()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(
            "Server=.;Database=EmployeeAppDB;Trusted_Connection=True;",
             sqlOptions => sqlOptions.EnableRetryOnFailure()).Options;

            _context = new AppDbContext(options);

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _context.Employees.Add(new Models.Employee
            {
                Name = txtName.Text,
                Job = txtJob.Text,
                Salary = double.Parse(txtSalary.Text),
                Photo = _photo
            });
            _context.SaveChanges();
            Form_Clear();
        }






        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _photo = File.ReadAllBytes(ofd.FileName);
                    picEmployee.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var result = _context.Employees.Where(x => x.Name == txtSearch.Text).ToList();

            dgvEmployees.DataSource = result;
            dgvEmployees.Show();
            Form_Clear();


        }

        private void LoadEmployees()
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var emp = _context.Employees.FirstOrDefault(e => e.Name == cmbName.Text); 
            emp.Name = txtName.Text;
            emp.Job = txtJob.Text;
            emp.Salary = double.Parse(txtSalary.Text);
            _context.Employees.Update(emp);
            _context.SaveChanges();
            Form_Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var emp = _context.Employees.FirstOrDefault(e => e.Name == cmbName.Text);
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            Form_Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var employees = _context.Employees.Select(e => e);

            foreach (var emp in employees)
            {
                cmbName.Items.Add(emp.Name);
            }

        }

        private void Form_Clear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear();
                }
                else if (ctrl is ComboBox cmb)
                {

                    cmb.Text = string.Empty; 
                }
                else if (ctrl is PictureBox pic)
                {
                    pic.Image = null;
                }
            }
        }
    }
}



