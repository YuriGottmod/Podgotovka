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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void списокРекBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.списокРекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.рекиМарковDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рекиМарковDataSet.СписокРек". При необходимости она может быть перемещена или удалена.
            this.списокРекTableAdapter.Fill(this.рекиМарковDataSet.СписокРек);

        }

        private void названиеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char)e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (char.IsLetter(e.KeyChar))
            {
                return;
            }

            if ((char)e.KeyChar == (char)Keys.Space)
            {
                return;
            }

            if ((char)e.KeyChar == '-')
            {
                return;
            }

            if ((char)e.KeyChar == '_')
            {
                return;
            }

            e.Handled = true;
        }

        private void протяженностьTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (char.IsNumber(e.KeyChar))
            {
                return;
            }

            if ((char)e.KeyChar == ',')
            {
                return;
            }

            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|All files (*.*)|*.*";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    this.фотоPictureBox.Size = new System.Drawing.Size(140, 140);
                    фотоPictureBox.Image = image;
                    фотоPictureBox.Invalidate();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            фотоPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            this.Validate();
            this.списокРекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.рекиМарковDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            списокРекBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.списокРекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.рекиМарковDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
