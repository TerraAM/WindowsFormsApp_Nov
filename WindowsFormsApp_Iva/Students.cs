using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Iva
{
    public partial class Students : Form
    {
        StudentsTable studentsTable;
        public Students()
        {
            InitializeComponent();
        }

        private void students_IvanovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students_IvanovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_RomanDataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Students_Ivanov". При необходимости она может быть перемещена или удалена.
            this.students_IvanovTableAdapter.Fill(this.education_RomanDataSet.Students_Ivanov);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsTable = new StudentsTable();
            studentsTable.Visible = true;
        }
    }
}
