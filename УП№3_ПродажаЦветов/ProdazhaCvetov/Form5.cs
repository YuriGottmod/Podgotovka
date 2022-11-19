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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void цветыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цветыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаЦветовМарковDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаЦветовМарковDataSet.Цветы". При необходимости она может быть перемещена или удалена.
            this.цветыTableAdapter.Fill(this.продажаЦветовМарковDataSet.Цветы);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            цветыBindingSource.Filter = "Название_цветка='" + comboBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            цветыBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                цветыDataGridView.Sort(цветыDataGridView.Columns[comboBox2.SelectedIndex], ListSortDirection.Ascending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                цветыDataGridView.Sort(цветыDataGridView.Columns[comboBox2.SelectedIndex], ListSortDirection.Descending);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            цветыBindingSource.Filter = "Название_цветка like '" + textBox1.Text + "%'";
        }
    }
}
