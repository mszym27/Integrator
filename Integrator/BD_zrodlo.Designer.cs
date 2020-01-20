namespace Integrator
{
    partial class BD_zrodlo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_baza = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.bt_test = new System.Windows.Forms.Button();
            this.bt_zapisz = new System.Windows.Forms.Button();
            this.bt_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baza danych";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasło";
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(93, 12);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(100, 20);
            this.tb_host.TabIndex = 5;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(93, 38);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 20);
            this.tb_port.TabIndex = 6;
            this.tb_port.TextChanged += new System.EventHandler(this.tb_port_TextChanged);
            // 
            // tb_baza
            // 
            this.tb_baza.Location = new System.Drawing.Point(93, 64);
            this.tb_baza.Name = "tb_baza";
            this.tb_baza.Size = new System.Drawing.Size(100, 20);
            this.tb_baza.TabIndex = 7;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(93, 90);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 8;
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(93, 116);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '*';
            this.tb_haslo.Size = new System.Drawing.Size(100, 20);
            this.tb_haslo.TabIndex = 9;
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(12, 164);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(102, 23);
            this.bt_test.TabIndex = 10;
            this.bt_test.Text = "Test połączenia";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // bt_zapisz
            // 
            this.bt_zapisz.Location = new System.Drawing.Point(135, 164);
            this.bt_zapisz.Name = "bt_zapisz";
            this.bt_zapisz.Size = new System.Drawing.Size(75, 23);
            this.bt_zapisz.TabIndex = 11;
            this.bt_zapisz.Text = "Zapisz";
            this.bt_zapisz.UseVisualStyleBackColor = true;
            this.bt_zapisz.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_anuluj
            // 
            this.bt_anuluj.Location = new System.Drawing.Point(229, 164);
            this.bt_anuluj.Name = "bt_anuluj";
            this.bt_anuluj.Size = new System.Drawing.Size(75, 23);
            this.bt_anuluj.TabIndex = 12;
            this.bt_anuluj.Text = "Anuluj";
            this.bt_anuluj.UseVisualStyleBackColor = true;
            this.bt_anuluj.Click += new System.EventHandler(this.bt_anuluj_Click);
            // 
            // BD_zrodlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 199);
            this.Controls.Add(this.bt_anuluj);
            this.Controls.Add(this.bt_zapisz);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_baza);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_host);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BD_zrodlo";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.BD_zrodlo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_baza;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Button bt_zapisz;
        private System.Windows.Forms.Button bt_anuluj;

    }
}
