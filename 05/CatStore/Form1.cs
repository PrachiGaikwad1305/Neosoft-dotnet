using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Net.Code.ADONet;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.unchanged;
        string Name;
        double Weight;
        string Gender;
        public Form1()
        {
            InitializeComponent();
        }

        
          private void Form1_Load(object sender, EventArgs e)
          {
            string conStr = @"Data Source=DESKTOP-BUPJUKQ\SQLEXPRESS;Initial Catalog=CatDb;Integrated Security=True";


            SqlConnection connection;
            using (connection = new SqlConnection(conStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Id,Name,Weight,Gender from Cat", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Cat");
                dataGridView1.DataSource = ds.Tables["Cat"].DefaultView;
            }

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Name = txtboxName.Text;
            Weight = Convert.ToDouble(txtboxWeight.Text);
            if (radioMale.Checked == true)
            {
                Gender = "Male";
            }
            else if(radioFemale.Checked == true)
            {
                Gender = "Female";
            }

            string conStr = @"Data Source=DESKTOP-BUPJUKQ\SQLEXPRESS;Initial Catalog=CatDb;Integrated Security=True";

            SqlConnection connection;
            using (connection = new SqlConnection(conStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("Select * from Cat", connection);
                DataTable dt = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                string query = $"insert into Cat(Name,Weight,Gender,Image) Values('{Name}',{Weight},'{Gender}','{pictureBox1.Image}')";
                adapter.InsertCommand = new SqlCommand(query, connection);
                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);
                adapter.Update(dt);
            }
            txtboxName.Text = "";
            txtboxWeight.Text = "";
            pictureBox1.Image = null;
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catDbDataSet.Cat' table. You can move, or remove it, as needed.
            this.catTableAdapter.Fill(this.catDbDataSet.Cat);

        }
    }
}
