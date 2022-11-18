using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Project_BD_Fabrika
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void продукцияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продукцияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Fabrica_N_MarkovDataSet);

        }

        private void продукцияBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.продукцияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Fabrica_N_MarkovDataSet);

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Fabrica_N_MarkovDataSet.Продукция". При необходимости она может быть перемещена или удалена.
            this.продукцияTableAdapter.Fill(this.bD_Fabrica_N_MarkovDataSet.Продукция);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.продукцияBindingSource.EndEdit();
            продукцияTableAdapter.Update(bD_Fabrica_N_MarkovDataSet);
            MessageBox.Show("Данные обновлены!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            for (int i = 0; i < продукцияDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < продукцияDataGridView.RowCount; j++)
                {
                    ExcelApp.Cells[1, i + 1] = продукцияDataGridView.Columns[i].HeaderText;
                }
            }
            
            for (int i = 0; i < продукцияDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < продукцияDataGridView.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = продукцияDataGridView[i, j].Value;
                }
            }

            ExcelApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //создаем объект приложения

            var application = new word.Application();

            //создаем объект документа

            word.Document document = application.Documents.Add();

            //Задаем шрифт и другие параметры

            document.Content.Font.Size = 12;
            document.Content.Font.Name = "Times New Roman";

            //выводим заголовок

            word.Paragraph zagolov = document.Paragraphs.Add();
            word.Range range = application.Selection.Range;
            range.Text = "Продукция";
            zagolov.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;

            //создаем объект таблицы

            word.Paragraph tablePara = document.Paragraphs.Add();
            word.Range tableRange = tablePara.Range;

            //формируем и форматируем таблицу

            word.Table paymentTable = document.Tables.Add(tableRange, продукцияDataGridView.RowCount + 1, продукцияDataGridView.ColumnCount);
            paymentTable.Borders.InsideLineStyle = paymentTable.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
            paymentTable.Range.Cells.VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

            //выводим шапку таблицы

            word.Range cellRange;
            for (int i = 0; i < продукцияDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < продукцияDataGridView.RowCount; j++)
                {
                    cellRange = paymentTable.Cell(1, i + 1).Range;
                    cellRange.Text = продукцияDataGridView.Columns[i].HeaderText;
                }
            }

            paymentTable.Rows[1].Range.Bold = 1;
            paymentTable.Rows[1].Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            
            //выводим содержимое таблицы

            for (int i = 0; i < продукцияDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < продукцияDataGridView.RowCount; j++)
                {
                    cellRange = paymentTable.Cell(j + 2, i + 1).Range;
                    cellRange.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = paymentTable.Cell(j + 2, i + 1).Range;
                    cellRange.Text = Convert.ToString(продукцияDataGridView[i, j].Value);
                }
            }

            //делаем видимым приложение

            application.Visible = true;

        }
    }
}
