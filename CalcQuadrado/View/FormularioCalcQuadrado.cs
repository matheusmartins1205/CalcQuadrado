using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcQuadrado.View
{
    public partial class FormularioCalcQuadrado : Form
    {
        public FormularioCalcQuadrado()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txt_calcular.Text);

            txt_resultado.Text = "O valor quadrado de " + num + " é " + Quadrado(num);
            txt_calcular.Focus();
            txt_calcular.SelectAll();
        }

        private void Quadrado_Click(object sender, EventArgs e) { }
        int Quadrado(int num)
        {
            {

                int resultado;
                resultado = num * num;

                return resultado;

            }
        }
    }
}
       
