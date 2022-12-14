using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdazhaCvetov
{
    public partial class Form1 : Form
    {
        public static int @num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void цветыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цветыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаЦветовМарковDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаЦветовМарковDataSet.Цветы". При необходимости она может быть перемещена или удалена.
            this.цветыTableAdapter.Fill(this.продажаЦветовМарковDataSet.Цветы);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(код_цветкаTextBox.Text);
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
