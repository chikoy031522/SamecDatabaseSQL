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
            if (e.KeyChar == (char)Keys.Enter)
            {
                 if (!string.IsNullOrEmpty(txtMemberID.Text))
                {
                    GetMember(txtMemberID.Text);
                }
            } else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            
        }

        private void GetMember(string memid)
        {
            using (SqlConnection conn = new SqlConnection(GetSetClass.sqlconnectstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GetMember", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MemberID", memid);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblMember");
                    conn.Close();
                    txtMemberFirstname.Text = ds.Tables["tblMember"].Rows[0]["Firstname"].ToString();
                    txtMemberLastName.Text = ds.Tables["tblMember"].Rows[0]["Lastname"].ToString();
                    cmbPaymentType.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

        }
        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMemberID.Text) && !string.IsNullOrEmpty(cmbPaymentType.Text) && !string.IsNullOrEmpty(cmbMonths.Text) && !string.IsNullOrEmpty(cmbYears.Text) 
                && !string.IsNullOrEmpty(txtPaymentAmount.Text))
            {
                AddUpdatePayment("add");
            }
        }

        private void AddUpdatePayment(string tt)
        {
            using (SqlConnection conn = new SqlConnection(GetSetClass.sqlconnectstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("AddUpdatePayment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MemberID", memid);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblMember");
                    conn.Close();
                    txtMemberFirstname.Text = ds.Tables["tblMember"].Rows[0]["Firstname"].ToString();
                    txtMemberLastName.Text = ds.Tables["tblMember"].Rows[0]["Lastname"].ToString();
                    cmbPaymentType.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
