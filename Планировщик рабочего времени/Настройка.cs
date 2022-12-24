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
    public partial class Настройка : Form
    {
        public Настройка()
        {
            InitializeComponent();
        }
        public int kod, post;
        private void Настройка_Load(object sender, EventArgs e)
        {
            this.postsTableAdapter.Fill(this.workTimeDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
            
            usersBindingSource.Filter = "KodUser = " + Convert.ToString(kod);
            if (post != 6)
                postsBindingSource.Filter = "KodPost not in (6, 7)";
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nameUserTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели ФИО пользователя!");
                nameUserTextBox.Focus();
            }
            else if (kodPostComboBox.Text.Trim() == "")
            {
                MessageBox.Show("Вы не выбрали занимаемую должность!");
                kodPostComboBox.Focus();
            }
            else if (roomNumberTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели номер кабинета пользователя!");
                roomNumberTextBox.Focus();
            }
            else
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.workTimeDataSet);
                MessageBox.Show("Сохранено!");
            }

        }
    }
}
