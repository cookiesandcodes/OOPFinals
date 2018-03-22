using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace STUDENTREG
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txtboxcourse.Enabled = false;
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtboxcourse.Text = Form2.course;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;)|*.jpg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                txtboxpath.Text = open.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database='dbmain';username=root;password=");
        MySqlCommand command;

        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM system";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgv_stud.DataSource = table;
        }



        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Request Successful");
                }

                else
                {
                    MessageBox.Show("Request Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO system(fname,lname,mname,course) VALUES('" + txtboxfirst.Text + "','" + txtboxlast.Text + "','" + txtboxmid.Text + "','"+ txtboxcourse.Text + "')";
            executeMyQuery(insertQuery);
            populateDGV();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            txtboxID.Text = dgv_stud.CurrentRow.Cells[0].Value.ToString();
            txtboxfirst.Text = dgv_stud.CurrentRow.Cells[1].Value.ToString();
            txtboxlast.Text = dgv_stud.CurrentRow.Cells[2].Value.ToString();
            txtboxmid.Text = dgv_stud.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE system SET fname='" + txtboxfirst.Text +
                "',lname='" + txtboxlast.Text +
                "',mname='" + txtboxmid.Text +
                "',course='" + txtboxcourse.Text+
                "'WHERE id ='"+ int.Parse(txtboxID.Text) + "'";

           

            executeMyQuery(updateQuery);
            populateDGV();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM system WHERE id = " + int.Parse(txtboxID.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }
    }
}
