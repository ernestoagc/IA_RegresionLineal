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
using System.Diagnostics;
using BusinessEntities;


using Accord.IO;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Linear;

namespace WFRegresionLineal
{
    public partial class Form1 : Form
    {

		DataTable dtArchivo = new DataTable("Archivo");
        private DataTable sourceTable;
        double[][] inputs;
        double[] outputs;
        bool proceso = false;
        DataFrame<long,string> df = null;
        List<LinearRegressionCoefficient> listaCoeficientes;
        //public List<RegistroBE> listaRegistro = new List<RegistroBE>();
        public List<RegistroBE> listaRegistro;
        public Form1()
        {
            InitializeComponent();
            CargarValoresIniciales();
        }

		private void CargarValoresIniciales() {
            cmbProducto.ValueMember= "CODIGO";
            cmbProducto.DisplayMember = "NOMBRE";

            cmbBanca.ValueMember = "CODIGO";
            cmbBanca.DisplayMember = "NOMBRE";

            cmbGarantia.ValueMember = "CODIGO";
            cmbGarantia.DisplayMember = "NOMBRE";
            
            cmbMoneda.ValueMember = "CODIGO";
            cmbMoneda.DisplayMember = "NOMBRE";

            cmbTipoDocumento.ValueMember = "CODIGO";
            cmbTipoDocumento.DisplayMember = "NOMBRE";

            cmbTipoPlazo.ValueMember = "CODIGO";
            cmbTipoPlazo.DisplayMember = "NOMBRE";


            cmbProducto.DataSource = Helper.UtilFunction.getProductos();
            cmbBanca.DataSource = Helper.UtilFunction.getBanca();
            cmbGarantia.DataSource = Helper.UtilFunction.getGarantia();
            cmbMoneda.DataSource = Helper.UtilFunction.getMoneda();
            cmbTipoDocumento.DataSource = Helper.UtilFunction.getTipoDocumento();
            cmbTipoPlazo.DataSource = Helper.UtilFunction.getTipoPlazo();

          //  gvDatos.DataSource = listaRegistro;
            
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
                    leerExcel(openfd.FileName);
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

            if (proceso)
            {
                tabControl1.SelectedIndex = 2;
                RegistroBE registroBE = new RegistroBE();
                registroBE.PRODUCTO_CODIGO = Convert.ToInt32(cmbProducto.SelectedValue);
                registroBE.PRODUCTO = ((ParametroBE)cmbProducto.SelectedItem).NOMBRE;

                registroBE.BANCA_CODIGO = Convert.ToInt32(cmbBanca.SelectedValue);
                registroBE.BANCA = ((ParametroBE)cmbBanca.SelectedItem).NOMBRE;

                registroBE.MONEDA_CODIGO = Convert.ToInt32(cmbMoneda.SelectedValue);
                registroBE.MONEDA = ((ParametroBE)cmbMoneda.SelectedItem).NOMBRE;

                registroBE.TIPO_DOCUMENTO_CODIGO = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                registroBE.TIPO_DOCUMENTO = ((ParametroBE)cmbTipoDocumento.SelectedItem).NOMBRE;


                registroBE.TIPO_PLAZO_CODIGO = Convert.ToInt32(cmbTipoPlazo.SelectedValue);
                registroBE.TIPO_PLAZO = ((ParametroBE)cmbTipoPlazo.SelectedItem).NOMBRE;


                registroBE.GARANTIA_CODIGO = Convert.ToInt32(cmbGarantia.SelectedValue);
                registroBE.GARANTIA = ((ParametroBE)cmbGarantia.SelectedItem).NOMBRE;

                registroBE.IMPORTE = Convert.ToInt32(txtImporte.Text);
                registroBE.PLAZO = Convert.ToInt32(txtPlazo.Text);
                registroBE.NRO_FAMILIA = Convert.ToInt32(txtNumeroFamilia.Text);

                agregarRegistro(registroBE);
                MessageBox.Show("Se realizo el cálculo de tasa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {

                MessageBox.Show("Debe de ejecutar el proceso antes de realizar el calculo de la tasa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


        }

        private void agregarRegistro(RegistroBE registroBE) {
            double valorTasa = 0;
            foreach(var obj in listaCoeficientes) {

                switch (obj.Name)
                {
                    case "PRODUCTO":
                        registroBE.PRODUCTO_VALOR = registroBE.PRODUCTO_CODIGO * obj.Value;
                        break;
                    case "GARANTIA":
                        registroBE.GARANTIA_VALOR = registroBE.GARANTIA_CODIGO * obj.Value;
                        break;
                    case "MONEDA":
                        registroBE.MONEDA_VALOR = registroBE.MONEDA_CODIGO * obj.Value;
                        break;
                    case "IMPORTE":
                        registroBE.IMPORTE_VALOR = registroBE.IMPORTE * obj.Value;
                        break;
                    case "TIPO_PLAZO":
                        registroBE.TIPO_PLAZO_VALOR = registroBE.TIPO_PLAZO_CODIGO * obj.Value;
                        break;
                    case "PLAZO":
                        registroBE.PLAZO_VALOR = registroBE.PLAZO * obj.Value;
                        break;
                    case "NRO_FAMILIA":
                        registroBE.NRO_FAMILIA_VALOR = registroBE.NRO_FAMILIA * obj.Value;
                        break;
                    case "BANCA":
                        registroBE.BANCA_VALOR = registroBE.BANCA_CODIGO * obj.Value;
                        break;
                    case "TIPO_DOCUMENTO":
                        registroBE.TIPO_DOCUMENTO_VALOR = registroBE.TIPO_DOCUMENTO_CODIGO * obj.Value;
                        break;
                    case "Intercept":
                        registroBE.INTERCEPTO = obj.Value;
                        break;
                    default:
                        break;
                }

            }

            registroBE.TASA = registroBE.INTERCEPTO + registroBE.PRODUCTO_VALOR + registroBE.GARANTIA_VALOR + registroBE.BANCA_VALOR + registroBE.IMPORTE_VALOR + registroBE.MONEDA_VALOR + registroBE.NRO_FAMILIA_VALOR + registroBE.PLAZO_VALOR + registroBE.TIPO_DOCUMENTO_VALOR + registroBE.TIPO_PLAZO_VALOR;
            if (listaRegistro == null)
                listaRegistro = new List<RegistroBE>();


            listaRegistro.Add(registroBE);
            DataTable dtRespuesta=  Helper.UtilFunction.ConvertToDatatable(listaRegistro);

            dtRespuesta.Columns.Remove("PRODUCTO_CODIGO");
            dtRespuesta.Columns.Remove("PRODUCTO_VALOR");
            dtRespuesta.Columns.Remove("MONEDA_CODIGO");
            dtRespuesta.Columns.Remove("MONEDA_VALOR");
            dtRespuesta.Columns.Remove("IMPORTE_VALOR");
            dtRespuesta.Columns.Remove("TIPO_PLAZO_CODIGO");
            dtRespuesta.Columns.Remove("TIPO_PLAZO_VALOR");

            dtRespuesta.Columns.Remove("PLAZO_VALOR");
            dtRespuesta.Columns.Remove("GARANTIA_CODIGO");
            dtRespuesta.Columns.Remove("GARANTIA_VALOR");
            dtRespuesta.Columns.Remove("TIPO_DOCUMENTO_CODIGO");
            dtRespuesta.Columns.Remove("TIPO_DOCUMENTO_VALOR");

            dtRespuesta.Columns.Remove("NRO_FAMILIA_VALOR");
            dtRespuesta.Columns.Remove("BANCA_CODIGO");
            dtRespuesta.Columns.Remove("BANCA_VALOR");
            dtRespuesta.Columns.Remove("INTERCEPTO");


            gvDatos.DataSource = dtRespuesta;
            //gvDatos.Update();
            var ook = gvEstadistica;
            string fuente = "";
        }

        private void leerExcel(string archivo) {
            ExcelReader db = new ExcelReader(archivo, true, false);
            HojaSeleccion t = new HojaSeleccion(db.GetWorksheetList());

            if (t.ShowDialog(this) == DialogResult.OK)
            {
                string hoja = t.Selection;
                sourceTable = db.GetWorksheet(hoja);
                gvArchivo.DataSource = sourceTable;
            }
               

        }

        private void btnProcesar_Click(object sender, EventArgs e)
		{
            Procesar();
        }

		private void Procesar() {
            try {
                if (gvArchivo.Rows.Count == 0) {

                    MessageBox.Show("Primero se debe realizar la carga de datos históricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                tabControl1.SelectedIndex = 1;
                string[] independentNames = Helper.UtilFunction.getVariablesIndependientesDefecto();
                string dependentName = Helper.UtilFunction.getVariableDependienteDefecto();

                DataTable independent = sourceTable.DefaultView.ToTable(false, independentNames);
                DataTable dependent = sourceTable.DefaultView.ToTable(false, dependentName);

                inputs = independent.ToJagged();
                outputs = dependent.Columns[dependentName].ToArray();

                MultipleLinearRegressionAnalysis mlr = new MultipleLinearRegressionAnalysis(intercept: true)
                {
                    Inputs = independentNames,
                    Output = dependentName
                };

                // Compute the Linear Regression Analysis
                MultipleLinearRegression reg = mlr.Learn(inputs, outputs);

                gvEstadistica.DataSource = mlr.Coefficients;

                //   var listaCoeficientes = mlr.Coefficients.ToList();

                listaCoeficientes = mlr.Coefficients.ToList();

                var coeficientes = mlr.CoefficientValues;

                proceso = true;

                MessageBox.Show("Se ejecuto el algoritmo correctamente", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex) {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void leerCSV(string fileName) {
            df = DataFrame.ReadCsv(fileName);
        }


        private string getParametroDependiente() {
            string dependiente = "TASA";

            return dependiente;

        }

        private string[] getParametroIndependiente() {

            string[] independientes = { "PRODUCTO", "MONEDA", "IMPORTE", "TIPO_PLAZO", "PLAZO", "GARANTIA", "TIPO_DOCUMENTO", "NRO_FAMILIA" };

            return independientes;
        }
	}
}
