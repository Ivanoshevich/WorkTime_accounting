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
    public partial class Отчет : Form
    {
        public Отчет()
        {
            InitializeComponent();
        }
        public int stat, kod;
        public string dat1, dat2;
        private void Отчет_Load(object sender, EventArgs e)
        {
            if (stat == 1)
            {
                reportViewer1.Visible = true;
                reportViewer1.Dock = DockStyle.Fill;
                this.PhoneBookTableAdapter.Fill(this.WorkTimeDataSet.PhoneBook);
                this.reportViewer1.RefreshReport();
            }
            if (stat == 2)
            {
                reportViewer2.Visible = true;
                reportViewer2.Dock = DockStyle.Fill;
                this.SheduleReportTableAdapter.Fill(this.WorkTimeDataSet.SheduleReport, kod, Convert.ToDateTime(dat1));
                this.reportViewer2.RefreshReport();
            }
            if (stat == 3)
            {
                reportViewer3.Visible = true;
                reportViewer3.Dock = DockStyle.Fill;
                this.ReportErrorTableAdapter.Fill(this.WorkTimeDataSet.ReportError, Convert.ToDateTime(dat1), Convert.ToDateTime(dat2));
                this.reportViewer3.RefreshReport();
            }
            if (stat == 4)
            {
                reportViewer4.Visible = true;
                reportViewer4.Dock = DockStyle.Fill;
                this.ReportActivityTableAdapter.Fill(this.WorkTimeDataSet.ReportActivity, Convert.ToDateTime(dat1), Convert.ToDateTime(dat2));
                this.reportViewer4.RefreshReport();
            }
            this.reportViewer2.RefreshReport();
        }
    }
}
