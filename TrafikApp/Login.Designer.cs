namespace TrafikApp
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.inicioSesion_button = new System.Windows.Forms.Button();
            this.contrasena_textbox = new System.Windows.Forms.TextBox();
            this.mensajeErrorLogin_label = new System.Windows.Forms.Label();
            this.alternarContrasena_button = new System.Windows.Forms.Button();
            this.salirApp_button = new System.Windows.Forms.Button();
            this.imagenLogo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // email_textbox
            // 
            this.email_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.Location = new System.Drawing.Point(139, 104);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(241, 29);
            this.email_textbox.TabIndex = 1;
            // 
            // inicioSesion_button
            // 
            this.inicioSesion_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inicioSesion_button.BackColor = System.Drawing.Color.Black;
            this.inicioSesion_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicioSesion_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioSesion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioSesion_button.ForeColor = System.Drawing.Color.White;
            this.inicioSesion_button.Location = new System.Drawing.Point(139, 241);
            this.inicioSesion_button.Name = "inicioSesion_button";
            this.inicioSesion_button.Size = new System.Drawing.Size(241, 42);
            this.inicioSesion_button.TabIndex = 3;
            this.inicioSesion_button.Text = "Iniciar Sesión";
            this.inicioSesion_button.UseVisualStyleBackColor = false;
            this.inicioSesion_button.Click += new System.EventHandler(this.inicioSesion_button_Click);
            // 
            // contrasena_textbox
            // 
            this.contrasena_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contrasena_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena_textbox.Location = new System.Drawing.Point(139, 168);
            this.contrasena_textbox.Name = "contrasena_textbox";
            this.contrasena_textbox.Size = new System.Drawing.Size(241, 29);
            this.contrasena_textbox.TabIndex = 2;
            this.contrasena_textbox.UseSystemPasswordChar = true;
            // 
            // mensajeErrorLogin_label
            // 
            this.mensajeErrorLogin_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mensajeErrorLogin_label.AutoSize = true;
            this.mensajeErrorLogin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeErrorLogin_label.Location = new System.Drawing.Point(44, 286);
            this.mensajeErrorLogin_label.Name = "mensajeErrorLogin_label";
            this.mensajeErrorLogin_label.Size = new System.Drawing.Size(0, 16);
            this.mensajeErrorLogin_label.TabIndex = 12;
            // 
            // alternarContrasena_button
            // 
            this.alternarContrasena_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alternarContrasena_button.BackColor = System.Drawing.Color.Transparent;
            this.alternarContrasena_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alternarContrasena_button.BackgroundImage")));
            this.alternarContrasena_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alternarContrasena_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alternarContrasena_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alternarContrasena_button.Location = new System.Drawing.Point(395, 163);
            this.alternarContrasena_button.Name = "alternarContrasena_button";
            this.alternarContrasena_button.Size = new System.Drawing.Size(36, 35);
            this.alternarContrasena_button.TabIndex = 13;
            this.alternarContrasena_button.UseVisualStyleBackColor = false;
            this.alternarContrasena_button.Click += new System.EventHandler(this.alternarContrasena_button_Click);
            // 
            // salirApp_button
            // 
            this.salirApp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salirApp_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirApp_button.BackgroundImage")));
            this.salirApp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirApp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirApp_button.Location = new System.Drawing.Point(460, 12);
            this.salirApp_button.Name = "salirApp_button";
            this.salirApp_button.Size = new System.Drawing.Size(37, 35);
            this.salirApp_button.TabIndex = 16;
            this.salirApp_button.UseVisualStyleBackColor = true;
            this.salirApp_button.Click += new System.EventHandler(this.salirApp_button_Click);
            // 
            // imagenLogo_pictureBox
            // 
            this.imagenLogo_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogo_pictureBox.BackgroundImage")));
            this.imagenLogo_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenLogo_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.imagenLogo_pictureBox.Name = "imagenLogo_pictureBox";
            this.imagenLogo_pictureBox.Size = new System.Drawing.Size(74, 68);
            this.imagenLogo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenLogo_pictureBox.TabIndex = 19;
            this.imagenLogo_pictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 351);
            this.ControlBox = false;
            this.Controls.Add(this.imagenLogo_pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contrasena_textbox);
            this.Controls.Add(this.salirApp_button);
            this.Controls.Add(this.alternarContrasena_button);
            this.Controls.Add(this.inicioSesion_button);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.mensajeErrorLogin_label);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Button inicioSesion_button;
        private System.Windows.Forms.TextBox contrasena_textbox;
        private System.Windows.Forms.Label mensajeErrorLogin_label;
        private System.Windows.Forms.Button alternarContrasena_button;
        private System.Windows.Forms.Button salirApp_button;
        private System.Windows.Forms.PictureBox imagenLogo_pictureBox;
    }
}

