using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Invenario
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public int Existencia { get; set; }
    }
}