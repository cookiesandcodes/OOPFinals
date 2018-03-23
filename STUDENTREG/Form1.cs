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
using System.IO;



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
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // `ID`,`Last Name`,`First Name`,`Middle Name`,`Course`
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
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@image", a);
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
        byte[] a;
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                a = ms.GetBuffer();
                ms.Close();
                
            }
            
            string insertQuery = "INSERT INTO system(`First Name`,`Last Name`,`Middle Name`,`course`,`image`) VALUES('"
                + txtboxfirst.Text + "','"
                + txtboxlast.Text + "','"
                + txtboxmid.Text + "','"
                + txtboxcourse.Text + "',@image)";
            executeMyQuery(insertQuery);
            populateDGV();
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            txtboxID.Text = dgv_stud.CurrentRow.Cells[0].Value.ToString();
            txtboxfirst.Text = dgv_stud.CurrentRow.Cells[1].Value.ToString();
            txtboxlast.Text = dgv_stud.CurrentRow.Cells[2].Value.ToString();
            txtboxmid.Text = dgv_stud.CurrentRow.Cells[3].Value.ToString();
           /* byte[] imbyt = dgv_stud.T
            MemoryStream xx = new MemoryStream(imbyt);
            pictureBox1.Image = Image.FromStream(xx);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; */
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
    
            }
            string updateQuery = "UPDATE system SET `First Name`='" + txtboxfirst.Text +
                "',`Last Name`='" + txtboxlast.Text +
                "',`Middle Name`='" + txtboxmid.Text +
                "',`course`='" + txtboxcourse.Text +
                "',`image`= @image "+
                "WHERE id ='" + int.Parse(txtboxID.Text) + "'";
            executeMyQuery(updateQuery);
            populateDGV();
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM system WHERE id = " + int.Parse(txtboxID.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }

        private void dgv_stud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
