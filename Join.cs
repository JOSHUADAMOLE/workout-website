using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void Join_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent; 
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;
            label10.BackColor = Color.Transparent;
            label11.Parent = pictureBox1;
            label11.BackColor = Color.Transparent;
            label12.Parent = pictureBox1;
            label12.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
        }

       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Login form3 = new Login();
            form3.Show();
            Visible = false;
        }

        private void Save_btn_MouseHover(object sender, EventArgs e)
        {
            Save_btn.BackColor = Color.Red;
        }

        private void Save_btn_MouseLeave(object sender, EventArgs e)
        {
            Save_btn.BackColor = Color.Salmon;
        }
    }
}
