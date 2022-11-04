
namespace SamecProject
{
    partial class frmPaymentType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentType));
            this.dgvPaymentType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPaymentTypeDesc = new System.Windows.Forms.TextBox();
            this.btnPaymentTypeSave = new System.Windows.Forms.Button();
            this.btnPaymentTypeDelete = new System.Windows.Forms.Button();
            this.btnPaymentTypeUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentType
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPaymentType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentType.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentType.ColumnHeadersHeight = 30;
            this.dgvPaymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PaymentTypeID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentType.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentType.EnableHeadersVisualStyles = false;
            this.dgvPaymentType.GridColor = System.Drawing.Color.LightGray;
            this.dgvPaymentType.Location = new System.Drawing.Point(12, 45);
            this.dgvPaymentType.Name = "dgvPaymentType";
            this.dgvPaymentType.ReadOnly = true;
            this.dgvPaymentType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentType.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPaymentType.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentType.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPaymentType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentType.Size = new System.Drawing.Size(337, 298);
            this.dgvPaymentType.TabIndex = 7;
            this.dgvPaymentType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentType_CellContentClick);
            this.dgvPaymentType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentType_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentDesc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PaymentTypeID
            // 
            this.PaymentTypeID.DataPropertyName = "PaymentTypeID";
            this.PaymentTypeID.HeaderText = "PaymentTypeID";
            this.PaymentTypeID.Name = "PaymentTypeID";
            this.PaymentTypeID.ReadOnly = true;
            this.PaymentTypeID.Visible = false;
            // 
            // txtPaymentTypeDesc
            // 
            this.txtPaymentTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentTypeDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentTypeDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPaymentTypeDesc.Location = new System.Drawing.Point(12, 12);
            this.txtPaymentTypeDesc.MaxLength = 20;
            this.txtPaymentTypeDesc.Name = "txtPaymentTypeDesc";
            this.txtPaymentTypeDesc.Size = new System.Drawing.Size(337, 27);
            this.txtPaymentTypeDesc.TabIndex = 11;
            this.txtPaymentTypeDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPaymentTypeSave
            // 
            this.btnPaymentTypeSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPaymentTypeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentTypeSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentTypeSave.ForeColor = System.Drawing.Color.White;
            this.btnPaymentTypeSave.Location = new System.Drawing.Point(61, 349);
            this.btnPaymentTypeSave.Name = "btnPaymentTypeSave";
            this.btnPaymentTypeSave.Size = new System.Drawing.Size(94, 28);
            this.btnPaymentTypeSave.TabIndex = 19;
            this.btnPaymentTypeSave.Text = "Save";
            this.btnPaymentTypeSave.UseVisualStyleBackColor = false;
            this.btnPaymentTypeSave.Click += new System.EventHandler(this.btnPaymentTypeSave_Click);
            // 
            // btnPaymentTypeDelete
            // 
            this.btnPaymentTypeDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPaymentTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentTypeDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnPaymentTypeDelete.Location = new System.Drawing.Point(255, 349);
            this.btnPaymentTypeDelete.Name = "btnPaymentTypeDelete";
            this.btnPaymentTypeDelete.Size = new System.Drawing.Size(94, 28);
            this.btnPaymentTypeDelete.TabIndex = 20;
            this.btnPaymentTypeDelete.Text = "Delete";
            this.btnPaymentTypeDelete.UseVisualStyleBackColor = false;
            this.btnPaymentTypeDelete.Click += new System.EventHandler(this.btnPaymentTypeDelete_Click);
            // 
            // btnPaymentTypeUpdate
            // 
            this.btnPaymentTypeUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPaymentTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentTypeUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentTypeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPaymentTypeUpdate.Location = new System.Drawing.Point(158, 349);
            this.btnPaymentTypeUpdate.Name = "btnPaymentTypeUpdate";
            this.btnPaymentTypeUpdate.Size = new System.Drawing.Size(94, 28);
            this.btnPaymentTypeUpdate.TabIndex = 21;
            this.btnPaymentTypeUpdate.Text = "Update";
            this.btnPaymentTypeUpdate.UseVisualStyleBackColor = false;
            this.btnPaymentTypeUpdate.Click += new System.EventHandler(this.btnPaymentTypeUpdate_Click);
            // 
            // frmPaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 384);
            this.Controls.Add(this.btnPaymentTypeUpdate);
            this.Controls.Add(this.btnPaymentTypeDelete);
            this.Controls.Add(this.btnPaymentTypeSave);
            this.Controls.Add(this.txtPaymentTypeDesc);
            this.Controls.Add(this.dgvPaymentType);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Type";
            this.Load += new System.EventHandler(this.frmPaymentType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeID;
        private System.Windows.Forms.TextBox txtPaymentTypeDesc;
        private System.Windows.Forms.Button btnPaymentTypeSave;
        private System.Windows.Forms.Button btnPaymentTypeDelete;
        private System.Windows.Forms.Button btnPaymentTypeUpdate;
    }
}