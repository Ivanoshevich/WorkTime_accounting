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
    public partial class Период : Form
    {
        public Период()
        {
            InitializeComponent();
        }
        public int stat;
        private void button1_Click(object sender, EventArgs e)
        {
            Отчет o = new Отчет();
            o.stat = stat;
            o.dat1 = dateTimePicker1.Text;
            o.dat2 = dateTimePicker2.Text;
            o.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
