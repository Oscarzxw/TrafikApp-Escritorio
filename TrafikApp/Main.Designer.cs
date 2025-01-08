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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cerrarSesion
            // 
            this.button_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_cerrarSesion.BackColor = System.Drawing.Color.Black;
            this.button_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cerrarSesion.Location = new System.Drawing.Point(467, 21);
            this.button_cerrarSesion.Name = "button_cerrarSesion";
            this.button_cerrarSesion.Size = new System.Drawing.Size(39, 29);
            this.button_cerrarSesion.TabIndex = 10;
            this.button_cerrarSesion.TabStop = false;
            this.button_cerrarSesion.Text = "<-";
            this.button_cerrarSesion.UseVisualStyleBackColor = false;
            this.button_cerrarSesion.Click += new System.EventHandler(this.button_cerrarSesion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gestionar Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(533, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "Gestionar Incidencias";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 542);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}