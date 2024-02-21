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
            this.btnSequential = new System.Windows.Forms.Button();
            this.btnDirectAccess = new System.Windows.Forms.Button();
            this.btnIndexed = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSequential
            // 
            this.btnSequential.Location = new System.Drawing.Point(26, 143);
            this.btnSequential.Name = "btnSequential";
            this.btnSequential.Size = new System.Drawing.Size(105, 23);
            this.btnSequential.TabIndex = 0;
            this.btnSequential.Text = "sequential";
            this.btnSequential.UseVisualStyleBackColor = true;
            this.btnSequential.Click += new System.EventHandler(this.btnSequential_Click);
            // 
            // btnDirectAccess
            // 
            this.btnDirectAccess.Location = new System.Drawing.Point(26, 270);
            this.btnDirectAccess.Name = "btnDirectAccess";
            this.btnDirectAccess.Size = new System.Drawing.Size(105, 23);
            this.btnDirectAccess.TabIndex = 1;
            this.btnDirectAccess.Text = "Direct";
            this.btnDirectAccess.UseVisualStyleBackColor = true;
            this.btnDirectAccess.Click += new System.EventHandler(this.btnDirectAccess_Click);
            // 
            // btnIndexed
            // 
            this.btnIndexed.Location = new System.Drawing.Point(26, 214);
            this.btnIndexed.Name = "btnIndexed";
            this.btnIndexed.Size = new System.Drawing.Size(105, 23);
            this.btnIndexed.TabIndex = 2;
            this.btnIndexed.Text = "indexed";
            this.btnIndexed.UseVisualStyleBackColor = true;
            this.btnIndexed.Click += new System.EventHandler(this.btnIndexed_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(228, 114);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(542, 265);
            this.textBoxOutput.TabIndex = 3;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(241, 23);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "Guardar";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.btnIndexed);
            this.Controls.Add(this.btnDirectAccess);
            this.Controls.Add(this.btnSequential);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSequential;
        private System.Windows.Forms.Button btnDirectAccess;
        private System.Windows.Forms.Button btnIndexed;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

