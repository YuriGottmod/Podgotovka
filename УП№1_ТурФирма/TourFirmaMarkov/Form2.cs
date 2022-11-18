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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void информацияОТуристахBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.информацияОТуристахBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.турФирмаМарковDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "турФирмаМарковDataSet.ИнформацияОТуристах". При необходимости она может быть перемещена или удалена.
            this.информацияОТуристахTableAdapter.Fill(this.турФирмаМарковDataSet.ИнформацияОТуристах);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                this.Validate();
                this.информацияОТуристахBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.турФирмаМарковDataSet);
            } 
            catch 
            {
                MessageBox.Show("Введены неккоректные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            информацияОТуристахBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            информацияОТуристахBindingSource.RemoveCurrent();
        }
    }
}
