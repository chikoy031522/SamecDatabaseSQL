
namespace SamecProject
{
    partial class frmReports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.GetMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SamecDatabaseDataSet = new SamecProject.SamecDatabaseDataSet();
            this.GetMembersTableAdapter = new SamecProject.SamecDatabaseDataSetTableAdapters.GetMembersTableAdapter();
            this.SamecDatabaseDataSet2 = new SamecProject.SamecDatabaseDataSet2();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GetMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamecDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamecDatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // GetMembersBindingSource
            // 
            this.GetMembersBindingSource.DataMember = "GetMembers";
            this.GetMembersBindingSource.DataSource = this.SamecDatabaseDataSet;
            // 
            // SamecDatabaseDataSet
            // 
            this.SamecDatabaseDataSet.DataSetName = "SamecDatabaseDataSet";
            this.SamecDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetMembersTableAdapter
            // 
            this.GetMembersTableAdapter.ClearBeforeFill = true;
            // 
            // SamecDatabaseDataSet2
            // 
            this.SamecDatabaseDataSet2.DataSetName = "SamecDatabaseDataSet2";
            this.SamecDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(800, 500);
            this.rptViewer.TabIndex = 0;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.rptViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamecDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamecDatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource GetMembersBindingSource;
        private SamecDatabaseDataSet SamecDatabaseDataSet;
        private SamecDatabaseDataSetTableAdapters.GetMembersTableAdapter GetMembersTableAdapter;
        private SamecDatabaseDataSet2 SamecDatabaseDataSet2;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}