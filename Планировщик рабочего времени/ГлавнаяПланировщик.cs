using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Планировщик_рабочего_времени
{
    public partial class ГлавнаяПланировщик : Form
    {
        public ГлавнаяПланировщик()
        {
            InitializeComponent();
        }
        public int kod;
        public string name;
        private void plan()
        {
            sheduleBindingSource.Filter = string.Format("KodUser = {0} and DateRecord = '{1}' ", kod, Convert.ToDateTime(dateTimePicker1.Text));
            if (sheduleDataGridView.RowCount == 1)
            {
                button1.Visible = true;
            }
            else button1.Visible = false;
        }

        private void ГлавнаяПланировщик_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Shedule". При необходимости она может быть перемещена или удалена.
            this.sheduleTableAdapter.Fill(this.workTimeDataSet.Shedule);
            timer1.Start();
            statusStrip1.Items[1].Text = "Дата: " + DateTime.Now.ToString("dd MMMM yyyy");
            statusStrip1.Items[2].Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
            statusStrip1.Items[0].Text = "Пользователь: " + name;
            this.todayRemindingTableAdapter1.Fill(this.workTimeDataSet.TodayReminding, kod);
            this.todayTaskTableAdapter.Fill(this.workTimeDataSet.TodayTask, kod);
            groupBox1.Text = "Напоминание на " + DateTime.Now.ToString("dd MMMM yyyy");
            if (label1.Text == "")
            {
                label1.Text = "На сегодня напоминаний нету";
            }
            groupBox2.Text = "Задание на " + DateTime.Now.ToString("dd MMMM yyyy");
            if (label2.Text == "")
            {
                label2.Text = "Заданий на сегодня не назначено";
            }
            plan();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[2].Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Планировщик", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Настройка n = new Настройка();
            n.kod = kod;
            n.Show();
        }

        private void телефонныйСправочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ТелефоннаяКнига t = new ТелефоннаяКнига();
            t.Show();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СменаПароля s = new СменаПароля();
            s.kod = kod;
            s.Show();
        }

        private void напоминанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Напоминания n = new Напоминания();
            n.kod = kod;
            n.Show();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ГлавнаяПланировщик_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sheduleDataGridView.CurrentRow.Cells[1].Value = kod;
            sheduleDataGridView.CurrentRow.Cells[5].Value = Convert.ToDateTime(dateTimePicker1.Text);
            sheduleDataGridView.CurrentRow.Cells[6].Value = 0;
            this.Validate();
            this.sheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);
            plan();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            plan();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=localhost\sqlexpress;Initial Catalog=WorkTime;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                cn.Open();
                using (SqlCommand command = cn.CreateCommand())
                {
                    command.CommandText = "Exec CreatePlan @kod, @dat";
                    command.Parameters.Add(new SqlParameter("@kod", kod));
                    command.Parameters.Add(new SqlParameter("@dat", Convert.ToDateTime(dateTimePicker1.Text)));
                    command.ExecuteNonQuery();
                    cn.Close();
                }

            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Shedule". При необходимости она может быть перемещена или удалена.
            this.sheduleTableAdapter.Fill(this.workTimeDataSet.Shedule);
            plan();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Отчет o = new Отчет();
            o.kod = kod;
            o.stat = 2;
            o.dat1 = dateTimePicker1.Text;
            o.Show();
        }
    }
}
