namespace Планировщик_рабочего_времени
{
    partial class Отчет
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkTimeDataSet = new Планировщик_рабочего_времени.WorkTimeDataSet();
            this.ReportErrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SheduleReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhoneBookTableAdapter = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.PhoneBookTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportErrorTableAdapter = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.ReportErrorTableAdapter();
            this.ReportActivityTableAdapter = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.ReportActivityTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SheduleReportTableAdapter = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.SheduleReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportErrorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneBookBindingSource
            // 
            this.PhoneBookBindingSource.DataMember = "PhoneBook";
            this.PhoneBookBindingSource.DataSource = this.WorkTimeDataSet;
            // 
            // WorkTimeDataSet
            // 
            this.WorkTimeDataSet.DataSetName = "WorkTimeDataSet";
            this.WorkTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportErrorBindingSource
            // 
            this.ReportErrorBindingSource.DataMember = "ReportError";
            this.ReportErrorBindingSource.DataSource = this.WorkTimeDataSet;
            // 
            // ReportActivityBindingSource
            // 
            this.ReportActivityBindingSource.DataMember = "ReportActivity";
            this.ReportActivityBindingSource.DataSource = this.WorkTimeDataSet;
            // 
            // SheduleReportBindingSource
            // 
            this.SheduleReportBindingSource.DataMember = "SheduleReport";
            this.SheduleReportBindingSource.DataSource = this.WorkTimeDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhoneBookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Планировщик_рабочего_времени.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 39);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(385, 173);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // reportViewer3
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ReportErrorBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Планировщик_рабочего_времени.Report4.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(633, 39);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(404, 183);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.Visible = false;
            // 
            // reportViewer4
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ReportActivityBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Планировщик_рабочего_времени.Report5.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(633, 234);
            this.reportViewer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(404, 189);
            this.reportViewer4.TabIndex = 3;
            this.reportViewer4.Visible = false;
            // 
            // PhoneBookTableAdapter
            // 
            this.PhoneBookTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.WorkTimeDataSet;
            this.bindingSource1.Position = 0;
            // 
            // ReportErrorTableAdapter
            // 
            this.ReportErrorTableAdapter.ClearBeforeFill = true;
            // 
            // ReportActivityTableAdapter
            // 
            this.ReportActivityTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.SheduleReportBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Планировщик_рабочего_времени.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(31, 234);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(385, 189);
            this.reportViewer2.TabIndex = 4;
            this.reportViewer2.Visible = false;
            // 
            // SheduleReportTableAdapter
            // 
            this.SheduleReportTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 486);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Отчет";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Отчет_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportErrorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhoneBookBindingSource;
        private WorkTimeDataSet WorkTimeDataSet;
        private WorkTimeDataSetTableAdapters.PhoneBookTableAdapter PhoneBookTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource ReportErrorBindingSource;
        private WorkTimeDataSetTableAdapters.ReportErrorTableAdapter ReportErrorTableAdapter;
        private System.Windows.Forms.BindingSource ReportActivityBindingSource;
        private WorkTimeDataSetTableAdapters.ReportActivityTableAdapter ReportActivityTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource SheduleReportBindingSource;
        private WorkTimeDataSetTableAdapters.SheduleReportTableAdapter SheduleReportTableAdapter;
    }
}