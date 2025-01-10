namespace TrafikApp
{
    partial class Main
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
            this.button_cerrarSesion = new System.Windows.Forms.Button();
            this.gestionarUsuarios_button = new System.Windows.Forms.Button();
            this.gestionarIncidencias_button = new System.Windows.Forms.Button();
            this.componentes_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_cerrarSesion
            // 
            this.button_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_cerrarSesion.BackColor = System.Drawing.Color.Black;
            this.button_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cerrarSesion.Location = new System.Drawing.Point(468, 21);
            this.button_cerrarSesion.Name = "button_cerrarSesion";
            this.button_cerrarSesion.Size = new System.Drawing.Size(144, 29);
            this.button_cerrarSesion.TabIndex = 10;
            this.button_cerrarSesion.TabStop = false;
            this.button_cerrarSesion.Text = "Cerrar Sesión";
            this.button_cerrarSesion.UseVisualStyleBackColor = false;
            this.button_cerrarSesion.Click += new System.EventHandler(this.button_cerrarSesion_Click);
            // 
            // gestionarUsuarios_button
            // 
            this.gestionarUsuarios_button.Location = new System.Drawing.Point(48, 12);
            this.gestionarUsuarios_button.Name = "gestionarUsuarios_button";
            this.gestionarUsuarios_button.Size = new System.Drawing.Size(382, 49);
            this.gestionarUsuarios_button.TabIndex = 11;
            this.gestionarUsuarios_button.Text = "Gestionar Usuarios";
            this.gestionarUsuarios_button.UseVisualStyleBackColor = true;
            this.gestionarUsuarios_button.Click += new System.EventHandler(this.gestionarUsuarios_button_Click);
            // 
            // gestionarIncidencias_button
            // 
            this.gestionarIncidencias_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gestionarIncidencias_button.Location = new System.Drawing.Point(648, 12);
            this.gestionarIncidencias_button.Name = "gestionarIncidencias_button";
            this.gestionarIncidencias_button.Size = new System.Drawing.Size(417, 49);
            this.gestionarIncidencias_button.TabIndex = 12;
            this.gestionarIncidencias_button.Text = "Gestionar Incidencias";
            this.gestionarIncidencias_button.UseVisualStyleBackColor = true;
            this.gestionarIncidencias_button.Click += new System.EventHandler(this.gestionarIncidencias_button_Click);
            // 
            // componentes_panel
            // 
            this.componentes_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentes_panel.Location = new System.Drawing.Point(12, 100);
            this.componentes_panel.Name = "componentes_panel";
            this.componentes_panel.Size = new System.Drawing.Size(1078, 430);
            this.componentes_panel.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1102, 542);
            this.ControlBox = false;
            this.Controls.Add(this.componentes_panel);
            this.Controls.Add(this.gestionarIncidencias_button);
            this.Controls.Add(this.gestionarUsuarios_button);
            this.Controls.Add(this.button_cerrarSesion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cerrarSesion;
        private System.Windows.Forms.Button gestionarUsuarios_button;
        private System.Windows.Forms.Button gestionarIncidencias_button;
        private System.Windows.Forms.Panel componentes_panel;
    }
}