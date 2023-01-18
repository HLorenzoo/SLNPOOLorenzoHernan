namespace PresentaciónVehiculos
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
            this.btnRemolque = new System.Windows.Forms.Button();
            this.btnCamion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemolque
            // 
            this.btnRemolque.Location = new System.Drawing.Point(446, 145);
            this.btnRemolque.Name = "btnRemolque";
            this.btnRemolque.Size = new System.Drawing.Size(231, 142);
            this.btnRemolque.TabIndex = 0;
            this.btnRemolque.Text = "Remolque";
            this.btnRemolque.UseVisualStyleBackColor = true;
            this.btnRemolque.Click += new System.EventHandler(this.btnRemolque_Click);
            // 
            // btnCamion
            // 
            this.btnCamion.BackColor = System.Drawing.Color.IndianRed;
            this.btnCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamion.Location = new System.Drawing.Point(121, 140);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(230, 147);
            this.btnCamion.TabIndex = 1;
            this.btnCamion.Text = "Camion";
            this.btnCamion.UseVisualStyleBackColor = false;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCamion);
            this.Controls.Add(this.btnRemolque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemolque;
        private System.Windows.Forms.Button btnCamion;
    }
}

