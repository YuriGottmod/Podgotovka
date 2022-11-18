using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Project_BD_Fabrika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Проверка на заполнение полей авторизации

            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели логин.");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль.");
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Вы не выбрали тип пользователя.");
                return;
            }

            //Создание подключения к БД

            SqlConnection con = new SqlConnection(@"Data Source=427-12\SQLEXPRESS; Initial Catalog=BD_Fabrica_N_Markov; Integrated Security=True; User Instance=False");

            //Присвоение переменной str строки запроса

            string str = "select * from Авторизация " + "where Логин='" + textBox1.Text + "' " + "and Пароль='" + textBox2.Text + "'" + "and ТипПользователя='" + comboBox1.Text + "'";

            //Открытие подключения к БД

            con.Open();

            //Создание и выполнение sql-выражения

            SqlCommand cmd = new SqlCommand(str, con);
            object obj = cmd.ExecuteScalar();

            //Если ничего не вернул то выводим сообщение

            if (obj == null)
            {
                MessageBox.Show("Такого логина и пароля с таким типом пользователя в БД нет!");
            }
            else
            {
                if (comboBox1.Text == "Администратор")
                {
                    Administrator administrator = new Administrator();
                    administrator.Show();
                    this.Hide();
                }

                if (comboBox1.Text == "Заказчик")
                {
                    Zakazchik zakazchik = new Zakazchik();
                    zakazchik.Show();
                    this.Hide();
                }

                if (comboBox1.Text == "Работник")
                {
                    Rabotnik rabotnik = new Rabotnik();
                    rabotnik.Show();
                    this.Hide();
                }    
            }

            con.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
