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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();                                   
        }
               
        private void btnMemberCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text != "")
            {
                AddUpdateMember();                
            } else
            {
                MessageBox.Show("Be sure to provide Member ID ? ", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AddUpdateMember()
        {
            string conn = GetSetClass.sqlconnectstring;            
            string uname = GetSetClass.globalString;
            string BDate = (txtMemberBirthdate.Text.Length == 10) ? txtMemberBirthdate.Text : "" ;
            string IDate = (txtMemberInductiondate.Text.Length == 10) ? txtMemberInductiondate.Text : "";            
            int mID = string.IsNullOrEmpty(txtMemberID.Text) ? 0 : int.Parse(txtMemberID.Text);            
            using (SqlConnection sqlc = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("AddUpdateMember");
                cmd.Connection = sqlc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MemberID",mID);
                cmd.Parameters.AddWithValue("@Lastname", txtMemberLastName.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtMemberFirstname.Text);
                cmd.Parameters.AddWithValue("@Middlename", txtMemberMiddlename.Text);
                cmd.Parameters.AddWithValue("@Birthplace", txtMemberBirthplace.Text);
                cmd.Parameters.AddWithValue("@EmailAddress", txtMemberEmail.Text);
                cmd.Parameters.AddWithValue("@Telephone", txtMemberTelephone.Text);
                cmd.Parameters.AddWithValue("@Birthdate", BDate);
                cmd.Parameters.AddWithValue("@Inductiondate", IDate);
                cmd.Parameters.AddWithValue("@UserName", uname);
                sqlc.Open();
                cmd.ExecuteNonQuery();
                sqlc.Close();
            }
            this.Hide();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        public void InitializeData()
        {
            txtMemberID.Text = GetSetClass.memid;
            txtMemberLastName.Text = GetSetClass.memlname;
            txtMemberFirstname.Text = GetSetClass.memfname;
            txtMemberMiddlename.Text = GetSetClass.memmname;
            txtMemberBirthdate.Text = GetSetClass.membd;
            txtMemberBirthplace.Text = GetSetClass.membp;
            txtMemberTelephone.Text = GetSetClass.memtel;
            txtMemberInductiondate.Text = GetSetClass.meminid;
            txtMemberEmail.Text = GetSetClass.memea;
        }
        private void txtMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
