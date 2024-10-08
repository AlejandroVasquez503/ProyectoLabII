using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonLayer
{
    public class Gasto
    {
        public int GastoID { get; set; }
        public int UsuarioID { get; set; }
        public int CategoriaID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
