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
    public partial class ТелефоннаяКнига : Form
    {
        public ТелефоннаяКнига()
        {
            InitializeComponent();
        }

        private void ТелефоннаяКнига_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workTimeDataSet.PhoneBook". При необходимости она может быть перемещена или удалена.
            this.phoneBookTableAdapter.Fill(this.workTimeDataSet.PhoneBook);

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void печатьТелефоннойКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Отчет o = new Отчет();
            o.stat = 1;
            o.Show();
        }
    }
}
