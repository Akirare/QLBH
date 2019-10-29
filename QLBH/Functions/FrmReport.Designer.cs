namespace QLBH.Functions
{
    partial class FrmReport
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
            this.reportViewerCommon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCommon
            // 
            this.reportViewerCommon.LocalReport.ReportEmbeddedResource = "QLBH.Reports.ReportHoaDonBanHang.rdlc";
            this.reportViewerCommon.Location = new System.Drawing.Point(2, 0);
            this.reportViewerCommon.Name = "reportViewerCommon";
            this.reportViewerCommon.ServerReport.BearerToken = null;
            this.reportViewerCommon.Size = new System.Drawing.Size(689, 583);
            this.reportViewerCommon.TabIndex = 0;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 580);
            this.Controls.Add(this.reportViewerCommon);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
         
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewerCommon;
    }
}