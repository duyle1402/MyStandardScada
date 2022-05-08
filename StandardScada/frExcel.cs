using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Threading;
namespace StandardScada
{
    public partial class frExcel : Form
    {
        public frExcel()
        {
            InitializeComponent();
        }

        private void frExcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCADA_LVDataSet.SCADA_STATUS_TABLE' table. You can move, or remove it, as needed.
            this.sCADA_STATUS_TABLETableAdapter.Fill(this.sCADA_LVDataSet.SCADA_STATUS_TABLE);



        }

        private void btnExport_Click(object sender, EventArgs e)
        {    // tạo một thread tạm thời để không xung đột với thread chính
            var t = new Thread((ThreadStart)(() =>
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook()) // sử dụng thử viện closedxml 
                            {
                                //workbook.Worksheets.Add(this.sCADA_LVDataSet.SCADA_DATA_TABLE.CopyToDataTable(), "SCADA_DATA"); // 
                                workbook.Worksheets.Add(this.sCADA_LVDataSet.SCADA_STATUS_TABLE.CopyToDataTable(), "SCADA_STATUS_TABLE"); // 
                                workbook.SaveAs(sfd.FileName);

                            }
                            MessageBox.Show("You have succesfully exported your data to an excel file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)

                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            
        }
       
    }
}
