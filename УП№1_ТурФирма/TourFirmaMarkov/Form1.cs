using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourFirmaMarkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void туристыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.туристыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.турФирмаМарковDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "турФирмаМарковDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.турФирмаМарковDataSet.Туристы);

            comboBox1.Items.Add("Все туристы");
            for(int i = 0; i < туристыDataGridView.RowCount - 1; i++)
            {
                comboBox1.Items.Add(туристыDataGridView.Rows[i].Cells[1].Value);
            }

            label5.Text = (туристыDataGridView.RowCount - 1).ToString();
            label8.Text = (туристыDataGridView.RowCount - 1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.туристыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.турФирмаМарковDataSet);
            }
            catch 
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            туристыBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            туристыBindingSource.RemoveCurrent();
            MessageBox.Show("Запись удалена!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Все туристы")
            {
                туристыBindingSource.Filter = "Фамилия= '" + comboBox1.Text + "'";
            }
            else
            {
                туристыBindingSource.Filter = "";
            }

            label8.Text = (туристыDataGridView.RowCount - 1).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
                туристыDataGridView.Sort(туристыDataGridView.Columns[comboBox2.SelectedIndex], ListSortDirection.Ascending);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
                туристыDataGridView.Sort(туристыDataGridView.Columns[comboBox2.SelectedIndex], ListSortDirection.Descending);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrPoiskSort();
            label8.Text = (туристыDataGridView.RowCount - 1).ToString();
        }

        private void FiltrPoiskSort()
        {
            //Фильтрация
            /*
            if(comboBox1.Text != "Все туристы")
            {
                туристыBindingSource.Filter = "Фамилия= '" + comboBox1.Text + "'";
            }
            else
            {
                туристыBindingSource.Filter = "";
            }*/

            //Поиск
            туристыBindingSource.Filter = "Фамилия like '" + textBox1.Text + "%'";

            //Сортировка
            /*
            if (comboBox2.SelectedIndex > -1)
                туристыDataGridView.Sort(туристыDataGridView.Columns[comboBox2.SelectedIndex], ListSortDirection.Ascending);
            if (comboBox2.SelectedIndex > -1)
                туристыDataGridView.Sort(туристыDataGridView.Columns[comboBox2.SelectedIndex], ListSortDirection.Descending);*/
        }
    }
}
