using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpreadsheetLight;
using System.Data;

namespace cShare {
    class SaveExcel {
        public void LoadDataExcel (string pathSave, DataTable dtExcel) {
            SLDocument osDocument = new SLDocument();
            osDocument.ImportDataTable(1, 1, dtExcel, true);
            osDocument.SaveAs(pathSave);
        }
    }
}