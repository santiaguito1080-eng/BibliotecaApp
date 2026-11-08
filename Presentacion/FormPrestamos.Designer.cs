namespace BibliotecaApp.Presentacion
{
    partial class FormPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPrestamos = new DataGridView();
            cmbUsuarios = new ComboBox();
            cmbLibros = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaEstimada = new DateTimePicker();
            dtpfechaDevolucion = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnDevolver = new Button();
            btnLimpiar = new Button();
            lblUsuario = new Label();
            lblLibro = new Label();
            lblFechaDePrestamo = new Label();
            lblFechaEstimada = new Label();
            lblFechaDevolucion = new Label();
            lblEstado = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(12, 348);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(1007, 201);
            dgvPrestamos.TabIndex = 0;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(436, 108);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(179, 23);
            cmbUsuarios.TabIndex = 1;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(436, 137);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(179, 23);
            cmbLibros.TabIndex = 2;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(415, 182);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(200, 23);
            dtpFechaPrestamo.TabIndex = 3;
            // 
            // dtpFechaEstimada
            // 
            dtpFechaEstimada.Location = new Point(415, 211);
            dtpFechaEstimada.Name = "dtpFechaEstimada";
            dtpFechaEstimada.Size = new Size(200, 23);
            dtpFechaEstimada.TabIndex = 4;
            // 
            // dtpfechaDevolucion
            // 
            dtpfechaDevolucion.Location = new Point(415, 240);
            dtpfechaDevolucion.Name = "dtpfechaDevolucion";
            dtpfechaDevolucion.Size = new Size(200, 23);
            dtpfechaDevolucion.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(415, 281);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(179, 23);
            cmbEstado.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(685, 306);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(766, 306);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(847, 306);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(928, 306);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(75, 23);
            btnDevolver.TabIndex = 10;
            btnDevolver.Text = "DEVOLVER";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(662, 137);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(347, 108);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 15);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "USUARIO :";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(364, 137);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(45, 15);
            lblLibro.TabIndex = 13;
            lblLibro.Text = "LIBRO :";
            // 
            // lblFechaDePrestamo
            // 
            lblFechaDePrestamo.AutoSize = true;
            lblFechaDePrestamo.Location = new Point(279, 190);
            lblFechaDePrestamo.Name = "lblFechaDePrestamo";
            lblFechaDePrestamo.Size = new Size(130, 15);
            lblFechaDePrestamo.TabIndex = 14;
            lblFechaDePrestamo.Text = "FECHA DE PRESTAMO :";
            // 
            // lblFechaEstimada
            // 
            lblFechaEstimada.AutoSize = true;
            lblFechaEstimada.Location = new Point(223, 217);
            lblFechaEstimada.Name = "lblFechaEstimada";
            lblFechaEstimada.Size = new Size(186, 15);
            lblFechaEstimada.TabIndex = 15;
            lblFechaEstimada.Text = "FECHA ESTIMADA DEVOLUCION :";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Location = new Point(283, 246);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(126, 15);
            lblFechaDevolucion.TabIndex = 16;
            lblFechaDevolucion.Text = "FECHA DEVOLUCION :";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(353, 281);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 15);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "ESTADO :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 341);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1031, 47);
            panel2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(436, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 20;
            label1.Text = "GESTION DE PRESTAMOS";
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblFechaEstimada);
            Controls.Add(lblFechaDePrestamo);
            Controls.Add(lblLibro);
            Controls.Add(lblUsuario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDevolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(dtpfechaDevolucion);
            Controls.Add(dtpFechaEstimada);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbLibros);
            Controls.Add(cmbUsuarios);
            Controls.Add(dgvPrestamos);
            Name = "FormPrestamos";
            Text = "FormPrestamos";
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrestamos;
        private ComboBox cmbUsuarios;
        private ComboBox cmbLibros;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaEstimada;
        private DateTimePicker dtpfechaDevolucion;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnDevolver;
        private Button btnLimpiar;
        private Label lblUsuario;
        private Label lblLibro;
        private Label lblFechaDePrestamo;
        private Label lblFechaEstimada;
        private Label lblFechaDevolucion;
        private Label lblEstado;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}