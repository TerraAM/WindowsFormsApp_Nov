namespace WindowsFormsApp_Nov
{
    partial class StudentsForm
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
            System.Windows.Forms.Label no_zkLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label grLabel;
            System.Windows.Forms.Label biogrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.education_NovDataSet = new WindowsFormsApp_Nov.Education_NovDataSet();
            this.students_NovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_NovTableAdapter = new WindowsFormsApp_Nov.Education_NovDataSetTableAdapters.Students_NovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Nov.Education_NovDataSetTableAdapters.TableAdapterManager();
            this.students_NovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.students_NovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_zkTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            this.grTextBox = new System.Windows.Forms.TextBox();
            this.biogrTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            no_zkLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            grLabel = new System.Windows.Forms.Label();
            biogrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_NovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_NovBindingNavigator)).BeginInit();
            this.students_NovBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_zkLabel
            // 
            no_zkLabel.AutoSize = true;
            no_zkLabel.ForeColor = System.Drawing.Color.DarkBlue;
            no_zkLabel.Location = new System.Drawing.Point(23, 75);
            no_zkLabel.Name = "no_zkLabel";
            no_zkLabel.Size = new System.Drawing.Size(61, 13);
            no_zkLabel.TabIndex = 2;
            no_zkLabel.Text = "Номер ЗК:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.ForeColor = System.Drawing.Color.DarkBlue;
            famLabel.Location = new System.Drawing.Point(23, 100);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 4;
            famLabel.Text = "Фамилия:";
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.ForeColor = System.Drawing.Color.DarkBlue;
            imLabel.Location = new System.Drawing.Point(23, 126);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(32, 13);
            imLabel.TabIndex = 6;
            imLabel.Text = "Имя:";
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.ForeColor = System.Drawing.Color.DarkBlue;
            otLabel.Location = new System.Drawing.Point(23, 152);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(57, 13);
            otLabel.TabIndex = 8;
            otLabel.Text = "Отчество:";
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.ForeColor = System.Drawing.Color.DarkBlue;
            specLabel.Location = new System.Drawing.Point(23, 178);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(88, 13);
            specLabel.TabIndex = 10;
            specLabel.Text = "Специальность:";
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.ForeColor = System.Drawing.Color.DarkBlue;
            kursLabel.Location = new System.Drawing.Point(23, 204);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(34, 13);
            kursLabel.TabIndex = 12;
            kursLabel.Text = "Курс:";
            // 
            // grLabel
            // 
            grLabel.AutoSize = true;
            grLabel.ForeColor = System.Drawing.Color.DarkBlue;
            grLabel.Location = new System.Drawing.Point(23, 230);
            grLabel.Name = "grLabel";
            grLabel.Size = new System.Drawing.Size(45, 13);
            grLabel.TabIndex = 14;
            grLabel.Text = "Группа:";
            // 
            // biogrLabel
            // 
            biogrLabel.AutoSize = true;
            biogrLabel.ForeColor = System.Drawing.Color.DarkBlue;
            biogrLabel.Location = new System.Drawing.Point(23, 256);
            biogrLabel.Name = "biogrLabel";
            biogrLabel.Size = new System.Drawing.Size(66, 13);
            biogrLabel.TabIndex = 16;
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
            // education_NovDataSet
            // 
            this.education_NovDataSet.DataSetName = "Education_NovDataSet";
            this.education_NovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_NovBindingSource
            // 
            this.students_NovBindingSource.DataMember = "Students_Nov";
            this.students_NovBindingSource.DataSource = this.education_NovDataSet;
            // 
            // students_NovTableAdapter
            // 
            this.students_NovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_NovTableAdapter = this.students_NovTableAdapter;
            this.tableAdapterManager.Subjects_NovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Nov.Education_NovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_NovTableAdapter = null;
            // 
            // students_NovBindingNavigator
            // 
            this.students_NovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.students_NovBindingNavigator.BindingSource = this.students_NovBindingSource;
            this.students_NovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.students_NovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.students_NovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.students_NovBindingNavigatorSaveItem});
            this.students_NovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.students_NovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.students_NovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.students_NovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.students_NovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.students_NovBindingNavigator.Name = "students_NovBindingNavigator";
            this.students_NovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.students_NovBindingNavigator.Size = new System.Drawing.Size(291, 25);
            this.students_NovBindingNavigator.TabIndex = 1;
            this.students_NovBindingNavigator.Text = "bindingNavigator1";
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
            // students_NovBindingNavigatorSaveItem
            // 
            this.students_NovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.students_NovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("students_NovBindingNavigatorSaveItem.Image")));
            this.students_NovBindingNavigatorSaveItem.Name = "students_NovBindingNavigatorSaveItem";
            this.students_NovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.students_NovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.students_NovBindingNavigatorSaveItem.Click += new System.EventHandler(this.students_NovBindingNavigatorSaveItem_Click);
            // 
            // no_zkTextBox
            // 
            this.no_zkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "no_zk", true));
            this.no_zkTextBox.Location = new System.Drawing.Point(116, 71);
            this.no_zkTextBox.Name = "no_zkTextBox";
            this.no_zkTextBox.Size = new System.Drawing.Size(163, 20);
            this.no_zkTextBox.TabIndex = 3;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(116, 97);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(163, 20);
            this.famTextBox.TabIndex = 5;
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "im", true));
            this.imTextBox.Location = new System.Drawing.Point(116, 123);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(163, 20);
            this.imTextBox.TabIndex = 7;
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "ot", true));
            this.otTextBox.Location = new System.Drawing.Point(116, 149);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(163, 20);
            this.otTextBox.TabIndex = 9;
            // 
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(116, 175);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(163, 20);
            this.specTextBox.TabIndex = 11;
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "kurs", true));
            this.kursTextBox.Location = new System.Drawing.Point(116, 201);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(163, 20);
            this.kursTextBox.TabIndex = 13;
            // 
            // grTextBox
            // 
            this.grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "gr", true));
            this.grTextBox.Location = new System.Drawing.Point(116, 227);
            this.grTextBox.Name = "grTextBox";
            this.grTextBox.Size = new System.Drawing.Size(163, 20);
            this.grTextBox.TabIndex = 15;
            // 
            // biogrTextBox
            // 
            this.biogrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "biogr", true));
            this.biogrTextBox.Location = new System.Drawing.Point(116, 253);
            this.biogrTextBox.Name = "biogrTextBox";
            this.biogrTextBox.Size = new System.Drawing.Size(163, 20);
            this.biogrTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(26, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 348);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.students_NovBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentsForm";
            this.Text = "Студенты_Новак";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_NovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_NovBindingNavigator)).EndInit();
            this.students_NovBindingNavigator.ResumeLayout(false);
            this.students_NovBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_NovDataSet education_NovDataSet;
        private System.Windows.Forms.BindingSource students_NovBindingSource;
        private Education_NovDataSetTableAdapters.Students_NovTableAdapter students_NovTableAdapter;
        private Education_NovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator students_NovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton students_NovBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_zkTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
        private System.Windows.Forms.TextBox grTextBox;
        private System.Windows.Forms.TextBox biogrTextBox;
        private System.Windows.Forms.Button button1;
    }
}