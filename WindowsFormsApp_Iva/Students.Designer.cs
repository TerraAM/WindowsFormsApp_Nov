namespace WindowsFormsApp_Iva
{
    partial class Students
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
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label no_zkLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label grLabel;
            System.Windows.Forms.Label biogrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.label1 = new System.Windows.Forms.Label();
            this.education_RomanDataSet = new WindowsFormsApp_Iva.Education_RomanDataSet();
            this.students_IvanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_IvanovTableAdapter = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.Students_IvanovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.TableAdapterManager();
            this.students_IvanovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.students_IvanovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_zkTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            this.grTextBox = new System.Windows.Forms.TextBox();
            this.biogrTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            famLabel = new System.Windows.Forms.Label();
            no_zkLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            grLabel = new System.Windows.Forms.Label();
            biogrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_RomanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_IvanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_IvanovBindingNavigator)).BeginInit();
            this.students_IvanovBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.ForeColor = System.Drawing.Color.DarkBlue;
            famLabel.Location = new System.Drawing.Point(23, 100);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 6;
            famLabel.Text = "Фамилия:";
            // 
            // no_zkLabel
            // 
            no_zkLabel.AutoSize = true;
            no_zkLabel.ForeColor = System.Drawing.Color.DarkBlue;
            no_zkLabel.Location = new System.Drawing.Point(23, 75);
            no_zkLabel.Name = "no_zkLabel";
            no_zkLabel.Size = new System.Drawing.Size(61, 13);
            no_zkLabel.TabIndex = 4;
            no_zkLabel.Text = "Номер ЗК:";
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.ForeColor = System.Drawing.Color.DarkBlue;
            imLabel.Location = new System.Drawing.Point(23, 126);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(32, 13);
            imLabel.TabIndex = 8;
            imLabel.Text = "Имя:";
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.ForeColor = System.Drawing.Color.DarkBlue;
            otLabel.Location = new System.Drawing.Point(23, 152);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(57, 13);
            otLabel.TabIndex = 10;
            otLabel.Text = "Отчество:";
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.ForeColor = System.Drawing.Color.DarkBlue;
            specLabel.Location = new System.Drawing.Point(23, 178);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(88, 13);
            specLabel.TabIndex = 12;
            specLabel.Text = "Специальность:";
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.ForeColor = System.Drawing.Color.DarkBlue;
            kursLabel.Location = new System.Drawing.Point(23, 204);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(34, 13);
            kursLabel.TabIndex = 14;
            kursLabel.Text = "Курс:";
            // 
            // grLabel
            // 
            grLabel.AutoSize = true;
            grLabel.ForeColor = System.Drawing.Color.DarkBlue;
            grLabel.Location = new System.Drawing.Point(23, 230);
            grLabel.Name = "grLabel";
            grLabel.Size = new System.Drawing.Size(45, 13);
            grLabel.TabIndex = 16;
            grLabel.Text = "Группа:";
            // 
            // biogrLabel
            // 
            biogrLabel.AutoSize = true;
            biogrLabel.ForeColor = System.Drawing.Color.DarkBlue;
            biogrLabel.Location = new System.Drawing.Point(23, 256);
            biogrLabel.Name = "biogrLabel";
            biogrLabel.Size = new System.Drawing.Size(66, 13);
            biogrLabel.TabIndex = 20;
            biogrLabel.Text = "Биография:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            // 
            // education_RomanDataSet
            // 
            this.education_RomanDataSet.DataSetName = "Education_RomanDataSet";
            this.education_RomanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_IvanovBindingSource
            // 
            this.students_IvanovBindingSource.DataMember = "Students_Ivanov";
            this.students_IvanovBindingSource.DataSource = this.education_RomanDataSet;
            // 
            // students_IvanovTableAdapter
            // 
            this.students_IvanovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_IvanovTableAdapter = this.students_IvanovTableAdapter;
            this.tableAdapterManager.Subjects_IvanovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_IvanovTableAdapter = null;
            // 
            // students_IvanovBindingNavigator
            // 
            this.students_IvanovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.students_IvanovBindingNavigator.BindingSource = this.students_IvanovBindingSource;
            this.students_IvanovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.students_IvanovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.students_IvanovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.students_IvanovBindingNavigatorSaveItem});
            this.students_IvanovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.students_IvanovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.students_IvanovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.students_IvanovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.students_IvanovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.students_IvanovBindingNavigator.Name = "students_IvanovBindingNavigator";
            this.students_IvanovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.students_IvanovBindingNavigator.Size = new System.Drawing.Size(295, 25);
            this.students_IvanovBindingNavigator.TabIndex = 1;
            this.students_IvanovBindingNavigator.Text = "bindingNavigator1";
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
            // students_IvanovBindingNavigatorSaveItem
            // 
            this.students_IvanovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.students_IvanovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("students_IvanovBindingNavigatorSaveItem.Image")));
            this.students_IvanovBindingNavigatorSaveItem.Name = "students_IvanovBindingNavigatorSaveItem";
            this.students_IvanovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.students_IvanovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.students_IvanovBindingNavigatorSaveItem.Click += new System.EventHandler(this.students_IvanovBindingNavigatorSaveItem_Click);
            // 
            // no_zkTextBox
            // 
            this.no_zkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "no_zk", true));
            this.no_zkTextBox.Location = new System.Drawing.Point(116, 71);
            this.no_zkTextBox.Name = "no_zkTextBox";
            this.no_zkTextBox.Size = new System.Drawing.Size(163, 20);
            this.no_zkTextBox.TabIndex = 5;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(116, 97);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(163, 20);
            this.famTextBox.TabIndex = 7;
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "im", true));
            this.imTextBox.Location = new System.Drawing.Point(116, 123);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(163, 20);
            this.imTextBox.TabIndex = 9;
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "ot", true));
            this.otTextBox.Location = new System.Drawing.Point(116, 149);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(163, 20);
            this.otTextBox.TabIndex = 11;
            // 
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(116, 175);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(163, 20);
            this.specTextBox.TabIndex = 13;
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "kurs", true));
            this.kursTextBox.Location = new System.Drawing.Point(116, 201);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(163, 20);
            this.kursTextBox.TabIndex = 15;
            // 
            // grTextBox
            // 
            this.grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "gr", true));
            this.grTextBox.Location = new System.Drawing.Point(116, 227);
            this.grTextBox.Name = "grTextBox";
            this.grTextBox.Size = new System.Drawing.Size(163, 20);
            this.grTextBox.TabIndex = 17;
            // 
            // biogrTextBox
            // 
            this.biogrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_IvanovBindingSource, "biogr", true));
            this.biogrTextBox.Location = new System.Drawing.Point(116, 253);
            this.biogrTextBox.Name = "biogrTextBox";
            this.biogrTextBox.Size = new System.Drawing.Size(163, 20);
            this.biogrTextBox.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(25, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Список студентов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(biogrLabel);
            this.Controls.Add(this.biogrTextBox);
            this.Controls.Add(grLabel);
            this.Controls.Add(this.grTextBox);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursTextBox);
            this.Controls.Add(specLabel);
            this.Controls.Add(this.specTextBox);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(no_zkLabel);
            this.Controls.Add(this.no_zkTextBox);
            this.Controls.Add(this.students_IvanovBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Students";
            this.Text = "Студенты_Иванов";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_RomanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_IvanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_IvanovBindingNavigator)).EndInit();
            this.students_IvanovBindingNavigator.ResumeLayout(false);
            this.students_IvanovBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_RomanDataSet education_RomanDataSet;
        private System.Windows.Forms.BindingSource students_IvanovBindingSource;
        private Education_RomanDataSetTableAdapters.Students_IvanovTableAdapter students_IvanovTableAdapter;
        private Education_RomanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator students_IvanovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton students_IvanovBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_zkTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
        private System.Windows.Forms.TextBox grTextBox;
        private System.Windows.Forms.TextBox biogrTextBox;
        private System.Windows.Forms.Button button2;
    }
}