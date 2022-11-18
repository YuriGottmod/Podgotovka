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

namespace Project_BD_Fabrika
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
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

            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Введенные пароли не совпадают.");
                return;
            }

            //Создание подключения к БД

            SqlConnection con = new SqlConnection(@"Data Source=427-12\SQLEXPRESS;Initial Catalog=BD_Fabrica_N_Markov;Integrated Security=True; User Instance=False");
            try
            {
                //присвоение переменной str строки запроса

                string str = "insert into Авторизация (Логин, Пароль, ТипПользователя)" + "values(@log, @pas, @p3)";

                //открытие подключения к базе данных

                con.Open();

                //создание и выполнение sql-выражения

                SqlCommand cmd = new SqlCommand(str, con);

                //добавить три параметра - логин, пароль, а тип учетной записи будет постоянный - заказчик

                cmd.Parameters.AddWithValue("@log", textBox1.Text);
                cmd.Parameters.AddWithValue("@pas", textBox2.Text);
                cmd.Parameters.AddWithValue("@p3", "Заказчик");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Запись успешно добавлена!");

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch
            {
                MessageBox.Show("Такой логин уже существует в БД!");
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
