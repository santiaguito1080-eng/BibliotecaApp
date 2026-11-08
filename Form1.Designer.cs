namespace BibliotecaApp
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLibros = new Button();
            btnAutores = new Button();
            btnEditoriales = new Button();
            panelMenu = new Panel();
            lblSantiago = new Label();
            btnReportes = new Button();
            btnPrestamos = new Button();
            btnUsuarios = new Button();
            panelContenido = new Panel();
            panel1 = new Panel();
            Titulolbl = new Label();
            lblBienvenida = new Label();
            lblDescripcion = new Label();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.FromArgb(47, 85, 151);
            btnLibros.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLibros.ForeColor = SystemColors.ControlLightLight;
            btnLibros.Location = new Point(222, 143);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(180, 40);
            btnLibros.TabIndex = 1;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnAutores
            // 
            btnAutores.BackColor = Color.FromArgb(47, 85, 151);
            btnAutores.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAutores.ForeColor = SystemColors.ControlLightLight;
            btnAutores.Location = new Point(222, 189);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(180, 40);
            btnAutores.TabIndex = 1;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.BackColor = Color.FromArgb(47, 85, 151);
            btnEditoriales.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnEditoriales.FlatStyle = FlatStyle.Flat;
            btnEditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditoriales.ForeColor = SystemColors.ControlLightLight;
            btnEditoriales.Location = new Point(222, 235);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(180, 40);
            btnEditoriales.TabIndex = 1;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(lblSantiago);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(512, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(90, 450);
            panelMenu.TabIndex = 0;
            // 
            // lblSantiago
            // 
            lblSantiago.AutoSize = true;
            lblSantiago.ForeColor = SystemColors.AppWorkspace;
            lblSantiago.Location = new Point(6, 425);
            lblSantiago.Name = "lblSantiago";
            lblSantiago.Size = new Size(83, 15);
            lblSantiago.TabIndex = 0;
            lblSantiago.Text = "By Johan Peña";
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(47, 85, 151);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReportes.ForeColor = SystemColors.ControlLightLight;
            btnReportes.Location = new Point(222, 373);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(180, 40);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.FromArgb(47, 85, 151);
            btnPrestamos.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrestamos.ForeColor = SystemColors.ControlLightLight;
            btnPrestamos.Location = new Point(222, 327);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(180, 40);
            btnPrestamos.TabIndex = 1;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(47, 85, 151);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUsuarios.ForeColor = SystemColors.ControlLightLight;
            btnUsuarios.Location = new Point(222, 281);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(180, 40);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.WhiteSmoke;
            panelContenido.Controls.Add(lblDescripcion);
            panelContenido.Controls.Add(lblBienvenida);
            panelContenido.Controls.Add(btnReportes);
            panelContenido.Controls.Add(panel1);
            panelContenido.Controls.Add(btnPrestamos);
            panelContenido.Controls.Add(Titulolbl);
            panelContenido.Controls.Add(btnUsuarios);
            panelContenido.Controls.Add(btnLibros);
            panelContenido.Controls.Add(btnEditoriales);
            panelContenido.Controls.Add(btnAutores);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(512, 450);
            panelContenido.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 450);
            panel1.TabIndex = 1;
            // 
            // Titulolbl
            // 
            Titulolbl.AutoSize = true;
            Titulolbl.BackColor = Color.WhiteSmoke;
            Titulolbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Titulolbl.ForeColor = Color.MidnightBlue;
            Titulolbl.Location = new Point(111, 9);
            Titulolbl.Name = "Titulolbl";
            Titulolbl.Size = new Size(395, 32);
            Titulolbl.TabIndex = 0;
            Titulolbl.Text = "Sistema de Gestión de Biblioteca";
            Titulolbl.TextAlign = ContentAlignment.MiddleCenter;
            Titulolbl.Click += Titulolbl_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(200, 90);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(229, 17);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Para empezar da click en una casilla";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(165, 56);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(288, 21);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Bienvenido, administra tu biblioteca";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion de Biblioteca";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLibros;
        private Button btnAutores;
        private Button btnEditoriales;
        private Panel panelMenu;
        private Button btnUsuarios;
        private Button btnReportes;
        private Button btnPrestamos;
        private Panel panelContenido;
        private Label Titulolbl;
        private Panel panel1;
        private Label lblSantiago;
        private Label lblBienvenida;
        private Label lblDescripcion;
    }
}
