namespace WindowsFormsApp_Iva
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label hrsLabel;
            System.Windows.Forms.Label deptLabel;
            this.education_RomanDataSet = new WindowsFormsApp_Iva.Education_RomanDataSet();
            this.subjects_IvanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_IvanovTableAdapter = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.Subjects_IvanovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.TableAdapterManager();
            this.subjects_IvanovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjects_IvanovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.hrsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deptMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nameLabel = new System.Windows.Forms.Label();
            hrsLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_RomanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_IvanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_IvanovBindingNavigator)).BeginInit();
            this.subjects_IvanovBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // education_RomanDataSet
            // 
            this.education_RomanDataSet.DataSetName = "Education_RomanDataSet";
            this.education_RomanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjects_IvanovBindingSource
            // 
            this.subjects_IvanovBindingSource.DataMember = "Subjects_Ivanov";
            this.subjects_IvanovBindingSource.DataSource = this.education_RomanDataSet;
            // 
            // subjects_IvanovTableAdapter
            // 
            this.subjects_IvanovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_IvanovTableAdapter = null;
            this.tableAdapterManager.Subjects_IvanovTableAdapter = this.subjects_IvanovTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Iva.Education_RomanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_IvanovTableAdapter = null;
            // 
            // subjects_IvanovBindingNavigator
            // 
            this.subjects_IvanovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjects_IvanovBindingNavigator.BindingSource = this.subjects_IvanovBindingSource;
            this.subjects_IvanovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjects_IvanovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjects_IvanovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjects_IvanovBindingNavigatorSaveItem});
            this.subjects_IvanovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjects_IvanovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjects_IvanovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjects_IvanovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjects_IvanovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjects_IvanovBindingNavigator.Name = "subjects_IvanovBindingNavigator";
            this.subjects_IvanovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjects_IvanovBindingNavigator.Size = new System.Drawing.Size(331, 25);
            this.subjects_IvanovBindingNavigator.TabIndex = 0;
            this.subjects_IvanovBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // subjects_IvanovBindingNavigatorSaveItem
            // 
            this.subjects_IvanovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjects_IvanovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjects_IvanovBindingNavigatorSaveItem.Image")));
            this.subjects_IvanovBindingNavigatorSaveItem.Name = "subjects_IvanovBindingNavigatorSaveItem";
            this.subjects_IvanovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjects_IvanovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjects_IvanovBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjects_IvanovBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            nameLabel.Location = new System.Drawing.Point(19, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Название:";
            // 
            // hrsLabel
            // 
            hrsLabel.AutoSize = true;
            hrsLabel.ForeColor = System.Drawing.Color.DarkBlue;
            hrsLabel.Location = new System.Drawing.Point(19, 108);
            hrsLabel.Name = "hrsLabel";
            hrsLabel.Size = new System.Drawing.Size(85, 13);
            hrsLabel.TabIndex = 3;
            hrsLabel.Text = "Объем в часах:";
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.ForeColor = System.Drawing.Color.DarkBlue;
            deptLabel.Location = new System.Drawing.Point(19, 134);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(55, 13);
            deptLabel.TabIndex = 5;
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
            this.label1.TabIndex = 7;
            this.label1.Text = "Дисциплины";
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_IvanovBindingSource, "name", true));
            this.nameMaskedTextBox.Location = new System.Drawing.Point(110, 79);
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.nameMaskedTextBox.TabIndex = 8;
            // 
            // hrsMaskedTextBox
            // 
            this.hrsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_IvanovBindingSource, "hrs", true));
            this.hrsMaskedTextBox.Location = new System.Drawing.Point(110, 105);
            this.hrsMaskedTextBox.Mask = "999";
            this.hrsMaskedTextBox.Name = "hrsMaskedTextBox";
            this.hrsMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.hrsMaskedTextBox.TabIndex = 9;
            // 
            // deptMaskedTextBox
            // 
            this.deptMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_IvanovBindingSource, "dept", true));
            this.deptMaskedTextBox.Location = new System.Drawing.Point(110, 134);
            this.deptMaskedTextBox.Name = "deptMaskedTextBox";
            this.deptMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.deptMaskedTextBox.TabIndex = 10;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 193);
            this.Controls.Add(this.deptMaskedTextBox);
            this.Controls.Add(this.hrsMaskedTextBox);
            this.Controls.Add(this.nameMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(deptLabel);
            this.Controls.Add(hrsLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.subjects_IvanovBindingNavigator);
            this.Name = "Subjects";
            this.Text = "Справочник предметов_Иванов";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_RomanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_IvanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_IvanovBindingNavigator)).EndInit();
            this.subjects_IvanovBindingNavigator.ResumeLayout(false);
            this.subjects_IvanovBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Education_RomanDataSet education_RomanDataSet;
        private System.Windows.Forms.BindingSource subjects_IvanovBindingSource;
        private Education_RomanDataSetTableAdapters.Subjects_IvanovTableAdapter subjects_IvanovTableAdapter;
        private Education_RomanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjects_IvanovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjects_IvanovBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox hrsMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox deptMaskedTextBox;
    }
}