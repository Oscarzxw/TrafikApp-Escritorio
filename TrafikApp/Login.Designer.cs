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
            this.salirApp_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correo_textbox = new System.Windows.Forms.TextBox();
            this.inicioSesion_button = new System.Windows.Forms.Button();
            this.contrasena_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salirApp_button
            // 
            this.salirApp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salirApp_button.BackColor = System.Drawing.Color.Transparent;
            this.salirApp_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirApp_button.BackgroundImage")));
            this.salirApp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirApp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirApp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirApp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirApp_button.ForeColor = System.Drawing.Color.Black;
            this.salirApp_button.Location = new System.Drawing.Point(629, 12);
            this.salirApp_button.Name = "salirApp_button";
            this.salirApp_button.Size = new System.Drawing.Size(37, 36);
            this.salirApp_button.TabIndex = 9;
            this.salirApp_button.TabStop = false;
            this.salirApp_button.UseVisualStyleBackColor = false;
            this.salirApp_button.Click += new System.EventHandler(this.salirApp_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 146);
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
            this.label1.Location = new System.Drawing.Point(211, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // correo_textbox
            // 
            this.correo_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_textbox.Location = new System.Drawing.Point(215, 109);
            this.correo_textbox.Name = "correo_textbox";
            this.correo_textbox.Size = new System.Drawing.Size(241, 29);
            this.correo_textbox.TabIndex = 1;
            // 
            // inicioSesion_button
            // 
            this.inicioSesion_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inicioSesion_button.BackColor = System.Drawing.Color.Black;
            this.inicioSesion_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioSesion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioSesion_button.ForeColor = System.Drawing.Color.White;
            this.inicioSesion_button.Location = new System.Drawing.Point(215, 246);
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
            this.contrasena_textbox.Location = new System.Drawing.Point(215, 173);
            this.contrasena_textbox.Name = "contrasena_textbox";
            this.contrasena_textbox.Size = new System.Drawing.Size(241, 29);
            this.contrasena_textbox.TabIndex = 2;
            this.contrasena_textbox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(678, 407);
            this.ControlBox = false;
            this.Controls.Add(this.salirApp_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correo_textbox);
            this.Controls.Add(this.inicioSesion_button);
            this.Controls.Add(this.contrasena_textbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salirApp_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correo_textbox;
        private System.Windows.Forms.Button inicioSesion_button;
        private System.Windows.Forms.TextBox contrasena_textbox;
    }
}

