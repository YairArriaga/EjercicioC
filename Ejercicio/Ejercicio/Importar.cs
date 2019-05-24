using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace Ejercicio
{
    class Importar
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;
        public static string mejorAlumno;
        public static string peorAlumno;


        public void importarExcel(DataGridView dgv)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties = \"Excel 12.0 Xml;HDR=YES\"; ");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + "Sheet1" + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;

                var max = dt.AsEnumerable().Max(row => row["Calificacion"]);
                string maxcal = max.ToString();
                var min = dt.AsEnumerable().Min(row => row["Calificacion"]);
                string mincal = min.ToString();

                var query = from datos in dt.AsEnumerable()
                                #region
                            where datos.Field<double>("Calificacion") == Convert.ToDouble(maxcal)
                            select new
                            {
                                nombre= datos.Field<string>("Nombres"),
                                apellido_Paterno = datos.Field<string>("Apellido Paterno"),
                                apellido_Materno = datos.Field<string>("Apellido Materno"),
                                calificacion = datos.Field<double>("Calificacion")
                            }.ToString();
                #endregion
                var singleString = string.Join(",", query.ToArray());
                mejorAlumno = singleString.ToString();

                var query2 = from datos in dt.AsEnumerable()
                                #region
                            where datos.Field<double>("Calificacion") == Convert.ToDouble(mincal)
                            select new
                            {
                                nombre = datos.Field<string>("Nombres"),
                                apellido_Paterno = datos.Field<string>("Apellido Paterno"),
                                apellido_Materno = datos.Field<string>("Apellido Materno"),
                                calificacion = datos.Field<double>("Calificacion")
                            }.ToString();
                #endregion
                var singleString2 = string.Join(",", query2.ToArray());
                peorAlumno = singleString2.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
    }
}

