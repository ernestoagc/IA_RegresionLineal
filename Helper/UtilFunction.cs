using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessEntities;
using System.ComponentModel;

namespace Helper
{
   public static class UtilFunction
    {
        public static List<ParametroBE> getProductos() {
            List<ParametroBE> resultado = new List<ParametroBE>();
            resultado.Add(getParametro(Constante.PRODUCTO.PLD_CODIGO, Constante.PRODUCTO.PLD));
            resultado.Add(getParametro(Constante.PRODUCTO.PRESTAMO_COMERCIAL_CP_CODIGO, Constante.PRODUCTO.PRESTAMO_COMERCIAL_CP));
            resultado.Add(getParametro(Constante.PRODUCTO.CONSTRUYO_CODIGO, Constante.PRODUCTO.CONSTRUYO));
            resultado.Add(getParametro(Constante.PRODUCTO.CONTICASA_CODIGO, Constante.PRODUCTO.CONTICASA));
            resultado.Add(getParametro(Constante.PRODUCTO.CONTIPUENTE_CODIGO, Constante.PRODUCTO.CONTIPUENTE));
            resultado.Add(getParametro(Constante.PRODUCTO.DESCUENTOS_CODIGO, Constante.PRODUCTO.DESCUENTOS));
            resultado.Add(getParametro(Constante.PRODUCTO.FIA_IMPORTACION_CODIGO, Constante.PRODUCTO.FIA_IMPORTACION));
            resultado.Add(getParametro(Constante.PRODUCTO.FIA_EXPORTACION_CODIGO, Constante.PRODUCTO.FIA_EXPORTACION));
            resultado.Add(getParametro(Constante.PRODUCTO.PLD_CODIGO, Constante.PRODUCTO.TARJETA_CAPITAL_TRABAJO));
            return resultado;
        }


        public static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }


        public static List<ParametroBE> getTipoPlazo()
        {
            List<ParametroBE> resultado = new List<ParametroBE>();
            resultado.Add(getParametro(Constante.TIPO_PLAZO.DIA_CODIGO, Constante.TIPO_PLAZO.DIA));
            resultado.Add(getParametro(Constante.TIPO_PLAZO.MES_CODIGO, Constante.TIPO_PLAZO.MES_CODIGO));

            return resultado;
        }

        public static string[] getVariablesIndependientesDefecto() {
            string[] resultado = { "PRODUCTO", "MONEDA", "IMPORTE", "TIPO_PLAZO", "PLAZO", "GARANTIA", "TIPO_DOCUMENTO", "NRO_FAMILIA","BANCA" };

            return resultado;
        }

        public static string getVariableDependienteDefecto() {
            string resultado = "TASA";
            return resultado;
        }

        public static List<ParametroBE> getTipoDocumento()
        {
            List<ParametroBE> resultado = new List<ParametroBE>();
            resultado.Add(getParametro(Constante.TIPO_DOCUMENTO.DNI_CODIGO, Constante.TIPO_DOCUMENTO.DNI));
            resultado.Add(getParametro(Constante.TIPO_DOCUMENTO.RUC_CODIGO, Constante.TIPO_DOCUMENTO.RUC));

            return resultado;
        }


        public static List<ParametroBE> getBanca()
        {
            List<ParametroBE> resultado = new List<ParametroBE>();
            resultado.Add(getParametro(Constante.BANCA.MIN_CODIGO, Constante.BANCA.MIN));
            resultado.Add(getParametro(Constante.BANCA.BEC_CODIGO, Constante.BANCA.BEC));

            return resultado;
        }



        public static List<ParametroBE> getMoneda()
        {
            List<ParametroBE> resultado = new List<ParametroBE>();
            resultado.Add(getParametro(Constante.MONEDA.PEN_CODIGO, Constante.MONEDA.PEN));
            resultado.Add(getParametro(Constante.MONEDA.USD_CODIGO, Constante.MONEDA.USD));

            return resultado;
        }

        public static List<ParametroBE> getGarantia()
        {
            List<ParametroBE> resultado = new List<ParametroBE>();
            resultado.Add(getParametro(Constante.GARANTIA.SIN_GARANTIA_CODIGO, Constante.GARANTIA.SIN_GARANTIA));
            resultado.Add(getParametro(Constante.GARANTIA.DINERARIA_CODIGO, Constante.GARANTIA.DINERARIA));
            resultado.Add(getParametro(Constante.GARANTIA.NO_DINERARIA_CODIGO, Constante.GARANTIA.NO_DINERARIA));

            return resultado;
        }


        public static ParametroBE getParametro(string Codigo, string Nombre) {
            ParametroBE resultado = new ParametroBE();
            resultado.CODIGO = Codigo;
            resultado.NOMBRE = Nombre;

            return resultado;

        }

        public static ParametroBE getParametro(string Titulo, string Codigo, string Nombre)
        {
            ParametroBE resultado = getParametro(Codigo,Nombre);
            resultado.TITULO = Titulo;
            return resultado;

        }

    }
}
