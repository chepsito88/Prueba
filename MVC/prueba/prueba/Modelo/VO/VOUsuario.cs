using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prueba.Modelo.VO
{
    class VOUsuario
    {
        private string _Id;
        private string _Nombre;
        private int _Edad;
        private string _Direccion;

        public string Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
    }
}
