using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiversWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void списокРекBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.списокРекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.рекиМарковDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рекиМарковDataSet.ЗапросКониненты". При необходимости она может быть перемещена или удалена.
            this.запросКонинентыTableAdapter.Fill(this.рекиМарковDataSet.ЗапросКониненты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рекиМарковDataSet.СписокРек". При необходимости она может быть перемещена или удалена.
            this.списокРекTableAdapter.Fill(this.рекиМарковDataSet.СписокРек);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.списокРекBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.рекиМарковDataSet);
            }
            catch
            {
                MessageBox.Show("Введены неккоректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            списокРекBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                списокРекBindingSource.Filter = "Континент= '" + comboBox1.Text + "'";
            }

            if (checkBox2.Checked)
            {
                списокРекBindingSource.Filter = "Страны= '" + comboBox2.Text + "'";
            }

            if ((checkBox1.Checked) && (checkBox2.Checked))
            {
                списокРекBindingSource.Filter = "Континент= " + comboBox1.Text + "AND Страны = " + comboBox2.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            списокРекBindingSource.Filter = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            for (int i = 0; i < списокРекDataGridView.ColumnCount; i++)
            {
                ExcelApp.Cells[1, (i + 1)] = списокРекDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < списокРекDataGridView.ColumnCount -1; i++)
            {
                for (int j = 0; j < списокРекDataGridView.RowCount -1; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = списокРекDataGridView[i, j].Value;
                }
            }

            ExcelApp.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            int Col = 0;
            for (int i = 0; i < списокРекDataGridView.RowCount; i++)
            {
                Sum = Sum + Convert.ToDouble(списокРекDataGridView.Rows[i].Cells[2].Value);
                Col = Col + 1;
                label3.Text = Sum.ToString("");
                label4.Text = Col.ToString("");
            }
        }
    }
}
