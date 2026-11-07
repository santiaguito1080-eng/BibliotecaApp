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
    public partial class FormPrestamos : Form
    {
        private int idPrestamoSeleccionado = 0;
        public FormPrestamos()
        {
            InitializeComponent();

            CargarUsuarios();
            CargarLibros();
            ConfigurarEstado();
            CargarPrestamos();

        }

        private void CargarUsuarios()
        {
            cmbUsuarios.DataSource = PrestamoDatos.ListarUsuarios();
            cmbUsuarios.DisplayMember = "NombreCompleto";
            cmbUsuarios.ValueMember = "id_usuarios";
            cmbUsuarios.SelectedIndex = -1;
        }
        private void CargarLibros()
        {
            cmbLibros.DataSource = PrestamoDatos.ListarLibrosDisponibles();
            cmbLibros.DisplayMember = "titulo";
            cmbLibros.ValueMember = "id_libro";
            cmbLibros.SelectedIndex = -1;
        }

        private void ConfigurarEstado()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("DEVUELTO");

            cmbEstado.SelectedIndex = 0;
        }

        private void CargarPrestamos()
        {
            dgvPrestamos.DataSource = PrestamoDatos.ListarPrestamos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex == -1 || cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un usuario y un libro.");
                return;
            }

            if (dtpFechaEstimada.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha estimada no puede ser anterior a la fecha del préstamo.");
                return;
            }

            try
            {
                int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
                int idLibro = Convert.ToInt32(cmbLibros.SelectedValue);

                PrestamoDatos.RegistrarPrestamo(
                    dtpFechaPrestamo.Value,
                    dtpFechaEstimada.Value,
                    idLibro,
                    idUsuario
                );

                MessageBox.Show("Préstamo registrado correctamente.");

                CargarPrestamos();
                CargarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message);
            }
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPrestamos.Rows[e.RowIndex];

                idPrestamoSeleccionado = Convert.ToInt32(fila.Cells["id_prestamo"].Value);

                cmbUsuarios.SelectedValue = Convert.ToInt32(fila.Cells["id_usuarios"].Value);
                cmbLibros.SelectedValue = Convert.ToInt32(fila.Cells["id_libro"].Value);

                dtpFechaPrestamo.Value = Convert.ToDateTime(fila.Cells["FECHA_DE_PRESTAMO"].Value);

                dtpFechaEstimada.Value = Convert.ToDateTime(fila.Cells["FECHA_ESTIMADA_DEVOL"].Value);

                if (fila.Cells["FECHA_DEVOLUCION"].Value != DBNull.Value)
                {
                    dtpfechaDevolucion.Value = Convert.ToDateTime(fila.Cells["FECHA_DEVOLUCION"].Value);
                }

                cmbEstado.SelectedItem = fila.Cells["ESTADO"].Value?.ToString() ?? "";
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un préstamo de la tabla.");
                return;
            }

            if (cmbEstado.SelectedItem?.ToString() == "DEVUELTO")
            {
                MessageBox.Show("Este préstamo ya fue devuelto.");
                return;
            }

            try
            {
                PrestamoDatos.RegistrarDevolucion(
                    idPrestamoSeleccionado,
                    dtpfechaDevolucion.Value
                );

                MessageBox.Show("Devolución registrada correctamente.");

                CargarPrestamos();
                CargarLibros();

                idPrestamoSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la devolución: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un préstamo de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este préstamo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    PrestamoDatos.EliminarPrestamo(idPrestamoSeleccionado);

                    MessageBox.Show("Préstamo eliminado correctamente.");

                    idPrestamoSeleccionado = 0;

                    CargarPrestamos();
                    CargarLibros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el préstamo: " + ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un préstamo de la tabla.");
                return;
            }

            if (cmbEstado.SelectedItem?.ToString() != "ACTIVO")
            {
                MessageBox.Show("Solo puedes editar préstamos activos.");
                return;
            }

            if (dtpFechaEstimada.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha estimada no puede ser anterior a la fecha del préstamo.");
                return;
            }

            try
            {
                PrestamoDatos.ActualizarPrestamo(
                    idPrestamoSeleccionado,
                    dtpFechaEstimada.Value
                );

                MessageBox.Show("Préstamo actualizado correctamente.");

                CargarPrestamos();

                idPrestamoSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el préstamo: " + ex.Message);
            }
        }
    }
}
