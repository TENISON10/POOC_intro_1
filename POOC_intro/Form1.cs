using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOC_intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
           result= MessageBox.Show("¿deseas un pantallazo azul?", "POOC_intro",MessageBoxButtons.YesNo,MessageBoxIcon.Question          );
            if (result == DialogResult.Yes)
            {

                this.BackColor = Color.Blue;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

                wazaa.Visible = false;
            }
            
            
            
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
