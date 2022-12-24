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
    public partial class ГлавнаяРуководитель : Form
    {
        public ГлавнаяРуководитель()
        {
            InitializeComponent();
        }

        private void написаниеЗаданийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задания z = new Задания();
            z.Show();
        }
        public string name;
        public int kod, post;
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Планировщик", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ГлавнаяРуководитель_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ГлавнаяРуководитель_Load(object sender, EventArgs e)
        {
            timer1.Start();
            statusStrip1.Items[1].Text = "Дата: " + DateTime.Now.ToString("dd MMMM yyyy");
            statusStrip1.Items[2].Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
            statusStrip1.Items[0].Text = "Пользователь: " + name;
            if (post == 6)
            {
                администрированиеToolStripMenuItem.Visible = false;
            }
            if (post == 7)
            {
                профильToolStripMenuItem.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[2].Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void телефонныйСправочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ТелефоннаяКнига t = new ТелефоннаяКнига();
            t.Show();
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Настройка n = new Настройка();
            n.kod = kod;
            n.post = post;
            n.Show();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СменаПароля s = new СменаПароля();
            s.kod = kod;
            s.Show();
        }

        private void просмотрАктивностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ПросмотрАктивностей p = new ПросмотрАктивностей();
            p.Show();
        }

        private void справочникДолжностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СправочникДолжностей d = new СправочникДолжностей();
            d.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Пользователи p = new Пользователи();
            p.Show();
        }

        private void неВыполненныеЗаданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Период p = new Период();
            p.stat = 3;
            p.Show();
        }

        private void отчетОбАктивностяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Период p = new Период();
            p.stat = 4;
            p.Show();
        }
    }
}
