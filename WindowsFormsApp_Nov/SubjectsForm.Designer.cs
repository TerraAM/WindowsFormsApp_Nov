namespace WindowsFormsApp_Nov
{
    partial class SubjectsForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label hrsLabel;
            System.Windows.Forms.Label deptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.education_NovDataSet = new WindowsFormsApp_Nov.Education_NovDataSet();
            this.subjects_NovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_NovTableAdapter = new WindowsFormsApp_Nov.Education_NovDataSetTableAdapters.Subjects_NovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Nov.Education_NovDataSetTableAdapters.TableAdapterManager();
            this.subjects_NovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjects_NovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.education_NovDataSet1 = new WindowsFormsApp_Nov.Education_NovDataSet1();
            this.uspev_NovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_NovTableAdapter = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.Uspev_NovTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.TableAdapterManager();
            this.subjects_NovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_NovTableAdapter1 = new WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.Subjects_NovTableAdapter();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.hrsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deptMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nameLabel = new System.Windows.Forms.Label();
            hrsLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingNavigator)).BeginInit();
            this.subjects_NovBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_NovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.Navy;
            nameLabel.Location = new System.Drawing.Point(19, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Название:";
            // 
            // hrsLabel
            // 
            hrsLabel.AutoSize = true;
            hrsLabel.ForeColor = System.Drawing.Color.Navy;
            hrsLabel.Location = new System.Drawing.Point(19, 108);
            hrsLabel.Name = "hrsLabel";
            hrsLabel.Size = new System.Drawing.Size(85, 13);
            hrsLabel.TabIndex = 4;
            hrsLabel.Text = "Объем в часах:";
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.ForeColor = System.Drawing.Color.Navy;
            deptLabel.Location = new System.Drawing.Point(19, 134);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(55, 13);
            deptLabel.TabIndex = 6;
            deptLabel.Text = "Кафедра:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дисциплины";
            // 
            // education_NovDataSet
            // 
            this.education_NovDataSet.DataSetName = "Education_NovDataSet";
            this.education_NovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjects_NovBindingSource
            // 
            this.subjects_NovBindingSource.DataMember = "Subjects_Nov";
            this.subjects_NovBindingSource.DataSource = this.education_NovDataSet;
            // 
            // subjects_NovTableAdapter
            // 
            this.subjects_NovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_NovTableAdapter = null;
            this.tableAdapterManager.Subjects_NovTableAdapter = this.subjects_NovTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Nov.Education_NovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_NovTableAdapter = null;
            // 
            // subjects_NovBindingNavigator
            // 
            this.subjects_NovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjects_NovBindingNavigator.BindingSource = this.subjects_NovBindingSource;
            this.subjects_NovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjects_NovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjects_NovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjects_NovBindingNavigatorSaveItem});
            this.subjects_NovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjects_NovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjects_NovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjects_NovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjects_NovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjects_NovBindingNavigator.Name = "subjects_NovBindingNavigator";
            this.subjects_NovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjects_NovBindingNavigator.Size = new System.Drawing.Size(320, 25);
            this.subjects_NovBindingNavigator.TabIndex = 2;
            this.subjects_NovBindingNavigator.Text = "bindingNavigator1";
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
            // subjects_NovBindingNavigatorSaveItem
            // 
            this.subjects_NovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjects_NovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjects_NovBindingNavigatorSaveItem.Image")));
            this.subjects_NovBindingNavigatorSaveItem.Name = "subjects_NovBindingNavigatorSaveItem";
            this.subjects_NovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjects_NovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjects_NovBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjects_NovBindingNavigatorSaveItem_Click);
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Students_NovTableAdapter = null;
            this.tableAdapterManager1.Subjects_NovTableAdapter = this.subjects_NovTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp_Nov.Education_NovDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Uspev_NovTableAdapter = this.uspev_NovTableAdapter;
            // 
            // subjects_NovBindingSource1
            // 
            this.subjects_NovBindingSource1.DataMember = "Subjects_Nov";
            this.subjects_NovBindingSource1.DataSource = this.education_NovDataSet1;
            // 
            // subjects_NovTableAdapter1
            // 
            this.subjects_NovTableAdapter1.ClearBeforeFill = true;
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_NovBindingSource1, "name", true));
            this.nameMaskedTextBox.Location = new System.Drawing.Point(110, 79);
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.nameMaskedTextBox.TabIndex = 7;
            // 
            // hrsMaskedTextBox
            // 
            this.hrsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_NovBindingSource1, "hrs", true));
            this.hrsMaskedTextBox.Location = new System.Drawing.Point(110, 105);
            this.hrsMaskedTextBox.Mask = "999";
            this.hrsMaskedTextBox.Name = "hrsMaskedTextBox";
            this.hrsMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.hrsMaskedTextBox.TabIndex = 8;
            // 
            // deptMaskedTextBox
            // 
            this.deptMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_NovBindingSource1, "dept", true));
            this.deptMaskedTextBox.Location = new System.Drawing.Point(110, 131);
            this.deptMaskedTextBox.Name = "deptMaskedTextBox";
            this.deptMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.deptMaskedTextBox.TabIndex = 9;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 193);
            this.Controls.Add(this.deptMaskedTextBox);
            this.Controls.Add(this.hrsMaskedTextBox);
            this.Controls.Add(this.nameMaskedTextBox);
            this.Controls.Add(deptLabel);
            this.Controls.Add(hrsLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.subjects_NovBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "SubjectsForm";
            this.Text = "Дисциплины_Новак";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingNavigator)).EndInit();
            this.subjects_NovBindingNavigator.ResumeLayout(false);
            this.subjects_NovBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.education_NovDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_NovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_NovBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_NovDataSet education_NovDataSet;
        private System.Windows.Forms.BindingSource subjects_NovBindingSource;
        private Education_NovDataSetTableAdapters.Subjects_NovTableAdapter subjects_NovTableAdapter;
        private Education_NovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjects_NovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjects_NovBindingNavigatorSaveItem;
        private Education_NovDataSet1 education_NovDataSet1;
        private System.Windows.Forms.BindingSource uspev_NovBindingSource;
        private Education_NovDataSet1TableAdapters.Uspev_NovTableAdapter uspev_NovTableAdapter;
        private Education_NovDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private Education_NovDataSet1TableAdapters.Subjects_NovTableAdapter subjects_NovTableAdapter1;
        private System.Windows.Forms.BindingSource subjects_NovBindingSource1;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox hrsMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox deptMaskedTextBox;
    }
}