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
    public partial class UspevForm : Form
    {
        public UspevForm()
        {
            InitializeComponent();
        }

        private void uspev_NovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uspev_NovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_NovDataSet1);

        }

        private void UspevForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet1.Students_Nov". При необходимости она может быть перемещена или удалена.
            this.students_NovTableAdapter.Fill(this.education_NovDataSet1.Students_Nov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet1.Subjects_Nov". При необходимости она может быть перемещена или удалена.
            this.subjects_NovTableAdapter.Fill(this.education_NovDataSet1.Subjects_Nov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet1.Uspev_Nov". При необходимости она может быть перемещена или удалена.
            this.uspev_NovTableAdapter.Fill(this.education_NovDataSet1.Uspev_Nov);

        }

        private void uspev_NovBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uspev_NovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_NovDataSet1);

        }
    }
}
