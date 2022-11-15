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

namespace SamecProject
{
    public partial class frmReports : Form
    {

        ReportDataSource rds;
        string tabletype;
        public frmReports()
        {
            InitializeComponent();
        }

        public frmReports(ReportDataSource rdp,string tt)
        {
            InitializeComponent();
            rds = rdp;
            tabletype = tt;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            rptViewer.LocalReport.DataSources.Clear();
            if (tabletype == "Payments")
            {
                rptViewer.LocalReport.ReportPath = "Reports/rptPayments.rdlc";
            } else
            {
                rptViewer.LocalReport.ReportPath = "Reports/rptMembers.rdlc";
            }            
            rptViewer.LocalReport.DataSources.Add(rds);
            this.rptViewer.RefreshReport();
        }

    }
}
