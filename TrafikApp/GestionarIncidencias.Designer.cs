namespace TrafikApp
{
    partial class GestionarIncidencias
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
            this.mapa_webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // mapa_webBrowser
            // 
            this.mapa_webBrowser.Location = new System.Drawing.Point(718, 12);
            this.mapa_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapa_webBrowser.Name = "mapa_webBrowser";
            this.mapa_webBrowser.Size = new System.Drawing.Size(305, 242);
            this.mapa_webBrowser.TabIndex = 0;
            // 
            // GestionarIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 567);
            this.Controls.Add(this.mapa_webBrowser);
            this.Name = "GestionarIncidencias";
            this.Text = "GestionarIncidencias";
            this.Load += new System.EventHandler(this.GestionarIncidencias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser mapa_webBrowser;
    }
}