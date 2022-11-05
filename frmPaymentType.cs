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
                dgvPaymentType.ClearSelection();
            }
        }
       
        private void PaymentTypeAddUpdateDelete(string trantype, string trandesc, string tranid)
        {
            if (!string.IsNullOrEmpty(trandesc))
            {
                using (SqlConnection conn = new SqlConnection(GetSetClass.sqlconnectstring))
                {
                    SqlCommand cmd = new SqlCommand("AddUpdateDeletePaymentType");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("TranType", trantype);
                    cmd.Parameters.AddWithValue("PaymentTypeDesc", trandesc);
                    cmd.Parameters.AddWithValue("PaymentTypeID", tranid);
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    txtPaymentTypeDesc.Text = "";
                    GetActivePaymentType();
                    
                }
            } else
            {
                MessageBox.Show("Please provide payment type description ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnPaymentTypeDelete_Click(object sender, EventArgs e)
        {
            if (dgvPaymentType.SelectedRows.Count > 0)
            {
                DialogResult dres = MessageBox.Show("Are you sure you want to delete this payment type ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dres == DialogResult.Yes)
                {
                    string ptid = dgvPaymentType.SelectedRows[0].Cells[1].Value.ToString();
                    PaymentTypeAddUpdateDelete("delete", "delete", ptid);
                }                
            }
        }

        private void btnPaymentTypeUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPaymentType.SelectedRows.Count > 0)
            {
                string ptid = dgvPaymentType.SelectedRows[0].Cells[1].Value.ToString();
                string ptdesc = txtPaymentTypeDesc.Text;
                PaymentTypeAddUpdateDelete("update", ptdesc, ptid);
            }
        }

        private void btnPaymentTypeSave_Click(object sender, EventArgs e)
        {
            PaymentTypeAddUpdateDelete("add", txtPaymentTypeDesc.Text, "0");
        }
       

        private void dgvPaymentType_HeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvPaymentType.CurrentRow.Selected = false;
        }
       
        private void dgvPaymentType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPaymentTypeDesc.Text = dgvPaymentType.SelectedRows[0].Cells["PaymentDesc"].Value.ToString();
        }
    }
}
