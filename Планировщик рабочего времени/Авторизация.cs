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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль!");
            }
            else if (textBox1.Text.Trim() != passwordLabel1.Text.Trim())
            {
                MessageBox.Show("Вы ввели неправильный пароль!");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                if ((Convert.ToInt32(label4.Text) == 6) || (Convert.ToInt32(label4.Text) == 7))
                {
                    ГлавнаяРуководитель r = new ГлавнаяРуководитель();
                    r.kod = Convert.ToInt32(comboBox1.SelectedValue);
                    r.name = Convert.ToString(comboBox1.Text.Trim());
                    r.post = Convert.ToInt32(label4.Text);
                    r.Show();
                }
                else
                {
                    ГлавнаяПланировщик g = new ГлавнаяПланировщик();
                    g.kod = Convert.ToInt32(comboBox1.SelectedValue);
                    g.name = Convert.ToString(comboBox1.Text.Trim());
                    g.Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Регистрация r = new Регистрация();
            r.Show();
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
        }
    }
}
