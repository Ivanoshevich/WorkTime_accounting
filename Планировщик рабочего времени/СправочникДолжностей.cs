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
    public partial class СправочникДолжностей : Form
    {
        public СправочникДолжностей()
        {
            InitializeComponent();
        }

        private void postsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workTimeDataSet);

        }

        private void СправочникДолжностей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.workTimeDataSet.Posts);

        }
    }
}
