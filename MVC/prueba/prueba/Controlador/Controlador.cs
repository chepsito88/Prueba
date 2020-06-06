using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba.Modelo.DAO;
using prueba.Modelo.VO;


namespace prueba.Controlador
{
    class Controlador
    {
        Vista.Frm_usu x;
        DAO_Operaciones opera = new DAO_Operaciones();
        VOUsuario usuarios;

        public void Eventos() {
            x = new Vista.Frm_usu();
            usuarios = new VOUsuario();
            x.btn_agregar.Click += btn_Agregar_Click;
            x.btn_Modificar.Click += btn_Modificar_Click;
            x.btn_Eliminar.Click += btn_Eliminar_Click;
            x.btn_limpiar.Click += btn_Limpiar_Click;
            x.txt_Id.KeyPress += txt_Id_KeyPress;
            x.txt_Nombre.KeyPress += txt_Nombre_KeyPress;
            x.txt_Edad.KeyPress += txt_Edad_KeyPress;
            x.txt_Direccion.KeyPress += txt_Direccion_KeyPress;
            x.Dgv_usuarios.CellClick += Dgv_Usuarios_CellClick;
            x.Dgv_usuarios.RowHeadersVisible = false;
            x.ShowDialog();
        }

        private void Dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            x.txt_Id.ReadOnly = true;
            try
            {
                x.txt_Id.Text = x.Dgv_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                x.txt_Nombre.Text = x.Dgv_usuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                x.txt_Edad.Text = x.Dgv_usuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                x.txt_Direccion.Text = x.Dgv_usuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            opera.NumyLetraEspacio(e, x.txt_Direccion);
            if (e.KeyChar == (char)Keys.Enter)
            {
                x.txt_Direccion.Focus();
            }
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            opera.SoloNum(e, x.txt_Edad);
            if (e.KeyChar == (char)Keys.Enter)
            {
                x.txt_Edad.Focus();
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            opera.SoloLetras(e, x.txt_Nombre);
            if (e.KeyChar == (char)Keys.Enter)
            {
                x.txt_Nombre.Focus();
            }
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            opera.SoloNum(e, x.txt_Id);
            if (e.KeyChar == (char)Keys.Enter)
            {
                x.txt_Id.Focus();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (x.txt_Id.Text != "" && x.txt_Nombre.Text != "" && x.txt_Edad.Text != "" && x.txt_Direccion.Text != "")
            {
                usuarios.Id = x.txt_Id.Text;
                usuarios.Nombre = x.txt_Nombre.Text;
                usuarios.Edad = Convert.ToInt32(x.txt_Edad.Text);
                usuarios.Direccion = x.txt_Direccion.Text;
                opera.Agregar(usuarios);
                x.Dgv_usuarios.DataSource = opera.Consulta();

            }
            else
            {
                MessageBox.Show("Hay datos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (x.btn_Modificar.Text == "Actualizar")
            {

                if (x.txt_Id.Text != "" && x.txt_Nombre.Text != "" && x.txt_Edad.Text != "" && x.txt_Direccion.Text != "")
                {
                    usuarios.Id = x.txt_Id.Text;
                    usuarios.Nombre = x.txt_Nombre.Text;
                    usuarios.Edad = Convert.ToInt32(x.txt_Edad.Text);
                    usuarios.Direccion = x.txt_Direccion.Text;

                    opera.Actualizar(usuarios);
                    x.Dgv_usuarios.DataSource = opera.Consulta();
                    opera.Limpiar(x);

                }
            }
            else
            {
                MessageBox.Show("Hay datos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (x.btn_Eliminar.Text == "Eliminar")
            {
                opera.Cajas(x);
                if (x.txt_Id.Text != "")
                {
                    usuarios.Id = x.txt_Id.Text;
                    usuarios.Nombre = x.txt_Nombre.Text;
                    x.txt_Edad.Text = Convert.ToString(usuarios.Edad);
                    usuarios.Direccion = x.txt_Direccion.Text;

                    opera.Eliminar(usuarios);
                    x.Dgv_usuarios.DataSource = opera.Consulta();
                    opera.Limpiar(x);

                }
            }
            else
            {
                MessageBox.Show("Hay datos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            x.txt_Id.ReadOnly = false;
            x.txt_Id.Clear();
            x.txt_Nombre.Clear();
            x.txt_Edad.Clear();
            x.txt_Direccion.Clear();
        }

      
    }
}
