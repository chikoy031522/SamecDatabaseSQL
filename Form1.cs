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
using System.Configuration;
using System.IO;

namespace SamecProject
{    
    public partial class frmMain : Form
    {

        public string SQLConnStr = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SQLStringConnect();
            
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                bool logSuccess = ValidateUser(txtUsername.Text, txtPassword.Text);
                if (logSuccess)
                {
                    using(StreamWriter strWriter = new StreamWriter("DefaultUser.txt"))
                    {
                        strWriter.WriteLine(txtUsername.Text);
                    }
                    lblUsernameLogin.Text = txtUsername.Text;                    
                    txtPassword.Text = "";
                    GetSetClass.globalString = txtUsername.Text;
                    btnHome_Click(sender,e);
                    pnlBody.Visible = true;
                } else
                {
                    lblLoginError.Text = "Invalid credentials ? Make sure to enter correct username and paswword ";
                    lblLoginError.Visible = true;
                }
            } else
            {
                lblLoginError.Text = "Please enter username and password ? ";
                lblLoginError.Visible = true;
            }
        }

        private bool ValidateUser(string username, string userpassword)
        {
            bool isUserExist = false;
            using (SqlConnection sqlConn = new SqlConnection(SQLConnStr))
            {
                SqlCommand cmd = new SqlCommand("CheckUserExist");
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", userpassword);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlConn;
                sqlConn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                sqlConn.Close();
                isUserExist = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            }

            return isUserExist;
        }
        private void HideObjects()
        {
            lblLoginError.Visible = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            HideObjects();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            HideObjects();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender,e);
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            btnMemberRefresh_Click(sender,e);
            pnlMember.Visible = true;            
            pnlMember.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {                        
            pnlHome.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlBody.Visible = false;
        }

        public void btnMemberAdd_Click(object sender, EventArgs e)
        {
            SetInitialValue("add");
            frmMember addMem = new frmMember();
            addMem.Text += " - Add"; 
            addMem.ShowDialog();
        }

        public void btnMemberRefresh_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(SQLConnStr))
            {
                SqlCommand cmd = new SqlCommand("GetMembers");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();
                dgvMembers.ReadOnly = true;
                dgvMembers.DataSource = ds.Tables[0];
            }
        }
        
        private void btnMemberEdit_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                SetInitialValue("edit");
                frmMember editMem = new frmMember();
                editMem.Text += " - Edit";
                editMem.ShowDialog();
            }
                                                
        }
        public void SetInitialValue(string st)
        {
            DataGridView ggv = dgvMembers;
            GetSetClass.memid = (st == "edit") ? ggv.SelectedRows[0].Cells[0].Value.ToString() : "";
            GetSetClass.memlname = (st == "edit") ? ggv.SelectedRows[0].Cells[1].Value.ToString() : "";
            GetSetClass.memfname = (st == "edit") ? ggv.SelectedRows[0].Cells[2].Value.ToString() : "";
            GetSetClass.memmname = (st == "edit") ? ggv.SelectedRows[0].Cells[3].Value.ToString() : "";
            GetSetClass.membd = (st == "edit") ? ggv.SelectedRows[0].Cells[4].Value.ToString() : "";
            GetSetClass.membp = (st == "edit") ? ggv.SelectedRows[0].Cells[5].Value.ToString() : "";
            GetSetClass.memtel = (st == "edit") ? ggv.SelectedRows[0].Cells[6].Value.ToString() : "";
            GetSetClass.meminid = (st == "edit") ? ggv.SelectedRows[0].Cells[7].Value.ToString() : "";
            GetSetClass.memea = (st == "edit") ? ggv.SelectedRows[0].Cells[8].Value.ToString() : "";
        }

        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                DialogResult strRes = MessageBox.Show("Are you sure you want to delete this member ?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (strRes == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(SQLConnStr))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteMember");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MemberID", dgvMembers.SelectedRows[0].Cells[0].Value);
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        btnMemberRefresh_Click(sender, e);
                    }
                }                

            }

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlPayment.BringToFront();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            pnlMaintenance.BringToFront();
        }

        public void SQLStringConnect()
        {
            if (File.Exists("servername.txt"))
            {
                using (StreamReader strReader = new StreamReader("servername.txt"))
                {
                    string dbname = strReader.ReadLine();
                    string strConn = ConfigurationManager.ConnectionStrings["SQLSamecConnection"].ConnectionString;
                    GetSetClass.sqlconnectstring = strConn.Replace("servername", dbname);
                    SQLConnStr = GetSetClass.sqlconnectstring;
                }
            } else
            {
                MessageBox.Show("Create a text for the database name to properly connect to SQL and run the app ?", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (File.Exists("DefaultUser.txt"))
            {
                using (StreamReader strReader = new StreamReader("DefaultUser.txt"))
                {
                    txtUsername.Text = strReader.ReadLine();
                    txtPassword.Focus();

                }
            }            
        }

        private void btnPaymentType_Click(object sender, EventArgs e)
        {
            frmPaymentType fpt = new frmPaymentType();
            fpt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPayment frmP = new frmPayment();
            frmP.ShowDialog();
        }

        private void btnPaymentRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnStr))
            {
                SqlCommand cmd = new SqlCommand("GetPayments");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();
                dgvPayments.ReadOnly = true;
                dgvPayments.DataSource = ds.Tables[0];
            }
        }

        private void btnPaymentEdit_Click(object sender, EventArgs e)
        {
            if(dgvPayments.SelectedRows.Count > 0)
            {

            }
        }
    }
}
