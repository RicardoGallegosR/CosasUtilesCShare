using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using SharpCompress.Archives;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cShare {
    public class ZipFile {
        public void MakeZip(string pathFolder, string name) {
            using (var archive = ZipArchive.Create()) {
                try {
                    archive.AddAllFromDirectory(pathFolder, "*.dbf");
                    archive.SaveTo($@"{Path.GetDirectoryName(pathFolder)}\{name}.zip", CompressionType.Deflate);
                } catch (IOException) {
                    MessageBox.Show("Asegurese que el archivo este cerrado");
                } catch (DivideByZeroException) {
                    MessageBox.Show("Archivo vacio");
                }
            }
        }
    }
}