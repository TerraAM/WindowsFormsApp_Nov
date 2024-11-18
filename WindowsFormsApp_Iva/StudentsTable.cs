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
    public partial class StudentsTable : Form
    {
        private System.Windows.Forms.DataGridViewColumn COL;
        public StudentsTable()
        {
            InitializeComponent();
        }

        private void StudentsTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Uspev_Ivanov". При необходимости она может быть перемещена или удалена.
            this.uspev_IvanovTableAdapter.Fill(this.education_RomanDataSet.Uspev_Ivanov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_RomanDataSet.Students_Ivanov". При необходимости она может быть перемещена или удалена.
            this.students_IvanovTableAdapter.Fill(this.education_RomanDataSet.Students_Ivanov);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students_IvanovDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < students_IvanovDataGridView.RowCount - 1; j++)
                {
                    students_IvanovDataGridView[i, j].Style.BackColor = Color.White;
                    students_IvanovDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < students_IvanovDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < students_IvanovDataGridView.RowCount - 1; j++)
                {
                    if (students_IvanovDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        students_IvanovDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        students_IvanovDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn8;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn7;
                    break;
            }
            if (radioButton1.Checked)
                students_IvanovDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                students_IvanovDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsIvanovBindingSource.Filter = "fam='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentsIvanovBindingSource.Filter = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
