using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Марина1
{
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=databd.mdb";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = textBox4.Text;
            string l = textBox5.Text;
            string f = textBox6.Text;
            string g = textBox7.Text;
            string h = textBox8.Text;
            string query = "INSERT INTO Заказ (Имя,Фамилия,Отчество,Автомобиль,Комплектация,Цвет,Телефон,Дата) VALUES('" + b + "',' " + a + "','" + c + "', '" + d + "','" +l+ "','"+f+ "','"+g+ "','"+h+"')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике добавлены");
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
