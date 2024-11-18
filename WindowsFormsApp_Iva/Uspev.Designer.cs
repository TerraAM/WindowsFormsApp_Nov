namespace WindowsFormsApp_Iva
{
    partial class Uspev
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
            System.Windows.Forms.Label studentLabel;
            System.Windows.Forms.Label predmetLabel;
            System.Windows.Forms.Label ocenkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uspev));
            this.education_RomanDataSet = new WindowsFormsApp_Iva.Education_RomanDataSet();
            this.uspev_IvanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_IvanovTableAdapter = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.Uspev_IvanovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.TableAdapterManager();
            this.uspev_IvanovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uspev_IvanovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.subjectsIvanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_IvanovTableAdapter = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.Subjects_IvanovTableAdapter();
            this.fKUspevIvanovSubjectsIvanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subjectsIvanovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentsIvanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_IvanovTableAdapter = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.Students_IvanovTableAdapter();
            this.subjectsIvanovBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            studentLabel = new System.Windows.Forms.Label();
            predmetLabel = new System.Windows.Forms.Label();
            ocenkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_RomanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_IvanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_IvanovBindingNavigator)).BeginInit();
            this.uspev_IvanovBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsIvanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUspevIvanovSubjectsIvanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsIvanovBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsIvanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsIvanovBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.ForeColor = System.Drawing.Color.DarkBlue;
            studentLabel.Location = new System.Drawing.Point(23, 64);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(50, 13);
            studentLabel.TabIndex = 1;
            studentLabel.Text = "Студент:";
            // 
            // predmetLabel
            // 
            predmetLabel.AutoSize = true;
            predmetLabel.ForeColor = System.Drawing.Color.DarkBlue;
            predmetLabel.Location = new System.Drawing.Point(23, 89);
            predmetLabel.Name = "predmetLabel";
            predmetLabel.Size = new System.Drawing.Size(55, 13);
            predmetLabel.TabIndex = 3;
            predmetLabel.Text = "Предмет:";
            // 
            // ocenkaLabel
            // 
            ocenkaLabel.AutoSize = true;
            ocenkaLabel.ForeColor = System.Drawing.Color.DarkBlue;
            ocenkaLabel.Location = new System.Drawing.Point(23, 115);
            ocenkaLabel.Name = "ocenkaLabel";
            ocenkaLabel.Size = new System.Drawing.Size(48, 13);
            ocenkaLabel.TabIndex = 5;
            ocenkaLabel.Text = "Оценка:";
            // 
            // education_RomanDataSet
            // 
            this.education_RomanDataSet.DataSetName = "Education_RomanDataSet";
            this.education_RomanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspev_IvanovBindingSource
            // 
            this.uspev_IvanovBindingSource.DataMember = "Uspev_Ivanov";
            this.uspev_IvanovBindingSource.DataSource = this.education_RomanDataSet;
            // 
            // uspev_IvanovTableAdapter
            // 
            this.uspev_IvanovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_IvanovTableAdapter = null;
            this.tableAdapterManager.Subjects_IvanovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_IvanovTableAdapter = this.uspev_IvanovTableAdapter;
            // 
            // uspev_IvanovBindingNavigator
            // 
            this.uspev_IvanovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uspev_IvanovBindingNavigator.BindingSource = this.uspev_IvanovBindingSource;
            this.uspev_IvanovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uspev_IvanovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uspev_IvanovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uspev_IvanovBindingNavigatorSaveItem});
            this.uspev_IvanovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspev_IvanovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uspev_IvanovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uspev_IvanovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uspev_IvanovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uspev_IvanovBindingNavigator.Name = "uspev_IvanovBindingNavigator";
            this.uspev_IvanovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uspev_IvanovBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.uspev_IvanovBindingNavigator.TabIndex = 0;
            this.uspev_IvanovBindingNavigator.Text = "bindingNavigator1";
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
            // uspev_IvanovBindingNavigatorSaveItem
            // 
            this.uspev_IvanovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uspev_IvanovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uspev_IvanovBindingNavigatorSaveItem.Image")));
            this.uspev_IvanovBindingNavigatorSaveItem.Name = "uspev_IvanovBindingNavigatorSaveItem";
            this.uspev_IvanovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uspev_IvanovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.uspev_IvanovBindingNavigatorSaveItem.Click += new System.EventHandler(this.uspev_IvanovBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Успеваемость";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_IvanovBindingSource, "ocenka", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(79, 112);
            this.maskedTextBox1.Mask = "9";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // subjectsIvanovBindingSource
            // 
            this.subjectsIvanovBindingSource.DataMember = "Subjects_Ivanov";
            this.subjectsIvanovBindingSource.DataSource = this.education_RomanDataSet;
            // 
            // subjects_IvanovTableAdapter
            // 
            this.subjects_IvanovTableAdapter.ClearBeforeFill = true;
            // 
            // fKUspevIvanovSubjectsIvanovBindingSource
            // 
            this.fKUspevIvanovSubjectsIvanovBindingSource.DataMember = "FK_Uspev_Ivanov_Subjects_Ivanov";
            this.fKUspevIvanovSubjectsIvanovBindingSource.DataSource = this.subjectsIvanovBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uspev_IvanovBindingSource, "predmet", true));
            this.comboBox1.DataSource = this.subjectsIvanovBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "predm_ID";
            // 
            // subjectsIvanovBindingSource1
            // 
            this.subjectsIvanovBindingSource1.DataMember = "Subjects_Ivanov";
            this.subjectsIvanovBindingSource1.DataSource = this.education_RomanDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uspev_IvanovBindingSource, "student", true));
            this.comboBox2.DataSource = this.studentsIvanovBindingSource;
            this.comboBox2.DisplayMember = "fam";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(79, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "stud_ID";
            // 
            // studentsIvanovBindingSource
            // 
            this.studentsIvanovBindingSource.DataMember = "Students_Ivanov";
            this.studentsIvanovBindingSource.DataSource = this.education_RomanDataSet;
            // 
            // students_IvanovTableAdapter
            // 
            this.students_IvanovTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsIvanovBindingSource2
            // 
            this.subjectsIvanovBindingSource2.DataMember = "Subjects_Ivanov";
            this.subjectsIvanovBindingSource2.DataSource = this.education_RomanDataSet;
            // 
            // Uspev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 180);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(ocenkaLabel);
            this.Controls.Add(predmetLabel);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.uspev_IvanovBindingNavigator);
            this.Name = "Uspev";
            this.Text = "Успеваемость_Иванов";
            this.Load += new System.EventHandler(this.Uspev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_RomanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_IvanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_IvanovBindingNavigator)).EndInit();
            this.uspev_IvanovBindingNavigator.ResumeLayout(false);
            this.uspev_IvanovBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsIvanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUspevIvanovSubjectsIvanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsIvanovBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsIvanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsIvanovBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Education_RomanDataSet education_RomanDataSet;
        private System.Windows.Forms.BindingSource uspev_IvanovBindingSource;
        private Education_RomanDataSetTableAdapters.Uspev_IvanovTableAdapter uspev_IvanovTableAdapter;
        private Education_RomanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uspev_IvanovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uspev_IvanovBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource subjectsIvanovBindingSource;
        private Education_RomanDataSetTableAdapters.Subjects_IvanovTableAdapter subjects_IvanovTableAdapter;
        private System.Windows.Forms.BindingSource fKUspevIvanovSubjectsIvanovBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource subjectsIvanovBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource studentsIvanovBindingSource;
        private Education_RomanDataSetTableAdapters.Students_IvanovTableAdapter students_IvanovTableAdapter;
        private System.Windows.Forms.BindingSource subjectsIvanovBindingSource2;
    }
}