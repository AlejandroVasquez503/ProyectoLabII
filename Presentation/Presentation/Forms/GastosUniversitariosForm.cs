using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class GastosUniversitariosForm : Form
    {
        public GastosUniversitariosForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Crear un nuevo gasto basado en los campos del formulario
            GastosUniversitarios nuevoGasto = new GastosUniversitarios
            {
                Fecha = dtpFecha.Value,
                Monto = decimal.Parse(txtMonto.Text),
                Descripcion = txtDescripcion.Text
            };

            // Validar el gasto
            GastosUniversitariosValidator validator = new GastosUniversitariosValidator();
            var result = validator.Validate(nuevoGasto);

            if (!result.IsValid)
            {
                // Mostrar mensajes de error si las validaciones fallan
                string errores = string.Join("\n", result.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
