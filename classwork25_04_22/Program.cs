﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork25_04_22
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo("MyWorkBook.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int k = 4;
                for (int i = 0; i< 10;i++)
                {
                    worksheet.Cells[k, 3].Value = "VALUE - " + i;
                    worksheet.Cells[k++, 4].Value = "VALUE - " + i;
                }
                package.SaveAs("Result.xlsx");
            }
        }
    }
}