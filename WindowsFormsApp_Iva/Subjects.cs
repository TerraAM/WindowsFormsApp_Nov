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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void subjects_IvanovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_IvanovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_RomanDataSet);

        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Subjects_Ivanov". При необходимости она может быть перемещена или удалена.
            this.subjects_IvanovTableAdapter.Fill(this.education_RomanDataSet.Subjects_Ivanov);

        }
    }
}
