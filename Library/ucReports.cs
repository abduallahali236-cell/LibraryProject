using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using Library.Business;
using Library.Models;
using System.Data;
using System.Windows.Forms;
using static Library.Models.Report;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Library.UI;
using Library.UI.Helpers;

namespace Library.UI.UserControls;

public partial class ucReports : UserControl
{
    private readonly ReportService _reportService = new();
    private readonly System.Windows.Forms.Timer searchTimer = new();

    public ucReports()
    {
        InitializeComponent();

        InitializeReportTypes();
        ConfigureGrid();
        ConfigureSearchTimer();
        ConfigureDatePickers();

        ToggleDateFilters();

        LoadReport();
    }

private void InitializeReportTypes()
    {
        cmbReportType.DataSource =
            Enum.GetValues<ReportType>();
    }
    private void ConfigureGrid()
    {
        dgvReports.ReadOnly = true;

        dgvReports.MultiSelect = false;

        dgvReports.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

        dgvReports.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        dgvReports.AllowUserToAddRows = false;

        dgvReports.AllowUserToDeleteRows = false;

        dgvReports.AllowUserToResizeRows = false;

        dgvReports.RowHeadersVisible = false;

        dgvReports.EnableHeadersVisualStyles = false;
    }
    private void ConfigureSearchTimer()
    {
        searchTimer.Interval = 500;

        searchTimer.Tick += SearchTimer_Tick;
    }


    private void ConfigureDatePickers()
    {
        dtpFrom.Value = DateTime.Today.AddMonths(-1);

        dtpTo.Value = DateTime.Today;
    }
    private void ToggleDateFilters()
    {
        bool visible =
            (ReportType)cmbReportType.SelectedItem ==
            ReportType.Borrowings;

        lblFrom.Visible = visible;
        lblTo.Visible = visible;

        dtpFrom.Visible = visible;
        dtpTo.Visible = visible;
    }
    private void LoadReport()
    {
        Cursor = Cursors.WaitCursor;

        try
        {
            ReportType type =
                (ReportType)cmbReportType.SelectedItem;

            DateTime? from = null;
            DateTime? to = null;

            if (type == ReportType.Borrowings)
            {
                from = dtpFrom.Value.Date;
                to = dtpTo.Value.Date;
            }

            DataTable table =
                _reportService.GetReport(
                    type,
                    txtSearch.Text.Trim(),
                    from,
                    to);

            dgvReports.DataSource = table;

            lblRows.Text =
                $"Rows : {table.Rows.Count}";

            lblLastUpdated.Text =
                $"Last Updated : {DateTime.Now:dd/MM/yyyy HH:mm}";

        }
        catch (Exception ex)
        {
            MessageHelper.Error(ex.Message);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }
    private void SearchTimer_Tick(object? sender, EventArgs e)
    {
        searchTimer.Stop();

        LoadReport();
    }
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        searchTimer.Stop();

        searchTimer.Start();
    }
    private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToggleDateFilters();

        LoadReport();
    }
    private void dtpFrom_ValueChanged(object sender, EventArgs e)
    {
        LoadReport();
    }

    private void dtpTo_ValueChanged(object sender, EventArgs e)
    {
        LoadReport();
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();

        LoadReport();
    }
    private void btnExportExcel_Click(object sender, EventArgs e)
    {
        if (dgvReports.Rows.Count == 0)
            return;

        bool datesOnly = (ReportType)cmbReportType.SelectedItem == ReportType.Borrowings;

        ExcelExporter.Export(dgvReports, datesOnly);
    }
    private void btnExportPdf_Click(object sender, EventArgs e)
    {
        if (dgvReports.Rows.Count == 0)
            return;

        bool datesOnly = (ReportType)cmbReportType.SelectedItem == ReportType.Borrowings;

        PdfExporter.Export(dgvReports, datesOnly);
    }
}
