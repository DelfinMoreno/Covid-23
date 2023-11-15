using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class FrmCovid19 : Form
    {
        string vtos = "";
        string vfiebre = "";
        string vcansancio = "";
        string vincapacidad = "";
        string vrespiracion = "";
        string vdolor = "";
        String TipoSexo;
        public FrmCovid19()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincias.SelectedIndex !=-1)
            {
                Name = cbProvincias.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbcansancio.Checked == true)
            {
                vcansancio = "Cansancio";
            }
            else
            {
                vcansancio = "";
            }
        }

        private void FrmCovid19_Load(object sender, EventArgs e)
        {

        }

        private void chbFiebre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFiebre.Checked == true)
            {
                vfiebre = "Fiebre";
            }
            else
            {
                vfiebre = "";
            }
        }

        private void chbTos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTos.Checked == true)
            {
                vtos = "Tos";
            }
            else
            {
                vtos = "";
            }
        }

        private void chbDifResprirar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDifResprirar.Checked == true)
            {
                vrespiracion = "Respirar";
            }
            else
            {
                vrespiracion = "";
            }
        }

        private void chbDolorPecho_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDolorPecho.Checked == true)
            {
                vdolor = "Dolor en el pecho";
            }
            else
            {
                vdolor = "";
            }
        }

        private void chbIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIncapacidad.Checked == true)
            {
                vincapacidad = "Incapacidad para respirar";
            }
            else
            {
                vincapacidad = "";
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMasculino.Checked == true)
            {
                txtOtro.Enabled = false;
                TipoSexo = "Masculino";
            }
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbFemenino.Checked == true)
            {
                txtOtro.Enabled = false;
                TipoSexo = "Femenino";
            }
    }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbOtro.Checked == true)
            {
                txtOtro.Enabled = true;
                Name = txtOtro.Text;
            }
        }

        private void btnResumir_Click(object sender, EventArgs e)
        {
            string mensaje0 = "Información diagnóstico CORONAVIRUS - COVID-19";
            string mensaje1 = "Nombre: " + txtNombre.Text + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            string mensaje2 = "Fecha: " + txtFechaActual.Text + " Dirección: " + txtDireccion.Text;
            string mensaje3 = "Género: " + "Correo electrónico: " + txtCorreoElec.Text;
            string mensaje4 = "Síntomas básicos: " + vfiebre + " " + vtos + " " + vcansancio;
            string mensaje5 = "Síntomas graves: " + vrespiracion + " " + vdolor + " " + vincapacidad;

            DialogResult Resultado = new DialogResult();
            Resultado = MessageBox.Show(mensaje0 + mensaje1 + mensaje2 + mensaje3 + mensaje4 + mensaje5 + " " +
                "Información general resumen" + MessageBoxButtons.OK + MessageBoxIcon.Information);
        }
    }
}