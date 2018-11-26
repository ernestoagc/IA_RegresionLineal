using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Constante
    {
        public static class PRODUCTO
        {
            public static String TITULO = "PRODUCTO";

            public static String PLD = "PLD";
            public static String PRESTAMO_COMERCIAL_CP = "Préstamo Comercial (CP)";            
            public static String CONSTRUYO = "Construyo";
            public static String CONTICASA = "Conticasa";
            public static String CONTIPUENTE = "Contipuente";
            public static String DESCUENTOS = "Descuentos";
            public static String FIA_EXPORTACION = "FIA Exportación";
            public static String FIA_IMPORTACION = "FIA Importación";
            public static String TARJETA_CAPITAL_TRABAJO = "Tarjeta Capital de Trabajo";

            public static String PLD_CODIGO = "1";
            public static String PRESTAMO_COMERCIAL_CP_CODIGO = "2";
            public static String CONSTRUYO_CODIGO = "3";
            public static String CONTICASA_CODIGO = "4";
            public static String CONTIPUENTE_CODIGO = "5";
            public static String DESCUENTOS_CODIGO = "6";
            public static String FIA_EXPORTACION_CODIGO = "7";
            public static String FIA_IMPORTACION_CODIGO = "8";
            public static String TARJETA_CAPITAL_TRABAJO_CODIGO = "9";
        }

        public static class GARANTIA
        {
            public static String TITULO = "GARANTIA";

            public static String SIN_GARANTIA = "SIN GARANTÍA";
            public static String DINERARIA = "DINERARIA";
            public static String NO_DINERARIA = "NO DINERARIA";

            public static String SIN_GARANTIA_CODIGO = "1";
            public static String DINERARIA_CODIGO = "2";
            public static String NO_DINERARIA_CODIGO = "3";

        }

        public static class TIPO_DOCUMENTO
        {
            public static String TITULO = "TIPO_DOCUMENTO";

            public static String DNI = "DNI";
            public static String RUC = "RUC";

            public static String DNI_CODIGO = "1";
            public static String RUC_CODIGO = "2";

        }

        public static class MONEDA
        {
            public static String TITULO = "MONEDA";

            public static String PEN = "PEN";
            public static String USD = "USD";

            public static String PEN_CODIGO = "1";
            public static String USD_CODIGO = "2";

        }


        public static class BANCA
        {
            public static String TITULO = "BANCA";

            public static String MIN = "MIN";
            public static String BEC = "BEC";

            public static String MIN_CODIGO = "1";
            public static String BEC_CODIGO = "2";

        }


        public static class TIPO_PLAZO
        {
            public static String TITULO = "TIPO_PLAZO";

            public static String DIA = "DIA";
            public static String MES = "MES";

            public static String DIA_CODIGO = "1";
            public static String MES_CODIGO = "2";

        }


    }
}
