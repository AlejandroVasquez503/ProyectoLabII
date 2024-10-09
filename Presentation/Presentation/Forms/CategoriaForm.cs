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
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GastosUniversitariosForm gastosUniversitariosForm = new GastosUniversitariosForm();
            gastosUniversitariosForm.ShowDialog();
        }
    }
}
