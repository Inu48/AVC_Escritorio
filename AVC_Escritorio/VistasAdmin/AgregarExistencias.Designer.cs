namespace AVC_Escritorio.VistasAdmin
{
    partial class AgregarExistencias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadNueva = new System.Windows.Forms.NumericUpDown();
            this.btnNuevasExistencias = new System.Windows.Forms.Button();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.lbCantidadProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a añadir:";
            // 
            // txtCantidadNueva
            // 
            this.txtCantidadNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadNueva.Location = new System.Drawing.Point(176, 78);
            this.txtCantidadNueva.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadNueva.Name = "txtCantidadNueva";
            this.txtCantidadNueva.Size = new System.Drawing.Size(120, 26);
            this.txtCantidadNueva.TabIndex = 1;
            this.txtCantidadNueva.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNuevasExistencias
            // 
            this.btnNuevasExistencias.Location = new System.Drawing.Point(112, 120);
            this.btnNuevasExistencias.Name = "btnNuevasExistencias";
            this.btnNuevasExistencias.Size = new System.Drawing.Size(109, 30);
            this.btnNuevasExistencias.TabIndex = 2;
            this.btnNuevasExistencias.Text = "Añadir";
            this.btnNuevasExistencias.UseVisualStyleBackColor = true;
            this.btnNuevasExistencias.Click += new System.EventHandler(this.btnNuevasExistencias_Click);
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProducto.Location = new System.Drawing.Point(31, 9);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(51, 20);
            this.lbNombreProducto.TabIndex = 3;
            this.lbNombreProducto.Text = "label2";
            // 
            // lbCantidadProducto
            // 
            this.lbCantidadProducto.AutoSize = true;
            this.lbCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadProducto.Location = new System.Drawing.Point(31, 39);
            this.lbCantidadProducto.Name = "lbCantidadProducto";
            this.lbCantidadProducto.Size = new System.Drawing.Size(51, 20);
            this.lbCantidadProducto.TabIndex = 4;
            this.lbCantidadProducto.Text = "label2";
            // 
            // AgregarExistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 183);
            this.Controls.Add(this.lbCantidadProducto);
            this.Controls.Add(this.lbNombreProducto);
            this.Controls.Add(this.btnNuevasExistencias);
            this.Controls.Add(this.txtCantidadNueva);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AgregarExistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarExistencias";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCantidadNueva;
        private System.Windows.Forms.Button btnNuevasExistencias;
        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.Label lbCantidadProducto;
    }
}