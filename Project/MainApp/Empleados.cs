using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace MainApp
{
    public partial class Empleados : UserControl
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                EnabledControls(true);
            }
            else
            {
                EnabledControls(false);
            }
        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void EnabledControls(bool v)
        {
            textNombre.Enabled = v;
            textApellido.Enabled = v;
            textDireccion.Enabled = v;
            textCiudad.Enabled = v;
            textCodigoPostal.Enabled = v;
            textTelefono.Enabled = v;
            textPuesto.Enabled = v;

            fechaNacimiento.Enabled = v;
            fechaContrato.Enabled = v;

            buttonNuevo.Enabled = v;
            buttonModificar.Enabled = v;
            buttonEliminar.Enabled = v;
        }

        String[] GetControlsValues()
        {
            return new string[]
            {
                textNombre.Text,
                textApellido.Text,
                textDireccion.Text,
                textCiudad.Text,
                textCodigoPostal.Text,
                textTelefono.Text,
                textPuesto.Text,
                fechaNacimiento.Value.ToString(),
                fechaContrato.Value.ToString()
            };
        }

    }
}
