﻿namespace SoftQuanLyNhaHang.Views
{
    partial class frmThanhToan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.goiMonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SoftQuanLyNhaHang.Views.DataSet1();
            this.goiMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.goiMonTableAdapter = new SoftQuanLyNhaHang.Views.DataSet1TableAdapters.GoiMonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.goiMonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goiMonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goiMonBindingSource1
            // 
            this.goiMonBindingSource1.DataMember = "GoiMon";
            this.goiMonBindingSource1.DataSource = this.dataSet1;
            this.goiMonBindingSource1.CurrentChanged += new System.EventHandler(this.goiMonBindingSource1_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goiMonBindingSource
            // 
            this.goiMonBindingSource.DataMember = "GoiMon";
            this.goiMonBindingSource.DataSource = this.dataSet1;
            this.goiMonBindingSource.CurrentChanged += new System.EventHandler(this.goiMonBindingSource_CurrentChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.goiMonBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftQuanLyNhaHang.Views.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(768, 278);
            this.reportViewer1.TabIndex = 0;
            // 
            // goiMonTableAdapter
            // 
            this.goiMonTableAdapter.ClearBeforeFill = true;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 278);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goiMonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goiMonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource goiMonBindingSource;
        private DataSet1TableAdapters.GoiMonTableAdapter goiMonTableAdapter;
        private System.Windows.Forms.BindingSource goiMonBindingSource1;
    }
}