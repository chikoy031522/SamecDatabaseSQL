﻿
namespace SamecProject
{
    partial class frmPayment
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
            this.SuspendLayout();
            // 
            // frmMember
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmMember";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberBirthplace;
        private System.Windows.Forms.TextBox txtMemberMiddlename;
        private System.Windows.Forms.TextBox txtMemberFirstname;
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.Button btnMemberSave;
        private System.Windows.Forms.Button btnMemberCancel;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.MaskedTextBox txtMemberInductiondate;
        private System.Windows.Forms.MaskedTextBox txtMemberBirthdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMemberTelephone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMemberID;
    }
}