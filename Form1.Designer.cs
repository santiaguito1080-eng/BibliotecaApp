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
            btnReportes = new Button();
            btnPrestamos = new Button();
            btnUsuarios = new Button();
            panelContenido = new Panel();
            Titulolbl = new Label();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.FromArgb(47, 85, 151);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLibros.ForeColor = SystemColors.ControlLightLight;
            btnLibros.Location = new Point(12, 12);
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
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAutores.ForeColor = SystemColors.ControlLightLight;
            btnAutores.Location = new Point(12, 58);
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
            btnEditoriales.FlatStyle = FlatStyle.Flat;
            btnEditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditoriales.ForeColor = SystemColors.ControlLightLight;
            btnEditoriales.Location = new Point(12, 104);
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
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnPrestamos);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnEditoriales);
            panelMenu.Controls.Add(btnAutores);
            panelMenu.Controls.Add(btnLibros);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(47, 85, 151);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReportes.ForeColor = SystemColors.ControlLightLight;
            btnReportes.Location = new Point(12, 242);
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
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrestamos.ForeColor = SystemColors.ControlLightLight;
            btnPrestamos.Location = new Point(12, 196);
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
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUsuarios.ForeColor = SystemColors.ControlLightLight;
            btnUsuarios.Location = new Point(12, 150);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(180, 40);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.Lavender;
            panelContenido.Controls.Add(Titulolbl);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(200, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(600, 450);
            panelContenido.TabIndex = 1;
            // 
            // Titulolbl
            // 
            Titulolbl.AutoSize = true;
            Titulolbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Titulolbl.Location = new Point(18, 12);
            Titulolbl.Name = "Titulolbl";
            Titulolbl.Size = new Size(352, 30);
            Titulolbl.TabIndex = 0;
            Titulolbl.Text = "Sistema de Gestión de Biblioteca";
            Titulolbl.Click += Titulolbl_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion de Biblioteca";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
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
    }
}
