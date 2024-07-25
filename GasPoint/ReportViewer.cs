using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPoint
{
    public partial class Visor : Form  
    {
        private readonly ReportViewer reportViewer;
        public Visor()
        {
            InitializeComponent();
            Text = "Report viewer";
            //WindowState = FormWindowState.;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            
        }

        public LocalReport GetReport()
        {
            return reportViewer.LocalReport;
        }

        public void RefreshReport()
        {
            reportViewer.RefreshReport();
        }
    }
}
