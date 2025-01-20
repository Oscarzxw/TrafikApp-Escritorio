namespace TrafikApp.Componentes
{
    partial class ComponenteGestionarUsuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponenteGestionarUsuarios));
            this.datosUsuarios_dataGrid = new System.Windows.Forms.DataGridView();
            this.nombreUsuario_textbox = new System.Windows.Forms.TextBox();
            this.apellidoUsuario_textbox = new System.Windows.Forms.TextBox();
            this.emailUsuario_textbox = new System.Windows.Forms.TextBox();
            this.contrasenaUsuario_textbox = new System.Windows.Forms.TextBox();
            this.rol_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anadirUsuario_button = new System.Windows.Forms.Button();
            this.eliminarUsuario_button = new System.Windows.Forms.Button();
            this.modificarUsuario_button = new System.Windows.Forms.Button();
            this.alternarContrasena_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarios_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datosUsuarios_dataGrid
            // 
            this.datosUsuarios_dataGrid.AllowUserToAddRows = false;
            this.datosUsuarios_dataGrid.AllowUserToDeleteRows = false;
            this.datosUsuarios_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosUsuarios_dataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.datosUsuarios_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosUsuarios_dataGrid.Location = new System.Drawing.Point(15, 36);
            this.datosUsuarios_dataGrid.Name = "datosUsuarios_dataGrid";
            this.datosUsuarios_dataGrid.ReadOnly = true;
            this.datosUsuarios_dataGrid.Size = new System.Drawing.Size(522, 611);
            this.datosUsuarios_dataGrid.TabIndex = 21;
            this.datosUsuarios_dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosUsuarios_dataGrid_CellClick);
            // 
            // nombreUsuario_textbox
            // 
            this.nombreUsuario_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreUsuario_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario_textbox.Location = new System.Drawing.Point(634, 52);
            this.nombreUsuario_textbox.Name = "nombreUsuario_textbox";
            this.nombreUsuario_textbox.Size = new System.Drawing.Size(278, 29);
            this.nombreUsuario_textbox.TabIndex = 22;
            // 
            // apellidoUsuario_textbox
            // 
            this.apellidoUsuario_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apellidoUsuario_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoUsuario_textbox.Location = new System.Drawing.Point(634, 120);
            this.apellidoUsuario_textbox.Name = "apellidoUsuario_textbox";
            this.apellidoUsuario_textbox.Size = new System.Drawing.Size(278, 29);
            this.apellidoUsuario_textbox.TabIndex = 23;
            // 
            // emailUsuario_textbox
            // 
            this.emailUsuario_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailUsuario_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUsuario_textbox.Location = new System.Drawing.Point(634, 194);
            this.emailUsuario_textbox.Name = "emailUsuario_textbox";
            this.emailUsuario_textbox.Size = new System.Drawing.Size(278, 29);
            this.emailUsuario_textbox.TabIndex = 24;
            // 
            // contrasenaUsuario_textbox
            // 
            this.contrasenaUsuario_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contrasenaUsuario_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaUsuario_textbox.Location = new System.Drawing.Point(634, 263);
            this.contrasenaUsuario_textbox.Name = "contrasenaUsuario_textbox";
            this.contrasenaUsuario_textbox.Size = new System.Drawing.Size(278, 29);
            this.contrasenaUsuario_textbox.TabIndex = 25;
            this.contrasenaUsuario_textbox.UseSystemPasswordChar = true;
            // 
            // rol_comboBox
            // 
            this.rol_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rol_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol_comboBox.FormattingEnabled = true;
            this.rol_comboBox.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.rol_comboBox.Location = new System.Drawing.Point(634, 338);
            this.rol_comboBox.Name = "rol_comboBox";
            this.rol_comboBox.Size = new System.Drawing.Size(278, 32);
            this.rol_comboBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Rol";
            // 
            // anadirUsuario_button
            // 
            this.anadirUsuario_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.anadirUsuario_button.BackColor = System.Drawing.Color.Black;
            this.anadirUsuario_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anadirUsuario_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirUsuario_button.ForeColor = System.Drawing.Color.White;
            this.anadirUsuario_button.Location = new System.Drawing.Point(606, 474);
            this.anadirUsuario_button.Name = "anadirUsuario_button";
            this.anadirUsuario_button.Size = new System.Drawing.Size(326, 44);
            this.anadirUsuario_button.TabIndex = 32;
            this.anadirUsuario_button.Text = "Añadir";
            this.anadirUsuario_button.UseVisualStyleBackColor = false;
            this.anadirUsuario_button.Click += new System.EventHandler(this.anadirUsuario_button_Click);
            // 
            // eliminarUsuario_button
            // 
            this.eliminarUsuario_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarUsuario_button.BackColor = System.Drawing.Color.Red;
            this.eliminarUsuario_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarUsuario_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarUsuario_button.ForeColor = System.Drawing.Color.White;
            this.eliminarUsuario_button.Location = new System.Drawing.Point(606, 574);
            this.eliminarUsuario_button.Name = "eliminarUsuario_button";
            this.eliminarUsuario_button.Size = new System.Drawing.Size(326, 44);
            this.eliminarUsuario_button.TabIndex = 33;
            this.eliminarUsuario_button.Text = "Eliminar";
            this.eliminarUsuario_button.UseVisualStyleBackColor = false;
            this.eliminarUsuario_button.Click += new System.EventHandler(this.eliminarUsuario_button_Click);
            // 
            // modificarUsuario_button
            // 
            this.modificarUsuario_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modificarUsuario_button.BackColor = System.Drawing.Color.DimGray;
            this.modificarUsuario_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarUsuario_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuario_button.ForeColor = System.Drawing.Color.White;
            this.modificarUsuario_button.Location = new System.Drawing.Point(606, 524);
            this.modificarUsuario_button.Name = "modificarUsuario_button";
            this.modificarUsuario_button.Size = new System.Drawing.Size(326, 44);
            this.modificarUsuario_button.TabIndex = 34;
            this.modificarUsuario_button.Text = "Modificar";
            this.modificarUsuario_button.UseVisualStyleBackColor = false;
            this.modificarUsuario_button.Click += new System.EventHandler(this.modificarUsuario_button_Click);
            // 
            // alternarContrasena_button
            // 
            this.alternarContrasena_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alternarContrasena_button.BackColor = System.Drawing.Color.Transparent;
            this.alternarContrasena_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alternarContrasena_button.BackgroundImage")));
            this.alternarContrasena_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alternarContrasena_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alternarContrasena_button.Location = new System.Drawing.Point(924, 259);
            this.alternarContrasena_button.Name = "alternarContrasena_button";
            this.alternarContrasena_button.Size = new System.Drawing.Size(36, 35);
            this.alternarContrasena_button.TabIndex = 35;
            this.alternarContrasena_button.UseVisualStyleBackColor = false;
            this.alternarContrasena_button.Click += new System.EventHandler(this.alternarContrasena_button_Click);
            // 
            // ComponenteGestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.alternarContrasena_button);
            this.Controls.Add(this.modificarUsuario_button);
            this.Controls.Add(this.eliminarUsuario_button);
            this.Controls.Add(this.anadirUsuario_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rol_comboBox);
            this.Controls.Add(this.contrasenaUsuario_textbox);
            this.Controls.Add(this.emailUsuario_textbox);
            this.Controls.Add(this.apellidoUsuario_textbox);
            this.Controls.Add(this.nombreUsuario_textbox);
            this.Controls.Add(this.datosUsuarios_dataGrid);
            this.Name = "ComponenteGestionarUsuarios";
            this.Size = new System.Drawing.Size(984, 650);
            this.Load += new System.EventHandler(this.ComponenteGestionarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarios_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datosUsuarios_dataGrid;
        private System.Windows.Forms.TextBox nombreUsuario_textbox;
        private System.Windows.Forms.TextBox apellidoUsuario_textbox;
        private System.Windows.Forms.TextBox emailUsuario_textbox;
        private System.Windows.Forms.TextBox contrasenaUsuario_textbox;
        private System.Windows.Forms.ComboBox rol_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button anadirUsuario_button;
        private System.Windows.Forms.Button eliminarUsuario_button;
        private System.Windows.Forms.Button modificarUsuario_button;
        private System.Windows.Forms.Button alternarContrasena_button;
    }
}
