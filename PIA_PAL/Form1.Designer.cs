namespace PIA_PAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrimeraVez = new PIA_PAL.herramientas.BotonPia();
            this.btnYa = new PIA_PAL.herramientas.BotonPia();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PIA_PAL.Properties.Resources.Close_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(763, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPrimeraVez
            // 
            this.btnPrimeraVez.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrimeraVez.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnPrimeraVez.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrimeraVez.BorderRadius = 20;
            this.btnPrimeraVez.BorderSize = 0;
            this.btnPrimeraVez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimeraVez.FlatAppearance.BorderSize = 0;
            this.btnPrimeraVez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraVez.ForeColor = System.Drawing.Color.Black;
            this.btnPrimeraVez.Location = new System.Drawing.Point(528, 258);
            this.btnPrimeraVez.Name = "btnPrimeraVez";
            this.btnPrimeraVez.Size = new System.Drawing.Size(150, 40);
            this.btnPrimeraVez.TabIndex = 1;
            this.btnPrimeraVez.Text = "Por primera vez";
            this.btnPrimeraVez.TextColor = System.Drawing.Color.Black;
            this.btnPrimeraVez.UseVisualStyleBackColor = false;
            this.btnPrimeraVez.Click += new System.EventHandler(this.btnPrimeraVez_Click);
            // 
            // btnYa
            // 
            this.btnYa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnYa.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnYa.BorderColor = System.Drawing.Color.Transparent;
            this.btnYa.BorderRadius = 20;
            this.btnYa.BorderSize = 0;
            this.btnYa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYa.FlatAppearance.BorderSize = 0;
            this.btnYa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYa.ForeColor = System.Drawing.Color.Black;
            this.btnYa.Location = new System.Drawing.Point(112, 258);
            this.btnYa.Name = "btnYa";
            this.btnYa.Size = new System.Drawing.Size(150, 40);
            this.btnYa.TabIndex = 2;
            this.btnYa.Text = "Examen ya realizado";
            this.btnYa.TextColor = System.Drawing.Color.Black;
            this.btnYa.UseVisualStyleBackColor = false;
            this.btnYa.Click += new System.EventHandler(this.btnYa_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::PIA_PAL.Properties.Resources.elefante;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(143, -38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(506, 459);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 360);
            this.Controls.Add(this.btnYa);
            this.Controls.Add(this.btnPrimeraVez);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private herramientas.BotonPia btnPrimeraVez;
        private herramientas.BotonPia btnPresentado;
        private herramientas.BotonPia btnPrimera;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private herramientas.BotonPia btnYa;
        private PictureBox pictureBox4;
    }
}