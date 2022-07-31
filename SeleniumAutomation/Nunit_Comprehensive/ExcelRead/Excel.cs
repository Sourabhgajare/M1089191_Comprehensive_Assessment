using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nunit_Comprehensive.ExcelRead
{
    public class Excel
    {
        public string ReadExcelName()
        {
            String path = @"C:\Users\mindc1may216\Desktop\MY_Folder\Read.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();
            Console.WriteLine("The Data in the ExcelSheet is :" + sheet);
            return sheet;
        }
    }
}
