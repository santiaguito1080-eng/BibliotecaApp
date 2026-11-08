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
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(12, 348);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(1007, 172);
            dgvPrestamos.TabIndex = 0;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(250, 42);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(179, 23);
            cmbUsuarios.TabIndex = 1;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(250, 89);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(179, 23);
            cmbLibros.TabIndex = 2;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(250, 131);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(200, 23);
            dtpFechaPrestamo.TabIndex = 3;
            // 
            // dtpFechaEstimada
            // 
            dtpFechaEstimada.Location = new Point(250, 169);
            dtpFechaEstimada.Name = "dtpFechaEstimada";
            dtpFechaEstimada.Size = new Size(200, 23);
            dtpFechaEstimada.TabIndex = 4;
            // 
            // dtpfechaDevolucion
            // 
            dtpfechaDevolucion.Location = new Point(250, 211);
            dtpfechaDevolucion.Name = "dtpfechaDevolucion";
            dtpfechaDevolucion.Size = new Size(200, 23);
            dtpfechaDevolucion.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(250, 257);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(179, 23);
            cmbEstado.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 526);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(132, 526);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(231, 526);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(334, 526);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(75, 23);
            btnDevolver.TabIndex = 10;
            btnDevolver.Text = "DEVOLVER";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(451, 526);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(169, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 15);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "USUARIO :";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(186, 92);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(45, 15);
            lblLibro.TabIndex = 13;
            lblLibro.Text = "LIBRO :";
            // 
            // lblFechaDePrestamo
            // 
            lblFechaDePrestamo.AutoSize = true;
            lblFechaDePrestamo.Location = new Point(101, 137);
            lblFechaDePrestamo.Name = "lblFechaDePrestamo";
            lblFechaDePrestamo.Size = new Size(130, 15);
            lblFechaDePrestamo.TabIndex = 14;
            lblFechaDePrestamo.Text = "FECHA DE PRESTAMO :";
            // 
            // lblFechaEstimada
            // 
            lblFechaEstimada.AutoSize = true;
            lblFechaEstimada.Location = new Point(45, 175);
            lblFechaEstimada.Name = "lblFechaEstimada";
            lblFechaEstimada.Size = new Size(186, 15);
            lblFechaEstimada.TabIndex = 15;
            lblFechaEstimada.Text = "FECHA ESTIMADA DEVOLUCION :";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Location = new Point(105, 217);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(126, 15);
            lblFechaDevolucion.TabIndex = 16;
            lblFechaDevolucion.Text = "FECHA DEVOLUCION :";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(175, 265);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 15);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "ESTADO :";
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 561);
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
    }
}