
namespace ChapterFour4_3
{
    partial class frmSQLTester
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.grdSQLTester = new System.Windows.Forms.DataGridView();
            this.txtSQLTester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSQLTester)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(469, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Records Returned";
            // 
            // lblRecords
            // 
            this.lblRecords.BackColor = System.Drawing.Color.White;
            this.lblRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecords.Location = new System.Drawing.Point(563, 366);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(146, 40);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "0";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(469, 340);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(240, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test SQL Statement";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // grdSQLTester
            // 
            this.grdSQLTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSQLTester.Location = new System.Drawing.Point(12, 12);
            this.grdSQLTester.Name = "grdSQLTester";
            this.grdSQLTester.RowTemplate.Height = 25;
            this.grdSQLTester.Size = new System.Drawing.Size(776, 322);
            this.grdSQLTester.TabIndex = 3;
            this.grdSQLTester.TabStop = false;
            // 
            // txtSQLTester
            // 
            this.txtSQLTester.Location = new System.Drawing.Point(12, 340);
            this.txtSQLTester.Multiline = true;
            this.txtSQLTester.Name = "txtSQLTester";
            this.txtSQLTester.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQLTester.Size = new System.Drawing.Size(451, 88);
            this.txtSQLTester.TabIndex = 4;
            // 
            // frmSQLTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSQLTester);
            this.Controls.Add(this.grdSQLTester);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSQLTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSQLTester_FormClosing);
            this.Load += new System.EventHandler(this.frmSQLTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSQLTester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView grdSQLTester;
        private System.Windows.Forms.TextBox txtSQLTester;
    }
}

