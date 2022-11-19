
namespace RiversWorld
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label кодРекиLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label протяженностьLabel;
            System.Windows.Forms.Label континентLabel;
            System.Windows.Forms.Label страныLabel;
            System.Windows.Forms.Label фотоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.рекиМарковDataSet = new RiversWorld.РекиМарковDataSet();
            this.списокРекBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокРекTableAdapter = new RiversWorld.РекиМарковDataSetTableAdapters.СписокРекTableAdapter();
            this.tableAdapterManager = new RiversWorld.РекиМарковDataSetTableAdapters.TableAdapterManager();
            this.списокРекBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.списокРекBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодРекиTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.протяженностьTextBox = new System.Windows.Forms.TextBox();
            this.континентTextBox = new System.Windows.Forms.TextBox();
            this.страныTextBox = new System.Windows.Forms.TextBox();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            кодРекиLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            протяженностьLabel = new System.Windows.Forms.Label();
            континентLabel = new System.Windows.Forms.Label();
            страныLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.рекиМарковDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРекBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРекBindingNavigator)).BeginInit();
            this.списокРекBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // кодРекиLabel
            // 
            кодРекиLabel.AutoSize = true;
            кодРекиLabel.Location = new System.Drawing.Point(41, 41);
            кодРекиLabel.Name = "кодРекиLabel";
            кодРекиLabel.Size = new System.Drawing.Size(57, 13);
            кодРекиLabel.TabIndex = 1;
            кодРекиLabel.Text = "Код Реки:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(38, 67);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // протяженностьLabel
            // 
            протяженностьLabel.AutoSize = true;
            протяженностьLabel.Location = new System.Drawing.Point(8, 93);
            протяженностьLabel.Name = "протяженностьLabel";
            протяженностьLabel.Size = new System.Drawing.Size(90, 13);
            протяженностьLabel.TabIndex = 5;
            протяженностьLabel.Text = "Протяженность:";
            // 
            // континентLabel
            // 
            континентLabel.AutoSize = true;
            континентLabel.Location = new System.Drawing.Point(35, 119);
            континентLabel.Name = "континентLabel";
            континентLabel.Size = new System.Drawing.Size(63, 13);
            континентLabel.TabIndex = 7;
            континентLabel.Text = "Континент:";
            // 
            // страныLabel
            // 
            страныLabel.AutoSize = true;
            страныLabel.Location = new System.Drawing.Point(50, 145);
            страныLabel.Name = "страныLabel";
            страныLabel.Size = new System.Drawing.Size(48, 13);
            страныLabel.TabIndex = 9;
            страныLabel.Text = "Страны:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(262, 38);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 11;
            фотоLabel.Text = "Фото:";
            // 
            // рекиМарковDataSet
            // 
            this.рекиМарковDataSet.DataSetName = "РекиМарковDataSet";
            this.рекиМарковDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокРекBindingSource
            // 
            this.списокРекBindingSource.DataMember = "СписокРек";
            this.списокРекBindingSource.DataSource = this.рекиМарковDataSet;
            // 
            // списокРекTableAdapter
            // 
            this.списокРекTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RiversWorld.РекиМарковDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СписокРекTableAdapter = this.списокРекTableAdapter;
            // 
            // списокРекBindingNavigator
            // 
            this.списокРекBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.списокРекBindingNavigator.BindingSource = this.списокРекBindingSource;
            this.списокРекBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.списокРекBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.списокРекBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.списокРекBindingNavigatorSaveItem});
            this.списокРекBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.списокРекBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.списокРекBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.списокРекBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.списокРекBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.списокРекBindingNavigator.Name = "списокРекBindingNavigator";
            this.списокРекBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.списокРекBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.списокРекBindingNavigator.TabIndex = 0;
            this.списокРекBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // списокРекBindingNavigatorSaveItem
            // 
            this.списокРекBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.списокРекBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("списокРекBindingNavigatorSaveItem.Image")));
            this.списокРекBindingNavigatorSaveItem.Name = "списокРекBindingNavigatorSaveItem";
            this.списокРекBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.списокРекBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.списокРекBindingNavigatorSaveItem.Click += new System.EventHandler(this.списокРекBindingNavigatorSaveItem_Click);
            // 
            // кодРекиTextBox
            // 
            this.кодРекиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокРекBindingSource, "КодРеки", true));
            this.кодРекиTextBox.Location = new System.Drawing.Point(104, 38);
            this.кодРекиTextBox.Name = "кодРекиTextBox";
            this.кодРекиTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодРекиTextBox.TabIndex = 2;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокРекBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(104, 64);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.названиеTextBox.TabIndex = 4;
            this.названиеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.названиеTextBox_KeyPress);
            // 
            // протяженностьTextBox
            // 
            this.протяженностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокРекBindingSource, "Протяженность", true));
            this.протяженностьTextBox.Location = new System.Drawing.Point(104, 90);
            this.протяженностьTextBox.Name = "протяженностьTextBox";
            this.протяженностьTextBox.Size = new System.Drawing.Size(100, 20);
            this.протяженностьTextBox.TabIndex = 6;
            this.протяженностьTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.протяженностьTextBox_KeyPress);
            // 
            // континентTextBox
            // 
            this.континентTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокРекBindingSource, "Континент", true));
            this.континентTextBox.Location = new System.Drawing.Point(104, 116);
            this.континентTextBox.Name = "континентTextBox";
            this.континентTextBox.Size = new System.Drawing.Size(100, 20);
            this.континентTextBox.TabIndex = 8;
            // 
            // страныTextBox
            // 
            this.страныTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокРекBindingSource, "Страны", true));
            this.страныTextBox.Location = new System.Drawing.Point(104, 142);
            this.страныTextBox.MaxLength = 50;
            this.страныTextBox.Name = "страныTextBox";
            this.страныTextBox.Size = new System.Drawing.Size(100, 20);
            this.страныTextBox.TabIndex = 10;
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.списокРекBindingSource, "Фото", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(306, 38);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(225, 124);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.фотоPictureBox.TabIndex = 12;
            this.фотоPictureBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(306, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Добавить фото";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(306, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 48);
            this.button4.TabIndex = 16;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 23);
            this.panel1.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(543, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(страныLabel);
            this.Controls.Add(this.страныTextBox);
            this.Controls.Add(континентLabel);
            this.Controls.Add(this.континентTextBox);
            this.Controls.Add(протяженностьLabel);
            this.Controls.Add(this.протяженностьTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(кодРекиLabel);
            this.Controls.Add(this.кодРекиTextBox);
            this.Controls.Add(this.списокРекBindingNavigator);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить/Редактировать";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.рекиМарковDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРекBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРекBindingNavigator)).EndInit();
            this.списокРекBindingNavigator.ResumeLayout(false);
            this.списокРекBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private РекиМарковDataSet рекиМарковDataSet;
        private System.Windows.Forms.BindingSource списокРекBindingSource;
        private РекиМарковDataSetTableAdapters.СписокРекTableAdapter списокРекTableAdapter;
        private РекиМарковDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator списокРекBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton списокРекBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодРекиTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox протяженностьTextBox;
        private System.Windows.Forms.TextBox континентTextBox;
        private System.Windows.Forms.TextBox страныTextBox;
        private System.Windows.Forms.PictureBox фотоPictureBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}