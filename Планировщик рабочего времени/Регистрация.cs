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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);

        }

        private void Регистрация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.workTimeDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.workTimeDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
            postsBindingSource.Filter = "KodPost not in (6, 7)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите отменить регистрацию? Введенные данные будут потеряны", "Планировщик", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                DialogResult result = MessageBox.Show("Вы хотите сохранить данные?", "Планировщик", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connStr = @"Data Source=localhost\sqlexpress;Initial Catalog=WorkTime;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(connStr))
                    {
                        cn.Open();
                        using (SqlCommand command = cn.CreateCommand())
                        {
                            command.CommandText = "INSERT INTO Users (NameUser, Birth, Telephone, KodPost, RoomNumber, Password, Email) VALUES (@name, @birth, @tel, @post, @room, @pass, @email)";
                            command.Parameters.Add(new SqlParameter("@name", nameUserTextBox.Text.Trim()));
                            command.Parameters.Add(new SqlParameter("@birth", Convert.ToDateTime(birthDateTimePicker.Text)));
                            command.Parameters.Add(new SqlParameter("@tel", telephoneMaskedTextBox.Text));
                            command.Parameters.Add(new SqlParameter("@post", kodPostComboBox.SelectedValue));
                            command.Parameters.Add(new SqlParameter("@room", Convert.ToInt32(roomNumberTextBox.Text)));
                            command.Parameters.Add(new SqlParameter("@pass", passwordTextBox.Text));
                            command.Parameters.Add(new SqlParameter("@email", emailTextBox.Text));
                            command.ExecuteNonQuery();
                            MessageBox.Show("Данные сохранены! Для входа в систему авторизуйтесь");
                            cn.Close();
                            Close();
                        }

                    }

                }

            }
        }
    }
}
