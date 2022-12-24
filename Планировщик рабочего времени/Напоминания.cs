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
    public partial class Напоминания : Form
    {
        public Напоминания()
        {
            InitializeComponent();
        }
        public int kod;
        private void Напоминания_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Remindings". При необходимости она может быть перемещена или удалена.
            this.remindingsTableAdapter.Fill(this.workTimeDataSet.Remindings);
            remindingsBindingSource.Filter = "KodUser = " + Convert.ToString(kod);
        }

        private void remindingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (textRemindingTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели текст напоминания!");
            }
            else
            {
                remindingsDataGridView.CurrentRow.Cells[3].Value = kod;
                this.Validate();
                this.remindingsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.workTimeDataSet);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dateRemindingDateTimePicker.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remindingsBindingSource.Filter = "KodUser = " + Convert.ToString(kod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remindingsBindingSource.Filter = string.Format("KodUser = {0} and DateReminding = '{1}' ", kod, Convert.ToDateTime(dateTimePicker1.Text));
        }
    }
}
