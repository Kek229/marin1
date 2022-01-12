using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Марина1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loggin = "admin";
            string pass = "admin";
            string a = textBox1.Text;
            string b = textBox2.Text;
            if (loggin == a && pass == b)
            {
                Process.Start("databd.mdb");
            }
            else
            {
                MessageBox.Show("Не правильнвый пароль или логин");
            }
        }
    }
}
