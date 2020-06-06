using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace prueba.Modelo
{
    class ClsConexion
    {
        public MySqlConnection _conexion;
        private string _Servidor;
        private string _Bd;
        private string _User;
        private string _Pass;
        private string _Cadena;


        public string Servidor { get => _Servidor; set => _Servidor = value; }
        public string Bd { get => _Bd; set => _Bd = value; }
        public string User { get => _User; set => _User = value; }
        public string Pass { get => _Pass; set => _Pass = value; }
        public string Cadena { get => _Cadena; set => _Cadena = value; }

        public void conexion() {
            try
            {
                _Cadena = "Server=localhost; Database=bd_clinica;Uid=root;Pwd=chepsito;";
                _conexion= new MySqlConnection(_Cadena);
                _conexion.Open();

            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Error en la conexion de la Base de Datos");
            }
        }
    }
}
