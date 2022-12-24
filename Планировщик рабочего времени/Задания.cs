using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планировщик_рабочего_времени
{
    public partial class Задания : Form
    {
        public Задания()
        {
            InitializeComponent();
        }

        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tasksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);

        }

        private void tasksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tasksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);

        }

        private void Задания_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.workTimeDataSet.Tasks);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tasksBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                tasksBindingSource.Filter = string.Format("DateTask = '{0}' ",Convert.ToDateTime(dateTimePicker1.Text));
            }
            if (radioButton2.Checked == true)
            {
                tasksBindingSource.Filter = "KodUser = " + Convert.ToString(comboBox1.SelectedValue);
            }
        }
    }
}
