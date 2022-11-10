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

namespace SamecProject
{
    public partial class frmPaymentSearch : Form
    {
        frmMain dgForm;       

        public frmPaymentSearch(frmMain frp)
        {
            InitializeComponent();
            dgForm = frp;
        }

        private void SearchPayments(string searchString,string searchType)
        {
            using (SqlConnection conn = new SqlConnection(GetSetClass.sqlconnectstring))
            {
                SqlCommand cmd = new SqlCommand("SearchPayments",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StringSearch", searchString);
                cmd.Parameters.AddWithValue("@SearchType", searchType);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();
                dgForm.DGPaymentDataBound(ds);               
            }
        }

        private void btnPaymentSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStringSearch.Text))
            {
                SearchPayments(txtStringSearch.Text,cmbSearchType.Text);
            }
        }

       
    }
}
