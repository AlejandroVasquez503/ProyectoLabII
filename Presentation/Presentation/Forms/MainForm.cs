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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Crear un nuevo usuario basado en los campos del formulario
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text,
                Apellido = txtApellido.Text,
                Carnet = txtCarnet.Text,
                Contraseña = txtContraseña.Text
            };

            // Validar el usuario
            UsuarioValidator validator = new UsuarioValidator();
            var result = validator.Validate(nuevoUsuario);

            if (!result.IsValid)
            {
                // Mostrar mensajes de error si las validaciones fallan
                string errores = string.Join("\n", result.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriaForm categoriaForm = new CategoriaForm();
            categoriaForm.ShowDialog();
        }
    }
}
