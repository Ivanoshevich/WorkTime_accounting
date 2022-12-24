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
    public partial class ПросмотрАктивностей : Form
    {
        public ПросмотрАктивностей()
        {
            InitializeComponent();
        }

        private void sheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);

        }
        private void Search()
        {
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                sheduleBindingSource.Filter = string.Format("DateRecord = '{0}'  and KodUser = {1}", Convert.ToDateTime(dateTimePicker1.Text), comboBox1.SelectedValue);
            }
            if ((checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                sheduleBindingSource.Filter = string.Format("DateRecord = '{0}'", Convert.ToDateTime(dateTimePicker1.Text));
            }
            if ((checkBox1.Checked == false) && (checkBox2.Checked == true))
            {
                sheduleBindingSource.Filter = string.Format("KodUser = {0}", comboBox1.SelectedValue);
            }
        }
        private void ПросмотрАктивностей_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Shedule". При необходимости она может быть перемещена или удалена.
            this.sheduleTableAdapter.Fill(this.workTimeDataSet.Shedule);
            Search();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sheduleBindingSource.Filter = "";
        }
    }
}
