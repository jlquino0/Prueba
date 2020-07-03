using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
    }
}