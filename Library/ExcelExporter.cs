using ClosedXML.Excel;
using System.Data;
using System.Windows.Forms;

namespace Library.UI.Helpers;

public static class ExcelExporter
{
    public static void Export(DataGridView grid, bool datesOnly = false)
    {
        if (grid == null || grid.Rows.Count == 0)
        {
            MessageBox.Show("There is no data to export.",
                "Export",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        using SaveFileDialog dialog = new();

        dialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
        dialog.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        using XLWorkbook workbook = new();

        DataTable table = ToDataTable(grid, datesOnly);

        workbook.Worksheets.Add(table, "Report");

        IXLWorksheet sheet = workbook.Worksheet("Report");

        sheet.Columns().AdjustToContents();

        sheet.Row(1).Style.Font.Bold = true;

        sheet.SheetView.FreezeRows(1);

        workbook.SaveAs(dialog.FileName);

        MessageBox.Show(
            "Excel file exported successfully.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private static DataTable ToDataTable(DataGridView grid, bool datesOnly)
    {
        DataTable table = new();

        foreach (DataGridViewColumn column in grid.Columns)
            table.Columns.Add(column.HeaderText);

        foreach (DataGridViewRow row in grid.Rows)
        {
            if (row.IsNewRow)
                continue;

            DataRow dataRow = table.NewRow();

            for (int i = 0; i < grid.Columns.Count; i++)
            {
                var val = row.Cells[i].Value;
                if (datesOnly)
                {
                    if (val is DateTime dt)
                        dataRow[i] = dt.ToString("dd/MM/yyyy");
                    else if (val is string s && DateTime.TryParse(s, out var parsed))
                        dataRow[i] = parsed.ToString("dd/MM/yyyy");
                    else
                        dataRow[i] = val ?? DBNull.Value;
                }
                else
                {
                    dataRow[i] = val ?? DBNull.Value;
                }
            }

            table.Rows.Add(dataRow);
        }

        return table;
    }
}
