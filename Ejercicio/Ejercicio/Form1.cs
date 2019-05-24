using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Http;

namespace Ejercicio
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            labelPromedio.Text = "";
            labelmax.Text = "";
            labelmin.Text = "";
            labelclima.Text = "";
            GetRequest("https://api.apixu.com/v1/current.json?key=687004ea525b4250a6f212133192405&q=Mexico/Sonora/Hermosillo");

        }
        public async void GetRequest(string url)
        {
            using (HttpClient cliente = new HttpClient())
            {
                using (HttpResponseMessage response = await cliente.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        MessageBox.Show(mycontent);
                        labelclima.Text = mycontent.Replace('{', ' ').Replace('}', ' ');
                    }
                }
            }

        }
        private void Importarbtn_Click(object sender, EventArgs e)
        {

            Importar Imp = new Importar();
            Imp.importarExcel(dgvexcel);
            string[] series = new string[dgvexcel.Rows.Count];

            string[] puntos = new string[dgvexcel.Rows.Count];

            int i = 0;

            foreach (DataGridViewRow row in dgvexcel.Rows)
            {
                series[i] = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                puntos[i] = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : string.Empty;
                i++;

            }
            double[] puntosd = new double[puntos.Length];
            for (int y = 0; y < puntos.Length; y++)
            {
                Double.TryParse(puntos[y], out puntosd[y]);
            }

            for (int x = 0; x < series.Length; x++)
            {
                Series serie = chartxls.Series.Add(series[x]);
                serie.Label = puntos[x].ToString();

                serie.Points.Add(puntosd[x]);
            }

            chartxls.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            chartxls.Titles.Add("Calificaciones");
            var total = dgvexcel.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[6].Value));
            decimal promedio=0;
            decimal cantRows = dgvexcel.Rows.Cast<DataGridViewRow>().Count();
            try
            {
                promedio = total / cantRows;

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No Se Permite Division Entre 0");
            }
            string resultado = "";
            DateTime thisDay = DateTime.Today;
            thisDay.ToString("dd/MM/yyyy");
            labelPromedio.Text = ("la Calificacion promedio" + " " + promedio.ToString()).ToUpperInvariant();
            labelmax.Text = ("mejor Calificacion " + Importar.mejorAlumno.Replace('=', ' ').Replace('{', ' ').Replace('}', ' ').ToLower()).ToUpperInvariant();
            labelmin.Text = ("peor calificacion " + Importar.peorAlumno.Replace('=', ' ').Replace('{', ' ').Replace('}', ' ').ToLower()).ToUpperInvariant();
            //dgvexcel.Rows.Remove(dgvexcel.Rows[dgvexcel.Rows.Count - 1]);
            string name = "", apm, fecha;
            string nom = "Clave";
            string enc = "Clave";
            int fila = 0;
            dgvexcel.Columns.Add(nom, enc);
            List<string> lista = new List<string>();

            foreach (DataGridViewRow row in dgvexcel.Rows)
            {
                resultado = "";
                if (name == null)
                {
                    break;
                }
                else
                {

                    name = (row.Cells["Nombres"].Value.ToString());

                    apm = (row.Cells["Apellido Materno"].Value.ToString());

                    fecha = (row.Cells["fecha de Nacimiento"].Value.ToString());
                    string actual = thisDay.ToString("dd/MM/yyyy");
                    TimeSpan tiempoDiferencia = (DateTime.Now - Convert.ToDateTime(fecha));

                    int edad = (tiempoDiferencia.Days) / 365;
                    string dos = apm.Substring(apm.Length - 2);
                    //resultado = name.Substring(0, 2) + Convert.ToString(apm[apm.Length - 2]) + edad;
                    resultado = name.Substring(0, 2) + dos + edad;
                    resultado = resultado.ToLower().Replace('a', 'x').Replace('b', 'y').Replace('c', 'z').Replace('d', 'a').Replace('e', 'b').Replace('f', 'c').
                        Replace('g', 'd').Replace('h', 'e').Replace('i', 'f').Replace('j', 'g').Replace('k', 'h').Replace('l', 'i').Replace('m', 'j').Replace('n', 'k').
                        Replace('ñ', 'l').Replace('o', 'm').Replace('p', 'n').Replace('q', 'ñ').Replace('r', 'o').Replace('s', 'p').Replace('t', 'q').Replace('u', 'r').
                        Replace('v', 's').Replace('w', 't').Replace('x', 'u').Replace('y', 'v').Replace('z', 'w');

                }
                fila = fila + 1;

                if (resultado != "")
                {

                    lista.Add(resultado);
                    this.dgvexcel[7, fila - 1].Value = resultado;


                }

            }
        }

        private void chartxls_Click(object sender, EventArgs e)
        {

        }

        private void labelPromedio_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvexcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posiciones = 0;
            string cambio, rotado;
            cambio = dgvexcel.CurrentCell.Value.ToString();
            posiciones = Convert.ToInt32(textBoxrota.Text);
            MessageBox.Show("Se rotara la clavle " + cambio + " " + posiciones + " veces");
            char[] arr, arr1;
            arr = cambio.ToCharArray();
            arr1 = leftrotation(arr, posiciones);
            rotado = string.Join("", arr1);
            MessageBox.Show("EL resultado de la Rotacion es " + rotado);
            dgvexcel.CurrentCell.Value = rotado;
            textBoxrota.Focus();

        }
        public static char[] leftrotation(char[] arr, int d)
        {

            char[] newarr = new char[arr.Length];
            var n = arr.Length;
            bool isswapped = false;
            for (int i = 0; i < n; i++)
            {
                int index = Math.Abs((i) - d);
                if (index == 0)
                {
                    isswapped = true;
                }

                if (!isswapped)
                {
                    int finalindex = (n) - index;
                    newarr[finalindex] = arr[i];
                }
                else
                {
                    newarr[index] = arr[i];
                }
            }
            return newarr;
        }

        private void textBoxrota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
