namespace ACT2_archivos_Csharp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnIndexado = new System.Windows.Forms.Button();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.btnDirecto = new System.Windows.Forms.Button();
            this.listBoxDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(384, 69);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnIndexado
            // 
            this.btnIndexado.Location = new System.Drawing.Point(539, 126);
            this.btnIndexado.Name = "btnIndexado";
            this.btnIndexado.Size = new System.Drawing.Size(116, 23);
            this.btnIndexado.TabIndex = 4;
            this.btnIndexado.Text = "INDEXEADO";
            this.btnIndexado.UseVisualStyleBackColor = true;
            this.btnIndexado.Click += new System.EventHandler(this.btnIndexado_Click);
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Location = new System.Drawing.Point(539, 69);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(116, 23);
            this.btnSecuencial.TabIndex = 5;
            this.btnSecuencial.Text = "SECUENCIAL";
            this.btnSecuencial.UseVisualStyleBackColor = true;
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // btnDirecto
            // 
            this.btnDirecto.Location = new System.Drawing.Point(539, 181);
            this.btnDirecto.Name = "btnDirecto";
            this.btnDirecto.Size = new System.Drawing.Size(116, 23);
            this.btnDirecto.TabIndex = 6;
            this.btnDirecto.Text = "DIRECTO";
            this.btnDirecto.UseVisualStyleBackColor = true;
            this.btnDirecto.Click += new System.EventHandler(this.btnDirecto_Click);
            // 
            // listBoxDatos
            // 
            this.listBoxDatos.FormattingEnabled = true;
            this.listBoxDatos.ItemHeight = 16;
            this.listBoxDatos.Location = new System.Drawing.Point(109, 126);
            this.listBoxDatos.Name = "listBoxDatos";
            this.listBoxDatos.Size = new System.Drawing.Size(413, 164);
            this.listBoxDatos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDatos);
            this.Controls.Add(this.btnDirecto);
            this.Controls.Add(this.btnSecuencial);
            this.Controls.Add(this.btnIndexado);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnIndexado;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.Button btnDirecto;
        private System.Windows.Forms.ListBox listBoxDatos;
    }
}

