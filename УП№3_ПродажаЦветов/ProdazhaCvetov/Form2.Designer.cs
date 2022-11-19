
namespace ProdazhaCvetov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label код_цветкаLabel;
            System.Windows.Forms.Label название_цветкаLabel;
            System.Windows.Forms.Label сорт_цветкаLabel;
            System.Windows.Forms.Label средняя_высотаLabel;
            System.Windows.Forms.Label тип_листаLabel;
            System.Windows.Forms.Label цветущийLabel;
            System.Windows.Forms.Label дополнительные_сведенияLabel;
            this.продажаЦветовМарковDataSet = new ProdazhaCvetov.ПродажаЦветовМарковDataSet();
            this.цветыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цветыTableAdapter = new ProdazhaCvetov.ПродажаЦветовМарковDataSetTableAdapters.ЦветыTableAdapter();
            this.tableAdapterManager = new ProdazhaCvetov.ПродажаЦветовМарковDataSetTableAdapters.TableAdapterManager();
            this.цветыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.цветыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_цветкаTextBox = new System.Windows.Forms.TextBox();
            this.название_цветкаTextBox = new System.Windows.Forms.TextBox();
            this.сорт_цветкаTextBox = new System.Windows.Forms.TextBox();
            this.средняя_высотаTextBox = new System.Windows.Forms.TextBox();
            this.тип_листаTextBox = new System.Windows.Forms.TextBox();
            this.цветущийCheckBox = new System.Windows.Forms.CheckBox();
            this.дополнительные_сведенияTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            код_цветкаLabel = new System.Windows.Forms.Label();
            название_цветкаLabel = new System.Windows.Forms.Label();
            сорт_цветкаLabel = new System.Windows.Forms.Label();
            средняя_высотаLabel = new System.Windows.Forms.Label();
            тип_листаLabel = new System.Windows.Forms.Label();
            цветущийLabel = new System.Windows.Forms.Label();
            дополнительные_сведенияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.продажаЦветовМарковDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветыBindingNavigator)).BeginInit();
            this.цветыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // продажаЦветовМарковDataSet
            // 
            this.продажаЦветовМарковDataSet.DataSetName = "ПродажаЦветовМарковDataSet";
            this.продажаЦветовМарковDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цветыBindingSource
            // 
            this.цветыBindingSource.DataMember = "Цветы";
            this.цветыBindingSource.DataSource = this.продажаЦветовМарковDataSet;
            // 
            // цветыTableAdapter
            // 
            this.цветыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ProdazhaCvetov.ПродажаЦветовМарковDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ПродавецTableAdapter = null;
            this.tableAdapterManager.ПродажиTableAdapter = null;
            this.tableAdapterManager.ЦветыTableAdapter = this.цветыTableAdapter;
            // 
            // цветыBindingNavigator
            // 
            this.цветыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.цветыBindingNavigator.BindingSource = this.цветыBindingSource;
            this.цветыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.цветыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.цветыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.цветыBindingNavigatorSaveItem});
            this.цветыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.цветыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.цветыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.цветыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.цветыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.цветыBindingNavigator.Name = "цветыBindingNavigator";
            this.цветыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.цветыBindingNavigator.Size = new System.Drawing.Size(346, 25);
            this.цветыBindingNavigator.TabIndex = 0;
            this.цветыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // цветыBindingNavigatorSaveItem
            // 
            this.цветыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.цветыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("цветыBindingNavigatorSaveItem.Image")));
            this.цветыBindingNavigatorSaveItem.Name = "цветыBindingNavigatorSaveItem";
            this.цветыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.цветыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.цветыBindingNavigatorSaveItem.Click += new System.EventHandler(this.цветыBindingNavigatorSaveItem_Click);
            // 
            // код_цветкаLabel
            // 
            код_цветкаLabel.AutoSize = true;
            код_цветкаLabel.Location = new System.Drawing.Point(85, 31);
            код_цветкаLabel.Name = "код_цветкаLabel";
            код_цветкаLabel.Size = new System.Drawing.Size(67, 13);
            код_цветкаLabel.TabIndex = 1;
            код_цветкаLabel.Text = "Код цветка:";
            // 
            // код_цветкаTextBox
            // 
            this.код_цветкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цветыBindingSource, "Код_цветка", true));
            this.код_цветкаTextBox.Location = new System.Drawing.Point(158, 28);
            this.код_цветкаTextBox.Name = "код_цветкаTextBox";
            this.код_цветкаTextBox.Size = new System.Drawing.Size(176, 20);
            this.код_цветкаTextBox.TabIndex = 2;
            // 
            // название_цветкаLabel
            // 
            название_цветкаLabel.AutoSize = true;
            название_цветкаLabel.Location = new System.Drawing.Point(54, 57);
            название_цветкаLabel.Name = "название_цветкаLabel";
            название_цветкаLabel.Size = new System.Drawing.Size(98, 13);
            название_цветкаLabel.TabIndex = 3;
            название_цветкаLabel.Text = "Название цветка:";
            // 
            // название_цветкаTextBox
            // 
            this.название_цветкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цветыBindingSource, "Название_цветка", true));
            this.название_цветкаTextBox.Location = new System.Drawing.Point(158, 54);
            this.название_цветкаTextBox.Name = "название_цветкаTextBox";
            this.название_цветкаTextBox.Size = new System.Drawing.Size(176, 20);
            this.название_цветкаTextBox.TabIndex = 4;
            // 
            // сорт_цветкаLabel
            // 
            сорт_цветкаLabel.AutoSize = true;
            сорт_цветкаLabel.Location = new System.Drawing.Point(80, 83);
            сорт_цветкаLabel.Name = "сорт_цветкаLabel";
            сорт_цветкаLabel.Size = new System.Drawing.Size(72, 13);
            сорт_цветкаLabel.TabIndex = 5;
            сорт_цветкаLabel.Text = "Сорт цветка:";
            // 
            // сорт_цветкаTextBox
            // 
            this.сорт_цветкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цветыBindingSource, "Сорт_цветка", true));
            this.сорт_цветкаTextBox.Location = new System.Drawing.Point(158, 80);
            this.сорт_цветкаTextBox.Name = "сорт_цветкаTextBox";
            this.сорт_цветкаTextBox.Size = new System.Drawing.Size(176, 20);
            this.сорт_цветкаTextBox.TabIndex = 6;
            // 
            // средняя_высотаLabel
            // 
            средняя_высотаLabel.AutoSize = true;
            средняя_высотаLabel.Location = new System.Drawing.Point(59, 109);
            средняя_высотаLabel.Name = "средняя_высотаLabel";
            средняя_высотаLabel.Size = new System.Drawing.Size(93, 13);
            средняя_высотаLabel.TabIndex = 7;
            средняя_высотаLabel.Text = "Средняя высота:";
            средняя_высотаLabel.Click += new System.EventHandler(this.средняя_высотаLabel_Click);
            // 
            // средняя_высотаTextBox
            // 
            this.средняя_высотаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цветыBindingSource, "Средняя_высота", true));
            this.средняя_высотаTextBox.Location = new System.Drawing.Point(158, 106);
            this.средняя_высотаTextBox.Name = "средняя_высотаTextBox";
            this.средняя_высотаTextBox.Size = new System.Drawing.Size(176, 20);
            this.средняя_высотаTextBox.TabIndex = 8;
            this.средняя_высотаTextBox.TextChanged += new System.EventHandler(this.средняя_высотаTextBox_TextChanged);
            // 
            // тип_листаLabel
            // 
            тип_листаLabel.AutoSize = true;
            тип_листаLabel.Location = new System.Drawing.Point(91, 135);
            тип_листаLabel.Name = "тип_листаLabel";
            тип_листаLabel.Size = new System.Drawing.Size(61, 13);
            тип_листаLabel.TabIndex = 9;
            тип_листаLabel.Text = "Тип листа:";
            // 
            // тип_листаTextBox
            // 
            this.тип_листаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цветыBindingSource, "Тип_листа", true));
            this.тип_листаTextBox.Location = new System.Drawing.Point(158, 132);
            this.тип_листаTextBox.Name = "тип_листаTextBox";
            this.тип_листаTextBox.Size = new System.Drawing.Size(176, 20);
            this.тип_листаTextBox.TabIndex = 10;
            // 
            // цветущийLabel
            // 
            цветущийLabel.AutoSize = true;
            цветущийLabel.Location = new System.Drawing.Point(91, 163);
            цветущийLabel.Name = "цветущийLabel";
            цветущийLabel.Size = new System.Drawing.Size(61, 13);
            цветущийLabel.TabIndex = 11;
            цветущийLabel.Text = "Цветущий:";
            // 
            // цветущийCheckBox
            // 
            this.цветущийCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.цветыBindingSource, "Цветущий", true));
            this.цветущийCheckBox.Location = new System.Drawing.Point(158, 158);
            this.цветущийCheckBox.Name = "цветущийCheckBox";
            this.цветущийCheckBox.Size = new System.Drawing.Size(104, 24);
            this.цветущийCheckBox.TabIndex = 12;
            this.цветущийCheckBox.Text = "checkBox1";
            this.цветущийCheckBox.UseVisualStyleBackColor = true;
            // 
            // дополнительные_сведенияLabel
            // 
            дополнительные_сведенияLabel.AutoSize = true;
            дополнительные_сведенияLabel.Location = new System.Drawing.Point(7, 191);
            дополнительные_сведенияLabel.Name = "дополнительные_сведенияLabel";
            дополнительные_сведенияLabel.Size = new System.Drawing.Size(149, 13);
            дополнительные_сведенияLabel.TabIndex = 13;
            дополнительные_сведенияLabel.Text = "Дополнительные сведения:";
            дополнительные_сведенияLabel.Click += new System.EventHandler(this.дополнительные_сведенияLabel_Click);
            // 
            // дополнительные_сведенияTextBox
            // 
            this.дополнительные_сведенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цветыBindingSource, "Дополнительные_сведения", true));
            this.дополнительные_сведенияTextBox.Location = new System.Drawing.Point(162, 188);
            this.дополнительные_сведенияTextBox.Name = "дополнительные_сведенияTextBox";
            this.дополнительные_сведенияTextBox.Size = new System.Drawing.Size(172, 20);
            this.дополнительные_сведенияTextBox.TabIndex = 14;
            this.дополнительные_сведенияTextBox.TextChanged += new System.EventHandler(this.дополнительные_сведенияTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(42, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(42, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(42, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(346, 387);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(дополнительные_сведенияLabel);
            this.Controls.Add(this.дополнительные_сведенияTextBox);
            this.Controls.Add(цветущийLabel);
            this.Controls.Add(this.цветущийCheckBox);
            this.Controls.Add(тип_листаLabel);
            this.Controls.Add(this.тип_листаTextBox);
            this.Controls.Add(средняя_высотаLabel);
            this.Controls.Add(this.средняя_высотаTextBox);
            this.Controls.Add(сорт_цветкаLabel);
            this.Controls.Add(this.сорт_цветкаTextBox);
            this.Controls.Add(название_цветкаLabel);
            this.Controls.Add(this.название_цветкаTextBox);
            this.Controls.Add(код_цветкаLabel);
            this.Controls.Add(this.код_цветкаTextBox);
            this.Controls.Add(this.цветыBindingNavigator);
            this.Name = "Form2";
            this.Text = "Информация о цветке";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажаЦветовМарковDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветыBindingNavigator)).EndInit();
            this.цветыBindingNavigator.ResumeLayout(false);
            this.цветыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ПродажаЦветовМарковDataSet продажаЦветовМарковDataSet;
        private System.Windows.Forms.BindingSource цветыBindingSource;
        private ПродажаЦветовМарковDataSetTableAdapters.ЦветыTableAdapter цветыTableAdapter;
        private ПродажаЦветовМарковDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator цветыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton цветыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_цветкаTextBox;
        private System.Windows.Forms.TextBox название_цветкаTextBox;
        private System.Windows.Forms.TextBox сорт_цветкаTextBox;
        private System.Windows.Forms.TextBox средняя_высотаTextBox;
        private System.Windows.Forms.TextBox тип_листаTextBox;
        private System.Windows.Forms.CheckBox цветущийCheckBox;
        private System.Windows.Forms.TextBox дополнительные_сведенияTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}