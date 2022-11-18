using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BD_Fabrika
{
    public partial class Rabotnik : Form
    {
        public Rabotnik()
        {
            InitializeComponent();
        }

        private void Rabotnik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void продукцияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продукцияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Fabrica_N_MarkovDataSet);

        }

        private void Rabotnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Fabrica_N_MarkovDataSet.Продукция". При необходимости она может быть перемещена или удалена.
            this.продукцияTableAdapter.Fill(this.bD_Fabrica_N_MarkovDataSet.Продукция);

        }
    }
}
