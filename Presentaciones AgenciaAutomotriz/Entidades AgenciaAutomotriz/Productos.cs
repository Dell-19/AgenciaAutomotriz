﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_AgenciaAutomotriz
{
    public class Productos
    {
        public Productos(int idProducto, string codigoBarras, string nombre, string descripcion, string marca)
        {
            IdProducto = idProducto;
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public int IdProducto { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
