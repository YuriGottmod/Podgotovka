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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void продавецBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продавецBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаЦветовМарковDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаЦветовМарковDataSet.Продавец". При необходимости она может быть перемещена или удалена.
            this.продавецTableAdapter.Fill(this.продажаЦветовМарковDataSet.Продавец);

        }
    }
}
