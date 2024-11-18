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
    public partial class Uspev : Form
    {
        public Uspev()
        {
            InitializeComponent();
        }

        private void uspev_IvanovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uspev_IvanovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_RomanDataSet);

        }

        private void Uspev_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Students_Ivanov". При необходимости она может быть перемещена или удалена.
            this.students_IvanovTableAdapter.Fill(this.education_RomanDataSet.Students_Ivanov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Subjects_Ivanov". При необходимости она может быть перемещена или удалена.
            this.subjects_IvanovTableAdapter.Fill(this.education_RomanDataSet.Subjects_Ivanov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Uspev_Ivanov". При необходимости она может быть перемещена или удалена.
            this.uspev_IvanovTableAdapter.Fill(this.education_RomanDataSet.Uspev_Ivanov);

        }
    }
}
