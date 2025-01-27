namespace TrafikApp.Componentes
{
    partial class ComponenteGestionarIncidencias
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
            this.causaIncidencia_textbox = new System.Windows.Forms.TextBox();
            this.latitud_textBox = new System.Windows.Forms.TextBox();
            this.datosIncidencias_dataGrid = new System.Windows.Forms.DataGridView();
            this.longitud_textBox = new System.Windows.Forms.TextBox();
            this.anadirIncidencia_button = new System.Windows.Forms.Button();
            this.mapa_webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.eliminarIncidencia_button = new System.Windows.Forms.Button();
            this.tipoIncidencia_comboBox = new System.Windows.Forms.ComboBox();
            this.fechaInicio_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generarInforme_button = new System.Windows.Forms.Button();
            this.modificarIncidencia_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosIncidencias_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapa_webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // causaIncidencia_textbox
            // 
            this.causaIncidencia_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.causaIncidencia_textbox.Location = new System.Drawing.Point(23, 62);
            this.causaIncidencia_textbox.Multiline = true;
            this.causaIncidencia_textbox.Name = "causaIncidencia_textbox";
            this.causaIncidencia_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.causaIncidencia_textbox.Size = new System.Drawing.Size(536, 155);
            this.causaIncidencia_textbox.TabIndex = 23;
            // 
            // latitud_textBox
            // 
            this.latitud_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitud_textBox.Location = new System.Drawing.Point(376, 274);
            this.latitud_textBox.Name = "latitud_textBox";
            this.latitud_textBox.Size = new System.Drawing.Size(183, 29);
            this.latitud_textBox.TabIndex = 22;
            this.latitud_textBox.TextChanged += new System.EventHandler(this.latitud_textBox_TextChanged);
            this.latitud_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.latitud_textBox_KeyPress);
            // 
            // datosIncidencias_dataGrid
            // 
            this.datosIncidencias_dataGrid.AllowUserToAddRows = false;
            this.datosIncidencias_dataGrid.AllowUserToDeleteRows = false;
            this.datosIncidencias_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosIncidencias_dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datosIncidencias_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosIncidencias_dataGrid.Location = new System.Drawing.Point(23, 447);
            this.datosIncidencias_dataGrid.Name = "datosIncidencias_dataGrid";
            this.datosIncidencias_dataGrid.ReadOnly = true;
            this.datosIncidencias_dataGrid.Size = new System.Drawing.Size(1418, 354);
            this.datosIncidencias_dataGrid.TabIndex = 20;
            this.datosIncidencias_dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosIncidencias_dataGrid_CellClick);
            // 
            // longitud_textBox
            // 
            this.longitud_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitud_textBox.Location = new System.Drawing.Point(376, 349);
            this.longitud_textBox.Name = "longitud_textBox";
            this.longitud_textBox.Size = new System.Drawing.Size(183, 29);
            this.longitud_textBox.TabIndex = 24;
            this.longitud_textBox.TextChanged += new System.EventHandler(this.longitud_textBox_TextChanged);
            this.longitud_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.longitud_textBox_KeyPress);
            // 
            // anadirIncidencia_button
            // 
            this.anadirIncidencia_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.anadirIncidencia_button.BackColor = System.Drawing.Color.Black;
            this.anadirIncidencia_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anadirIncidencia_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirIncidencia_button.ForeColor = System.Drawing.Color.White;
            this.anadirIncidencia_button.Location = new System.Drawing.Point(601, 132);
            this.anadirIncidencia_button.Name = "anadirIncidencia_button";
            this.anadirIncidencia_button.Size = new System.Drawing.Size(234, 40);
            this.anadirIncidencia_button.TabIndex = 25;
            this.anadirIncidencia_button.Text = "Añadir";
            this.anadirIncidencia_button.UseVisualStyleBackColor = false;
            this.anadirIncidencia_button.Click += new System.EventHandler(this.anadirIncidencia_button_Click);
            // 
            // mapa_webView2
            // 
            this.mapa_webView2.AllowExternalDrop = true;
            this.mapa_webView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapa_webView2.CreationProperties = null;
            this.mapa_webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.mapa_webView2.Location = new System.Drawing.Point(906, 35);
            this.mapa_webView2.Name = "mapa_webView2";
            this.mapa_webView2.Size = new System.Drawing.Size(535, 392);
            this.mapa_webView2.TabIndex = 26;
            this.mapa_webView2.ZoomFactor = 1D;
            // 
            // eliminarIncidencia_button
            // 
            this.eliminarIncidencia_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eliminarIncidencia_button.BackColor = System.Drawing.Color.Red;
            this.eliminarIncidencia_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarIncidencia_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarIncidencia_button.ForeColor = System.Drawing.Color.White;
            this.eliminarIncidencia_button.Location = new System.Drawing.Point(601, 244);
            this.eliminarIncidencia_button.Name = "eliminarIncidencia_button";
            this.eliminarIncidencia_button.Size = new System.Drawing.Size(234, 39);
            this.eliminarIncidencia_button.TabIndex = 27;
            this.eliminarIncidencia_button.Text = "Eliminar";
            this.eliminarIncidencia_button.UseVisualStyleBackColor = false;
            this.eliminarIncidencia_button.Click += new System.EventHandler(this.eliminarincidencia_button_Click);
            // 
            // tipoIncidencia_comboBox
            // 
            this.tipoIncidencia_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoIncidencia_comboBox.FormattingEnabled = true;
            this.tipoIncidencia_comboBox.Items.AddRange(new object[] {
            "OBRA",
            "EVEN",
            "ACCIDENTE",
            "CALLE CORTADA",
            "OTRO"});
            this.tipoIncidencia_comboBox.Location = new System.Drawing.Point(23, 271);
            this.tipoIncidencia_comboBox.Name = "tipoIncidencia_comboBox";
            this.tipoIncidencia_comboBox.Size = new System.Drawing.Size(331, 32);
            this.tipoIncidencia_comboBox.TabIndex = 28;
            // 
            // fechaInicio_date
            // 
            this.fechaInicio_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio_date.Location = new System.Drawing.Point(23, 349);
            this.fechaInicio_date.Name = "fechaInicio_date";
            this.fechaInicio_date.Size = new System.Drawing.Size(331, 26);
            this.fechaInicio_date.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Causa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Latitud";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Longitud";
            // 
            // generarInforme_button
            // 
            this.generarInforme_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generarInforme_button.BackColor = System.Drawing.Color.SteelBlue;
            this.generarInforme_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarInforme_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarInforme_button.ForeColor = System.Drawing.Color.White;
            this.generarInforme_button.Location = new System.Drawing.Point(601, 323);
            this.generarInforme_button.Name = "generarInforme_button";
            this.generarInforme_button.Size = new System.Drawing.Size(234, 37);
            this.generarInforme_button.TabIndex = 38;
            this.generarInforme_button.Text = "Generar Informe";
            this.generarInforme_button.UseVisualStyleBackColor = false;
            this.generarInforme_button.Click += new System.EventHandler(this.generarInforme_button_Click);
            // 
            // modificarIncidencia_button
            // 
            this.modificarIncidencia_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modificarIncidencia_button.BackColor = System.Drawing.Color.DimGray;
            this.modificarIncidencia_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarIncidencia_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarIncidencia_button.ForeColor = System.Drawing.Color.White;
            this.modificarIncidencia_button.Location = new System.Drawing.Point(601, 188);
            this.modificarIncidencia_button.Name = "modificarIncidencia_button";
            this.modificarIncidencia_button.Size = new System.Drawing.Size(234, 40);
            this.modificarIncidencia_button.TabIndex = 39;
            this.modificarIncidencia_button.Text = "Modificar";
            this.modificarIncidencia_button.UseVisualStyleBackColor = false;
            this.modificarIncidencia_button.Click += new System.EventHandler(this.modificarIncidencia_button_Click);
            // 
            // ComponenteGestionarIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.modificarIncidencia_button);
            this.Controls.Add(this.generarInforme_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaInicio_date);
            this.Controls.Add(this.tipoIncidencia_comboBox);
            this.Controls.Add(this.eliminarIncidencia_button);
            this.Controls.Add(this.mapa_webView2);
            this.Controls.Add(this.anadirIncidencia_button);
            this.Controls.Add(this.longitud_textBox);
            this.Controls.Add(this.causaIncidencia_textbox);
            this.Controls.Add(this.latitud_textBox);
            this.Controls.Add(this.datosIncidencias_dataGrid);
            this.Name = "ComponenteGestionarIncidencias";
            this.Size = new System.Drawing.Size(1465, 815);
            this.Load += new System.EventHandler(this.ComponenteGestionarIncidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosIncidencias_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapa_webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox causaIncidencia_textbox;
        private System.Windows.Forms.TextBox latitud_textBox;
        private System.Windows.Forms.DataGridView datosIncidencias_dataGrid;
        private System.Windows.Forms.TextBox longitud_textBox;
        private System.Windows.Forms.Button anadirIncidencia_button;
        private Microsoft.Web.WebView2.WinForms.WebView2 mapa_webView2;
        private System.Windows.Forms.Button eliminarIncidencia_button;
        private System.Windows.Forms.ComboBox tipoIncidencia_comboBox;
        private System.Windows.Forms.DateTimePicker fechaInicio_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button generarInforme_button;
        private System.Windows.Forms.Button modificarIncidencia_button;
    }
}
