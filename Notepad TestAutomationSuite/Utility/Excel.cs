﻿using System;
using ExcelSheet = Microsoft.Office.Interop.Excel;


namespace Notepad_TestAutomationSuite.Utility
{
    class Excel
    {
        public String readExcel(string filePath, int worksheetIndex, int column, int row)
        {

            ExcelSheet.Application xlApplication = new ExcelSheet.Application();

            ExcelSheet.Workbook xlWorkbook = xlApplication.Workbooks.Open(@filePath);

            ExcelSheet._Worksheet xlWorksheet = (ExcelSheet._Worksheet)xlWorkbook.Sheets[worksheetIndex];

            ExcelSheet.Range xlRange = xlWorksheet.UsedRange;

            Console.Write(xlRange.Cells[row, column].Value2.ToString());

            String value = xlRange.Cells[row, column].Value2.ToString();
            xlWorkbook.Close();
            xlApplication.Quit();
            return value;

        }
    }
}
