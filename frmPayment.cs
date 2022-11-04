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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            GetPaymentType();
            cmbMonths.Items.AddRange(Enum.GetNames(typeof(Months)));
            int lYear = DateTime.Now.Year;
            for (int i = lYear; i >= lYear-10; i--)
            {
                cmbYears.Items.Add(i);
            }

        }

        private void GetPaymentType()
        {
            using (SqlConnection conn = new SqlConnection(GetSetClass.sqlconnectstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GetPaymentType", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblPaymentType");
                    cmbPaymentType.DisplayMember = "PaymentDesc";
                    cmbPaymentType.ValueMember = "PaymentTypeID";
                    cmbPaymentType.DataSource = ds.Tables["tblPaymentType"];
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        enum Months
        {
            January = 1,February, March, April, May, June, July, August, September, October, November, December
        };
                
        private void txtMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
    }
}
