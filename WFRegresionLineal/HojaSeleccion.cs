using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRegresionLineal
{
    public partial class HojaSeleccion : Form
    {
        public HojaSeleccion(string[] tables)
        {
            InitializeComponent();
            lbExcel.DataSource = tables;
        }


        public string Selection
        {
            get { return this.lbExcel.SelectedItem as string; }
        }
    }

}
