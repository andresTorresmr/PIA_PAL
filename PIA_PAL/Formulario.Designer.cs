namespace PIA_PAL
{
    partial class Formulario
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
            this.roundedPictureBoxPia1 = new PIA_PAL.herramientas.RoundedPictureBoxPia();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBoxPia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPictureBoxPia1
            // 
            this.roundedPictureBoxPia1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPictureBoxPia1.BackgroundImage = global::PIA_PAL.Properties.Resources.elefante;
            this.roundedPictureBoxPia1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedPictureBoxPia1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.roundedPictureBoxPia1.BorderColor = System.Drawing.Color.OrangeRed;
            this.roundedPictureBoxPia1.BorderColor2 = System.Drawing.Color.GreenYellow;
            this.roundedPictureBoxPia1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.roundedPictureBoxPia1.BorderSize = 10;
            this.roundedPictureBoxPia1.GradientAngle = 50F;
            this.roundedPictureBoxPia1.Location = new System.Drawing.Point(191, 26);
            this.roundedPictureBoxPia1.Name = "roundedPictureBoxPia1";
            this.roundedPictureBoxPia1.Size = new System.Drawing.Size(388, 388);
            this.roundedPictureBoxPia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPictureBoxPia1.TabIndex = 0;
            this.roundedPictureBoxPia1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PIA_PAL.Properties.Resources.Close_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(747, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIA_PAL.Properties.Resources.fondo_rojo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedPictureBoxPia1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBoxPia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private herramientas.RoundedPictureBoxPia roundedPictureBoxPia1;
        private PictureBox pictureBox1;
    }
}