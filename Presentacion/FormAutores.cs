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
    public partial class FormAutores : Form

    {
        private int idAutorSeleccionado = 0;
        public FormAutores()
        {
            InitializeComponent();
            CargarAutores();
        }

        private void CargarAutores()
        {
            dtvAutores.DataSource = AutorDatos.ListarAutores();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El nombre y el apellido son obligatorios.");
                return;
            }

            try
            {
                AutorDatos.RegistrarAutor(
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtNacionalidad.Text.Trim()
                );

                MessageBox.Show("Autor registrado correctamente.");

                CargarAutores();

                txtNombre.Clear();
                txtApellido.Clear();
                txtNacionalidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el autor: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idAutorSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un autor de la tabla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El nombre y el apellido son obligatorios.");
                return;
            }

            try
            {
                AutorDatos.EditarAutor(
                    idAutorSeleccionado,
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtNacionalidad.Text.Trim()
                );

                MessageBox.Show("Autor actualizado correctamente.");

                CargarAutores();

                idAutorSeleccionado = 0;

                txtNombre.Clear();
                txtApellido.Clear();
                txtNacionalidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el autor: " + ex.Message);
            }







        }

        private void dtvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvAutores.Rows[e.RowIndex];

                idAutorSeleccionado = Convert.ToInt32(fila.Cells["id_autor"].Value);

                txtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value) ?? "";
                txtApellido.Text = Convert.ToString(fila.Cells["apellido"].Value) ?? "";
                txtNacionalidad.Text = Convert.ToString(fila.Cells["nacionalidad"].Value) ?? "";
            }
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            if (idAutorSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un autor de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este autor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                AutorDatos.EliminarAutor(idAutorSeleccionado);

                MessageBox.Show("Autor eliminado correctamente.");

                CargarAutores();

                idAutorSeleccionado = 0;

                txtNombre.Clear();
                txtApellido.Clear();
                txtNacionalidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el autor. Puede estar asociado a un libro.\n" + ex.Message);
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarAutores();

            MessageBox.Show("Lista de autores actualizada correctamente.");
        }
    }
}
