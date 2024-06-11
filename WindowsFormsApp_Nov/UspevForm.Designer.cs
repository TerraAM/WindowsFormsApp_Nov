namespace WindowsFormsApp_Nov
{
    partial class UspevForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UspevForm));
            this.label1 = new System.Windows.Forms.Label();
            this.education_NovDataSet1 = new WindowsFormsApp_Nov.Education_NovDataSet1();
            this.uspev_NovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_NovTableAdapter = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.Uspev_NovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.TableAdapterManager();
            this.uspev_NovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uspev_NovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ocenkaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subjects_NovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_NovTableAdapter = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.Subjects_NovTableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.students_NovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_NovTableAdapter = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.Students_NovTableAdapter();
            this.famComboBox = new System.Windows.Forms.ComboBox();
            studentLabel = new System.Windows.Forms.Label();
            predmetLabel = new System.Windows.Forms.Label();
            ocenkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_NovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_NovBindingNavigator)).BeginInit();
            this.uspev_NovBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_NovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.ForeColor = System.Drawing.Color.DarkBlue;
            studentLabel.Location = new System.Drawing.Point(23, 64);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(50, 13);
            studentLabel.TabIndex = 3;
            studentLabel.Text = "Студент:";
            // 
            // predmetLabel
            // 
            predmetLabel.AutoSize = true;
            predmetLabel.ForeColor = System.Drawing.Color.DarkBlue;
            predmetLabel.Location = new System.Drawing.Point(21, 90);
            predmetLabel.Name = "predmetLabel";
            predmetLabel.Size = new System.Drawing.Size(55, 13);
            predmetLabel.TabIndex = 4;
            predmetLabel.Text = "Предмет:";
            // 
            // ocenkaLabel
            // 
            ocenkaLabel.AutoSize = true;
            ocenkaLabel.ForeColor = System.Drawing.Color.DarkBlue;
            ocenkaLabel.Location = new System.Drawing.Point(22, 116);
            ocenkaLabel.Name = "ocenkaLabel";
            ocenkaLabel.Size = new System.Drawing.Size(48, 13);
            ocenkaLabel.TabIndex = 6;
            ocenkaLabel.Text = "Оценка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Успеваемость";
            // 
            // education_NovDataSet1
            // 
            this.education_NovDataSet1.DataSetName = "Education_NovDataSet1";
            this.education_NovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspev_NovBindingSource
            // 
            this.uspev_NovBindingSource.DataMember = "Uspev_Nov";
            this.uspev_NovBindingSource.DataSource = this.education_NovDataSet1;
            // 
            // uspev_NovTableAdapter
            // 
            this.uspev_NovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_NovTableAdapter = null;
            this.tableAdapterManager.Subjects_NovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_NovTableAdapter = this.uspev_NovTableAdapter;
            // 
            // uspev_NovBindingNavigator
            // 
            this.uspev_NovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uspev_NovBindingNavigator.BindingSource = this.uspev_NovBindingSource;
            this.uspev_NovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uspev_NovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uspev_NovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uspev_NovBindingNavigatorSaveItem});
            this.uspev_NovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspev_NovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uspev_NovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uspev_NovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uspev_NovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uspev_NovBindingNavigator.Name = "uspev_NovBindingNavigator";
            this.uspev_NovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uspev_NovBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.uspev_NovBindingNavigator.TabIndex = 3;
            this.uspev_NovBindingNavigator.Text = "bindingNavigator1";
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
            // uspev_NovBindingNavigatorSaveItem
            // 
            this.uspev_NovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uspev_NovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uspev_NovBindingNavigatorSaveItem.Image")));
            this.uspev_NovBindingNavigatorSaveItem.Name = "uspev_NovBindingNavigatorSaveItem";
            this.uspev_NovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uspev_NovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.uspev_NovBindingNavigatorSaveItem.Click += new System.EventHandler(this.uspev_NovBindingNavigatorSaveItem_Click_1);
            // 
            // ocenkaMaskedTextBox
            // 
            this.ocenkaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_NovBindingSource, "ocenka", true));
            this.ocenkaMaskedTextBox.Location = new System.Drawing.Point(79, 113);
            this.ocenkaMaskedTextBox.Mask = "9";
            this.ocenkaMaskedTextBox.Name = "ocenkaMaskedTextBox";
            this.ocenkaMaskedTextBox.Size = new System.Drawing.Size(180, 20);
            this.ocenkaMaskedTextBox.TabIndex = 8;
            // 
            // subjects_NovBindingSource
            // 
            this.subjects_NovBindingSource.DataMember = "Subjects_Nov";
            this.subjects_NovBindingSource.DataSource = this.education_NovDataSet1;
            // 
            // subjects_NovTableAdapter
            // 
            this.subjects_NovTableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_NovBindingSource, "name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjects_NovBindingSource, "name", true));
            this.nameComboBox.DataSource = this.subjects_NovBindingSource;
            this.nameComboBox.DisplayMember = "name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(79, 87);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(180, 21);
            this.nameComboBox.TabIndex = 9;
            this.nameComboBox.ValueMember = "name";
            // 
            // students_NovBindingSource
            // 
            this.students_NovBindingSource.DataMember = "Students_Nov";
            this.students_NovBindingSource.DataSource = this.education_NovDataSet1;
            // 
            // students_NovTableAdapter
            // 
            this.students_NovTableAdapter.ClearBeforeFill = true;
            // 
            // famComboBox
            // 
            this.famComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_NovBindingSource, "fam", true));
            this.famComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.students_NovBindingSource, "fam", true));
            this.famComboBox.DataSource = this.students_NovBindingSource;
            this.famComboBox.DisplayMember = "fam";
            this.famComboBox.FormattingEnabled = true;
            this.famComboBox.Location = new System.Drawing.Point(79, 60);
            this.famComboBox.Name = "famComboBox";
            this.famComboBox.Size = new System.Drawing.Size(180, 21);
            this.famComboBox.TabIndex = 10;
            this.famComboBox.ValueMember = "fam";
            // 
            // UspevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 180);
            this.Controls.Add(this.famComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.ocenkaMaskedTextBox);
            this.Controls.Add(ocenkaLabel);
            this.Controls.Add(predmetLabel);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.uspev_NovBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "UspevForm";
            this.Text = "Успеваемость_Новак";
            this.Load += new System.EventHandler(this.UspevForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_NovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_NovBindingNavigator)).EndInit();
            this.uspev_NovBindingNavigator.ResumeLayout(false);
            this.uspev_NovBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_NovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_NovDataSet1 education_NovDataSet1;
        private System.Windows.Forms.BindingSource uspev_NovBindingSource;
        private Education_NovDataSet1TableAdapters.Uspev_NovTableAdapter uspev_NovTableAdapter;
        private Education_NovDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uspev_NovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uspev_NovBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox ocenkaMaskedTextBox;
        private System.Windows.Forms.BindingSource subjects_NovBindingSource;
        private Education_NovDataSet1TableAdapters.Subjects_NovTableAdapter subjects_NovTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.BindingSource students_NovBindingSource;
        private Education_NovDataSet1TableAdapters.Students_NovTableAdapter students_NovTableAdapter;
        private System.Windows.Forms.ComboBox famComboBox;
    }
}