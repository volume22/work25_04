using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
namespace WpfApp2.Model
{
    class DataSettings
    {
        public string Path { get; private set; }
        MCSEntities db = new MCSEntities();

        public DataSettings() { }
        public DataSettings(string path)
        {
            this.Path = path;

        }

        public List<newEquipment> getListOfCars(DateTime from, DateTime to)
        {
            List<newEquipment> newEquipments = new List<newEquipment>();
            newEquipments = db.newEquipment.
                Where(w => w.CreateDate >= from && w.CreateDate <= to).ToList();

            return newEquipments;
        }

        public bol createExcell()
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(Path)))
            {
                ExcelWorksheet worksheet1 = package.Workbook.Worksheets["Лист1"];

                /*ExcelWorkbook workbook = package.Workbook;
                ExcelWorksheet worksheet = workbook.Worksheets["Лист1"];*/

                int k = 4;
                foreach (var item in newEquipments)
                {
                    worksheet1.Cells[k, 3].Value = elem.TablesModel.strName;
                    worksheet1.Cells[k, 3].Value = "";
                    worksheet1.Cells[k, 3].Value = elem.LastDate;
                    worksheet1.Cells[k, 3].Value = "";
                    k++
                }
                try
                {
                    package.SaveAs("Result1." + DateTime.Today + "xlsx");
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }



            }
        }
    }
}
