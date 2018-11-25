using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using CsvHelper;
using Extreme.DataAnalysis;
using Extreme.Mathematics;
using Extreme.Statistics;

namespace WFRegresionLineal
{
    public partial class Form1 : Form
    {

		DataTable dtArchivo = new DataTable("Archivo");
		DataFrame<long,string> df = null;
        public Form1()
        {
            InitializeComponent();
        }

		private void InicializarGrilla() {

		}

		private void gvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnExaminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (openfd.ShowDialog() ==DialogResult.OK)
				{
					txtExaminar.Text = openfd.FileName;
					dtArchivo = ReadCvs(openfd.FileName);
					gvDatos.DataSource = dtArchivo;
					MessageBox.Show("Se cargo el archivo de forma exitosa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex) {

				MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}


		}

		public DataTable ReadCvs(string fileName) {

			df = DataFrame.ReadCsv(fileName);
			//CsvReader();
			DataTable dt = new DataTable("Datos");
			using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
				Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=Yes;FMT=Delimited(;)';"))
			{
				using (OleDbCommand cmd = new OleDbCommand(string.Format("select * from [{0}]",new FileInfo(fileName).Name),cn))
				{
					cn.Open();
					using (OleDbDataAdapter adapter= new OleDbDataAdapter(cmd))
					{
						adapter.Fill(dt);
					}
					
				}

			}
				return dt;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{

		}

		private void btnProcesar_Click(object sender, EventArgs e)
		{
			var model = new LinearRegressionModel(df,
				"TASA", new string[] { "PRODUCTO", "MONEDA", "IMPORTE", "TIPO_PLAZO", "PLAZO", "GARANTIA", "SEGMENTO", "TIPO_DOCUMENTO", "NRO_FAMILIA", "BANCA" });
		}

		private void Procesar() {

		}
	}
}
