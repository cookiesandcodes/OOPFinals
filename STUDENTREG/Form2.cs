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
    public partial class Form2 : Form
    {
        public static string course;
        
        public Form2()
        {
            
            InitializeComponent();
            ListViewCOURSE.View = View.Details;
            string[] arr = new string[4];
            ListViewItem itm;

            arr[0] = "BSCS";
            arr[1] = "Bachelor of Science in Computer Science";
            itm = new ListViewItem(arr);
            ListViewCOURSE.Items.Add(itm);

            arr[0] = "BSIT";
            arr[1] = "Bachelor of Science in Information Technology";
            itm = new ListViewItem(arr);
            ListViewCOURSE.Items.Add(itm);

            arr[0] = "BSCpE";
            arr[1] = "Bachelor of Science in Computer Engineering";
            itm = new ListViewItem(arr);
            ListViewCOURSE.Items.Add(itm);

            arr[0] = "BSECE";
            arr[1] = "Bachelor of Science in Electronics and Communications Engineering";
            itm = new ListViewItem(arr);
            ListViewCOURSE.Items.Add(itm);
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            course = textBox1.Text;
            this.Hide();
        }

        private void ListViewCOURSE_Click(object sender, EventArgs e)
        {
            textBox1.Text = ListViewCOURSE.SelectedItems[0].SubItems[0].Text;
        }
    }
}
