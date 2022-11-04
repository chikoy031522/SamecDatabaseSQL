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
    public partial class frmPaymentType : Form
    {
        public frmPaymentType()
        {
            InitializeComponent();
        }

        private void frmPaymentType_Load(object sender, EventArgs e)
        {
            GetActivePaymentType();
        }

        private void GetActivePaymentType()
        {
            using (SqlConnection conn = new SqlConnection(GetSetClass.sqlconnectstring))
            {
                SqlCommand cmd = new SqlCommand("GetPaymentType");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();                
                dgvPaymentType.DataSource = ds.Tables[0];


            }
        }
    }
}
