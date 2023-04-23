using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void Join_btn_Click(object sender, EventArgs e)
        {
            Join form2 = new Join();
            form2.Show();
            Visible = false;

        }

        private void Login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Aqua;
        }

        private void Login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Aquamarine;
        }

        private void Join_btn_MouseHover_1(object sender, EventArgs e)
        {
            Join_btn.BackColor = Color.Red;
        }

        private void Join_btn_MouseLeave_1(object sender, EventArgs e)
        {
            Join_btn.BackColor = Color.Salmon;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Visible = false;
        }
    }
}
