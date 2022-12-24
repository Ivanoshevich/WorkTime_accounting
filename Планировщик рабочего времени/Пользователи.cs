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
    public partial class Пользователи : Form
    {
        public Пользователи()
        {
            InitializeComponent();
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
            else if (passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели пароль!");
                passwordTextBox.Focus();
            }
            else
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.workTimeDataSet);
            }
        }

        private void Пользователи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.workTimeDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);

        }
    }
}
