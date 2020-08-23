using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescuantosTemporda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double valor = 0.0;

            double descuento = 0.0;


            valor = Convert.ToDouble(txtValor.Text);

            if ((rbEscolar.Checked == true) && (valor <= 100000))
            {
                descuento = 0.0;
                valor = valor + descuento;

            }

            else if ((rbEscolar.Checked == true) && (valor >= 100001 && valor <= 300000))
            {
                descuento = valor * 0.10;
                valor = valor - descuento;

            }

            else if ((rbEscolar.Checked == true) && (valor >300000))
            {
                descuento = valor * 0.15;
                valor = valor - descuento;

            }


 

            
            if ((rbHalloween.Checked == true) && (valor >= 50 && valor <= 30000))
            {
                descuento = 0.0;
                valor = valor + descuento;
            }

            else if ((rbHalloween.Checked == true) && (valor >= 30001 && valor <= 200000))
            {
                descuento = valor * 0.02;
                valor = valor - descuento;
            }

            else if ((rbHalloween.Checked == true) && (valor > 200000))
            {
                descuento = valor * 0.05;
                valor = valor - descuento;
            }


            

            if ((rbDiciembre.Checked == true) && (valor >= 50 && valor <= 300000))
            {
                descuento = 0.0;
                valor = valor + descuento;

            }

            else if ((rbDiciembre.Checked == true) && (valor >= 300001 && valor <= 500000))
            {
                descuento = valor * 0.05;
                valor = valor - descuento;

            }

            else if ((rbDiciembre.Checked == true) && (valor > 500000))
            {
                descuento = valor * 0.10;
                valor = valor - descuento;


            }
            label4.Visible = true;
            label4.Text = Convert.ToString(String.Format("{0:n0}", valor));
            label5.Visible = true;
            label5.Text = Convert.ToString(String.Format("{0:n0}", descuento));
            label6.Visible = true;
            label7.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Text = String.Empty;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            txtValor.Focus();
            rbEscolar.Checked = true;
        }
    }
}
