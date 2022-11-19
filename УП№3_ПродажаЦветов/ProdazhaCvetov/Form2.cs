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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void цветыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цветыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаЦветовМарковDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаЦветовМарковDataSet.Цветы". При необходимости она может быть перемещена или удалена.
            this.цветыTableAdapter.Fill(this.продажаЦветовМарковDataSet.Цветы);

        }

        private void дополнительные_сведенияLabel_Click(object sender, EventArgs e)
        {

        }

        private void дополнительные_сведенияTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void средняя_высотаLabel_Click(object sender, EventArgs e)
        {

        }

        private void средняя_высотаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цветыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаЦветовМарковDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            цветыBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            цветыBindingSource.RemoveCurrent();
        }
    }
}
