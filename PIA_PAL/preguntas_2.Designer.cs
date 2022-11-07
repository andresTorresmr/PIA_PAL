namespace PIA_PAL
{
    partial class preguntas_2
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
            this.btn_anterior = new PIA_PAL.herramientas.BotonPia();
            this.btn_siguiente = new PIA_PAL.herramientas.BotonPia();
            this.SuspendLayout();
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_anterior.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_anterior.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_anterior.BorderRadius = 20;
            this.btn_anterior.BorderSize = 0;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.ForeColor = System.Drawing.Color.White;
            this.btn_anterior.Location = new System.Drawing.Point(12, 398);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(150, 40);
            this.btn_anterior.TabIndex = 0;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.TextColor = System.Drawing.Color.White;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_siguiente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_siguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_siguiente.BorderRadius = 20;
            this.btn_siguiente.BorderSize = 0;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.ForeColor = System.Drawing.Color.White;
            this.btn_siguiente.Location = new System.Drawing.Point(638, 398);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(150, 40);
            this.btn_siguiente.TabIndex = 1;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.TextColor = System.Drawing.Color.White;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            // 
            // preguntas_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_anterior);
            this.Name = "preguntas_2";
            this.Text = "preguntas_2";
            this.ResumeLayout(false);

        }

        #endregion

        private herramientas.BotonPia btn_anterior;
        private herramientas.BotonPia btn_siguiente;
    }
}