using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba.Modelo.VO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace prueba.Modelo.DAO
{
    class DAO_Operaciones:ClsConexion
    {
        MySqlCommand _Agregar;
        MySqlCommand _Modificar;
        MySqlCommand _Eliminar;
        DataTable _Tabla = new DataTable();
        MySqlDataAdapter _Consultar;

        public DataTable Consulta()
        {
            conexion();
            _Tabla = new DataTable();
            string cadenaconsulta = "SELECT IdUsuario AS Matricula, Nombre AS Nombre, Edad As Edad, Direccion AS Direccion FROM usuario";
            _Consultar = new MySqlDataAdapter(cadenaconsulta, _conexion);
            _Consultar.Fill(_Tabla);
            return _Tabla;
        }
        ///Metodo para Agregar
        public void Agregar(VOUsuario Vo)
        {
            conexion();
            try
            {
                string Cadenausuario = "INSERT INTO usuario (IdUsuario, Nombre, Edad, Direccion) VALUES ('" + Vo.Id + "', '" + Vo.Nombre + "'," + Vo.Edad + ",'" + Vo.Direccion + "') ";
                _Agregar = new MySqlCommand(Cadenausuario, _conexion);
                _Agregar.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Datos guardados", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar los datos..." + e.Message, "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        //////////////////////////Metodo para Eliminar
        public void Eliminar(VOUsuario Vo)
        {
            conexion();
            try
            {
                //se coloca la sentencia que va en sql para realizar dicha operación 
                string cadenaempleado = "DELETE from usuario Where IdUsuario ='" + Vo.Id + "'";
                _Eliminar = new MySqlCommand(cadenaempleado, _conexion);
                _Eliminar.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Datos eliminados", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "Error al eliminar los datos...", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        ////////////////////Metodo para Modificar
        public void Actualizar(VOUsuario Vo)
        {
            try
            {
                conexion();
                string cadenausuaeio = "UPDATE usuario SET Nombre='" + Vo.Nombre + "', Edad=" + Vo.Edad + ", Direccion='" + Vo.Direccion + "' WHERE IdUsuario='" + Vo.Id + "'";
                _Modificar = new MySqlCommand(cadenausuaeio, _conexion);
                _Modificar.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Datos actualizados...", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar los datos...", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        //////////////////////////////////
        ///////////VALIDACIONES
        public bool resp1;
        public ErrorProvider errores = new ErrorProvider();

        ///VALIDACION DE NUMEROS
        public void SoloNum(KeyPressEventArgs E, TextBox caja)
        {

            if (char.IsNumber(E.KeyChar))
            {
                errores.Clear();
                E.Handled = false;
            }
            else
            {
                if (char.IsControl(E.KeyChar))
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    if (char.IsWhiteSpace(E.KeyChar))
                    {
                        E.Handled = true;
                        errores.SetError(caja, "No se aceptan espacios en blanco");
                    }
                    else
                    {
                        E.Handled = true;
                        errores.SetError(caja, "Se aceptan solo números");
                    }
                }

            }
        }
        ////////////////////////VALIDACION DE NUMEROS, LETRAS Y ESPACIOS.
        public void NumyLetraEspacio(KeyPressEventArgs E, TextBox caja)
        {
            if (char.IsNumber(E.KeyChar))
            {
                errores.Clear();
                E.Handled = false;
            }
            else
            {
                if (char.IsControl(E.KeyChar))
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    E.Handled = false;
                    errores.Clear();
                }
            }
        }
        //////////////VALIDACION DE SOLO LETRAS
        internal void SoloLetras(KeyPressEventArgs E, TextBox caja)
        {
            if (char.IsNumber(E.KeyChar))
            {
                errores.SetError(caja, "No se aceptan números");
                E.Handled = true;
            }
            else
            {
                if (char.IsControl(E.KeyChar))
                {
                    errores.Clear();
                    E.Handled = false;

                }
                else
                {
                    if (char.IsWhiteSpace(E.KeyChar))
                    {
                        E.Handled = false;
                        errores.SetError(caja, string.Empty);
                    }
                    else
                    {
                        E.Handled = false;
                        errores.SetError(caja, string.Empty);
                    }
                }
            }
        }
        //////////VALIDACION DE CAJAS
        public bool Cajas(Form todo)
        {
            resp1 = false;
            foreach (Control controles in todo.Controls)
            {
                if (controles is TextBox)
                {
                    if (controles.Text == string.Empty)
                    {
                        errores.SetError(controles, "Campo obligatorio");
                        resp1 = true;
                    }
                    else
                    {
                        errores.SetError(controles, string.Empty);
                    }
                }
            }
            return resp1;
        }
        /////////VALIDACION DE LIMPIAR FORMULARIOS
        public void Limpiar(Form formulario)
        {
            foreach (Control controles in formulario.Controls)
            {
                if (controles is TextBox)
                {
                    controles.Text = string.Empty;
                }
                else
                {
                    if (controles is ComboBox)
                    {
                        controles.Text = string.Empty;
                    }
                }
            }
        }
    }
}
