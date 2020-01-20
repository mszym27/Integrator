namespace Integrator
{
    partial class OProgramie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_przedmiot = new System.Windows.Forms.Label();
            this.l_autor = new System.Windows.Forms.Label();
            this.l_indeks = new System.Windows.Forms.Label();
            this.l_rok_akademicki = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Integrator.Properties.Resources.logo_imsi;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przedmiot";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Indeks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rok akademicki";
            // 
            // l_przedmiot
            // 
            this.l_przedmiot.AutoSize = true;
            this.l_przedmiot.Location = new System.Drawing.Point(152, 180);
            this.l_przedmiot.Name = "l_przedmiot";
            this.l_przedmiot.Size = new System.Drawing.Size(35, 13);
            this.l_przedmiot.TabIndex = 5;
            this.l_przedmiot.Text = "label5";
            // 
            // l_autor
            // 
            this.l_autor.AutoSize = true;
            this.l_autor.Location = new System.Drawing.Point(152, 204);
            this.l_autor.Name = "l_autor";
            this.l_autor.Size = new System.Drawing.Size(35, 13);
            this.l_autor.TabIndex = 6;
            this.l_autor.Text = "label6";
            // 
            // l_indeks
            // 
            this.l_indeks.AutoSize = true;
            this.l_indeks.Location = new System.Drawing.Point(152, 229);
            this.l_indeks.Name = "l_indeks";
            this.l_indeks.Size = new System.Drawing.Size(35, 13);
            this.l_indeks.TabIndex = 7;
            this.l_indeks.Text = "label5";
            // 
            // l_rok_akademicki
            // 
            this.l_rok_akademicki.AutoSize = true;
            this.l_rok_akademicki.Location = new System.Drawing.Point(152, 252);
            this.l_rok_akademicki.Name = "l_rok_akademicki";
            this.l_rok_akademicki.Size = new System.Drawing.Size(35, 13);
            this.l_rok_akademicki.TabIndex = 8;
            this.l_rok_akademicki.Text = "label5";
            // 
            // OProgramie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 283);
            this.Controls.Add(this.l_rok_akademicki);
            this.Controls.Add(this.l_indeks);
            this.Controls.Add(this.l_autor);
            this.Controls.Add(this.l_przedmiot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OProgramie";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O Programie";
            this.Load += new System.EventHandler(this.OProgramie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_przedmiot;
        private System.Windows.Forms.Label l_autor;
        private System.Windows.Forms.Label l_indeks;
        private System.Windows.Forms.Label l_rok_akademicki;

    }
}
