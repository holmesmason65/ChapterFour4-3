/* Mason Holmes 
 * Program provides a GUI for querying the North Winds database.
 */

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

namespace ChapterFour4_3
{
    public partial class frmSQLTester : Form
    {
        SqlConnection booksConnection; 

        public frmSQLTester()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCommand = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();

            try
            {
                // establish command object and data adapter
                resultsCommand = new SqlCommand(txtSQLTester.Text, booksConnection);
                resultsAdapter.SelectCommand = resultsCommand;
                resultsAdapter.Fill(resultsTable);
                // bind grid view to table data
                grdSQLTester.DataSource = resultsTable;
                lblRecords.Text = resultsTable.Rows.Count.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Processsing SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            resultsCommand.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose(); 
        }

        private void frmSQLTester_Load(object sender, EventArgs e)
        {
            // connect to books database
            booksConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFileName=C:\Users\mason\source\repos\ChapterFour4-3\ChapterFour4-3\bin\Debug\netcoreapp3.1\SQLNwindDB.mdf;
                                                Integrated Security=True; Connect Timeout=30; User Instance=True;");
            booksConnection.Open();
        }

        private void frmSQLTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksConnection.Close();
            booksConnection.Dispose();
        }
    }
}
