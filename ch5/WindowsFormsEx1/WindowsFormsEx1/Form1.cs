using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Hello, "+txtName.Text;
            lblShow.BackColor = Color.Yellow;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
         
        }
    }
}
