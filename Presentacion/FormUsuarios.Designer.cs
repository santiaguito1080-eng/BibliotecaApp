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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblGesUsuarios
            // 
            lblGesUsuarios.AutoSize = true;
            lblGesUsuarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGesUsuarios.ForeColor = Color.White;
            lblGesUsuarios.Location = new Point(272, 9);
            lblGesUsuarios.Name = "lblGesUsuarios";
            lblGesUsuarios.Size = new Size(279, 32);
            lblGesUsuarios.TabIndex = 0;
            lblGesUsuarios.Text = "GESTION DE USUARIOS";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(138, 78);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(78, 17);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "NOMBRES :";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(224, 77);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(123, 23);
            txtNombres.TabIndex = 2;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(131, 112);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(85, 17);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "APELLIDOS :";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(224, 106);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(123, 23);
            txtApellidos.TabIndex = 4;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(118, 141);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(100, 17);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "DOCUMENTO :";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(223, 135);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(123, 23);
            txtDocumento.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(134, 164);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(82, 17);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "TELEFONO :";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(222, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(124, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(151, 199);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(67, 17);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "CORREO :";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(224, 193);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(123, 23);
            txtCorreo.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.YellowGreen;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(409, 266);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkOrange;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(500, 266);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 30);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Salmon;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(591, 266);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 30);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiarr
            // 
            btnLimpiarr.Location = new Point(409, 130);
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 296);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(lblGesUsuarios);
            panel2.Location = new Point(110, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(872, 54);
            panel2.TabIndex = 18;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            Name = "FormUsuarios";
            Text = "GESTION DE USUARIOS ";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
    }
}