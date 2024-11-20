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
using OfficeOpenXml;

namespace PatientManagementSystem_RollBased.Forms.Reports
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
            this.Load += GenerateReportForm_Load;

        }
        private void GenerateReportForm_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with Item Status options
            cmbItemStatus.Items.Add("Active");
            cmbItemStatus.Items.Add("Inactive");
            cmbItemStatus.Items.Add("All"); // Add "All" for no filtering
            cmbItemStatus.SelectedIndex = 0; // Set default selection
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatientRegister;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            string query = "EXEC GetItemReport @FromDate, @ToDate, @ItemStatus";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                    command.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                    // Pass NULL if "All" is selected
                    if (cmbItemStatus.SelectedItem.ToString() == "All")
                        command.Parameters.AddWithValue("@ItemStatus", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ItemStatus", cmbItemStatus.SelectedItem.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvReportPreview.DataSource = dataTable; // Bind data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvReportPreview.DataSource == null || dgvReportPreview.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create and show SaveFileDialog to choose where to save the Excel file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Report";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Set the EPPlus license context (non-commercial for free use)
                        // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


                        // Create a new Excel package
                        using (ExcelPackage excel = new ExcelPackage())
                        {
                            // Add a worksheet to the Excel file
                            var worksheet = excel.Workbook.Worksheets.Add("Report");

                            // Add DataGridView headers to Excel
                            for (int i = 1; i <= dgvReportPreview.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i].Value = dgvReportPreview.Columns[i - 1].HeaderText;
                            }

                            // Add DataGridView rows to Excel
                            for (int i = 0; i < dgvReportPreview.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvReportPreview.Columns.Count; j++)
                                {
                                    // Ensure that you're not adding null values to the cells
                                    worksheet.Cells[i + 2, j + 1].Value = dgvReportPreview.Rows[i].Cells[j].Value ?? string.Empty;
                                }
                            }

                            // Save the Excel file to the selected path
                            FileInfo file = new FileInfo(saveFileDialog.FileName);
                            excel.SaveAs(file);

                            MessageBox.Show("Report exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbItemStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportToCSV_Click_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set filter for CSV files
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Save Report as CSV";

                // Define the path where you want to create the new folder
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // Get Desktop path
                string reportFolderPath = Path.Combine(desktopPath, "ReportFolder"); // Define folder name as "ReportFolder"

                // Check if the folder already exists, if not create it
                if (!Directory.Exists(reportFolderPath))
                {
                    Directory.CreateDirectory(reportFolderPath);  // Create the folder if it doesn't exist
                }

                // Set the initial directory to the new folder
                saveFileDialog.InitialDirectory = reportFolderPath;

                // Show the SaveFileDialog to the user
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;  // Get the full path where the file will be saved

                    try
                    {
                        // Write the DataGridView contents to the CSV file
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            // Write column headers
                            for (int i = 0; i < dgvReportPreview.Columns.Count; i++)
                            {
                                sw.Write(dgvReportPreview.Columns[i].HeaderText); // Write column header
                                if (i < dgvReportPreview.Columns.Count - 1)
                                    sw.Write(",");  // Add a comma after each header
                            }
                            sw.WriteLine();  // Move to the next line after writing headers

                            // Write rows of data
                            foreach (DataGridViewRow row in dgvReportPreview.Rows)
                            {
                                // Skip the new row (empty row)
                                if (row.IsNewRow) continue;

                                // Skip rows that have no data (empty rows)
                                bool hasData = false;
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                                    {
                                        hasData = true;
                                        break;
                                    }
                                }
                                if (!hasData) continue; // Skip the row if it has no data

                                for (int i = 0; i < dgvReportPreview.Columns.Count; i++)
                                {
                                    string value = Convert.ToString(row.Cells[i].Value) ?? string.Empty;

                                    // Handle ExpiryDate formatting
                                    if (dgvReportPreview.Columns[i].HeaderText == "ExpiryDate" && DateTime.TryParse(value, out DateTime expiryDate))
                                    {
                                        // Format ExpiryDate in a custom format (yyyy-MM-dd)
                                        value = expiryDate.ToString("yyyy-MM-dd");
                                    }

                                    // Escape commas and quotes within the data
                                    value = value.Replace("\"", "\"\"");

                                    // Wrap values in quotes if they contain commas, quotes, or newlines
                                    if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                                    {
                                        value = $"\"{value}\"";
                                    }

                                    sw.Write(value); // Write the cell value
                                    if (i < dgvReportPreview.Columns.Count - 1)
                                        sw.Write(",");  // Add a comma between columns
                                }
                                sw.WriteLine();  // Move to the next line after writing each row
                            }
                        }
                        MessageBox.Show("CSV file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

}
