namespace PIA_PAL
{
    partial class Resultados
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
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBoxPia1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPictureBoxPia1
            // 
            this.roundedPictureBoxPia1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPictureBoxPia1.BackgroundImage = global::PIA_PAL.Properties.Resources.elefante;
            this.roundedPictureBoxPia1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedPictureBoxPia1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.roundedPictureBoxPia1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.roundedPictureBoxPia1.BorderColor2 = System.Drawing.Color.HotPink;
            this.roundedPictureBoxPia1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.roundedPictureBoxPia1.BorderSize = 5;
            this.roundedPictureBoxPia1.GradientAngle = 50F;
            this.roundedPictureBoxPia1.Location = new System.Drawing.Point(186, 23);
            this.roundedPictureBoxPia1.Name = "roundedPictureBoxPia1";
            this.roundedPictureBoxPia1.Size = new System.Drawing.Size(405, 405);
            this.roundedPictureBoxPia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPictureBoxPia1.TabIndex = 0;
            this.roundedPictureBoxPia1.TabStop = false;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedPictureBoxPia1);
            this.Name = "Resultados";
            this.Text = "Resultados";
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBoxPia1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private herramientas.RoundedPictureBoxPia roundedPictureBoxPia1;
    }
}