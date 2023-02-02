using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SpreadsheetLight;


namespace cShare {
     class OpenExcel {
        public DataTable AbrirExcel (string path) {
            DataTable dt = new DataTable();
            using (SLDocument sl = new SLDocument(path)) {
                int iRow = 1;
                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1))) {
                    if (dt.Columns.Count == 0) {
                        int iCol = 1;
                        while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, iCol))) {
                            dt.Columns.Add(sl.GetCellValueAsString(iRow, iCol));
                            iCol++;
                        }
                    } else {
                        DataRow dr = dt.NewRow();
                        for (int iCol = 0; iCol < dt.Columns.Count; iCol++) {
                            dr [iCol] = sl.GetCellValueAsString(iRow, iCol + 1);
                        }
                        dt.Rows.Add(dr);
                    }
                    iRow++;
                }
                return dt;
            }
        }
    }
}