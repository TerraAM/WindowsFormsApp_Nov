using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Nov
{
    public partial class StudentsForm : Form
    {
        private StudentsTable studentsTable;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void students_NovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students_NovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_NovDataSet);

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet.Students_Nov". При необходимости она может быть перемещена или удалена.
            this.students_NovTableAdapter.Fill(this.education_NovDataSet.Students_Nov);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsTable = new StudentsTable();
            studentsTable.Visible = true;
        }
    }
}
