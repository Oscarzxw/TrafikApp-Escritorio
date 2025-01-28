namespace TrafikApp
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.imagenPerfil_button = new System.Windows.Forms.PictureBox();
            this.flechaAtras_button = new System.Windows.Forms.Button();
            this.nombreApellido_Label = new System.Windows.Forms.Label();
            this.correo_Label = new System.Windows.Forms.Label();
            this.rol_label = new System.Windows.Forms.Label();
            this.cerrarSesion_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPerfil_button)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPerfil_button
            // 
            this.imagenPerfil_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imagenPerfil_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenPerfil_button.BackgroundImage")));
            this.imagenPerfil_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPerfil_button.Location = new System.Drawing.Point(60, 85);
            this.imagenPerfil_button.Name = "imagenPerfil_button";
            this.imagenPerfil_button.Size = new System.Drawing.Size(401, 370);
            this.imagenPerfil_button.TabIndex = 0;
            this.imagenPerfil_button.TabStop = false;
            // 
            // flechaAtras_button
            // 
            this.flechaAtras_button.BackColor = System.Drawing.Color.Transparent;
            this.flechaAtras_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flechaAtras_button.BackgroundImage")));
            this.flechaAtras_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flechaAtras_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flechaAtras_button.Location = new System.Drawing.Point(12, 12);
            this.flechaAtras_button.Name = "flechaAtras_button";
            this.flechaAtras_button.Size = new System.Drawing.Size(51, 36);
            this.flechaAtras_button.TabIndex = 1;
            this.flechaAtras_button.UseVisualStyleBackColor = false;
            this.flechaAtras_button.Click += new System.EventHandler(this.flechaAtras_button_Click);
            // 
            // nombreApellido_Label
            // 
            this.nombreApellido_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreApellido_Label.AutoSize = true;
            this.nombreApellido_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreApellido_Label.Location = new System.Drawing.Point(493, 113);
            this.nombreApellido_Label.Name = "nombreApellido_Label";
            this.nombreApellido_Label.Size = new System.Drawing.Size(25, 25);
            this.nombreApellido_Label.TabIndex = 2;
            this.nombreApellido_Label.Text = "n";
            // 
            // correo_Label
            // 
            this.correo_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correo_Label.AutoSize = true;
            this.correo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_Label.Location = new System.Drawing.Point(493, 253);
            this.correo_Label.Name = "correo_Label";
            this.correo_Label.Size = new System.Drawing.Size(24, 25);
            this.correo_Label.TabIndex = 3;
            this.correo_Label.Text = "e";
            // 
            // rol_label
            // 
            this.rol_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rol_label.AutoSize = true;
            this.rol_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol_label.Location = new System.Drawing.Point(493, 408);
            this.rol_label.Name = "rol_label";
            this.rol_label.Size = new System.Drawing.Size(19, 25);
            this.rol_label.TabIndex = 4;
            this.rol_label.Text = "r";
            // 
            // cerrarSesion_button
            // 
            this.cerrarSesion_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarSesion_button.BackColor = System.Drawing.Color.Black;
            this.cerrarSesion_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_button.ForeColor = System.Drawing.Color.White;
            this.cerrarSesion_button.Location = new System.Drawing.Point(762, 477);
            this.cerrarSesion_button.Name = "cerrarSesion_button";
            this.cerrarSesion_button.Size = new System.Drawing.Size(205, 49);
            this.cerrarSesion_button.TabIndex = 5;
            this.cerrarSesion_button.Text = "Cerrar Sesión";
            this.cerrarSesion_button.UseVisualStyleBackColor = false;
            this.cerrarSesion_button.Click += new System.EventHandler(this.cerrarSesion_button_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 538);
            this.Controls.Add(this.cerrarSesion_button);
            this.Controls.Add(this.rol_label);
            this.Controls.Add(this.correo_Label);
            this.Controls.Add(this.nombreApellido_Label);
            this.Controls.Add(this.flechaAtras_button);
            this.Controls.Add(this.imagenPerfil_button);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPerfil_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPerfil_button;
        private System.Windows.Forms.Button flechaAtras_button;
        private System.Windows.Forms.Label nombreApellido_Label;
        private System.Windows.Forms.Label correo_Label;
        private System.Windows.Forms.Label rol_label;
        private System.Windows.Forms.Button cerrarSesion_button;
    }
}