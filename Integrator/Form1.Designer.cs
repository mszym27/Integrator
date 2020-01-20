namespace Integrator
{
    partial class Glowne_okno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychŹródłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychCelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_podglad = new System.Windows.Forms.Button();
            this.bt_polacz = new System.Windows.Forms.Button();
            this.pb_integruj = new System.Windows.Forms.ProgressBar();
            this.lb_postepu = new System.Windows.Forms.Label();
            this.bt_integruj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_podglad_cel = new System.Windows.Forms.Button();
            this.bt_polacz_cel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaDanychŹródłoToolStripMenuItem,
            this.bazaDanychCelToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // bazaDanychŹródłoToolStripMenuItem
            // 
            this.bazaDanychŹródłoToolStripMenuItem.Name = "bazaDanychŹródłoToolStripMenuItem";
            this.bazaDanychŹródłoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bazaDanychŹródłoToolStripMenuItem.Text = "Baza danych - źródło";
            this.bazaDanychŹródłoToolStripMenuItem.Click += new System.EventHandler(this.bazaDanychŹródłoToolStripMenuItem_Click);
            // 
            // bazaDanychCelToolStripMenuItem
            // 
            this.bazaDanychCelToolStripMenuItem.Name = "bazaDanychCelToolStripMenuItem";
            this.bazaDanychCelToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bazaDanychCelToolStripMenuItem.Text = "Baza danych - cel";
            this.bazaDanychCelToolStripMenuItem.Click += new System.EventHandler(this.bazaDanychCelToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_podglad);
            this.groupBox1.Controls.Add(this.bt_polacz);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Źródło";
            // 
            // bt_podglad
            // 
            this.bt_podglad.Location = new System.Drawing.Point(387, 38);
            this.bt_podglad.Name = "bt_podglad";
            this.bt_podglad.Size = new System.Drawing.Size(75, 23);
            this.bt_podglad.TabIndex = 1;
            this.bt_podglad.Text = "Podgląd";
            this.bt_podglad.UseVisualStyleBackColor = true;
            this.bt_podglad.Click += new System.EventHandler(this.bt_podglad_Click);
            // 
            // bt_polacz
            // 
            this.bt_polacz.Location = new System.Drawing.Point(6, 38);
            this.bt_polacz.Name = "bt_polacz";
            this.bt_polacz.Size = new System.Drawing.Size(75, 23);
            this.bt_polacz.TabIndex = 0;
            this.bt_polacz.Text = "Połącz";
            this.bt_polacz.UseVisualStyleBackColor = true;
            this.bt_polacz.Click += new System.EventHandler(this.bt_polacz_Click);
            // 
            // pb_integruj
            // 
            this.pb_integruj.Location = new System.Drawing.Point(13, 296);
            this.pb_integruj.Name = "pb_integruj";
            this.pb_integruj.Size = new System.Drawing.Size(424, 16);
            this.pb_integruj.TabIndex = 2;
            // 
            // lb_postepu
            // 
            this.lb_postepu.AutoSize = true;
            this.lb_postepu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_postepu.Location = new System.Drawing.Point(443, 296);
            this.lb_postepu.Name = "lb_postepu";
            this.lb_postepu.Size = new System.Drawing.Size(29, 16);
            this.lb_postepu.TabIndex = 3;
            this.lb_postepu.Text = "0%";
            // 
            // bt_integruj
            // 
            this.bt_integruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_integruj.Location = new System.Drawing.Point(141, 239);
            this.bt_integruj.Name = "bt_integruj";
            this.bt_integruj.Size = new System.Drawing.Size(200, 50);
            this.bt_integruj.TabIndex = 4;
            this.bt_integruj.Text = "Integruj";
            this.bt_integruj.UseVisualStyleBackColor = true;
            this.bt_integruj.Click += new System.EventHandler(this.bt_integruj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_podglad_cel);
            this.groupBox2.Controls.Add(this.bt_polacz_cel);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cel";
            // 
            // bt_podglad_cel
            // 
            this.bt_podglad_cel.Location = new System.Drawing.Point(387, 38);
            this.bt_podglad_cel.Name = "bt_podglad_cel";
            this.bt_podglad_cel.Size = new System.Drawing.Size(75, 23);
            this.bt_podglad_cel.TabIndex = 1;
            this.bt_podglad_cel.Text = "Podgląd";
            this.bt_podglad_cel.UseVisualStyleBackColor = true;
            this.bt_podglad_cel.Click += new System.EventHandler(this.bt_podglad_cel_Click);
            // 
            // bt_polacz_cel
            // 
            this.bt_polacz_cel.Location = new System.Drawing.Point(6, 38);
            this.bt_polacz_cel.Name = "bt_polacz_cel";
            this.bt_polacz_cel.Size = new System.Drawing.Size(75, 23);
            this.bt_polacz_cel.TabIndex = 0;
            this.bt_polacz_cel.Text = "Połącz";
            this.bt_polacz_cel.UseVisualStyleBackColor = true;
            this.bt_polacz_cel.Click += new System.EventHandler(this.bt_polacz_cel_Click);
            // 
            // Glowne_okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_integruj);
            this.Controls.Add(this.lb_postepu);
            this.Controls.Add(this.pb_integruj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Glowne_okno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychŹródłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychCelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_podglad;
        private System.Windows.Forms.Button bt_polacz;
        private System.Windows.Forms.ProgressBar pb_integruj;
        private System.Windows.Forms.Label lb_postepu;
        private System.Windows.Forms.Button bt_integruj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_podglad_cel;
        private System.Windows.Forms.Button bt_polacz_cel;
    }
}

