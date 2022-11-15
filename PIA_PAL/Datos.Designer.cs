namespace PIA_PAL
{
    partial class Datos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nombre1 = new PIA_PAL.herramientas.PiaTextBox();
            this.nacimiento = new PIA_PAL.herramientas.DateTimePia();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonPia1 = new PIA_PAL.herramientas.BotonPia();
            this.Nombre2 = new PIA_PAL.herramientas.PiaTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ApellidoM = new PIA_PAL.herramientas.PiaTextBox();
            this.ApellidoP = new PIA_PAL.herramientas.PiaTextBox();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PIA_PAL.Properties.Resources.Close_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(772, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Nombre1
            // 
            this.Nombre1.BackColor = System.Drawing.SystemColors.Window;
            this.Nombre1.BorderColor = System.Drawing.Color.DarkRed;
            this.Nombre1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Nombre1.BorderRadius = 0;
            this.Nombre1.BorderSize = 2;
            this.Nombre1.Location = new System.Drawing.Point(106, 45);
            this.Nombre1.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre1.Multiline = false;
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.Padding = new System.Windows.Forms.Padding(7);
            this.Nombre1.PasswordChar = false;
            this.Nombre1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Nombre1.PlaceholderText = "";
            this.Nombre1.Size = new System.Drawing.Size(250, 30);
            this.Nombre1.TabIndex = 1;
            this.Nombre1.Tag = "Nombre1";
            this.Nombre1.Texts = "";
            this.Nombre1.UnderlinedStyle = false;
            this.Nombre1.Load += new System.EventHandler(this.piaTextBox1_Load);
            this.Nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre1_KeyPress);
            // 
            // nacimiento
            // 
            this.nacimiento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nacimiento.BorderSize = 0;
            this.nacimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nacimiento.Location = new System.Drawing.Point(106, 301);
            this.nacimiento.MinimumSize = new System.Drawing.Size(0, 35);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(250, 35);
            this.nacimiento.SkinColor = System.Drawing.Color.DarkRed;
            this.nacimiento.TabIndex = 5;
            this.nacimiento.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(106, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundo nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(106, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(106, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // botonPia1
            // 
            this.botonPia1.BackColor = System.Drawing.Color.DarkRed;
            this.botonPia1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.botonPia1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPia1.BorderRadius = 20;
            this.botonPia1.BorderSize = 0;
            this.botonPia1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPia1.FlatAppearance.BorderSize = 0;
            this.botonPia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPia1.ForeColor = System.Drawing.Color.White;
            this.botonPia1.Location = new System.Drawing.Point(638, 398);
            this.botonPia1.Name = "botonPia1";
            this.botonPia1.Size = new System.Drawing.Size(150, 40);
            this.botonPia1.TabIndex = 6;
            this.botonPia1.Text = "Ingresar";
            this.botonPia1.TextColor = System.Drawing.Color.White;
            this.botonPia1.UseVisualStyleBackColor = false;
            this.botonPia1.Click += new System.EventHandler(this.botonPia1_Click);
            // 
            // Nombre2
            // 
            this.Nombre2.BackColor = System.Drawing.SystemColors.Window;
            this.Nombre2.BorderColor = System.Drawing.Color.DarkRed;
            this.Nombre2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Nombre2.BorderRadius = 0;
            this.Nombre2.BorderSize = 2;
            this.Nombre2.Location = new System.Drawing.Point(106, 110);
            this.Nombre2.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre2.Multiline = false;
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Padding = new System.Windows.Forms.Padding(7);
            this.Nombre2.PasswordChar = false;
            this.Nombre2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Nombre2.PlaceholderText = "";
            this.Nombre2.Size = new System.Drawing.Size(250, 30);
            this.Nombre2.TabIndex = 2;
            this.Nombre2.Texts = "";
            this.Nombre2.UnderlinedStyle = false;
            this.Nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre2_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PIA_PAL.Properties.Resources.elefante;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(540, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 336);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(106, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido paterno:";
            // 
            // ApellidoM
            // 
            this.ApellidoM.BackColor = System.Drawing.SystemColors.Window;
            this.ApellidoM.BorderColor = System.Drawing.Color.DarkRed;
            this.ApellidoM.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ApellidoM.BorderRadius = 0;
            this.ApellidoM.BorderSize = 2;
            this.ApellidoM.Location = new System.Drawing.Point(106, 237);
            this.ApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoM.Multiline = false;
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.Padding = new System.Windows.Forms.Padding(7);
            this.ApellidoM.PasswordChar = false;
            this.ApellidoM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ApellidoM.PlaceholderText = "";
            this.ApellidoM.Size = new System.Drawing.Size(250, 30);
            this.ApellidoM.TabIndex = 4;
            this.ApellidoM.Texts = "";
            this.ApellidoM.UnderlinedStyle = false;
            this.ApellidoM.Load += new System.EventHandler(this.ApellidoM_Load);
            this.ApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoM_KeyPress);
            // 
            // ApellidoP
            // 
            this.ApellidoP.BackColor = System.Drawing.SystemColors.Window;
            this.ApellidoP.BorderColor = System.Drawing.Color.DarkRed;
            this.ApellidoP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ApellidoP.BorderRadius = 0;
            this.ApellidoP.BorderSize = 2;
            this.ApellidoP.Location = new System.Drawing.Point(106, 175);
            this.ApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoP.Multiline = false;
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Padding = new System.Windows.Forms.Padding(7);
            this.ApellidoP.PasswordChar = false;
            this.ApellidoP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ApellidoP.PlaceholderText = "";
            this.ApellidoP.Size = new System.Drawing.Size(250, 30);
            this.ApellidoP.TabIndex = 3;
            this.ApellidoP.Texts = "";
            this.ApellidoP.UnderlinedStyle = false;
            this.ApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoP_KeyPress);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::PIA_PAL.Properties.Resources._return;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::PIA_PAL.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(10, 15);
            this.btn_regresar.TabIndex = 17;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.ApellidoP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ApellidoM);
            this.Controls.Add(this.Nombre2);
            this.Controls.Add(this.botonPia1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.Nombre1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private herramientas.PiaTextBox Nombre1;
        private herramientas.DateTimePia nacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private herramientas.BotonPia botonPia1;
        private herramientas.PiaTextBox Nombre2;
        private PictureBox pictureBox2;
        private Label label5;
        private herramientas.PiaTextBox ApellidoM;
        private herramientas.PiaTextBox ApellidoP;
        private PictureBox btn_regresar;
    }
}