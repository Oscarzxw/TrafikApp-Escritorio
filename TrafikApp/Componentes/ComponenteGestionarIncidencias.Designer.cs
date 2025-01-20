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
            this.tituloIncidencia_textbox = new System.Windows.Forms.TextBox();
            this.datosIncidencias_dataGrid = new System.Windows.Forms.DataGridView();
            this.longitud_textBox = new System.Windows.Forms.TextBox();
            this.anadirIncidencia_button = new System.Windows.Forms.Button();
            this.mapa_webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoIncidencia_comboBox = new System.Windows.Forms.ComboBox();
            this.fechaInicio_date = new System.Windows.Forms.DateTimePicker();
            this.fechaFinal_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosIncidencias_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapa_webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // causaIncidencia_textbox
            // 
            this.causaIncidencia_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.causaIncidencia_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.causaIncidencia_textbox.Location = new System.Drawing.Point(778, 128);
            this.causaIncidencia_textbox.Multiline = true;
            this.causaIncidencia_textbox.Name = "causaIncidencia_textbox";
            this.causaIncidencia_textbox.Size = new System.Drawing.Size(331, 95);
            this.causaIncidencia_textbox.TabIndex = 23;
            // 
            // latitud_textBox
            // 
            this.latitud_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.latitud_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitud_textBox.Location = new System.Drawing.Point(778, 388);
            this.latitud_textBox.Name = "latitud_textBox";
            this.latitud_textBox.Size = new System.Drawing.Size(158, 29);
            this.latitud_textBox.TabIndex = 22;
            this.latitud_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.latitud_textBox_KeyPress);
            // 
            // tituloIncidencia_textbox
            // 
            this.tituloIncidencia_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloIncidencia_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloIncidencia_textbox.Location = new System.Drawing.Point(778, 64);
            this.tituloIncidencia_textbox.Name = "tituloIncidencia_textbox";
            this.tituloIncidencia_textbox.Size = new System.Drawing.Size(331, 29);
            this.tituloIncidencia_textbox.TabIndex = 21;
            // 
            // datosIncidencias_dataGrid
            // 
            this.datosIncidencias_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosIncidencias_dataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.datosIncidencias_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosIncidencias_dataGrid.Location = new System.Drawing.Point(23, 40);
            this.datosIncidencias_dataGrid.Name = "datosIncidencias_dataGrid";
            this.datosIncidencias_dataGrid.Size = new System.Drawing.Size(738, 761);
            this.datosIncidencias_dataGrid.TabIndex = 20;
            // 
            // longitud_textBox
            // 
            this.longitud_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.longitud_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitud_textBox.Location = new System.Drawing.Point(951, 388);
            this.longitud_textBox.Name = "longitud_textBox";
            this.longitud_textBox.Size = new System.Drawing.Size(158, 29);
            this.longitud_textBox.TabIndex = 24;
            this.longitud_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.longitud_textBox_KeyPress);
            // 
            // anadirIncidencia_button
            // 
            this.anadirIncidencia_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.anadirIncidencia_button.BackColor = System.Drawing.Color.Black;
            this.anadirIncidencia_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anadirIncidencia_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirIncidencia_button.ForeColor = System.Drawing.Color.White;
            this.anadirIncidencia_button.Location = new System.Drawing.Point(778, 681);
            this.anadirIncidencia_button.Name = "anadirIncidencia_button";
            this.anadirIncidencia_button.Size = new System.Drawing.Size(331, 47);
            this.anadirIncidencia_button.TabIndex = 25;
            this.anadirIncidencia_button.Text = "Añadir";
            this.anadirIncidencia_button.UseVisualStyleBackColor = false;
            this.anadirIncidencia_button.Click += new System.EventHandler(this.anadirIncidencia_button_Click);
            // 
            // mapa_webView2
            // 
            this.mapa_webView2.AllowExternalDrop = true;
            this.mapa_webView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapa_webView2.CreationProperties = null;
            this.mapa_webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.mapa_webView2.Location = new System.Drawing.Point(814, 461);
            this.mapa_webView2.Name = "mapa_webView2";
            this.mapa_webView2.Size = new System.Drawing.Size(268, 204);
            this.mapa_webView2.TabIndex = 26;
            this.mapa_webView2.ZoomFactor = 1D;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(778, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoIncidencia_comboBox
            // 
            this.tipoIncidencia_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tipoIncidencia_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoIncidencia_comboBox.FormattingEnabled = true;
            this.tipoIncidencia_comboBox.Items.AddRange(new object[] {
            "OBRAS",
            "EVEN",
            "ACCIDENTE",
            "CALLE CORTADA",
            "OTRO"});
            this.tipoIncidencia_comboBox.Location = new System.Drawing.Point(778, 258);
            this.tipoIncidencia_comboBox.Name = "tipoIncidencia_comboBox";
            this.tipoIncidencia_comboBox.Size = new System.Drawing.Size(331, 32);
            this.tipoIncidencia_comboBox.TabIndex = 28;
            // 
            // fechaInicio_date
            // 
            this.fechaInicio_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaInicio_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio_date.Location = new System.Drawing.Point(778, 327);
            this.fechaInicio_date.Name = "fechaInicio_date";
            this.fechaInicio_date.Size = new System.Drawing.Size(158, 26);
            this.fechaInicio_date.TabIndex = 29;
            // 
            // fechaFinal_date
            // 
            this.fechaFinal_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaFinal_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinal_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinal_date.Location = new System.Drawing.Point(951, 327);
            this.fechaFinal_date.MinDate = new System.DateTime(2025, 1, 16, 0, 0, 0, 0);
            this.fechaFinal_date.Name = "fechaFinal_date";
            this.fechaFinal_date.Size = new System.Drawing.Size(158, 26);
            this.fechaFinal_date.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(774, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Causa";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(774, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Inicio";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(947, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fin";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Latitud";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(947, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Longitud";
            // 
            // ComponenteGestionarIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaFinal_date);
            this.Controls.Add(this.fechaInicio_date);
            this.Controls.Add(this.tipoIncidencia_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mapa_webView2);
            this.Controls.Add(this.anadirIncidencia_button);
            this.Controls.Add(this.longitud_textBox);
            this.Controls.Add(this.causaIncidencia_textbox);
            this.Controls.Add(this.latitud_textBox);
            this.Controls.Add(this.tituloIncidencia_textbox);
            this.Controls.Add(this.datosIncidencias_dataGrid);
            this.Name = "ComponenteGestionarIncidencias";
            this.Size = new System.Drawing.Size(1120, 815);
            this.Load += new System.EventHandler(this.ComponenteGestionarIncidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosIncidencias_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapa_webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox causaIncidencia_textbox;
        private System.Windows.Forms.TextBox latitud_textBox;
        private System.Windows.Forms.TextBox tituloIncidencia_textbox;
        private System.Windows.Forms.DataGridView datosIncidencias_dataGrid;
        private System.Windows.Forms.TextBox longitud_textBox;
        private System.Windows.Forms.Button anadirIncidencia_button;
        private Microsoft.Web.WebView2.WinForms.WebView2 mapa_webView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tipoIncidencia_comboBox;
        private System.Windows.Forms.DateTimePicker fechaInicio_date;
        private System.Windows.Forms.DateTimePicker fechaFinal_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
