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
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void subjects_NovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_NovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_NovDataSet);

        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet1.Subjects_Nov". При необходимости она может быть перемещена или удалена.
            this.subjects_NovTableAdapter1.Fill(this.education_NovDataSet1.Subjects_Nov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet1.Uspev_Nov". При необходимости она может быть перемещена или удалена.
            this.uspev_NovTableAdapter.Fill(this.education_NovDataSet1.Uspev_Nov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_NovDataSet.Subjects_Nov". При необходимости она может быть перемещена или удалена.
            this.subjects_NovTableAdapter.Fill(this.education_NovDataSet.Subjects_Nov);

        }
    }
}
