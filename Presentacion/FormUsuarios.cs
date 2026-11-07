using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Presentacion
{
    public partial class FormUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;
        public FormUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            idUsuarioSeleccionado = 0;
            dgvUsuarios.ClearSelection();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = UsuarioDatos.ListarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "" ||
        txtDocumento.Text == "")
            {
                MessageBox.Show("Nombres, apellidos y documento son obligatorios.");
                return;
            }

            try
            {
                UsuarioDatos.RegistrarUsuario(
                    txtNombres.Text,
                    txtApellidos.Text,
                    txtDocumento.Text,
                    txtTelefono.Text,
                    txtCorreo.Text
                );

                MessageBox.Show("Usuario registrado correctamente.");

                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla.");
                return;
            }

            if (txtNombres.Text == "" || txtApellidos.Text == "" ||
                txtDocumento.Text == "")
            {
                MessageBox.Show("Nombres, apellidos y documento son obligatorios.");
                return;
            }

            try
            {
                UsuarioDatos.EditarUsuario(
                    idUsuarioSeleccionado,
                    txtNombres.Text,
                    txtApellidos.Text,
                    txtDocumento.Text,
                    txtTelefono.Text,
                    txtCorreo.Text
                );

                MessageBox.Show("Usuario actualizado correctamente.");

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["id_usuarios"].Value);

                txtNombres.Text = fila.Cells["NOMBRES"].Value?.ToString() ?? "";
                txtApellidos.Text = fila.Cells["APELLIDOS"].Value?.ToString() ?? "";
                txtDocumento.Text = fila.Cells["DOCUMENTO"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["TELEFONO"].Value?.ToString() ?? "";
                txtCorreo.Text = fila.Cells["CORREO"].Value?.ToString() ?? "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    UsuarioDatos.EliminarUsuario(idUsuarioSeleccionado);

                    MessageBox.Show("Usuario eliminado correctamente.");

                    CargarUsuarios();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                }
            }
        }

        private void btnLimpiarr_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
