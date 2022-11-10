
namespace SamecProject
{
    partial class frmPaymentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentSearch));
            this.txtStringSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPaySearch = new System.Windows.Forms.Button();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtStringSearch
            // 
            this.txtStringSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStringSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringSearch.ForeColor = System.Drawing.Color.Black;
            this.txtStringSearch.Location = new System.Drawing.Point(76, 39);
            this.txtStringSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtStringSearch.MaxLength = 100;
            this.txtStringSearch.Name = "txtStringSearch";
            this.txtStringSearch.Size = new System.Drawing.Size(242, 27);
            this.txtStringSearch.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search For : ";
            // 
            // btnPaySearch
            // 
            this.btnPaySearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPaySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaySearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaySearch.ForeColor = System.Drawing.Color.White;
            this.btnPaySearch.Location = new System.Drawing.Point(326, 40);
            this.btnPaySearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaySearch.Name = "btnPaySearch";
            this.btnPaySearch.Size = new System.Drawing.Size(71, 27);
            this.btnPaySearch.TabIndex = 19;
            this.btnPaySearch.Text = "Go";
            this.btnPaySearch.UseVisualStyleBackColor = false;
            this.btnPaySearch.Click += new System.EventHandler(this.btnPaySearch_Click);
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSearchType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "OR",
            "AND"});
            this.cmbSearchType.Location = new System.Drawing.Point(16, 39);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(57, 25);
            this.cmbSearchType.TabIndex = 20;
            // 
            // frmPaymentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 93);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.btnPaySearch);
            this.Controls.Add(this.txtStringSearch);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStringSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPaySearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
    }
}