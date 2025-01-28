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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gestionarUsuarios_button = new System.Windows.Forms.Button();
            this.gestionarIncidencias_button = new System.Windows.Forms.Button();
            this.componentes_panel = new System.Windows.Forms.Panel();
            this.usuario_pictureBox = new System.Windows.Forms.PictureBox();
            this.gestionarUsuarios_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incidencia_pictureBox = new System.Windows.Forms.PictureBox();
            this.verPerfil_button = new System.Windows.Forms.Button();
            this.imagenLogo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuario_pictureBox)).BeginInit();
            this.gestionarUsuarios_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidencia_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionarUsuarios_button
            // 
            this.gestionarUsuarios_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gestionarUsuarios_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestionarUsuarios_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarUsuarios_button.ForeColor = System.Drawing.Color.Black;
            this.gestionarUsuarios_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionarUsuarios_button.Location = new System.Drawing.Point(93, 8);
            this.gestionarUsuarios_button.Name = "gestionarUsuarios_button";
            this.gestionarUsuarios_button.Size = new System.Drawing.Size(279, 49);
            this.gestionarUsuarios_button.TabIndex = 11;
            this.gestionarUsuarios_button.Text = "Gestionar Usuarios";
            this.gestionarUsuarios_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gestionarUsuarios_button.UseVisualStyleBackColor = true;
            this.gestionarUsuarios_button.Click += new System.EventHandler(this.gestionarUsuarios_button_Click);
            // 
            // gestionarIncidencias_button
            // 
            this.gestionarIncidencias_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gestionarIncidencias_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestionarIncidencias_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarIncidencias_button.Location = new System.Drawing.Point(94, 8);
            this.gestionarIncidencias_button.Name = "gestionarIncidencias_button";
            this.gestionarIncidencias_button.Size = new System.Drawing.Size(279, 49);
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
            this.componentes_panel.Size = new System.Drawing.Size(1267, 430);
            this.componentes_panel.TabIndex = 13;
            // 
            // usuario_pictureBox
            // 
            this.usuario_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuario_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usuario_pictureBox.BackgroundImage")));
            this.usuario_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usuario_pictureBox.Location = new System.Drawing.Point(9, 8);
            this.usuario_pictureBox.Name = "usuario_pictureBox";
            this.usuario_pictureBox.Size = new System.Drawing.Size(54, 49);
            this.usuario_pictureBox.TabIndex = 15;
            this.usuario_pictureBox.TabStop = false;
            // 
            // gestionarUsuarios_panel
            // 
            this.gestionarUsuarios_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gestionarUsuarios_panel.Controls.Add(this.usuario_pictureBox);
            this.gestionarUsuarios_panel.Controls.Add(this.gestionarUsuarios_button);
            this.gestionarUsuarios_panel.Location = new System.Drawing.Point(49, 12);
            this.gestionarUsuarios_panel.Name = "gestionarUsuarios_panel";
            this.gestionarUsuarios_panel.Size = new System.Drawing.Size(384, 67);
            this.gestionarUsuarios_panel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.incidencia_pictureBox);
            this.panel1.Controls.Add(this.gestionarIncidencias_button);
            this.panel1.Location = new System.Drawing.Point(816, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 67);
            this.panel1.TabIndex = 16;
            // 
            // incidencia_pictureBox
            // 
            this.incidencia_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidencia_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("incidencia_pictureBox.BackgroundImage")));
            this.incidencia_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.incidencia_pictureBox.Location = new System.Drawing.Point(15, 8);
            this.incidencia_pictureBox.Name = "incidencia_pictureBox";
            this.incidencia_pictureBox.Size = new System.Drawing.Size(54, 49);
            this.incidencia_pictureBox.TabIndex = 16;
            this.incidencia_pictureBox.TabStop = false;
            // 
            // verPerfil_button
            // 
            this.verPerfil_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verPerfil_button.BackColor = System.Drawing.Color.Transparent;
            this.verPerfil_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verPerfil_button.BackgroundImage")));
            this.verPerfil_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verPerfil_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verPerfil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verPerfil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verPerfil_button.ForeColor = System.Drawing.Color.Black;
            this.verPerfil_button.Location = new System.Drawing.Point(1241, 12);
            this.verPerfil_button.Name = "verPerfil_button";
            this.verPerfil_button.Size = new System.Drawing.Size(38, 36);
            this.verPerfil_button.TabIndex = 17;
            this.verPerfil_button.TabStop = false;
            this.verPerfil_button.UseVisualStyleBackColor = false;
            this.verPerfil_button.Click += new System.EventHandler(this.verPerfil_button_Click);
            // 
            // imagenLogo_pictureBox
            // 
            this.imagenLogo_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogo_pictureBox.BackgroundImage")));
            this.imagenLogo_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenLogo_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.imagenLogo_pictureBox.Name = "imagenLogo_pictureBox";
            this.imagenLogo_pictureBox.Size = new System.Drawing.Size(74, 68);
            this.imagenLogo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenLogo_pictureBox.TabIndex = 18;
            this.imagenLogo_pictureBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1291, 542);
            this.ControlBox = false;
            this.Controls.Add(this.imagenLogo_pictureBox);
            this.Controls.Add(this.verPerfil_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gestionarUsuarios_panel);
            this.Controls.Add(this.componentes_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuario_pictureBox)).EndInit();
            this.gestionarUsuarios_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incidencia_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gestionarUsuarios_button;
        private System.Windows.Forms.Button gestionarIncidencias_button;
        private System.Windows.Forms.Panel componentes_panel;
        private System.Windows.Forms.PictureBox usuario_pictureBox;
        private System.Windows.Forms.Panel gestionarUsuarios_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox incidencia_pictureBox;
        private System.Windows.Forms.Button verPerfil_button;
        private System.Windows.Forms.PictureBox imagenLogo_pictureBox;
    }
}