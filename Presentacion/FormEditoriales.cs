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
    public partial class FormEditoriales : Form
    {
        private int idEditorialSeleccionada = 0;
        public FormEditoriales()
        {
            InitializeComponent();
            CargarEditoriales();
        }

        private void CargarEditoriales()
        {
            dtvEditoriales.DataSource = EditorialDatos.ListarEditoriales();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la editorial es obligatorio.");
                return;
            }

            try
            {
                EditorialDatos.RegistrarEditorial(
                    txtNombre.Text.Trim(),
                    txtPais.Text.Trim()
                );

                MessageBox.Show("Editorial registrada correctamente.");

                CargarEditoriales();

                txtNombre.Clear();
                txtPais.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la editorial: " + ex.Message);
            }
        }

        private void dtvEditoriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtvEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvEditoriales.Rows[e.RowIndex];

                idEditorialSeleccionada = Convert.ToInt32(fila.Cells["id_editorial"].Value);

                txtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value) ?? "";
                txtPais.Text = Convert.ToString(fila.Cells["pais"].Value) ?? "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idEditorialSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una editorial de la tabla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la editorial es obligatorio.");
                return;
            }

            try
            {
                EditorialDatos.EditarEditorial(
                    idEditorialSeleccionada,
                    txtNombre.Text.Trim(),
                    txtPais.Text.Trim()
                );

                MessageBox.Show("Editorial actualizada correctamente.");

                CargarEditoriales();

                idEditorialSeleccionada = 0;

                txtNombre.Clear();
                txtPais.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la editorial: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEditorialSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una editorial de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar esta editorial?",
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
                EditorialDatos.EliminarEditorial(idEditorialSeleccionada);

                MessageBox.Show("Editorial eliminada correctamente.");

                CargarEditoriales();

                idEditorialSeleccionada = 0;

                txtNombre.Clear();
                txtPais.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la editorial. Puede tener libros asociados.\n" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEditoriales();

            MessageBox.Show("Lista de editoriales actualizada correctamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPais.Clear();

            idEditorialSeleccionada = 0;

            dtvEditoriales.ClearSelection();
        }
    }
}
