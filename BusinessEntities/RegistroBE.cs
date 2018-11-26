using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RegistroBE
    {
        public string PRODUCTO { get; set; }
        public int PRODUCTO_CODIGO { get; set; }
        public double PRODUCTO_VALOR { get; set; }

        public string MONEDA { get; set; }
        public int MONEDA_CODIGO { get; set; }
        public double MONEDA_VALOR { get; set; }


        public int IMPORTE { get; set; }
        public double IMPORTE_VALOR { get; set; }


        public string TIPO_PLAZO { get; set; }
        public int TIPO_PLAZO_CODIGO { get; set; }
        public double TIPO_PLAZO_VALOR { get; set; }

        public int PLAZO { get; set; }
        public double PLAZO_VALOR { get; set; }

        public string GARANTIA { get; set; }
        public int GARANTIA_CODIGO { get; set; }
        public double GARANTIA_VALOR { get; set; }

        public string TIPO_DOCUMENTO { get; set; }
        public int TIPO_DOCUMENTO_CODIGO { get; set; }
        public double TIPO_DOCUMENTO_VALOR { get; set; }

        public int NRO_FAMILIA { get; set; }
        public double NRO_FAMILIA_VALOR { get; set; }

        public string BANCA { get; set; }
        public int BANCA_CODIGO { get; set; }
        public double BANCA_VALOR { get; set; }

        
        public double INTERCEPTO { get; set; }
        public double TASA { get; set; }
    }
}

