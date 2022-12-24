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
    public partial class СменаПароля : Form
    {
        public СменаПароля()
        {
            InitializeComponent();
        }
        public int kod;
        private void СменаПароля_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workTimeDataSet.Users);
            usersBindingSource.Filter = "KodUser = " + Convert.ToString(kod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели старый пароль!");
            }
            else if (label3.Text.Trim() != textBox1.Text.Trim())
            {
                MessageBox.Show("Вы ввели неверно старый пароль!");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели новый пароль!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите сменить пароль?", "Планировщик", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connStr = @"Data Source=localhost\sqlexpress;Initial Catalog=WorkTime;Integrated Security=True";
                    using (SqlConnection cn = new SqlConnection(connStr))
                    {
                        cn.Open();
                        using (SqlCommand command = cn.CreateCommand())
                        {
                            command.CommandText = "update Users set Password = @pass where KodUser = @kod";
                            command.Parameters.Add(new SqlParameter("@pass", textBox2.Text));
                            command.Parameters.Add(new SqlParameter("@kod", kod));
                            command.ExecuteNonQuery();
                            MessageBox.Show("Данные сохранены! Программа будет перезапущена.");
                            cn.Close();
                            Application.Restart();
                        }

                    }

                }
            }
        }
    }
}
