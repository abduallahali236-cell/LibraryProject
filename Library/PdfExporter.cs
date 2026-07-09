using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.Windows.Forms;

namespace Library.UI.Helpers;

public static class PdfExporter
{
    public static void Export(DataGridView grid)
    {
        if (grid == null || grid.Rows.Count == 0)
        {
            MessageBox.Show(
                "There is no data to export.",
                "Export",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        using SaveFileDialog dialog = new();

        dialog.Filter = "PDF Files (*.pdf)|*.pdf";
        dialog.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        DataTable table = ToDataTable(grid);

        Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Margin(25);

                page.Size(PageSizes.A4);

                page.DefaultTextStyle(x => x.FontSize(11));

                page.Header()
                    .Text("Library Report")
                    .FontSize(20)
                    .Bold()
                    .AlignCenter();

                page.Content()
                    .PaddingVertical(20)
                    .Table(tableBuilder =>
                    {
                        // Define columns once, adding one RelativeColumn per DataColumn
                        tableBuilder.ColumnsDefinition(c =>
                        {
                            foreach (DataColumn _ in table.Columns)
                                c.RelativeColumn();
                        });

                        tableBuilder.Header(header =>
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                header.Cell()
                                    .Border(1)
                                    .Padding(5)
                                    .Text(column.ColumnName)
                                    .Bold();
                            }
                        });

                        foreach (DataRow row in table.Rows)
                        {
                            foreach (object value in row.ItemArray)
                            {
                                tableBuilder.Cell()
                                    .Border(1)
                                    .Padding(5)
                                    .Text(value?.ToString() ?? "");
                            }
                        }
                    });

                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Generated: ");

                        x.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    });
            });
        })
        .GeneratePdf(dialog.FileName);

        MessageBox.Show(
            "PDF exported successfully.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private static DataTable ToDataTable(DataGridView grid)
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
                dataRow[i] = row.Cells[i].Value ?? DBNull.Value;
            }

            table.Rows.Add(dataRow);
        }

        return table;
    }
}