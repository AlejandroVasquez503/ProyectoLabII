using commonLayer.Models;
using dataLayer;
using System;
using System.Collections.Generic;

namespace businessLayer
{
    public class GastoBLL
    {
        private GastoDAL gastoDAL = new GastoDAL();

        public void AgregarGasto(Gasto nuevoGasto)
        {
            // Lógica de negocio: Validar el monto y la fecha
            if (nuevoGasto.Monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor a cero.");
            }

            if (nuevoGasto.Fecha > DateTime.Now)
            {
                throw new ArgumentException("La fecha no puede ser en el futuro.");
            }

            gastoDAL.InsertarGasto(nuevoGasto);
        }

        public List<Gasto> ObtenerGastosPorUsuario(int usuarioID)
        {
            return gastoDAL.ObtenerGastosPorUsuario(usuarioID);
        }

        public void ActualizarGasto(Gasto gasto)
        {
            if (gasto.GastoID <= 0)
            {
                throw new ArgumentException("El ID del gasto no es válido.");
            }

            gastoDAL.ActualizarGasto(gasto);
        }

        public void EliminarGasto(int gastoID)
        {
            if (gastoID <= 0)
            {
                throw new ArgumentException("El ID del gasto no es válido.");
            }

            gastoDAL.EliminarGasto(gastoID);
        }
    }
}
