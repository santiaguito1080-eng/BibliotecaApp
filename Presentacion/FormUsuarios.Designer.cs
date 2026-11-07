namespace BibliotecaApp.Presentacion
{
    partial class FormUsuarios
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
            lblGesUsuarios = new Label();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiarr = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblGesUsuarios
            // 
            lblGesUsuarios.AutoSize = true;
            lblGesUsuarios.Location = new Point(424, 31);
            lblGesUsuarios.Name = "lblGesUsuarios";
            lblGesUsuarios.Size = new Size(130, 15);
            lblGesUsuarios.TabIndex = 0;
            lblGesUsuarios.Text = "GESTION DE USUARIOS";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(70, 78);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(68, 15);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "NOMBRES :";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(144, 75);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(123, 23);
            txtNombres.TabIndex = 2;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(66, 118);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 15);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "APELLIDOS :";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(144, 115);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(123, 23);
            txtApellidos.TabIndex = 4;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(51, 155);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 15);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "DOCUMENTO :";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(144, 155);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(123, 23);
            txtDocumento.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(66, 189);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "TELEFONO :";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(143, 186);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(124, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(79, 224);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(59, 15);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "CORREO :";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(144, 221);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(123, 23);
            txtCorreo.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(576, 78);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(576, 118);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 30);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(696, 118);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 30);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiarr
            // 
            btnLimpiarr.Location = new Point(696, 82);
            btnLimpiarr.Name = "btnLimpiarr";
            btnLimpiarr.Size = new Size(85, 30);
            btnLimpiarr.TabIndex = 15;
            btnLimpiarr.Text = "LIMPIAR";
            btnLimpiarr.UseVisualStyleBackColor = true;
            btnLimpiarr.Click += btnLimpiarr_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToOrderColumns = true;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = SystemColors.Control;
            dgvUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 302);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(960, 150);
            dgvUsuarios.TabIndex = 16;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 511);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnLimpiarr);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombres);
            Controls.Add(lblNombres);
            Controls.Add(lblGesUsuarios);
            Name = "FormUsuarios";
            Text = "GESTION DE USUARIOS ";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGesUsuarios;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiarr;
        private DataGridView dgvUsuarios;
    }
}