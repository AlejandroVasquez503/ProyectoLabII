using commonLayer.Models;
using dataLayer;
using System.Collections.Generic;

namespace businessLayer
{
    public class CategoriaBLL
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();

        public List<Categoria> ObtenerCategorias()
        {
            return categoriaDAL.ObtenerCategorias();
        }

        public void AgregarCategoria(Categoria nuevaCategoria)
        {
            if (string.IsNullOrEmpty(nuevaCategoria.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            categoriaDAL.InsertarCategoria(nuevaCategoria);
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            if (categoria.CategoriaID <= 0)
            {
                throw new ArgumentException("El ID de la categoría no es válido.");
            }

            categoriaDAL.ActualizarCategoria(categoria);
        }

        public void EliminarCategoria(int categoriaID)
        {
            if (categoriaID <= 0)
            {
                throw new ArgumentException("El ID de la categoría no es válido.");
            }

            categoriaDAL.EliminarCategoria(categoriaID);
        }
    }
}
