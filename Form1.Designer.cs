namespace Ejercicio13
{
    partial class Form1
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
            this.BTN_Imagen = new System.Windows.Forms.Button();
            this.PIC = new System.Windows.Forms.OpenFileDialog();
            this.PIC_1 = new System.Windows.Forms.PictureBox();
            this.File = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Imagen
            // 
            this.BTN_Imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Imagen.Location = new System.Drawing.Point(187, 79);
            this.BTN_Imagen.Name = "BTN_Imagen";
            this.BTN_Imagen.Size = new System.Drawing.Size(75, 23);
            this.BTN_Imagen.TabIndex = 0;
            this.BTN_Imagen.Text = "IMAGEN";
            this.BTN_Imagen.UseVisualStyleBackColor = true;
            this.BTN_Imagen.Click += new System.EventHandler(this.BTN_Imagen_Click);
            // 
            // PIC
            // 
            this.PIC.FileName = "openFileDialog1";
            // 
            // PIC_1
            // 
            this.PIC_1.Location = new System.Drawing.Point(297, 47);
            this.PIC_1.Name = "PIC_1";
            this.PIC_1.Size = new System.Drawing.Size(154, 109);
            this.PIC_1.TabIndex = 1;
            this.PIC_1.TabStop = false;
            // 
            // File
            // 
            this.File.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 208);
            this.Controls.Add(this.PIC_1);
            this.Controls.Add(this.BTN_Imagen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Imagen;
        private System.Windows.Forms.OpenFileDialog PIC;
        private System.Windows.Forms.PictureBox PIC_1;
        private System.Windows.Forms.OpenFileDialog File;
    }
}

