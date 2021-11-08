using EverydayPatientInfo.ProjectStructure.PatientStructure;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure
{
    static class ExcelExport
    {
        static ExcelExport()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public static bool Export(List<Patient> patients, string path, string name, List<PatientExportParams> @params)
        {
            try
            {
                FileInfo file = new(path + "\\" + name + ".xlsx");
                if (file.Exists) try { file.Delete(); } catch { return false; };
                
                ExcelPackage package = new(file);
                
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("patients");
                ws.Cells[1, 1].LoadFromCollection<Patient>(patients, true);
                ws.Cells[1, 8].LoadFromCollection<PatientData>(new List<PatientData>(), true);
                for (int i = 2, j = 0; j < patients.Count; j++)
                {
                    ws.InsertRow(i+1, patients[j].PatientDataList.Count-1);
                    package.Save();
                
                    ws.Cells[i, 8].LoadFromCollection(patients[j].PatientDataList,false);
                
                    i += patients[j].PatientDataList.Count;
                }
                
                ExcelRangeBase range = ws.Cells;
                range.AutoFitColumns();

                ws.DeleteColumn(1);
                for (int i = 0, j = 1; i < 16; i++)
                {
                    if (!@params[i].IsShown)
                        ws.DeleteColumn(j);
                    else
                        j++;
                    
                }
                
                package.Save();
                return true;
            }
            catch
            {
                return false;
            }

        }


    }
}
