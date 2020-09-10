using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace Common
{
    public static class FileExporter
    {
        public static byte[] ExportToExcel<T>(List<T> data)
        {
            MemoryStream documentStream = new MemoryStream();
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(documentStream, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();

                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet();
                worksheetPart.Worksheet.AppendChild(new SheetData());

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Export" };
                sheets.Append(sheet);

                var worksheet = worksheetPart.Worksheet;

                var sheetData = worksheet.GetFirstChild<SheetData>();
                var rowHeader = new Row { RowIndex = 1 };

                sheetData.Append(rowHeader);

                int rowHeaderCellIndex = 0;
                foreach (PropertyInfo property in typeof(T).GetProperties())
                {
                    string name = property.Name;


                    if (property.GetCustomAttribute(typeof(DisplayNameAttribute)) is DisplayNameAttribute displayNameAttribute)
                    {
                        name = displayNameAttribute.DisplayName;
                    }

                    Cell cell = new Cell() { DataType = CellValues.String };

                    CellValue cellValue = new CellValue(name);
                    cell.Append(cellValue);

                    rowHeader.InsertAt(cell, rowHeaderCellIndex);
                    rowHeaderCellIndex++;
                }

                uint rowIndex = 2;
                foreach (var item in data)
                {
                    var row = new Row { RowIndex = rowIndex };
                    sheetData.Append(row);

                    int rowCellIndex = 0;
                    foreach (PropertyInfo property in item.GetType().GetProperties())
                    {
                        string name = property.Name;

                        var value = property.GetValue(item, null);

                        Cell cell = new Cell() { DataType = CellValues.String };
                        CellValue cellValue = new CellValue(property.GetValue(item, null) != null ? property.GetValue(item, null).ToString() : string.Empty);
                        cell.Append(cellValue);

                        row.InsertAt(cell, rowCellIndex);
                        rowCellIndex++;
                    }

                    rowIndex++;
                }

                document.Close();
            }


            var memoryStream = new MemoryStream();
            documentStream.CopyTo(memoryStream);

            return documentStream.ToArray();
        }
    }
}
