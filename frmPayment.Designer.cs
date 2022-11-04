
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRedText = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtMemberFirstname = new System.Windows.Forms.TextBox();
            this.txtMemberLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnMemberSave = new System.Windows.Forms.Button();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.txtPaymentID);
            this.grpMember.Controls.Add(this.dtpPaymentDate);
            this.grpMember.Controls.Add(this.cmbYears);
            this.grpMember.Controls.Add(this.cmbMonths);
            this.grpMember.Controls.Add(this.cmbPaymentType);
            this.grpMember.Controls.Add(this.label11);
            this.grpMember.Controls.Add(this.lblRedText);
            this.grpMember.Controls.Add(this.txtPaymentAmount);
            this.grpMember.Controls.Add(this.txtMemberFirstname);
            this.grpMember.Controls.Add(this.txtMemberLastName);
            this.grpMember.Controls.Add(this.label7);
            this.grpMember.Controls.Add(this.label6);
            this.grpMember.Controls.Add(this.label5);
            this.grpMember.Controls.Add(this.label4);
            this.grpMember.Controls.Add(this.label3);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Controls.Add(this.label1);
            this.grpMember.Controls.Add(this.txtMemberID);
            this.grpMember.Location = new System.Drawing.Point(23, 13);
            this.grpMember.Margin = new System.Windows.Forms.Padding(4);
            this.grpMember.Name = "grpMember";
            this.grpMember.Padding = new System.Windows.Forms.Padding(4);
            this.grpMember.Size = new System.Drawing.Size(374, 314);
            this.grpMember.TabIndex = 1;
            this.grpMember.TabStop = false;
            // 
            // cmbYears
            // 
            this.cmbYears.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbYears.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(135, 194);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(205, 25);
            this.cmbYears.TabIndex = 14;
            this.cmbYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberID_KeyPress);
            // 
            // cmbMonths
            // 
            this.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonths.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMonths.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Location = new System.Drawing.Point(135, 164);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(205, 25);
            this.cmbMonths.TabIndex = 13;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPaymentType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(135, 134);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(205, 25);
            this.cmbPaymentType.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(41, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Member ID : ";
            // 
            // lblRedText
            // 
            this.lblRedText.BackColor = System.Drawing.Color.White;
            this.lblRedText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedText.ForeColor = System.Drawing.Color.Red;
            this.lblRedText.Location = new System.Drawing.Point(318, 44);
            this.lblRedText.Name = "lblRedText";
            this.lblRedText.Size = new System.Drawing.Size(18, 16);
            this.lblRedText.TabIndex = 18;
            this.lblRedText.Text = "*";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmount.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentAmount.Location = new System.Drawing.Point(135, 256);
            this.txtPaymentAmount.MaxLength = 50;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(205, 27);
            this.txtPaymentAmount.TabIndex = 16;
            this.txtPaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentAmount_KeyPress);
            // 
            // txtMemberFirstname
            // 
            this.txtMemberFirstname.BackColor = System.Drawing.SystemColors.Info;
            this.txtMemberFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberFirstname.Enabled = false;
            this.txtMemberFirstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberFirstname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMemberFirstname.Location = new System.Drawing.Point(135, 102);
            this.txtMemberFirstname.MaxLength = 20;
            this.txtMemberFirstname.Name = "txtMemberFirstname";
            this.txtMemberFirstname.Size = new System.Drawing.Size(205, 27);
            this.txtMemberFirstname.TabIndex = 11;
            // 
            // txtMemberLastName
            // 
            this.txtMemberLastName.BackColor = System.Drawing.SystemColors.Info;
            this.txtMemberLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberLastName.Enabled = false;
            this.txtMemberLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberLastName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMemberLastName.Location = new System.Drawing.Point(135, 70);
            this.txtMemberLastName.MaxLength = 20;
            this.txtMemberLastName.Name = "txtMemberLastName";
            this.txtMemberLastName.Size = new System.Drawing.Size(205, 27);
            this.txtMemberLastName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(62, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Amount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Payment Date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Month : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lastname : ";
            // 
            // txtMemberID
            // 
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.ForeColor = System.Drawing.Color.Black;
            this.txtMemberID.Location = new System.Drawing.Point(135, 38);
            this.txtMemberID.MaxLength = 8;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(205, 27);
            this.txtMemberID.TabIndex = 9;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            this.txtMemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberID_KeyPress);
            // 
            // btnMemberSave
            // 
            this.btnMemberSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMemberSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberSave.ForeColor = System.Drawing.Color.White;
            this.btnMemberSave.Location = new System.Drawing.Point(158, 334);
            this.btnMemberSave.Name = "btnMemberSave";
            this.btnMemberSave.Size = new System.Drawing.Size(110, 28);
            this.btnMemberSave.TabIndex = 17;
            this.btnMemberSave.Text = "Save";
            this.btnMemberSave.UseVisualStyleBackColor = false;
            this.btnMemberSave.Click += new System.EventHandler(this.btnMemberSave_Click);
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CalendarFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.CustomFormat = "MM/dd/yyyy";
            this.dtpPaymentDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(135, 224);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(205, 27);
            this.dtpPaymentDate.TabIndex = 24;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPaymentID.Location = new System.Drawing.Point(135, 14);
            this.txtPaymentID.MaxLength = 8;
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(205, 27);
            this.txtPaymentID.TabIndex = 25;
            this.txtPaymentID.Visible = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(419, 374);
            this.Controls.Add(this.btnMemberSave);
            this.Controls.Add(this.grpMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRedText;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.TextBox txtMemberFirstname;
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnMemberSave;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtPaymentID;
    }
}