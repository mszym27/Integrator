using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using ustawienia = Integrator.Properties.Settings;
namespace Integrator
{

    public partial class Glowne_okno : Form
    {
        Class_Data _zrodlo = null;

        Class_Data _cel = null;

        Boolean _czyCel = false;

        Boolean _czyZrodlo = false;

        static internal Button _bt_polacz;

        static internal Button _bt_polacz_cel;

        public Glowne_okno()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _zrodlo = new Class_Data();

                _cel = new Class_Data();

                _bt_polacz = bt_polacz;

                _bt_polacz_cel = bt_polacz_cel;

                bt_podglad.Enabled = false;

                bt_podglad_cel.Enabled = false; 

                bt_integruj.Enabled = false;

                if (ustawienia.Default.zrodlo_login == "") bt_polacz.Enabled = false;

                if (ustawienia.Default.cel_login == "") bt_polacz_cel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nie mozna zamknąć aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_polacz_Click(object sender, EventArgs e)
        {
            try
            {
                if (_czyZrodlo == false)
                {
                        _zrodlo.Connect_MsSQL(
                            ustawienia.Default.zrodlo_host,
                            ustawienia.Default.zrodlo_port,
                            ustawienia.Default.zrodlo_baza,
                            ustawienia.Default.zrodlo_login,
                            ustawienia.Default.zrodlo_haslo
                        );

                        if (_zrodlo.error_db == null)
                        {
                            _czyZrodlo = true;
                            bt_podglad.Enabled = true;
                            bt_polacz.Text = "Rozłącz";
                            _bt_polacz.Enabled = true;
                            if (_czyCel == true) bt_integruj.Enabled = true;
                        }
                        else
                        {
                            throw new Exception(this._zrodlo.error_db);
                        }
  
                }
                else
                {
                    _zrodlo.Close_MsSQL();
                    if (_cel.error_db == null)
                    {
                        _czyZrodlo = false;
                        bt_podglad.Enabled = false;
                        bt_polacz.Text = "Połącz";
                        bt_integruj.Enabled = false;
                    }
                    else
                    {
                        throw new Exception(this._zrodlo.error_db);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_podglad_Click(object sender, EventArgs e)
        {
            try
            {
                Podglad _okno = new Podglad();
                _okno.Connect = this._zrodlo;
                _okno.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - Podgląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_integruj_Click(object sender, EventArgs e)
        {
            try
            {
                lb_postepu.Text = "0%";
                pb_integruj.Value = 0;
                lb_postepu.Update();

                int min = 0;
                int max = 100;
                int zwiekszenie = 1;
                int i = 1;

                bt_podglad.Enabled = false;

                bt_podglad_cel.Enabled = false;

                bt_polacz.Enabled = false;

                bt_polacz_cel.Enabled = false;

                bt_integruj.Enabled = false;

                _zrodlo.DS_MsSQL("SELECT [id_uzytkownika],[imie],[nazwisko],[adres],[id_miasta],[kod_pocztowy],[telefon] FROM [dbo].[uzytkownik]", "uzytkownik");

                _zrodlo.DS_MsSQL("SELECT [id_miasta],[nazwa] FROM [wt_14_16_zrodlo].[dbo].[miasto]", "miasto");

                _cel.Noread_MsSQL("BEGIN TRANSACTION");

                int suma_wierszy = _zrodlo.ds_MsSQL.Tables[0].Rows.Count + _zrodlo.ds_MsSQL.Tables[1].Rows.Count;

                if (suma_wierszy == 0)
                {
                    MessageBox.Show("Źródło jest puste", "Błąd integracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                zwiekszenie = Convert.ToInt32(max/suma_wierszy);

                _cel.Noread_MsSQL("SET IDENTITY_INSERT [dbo].[miasto] ON");

                while (i <= _zrodlo.ds_MsSQL.Tables[0].Rows.Count)
                {

                    _cel.Noread_MsSQL("INSERT INTO [dbo].[miasto]([id_miasta],[nazwa]) VALUES ("
                        + _zrodlo.ds_MsSQL.Tables["miasto"].Rows[i - 1][0].ToString()
                        + ",'" + _zrodlo.ds_MsSQL.Tables["miasto"].Rows[i - 1][1].ToString() + "')");
                    i++;
                    pb_integruj_Load(ref min, max, zwiekszenie, suma_wierszy, i);         
                }

                _cel.Noread_MsSQL("SET IDENTITY_INSERT [dbo].[miasto] OFF");

                i = 1;

                _cel.Noread_MsSQL("SET IDENTITY_INSERT [dbo].[uzytkownik] ON");

                while (i <= _zrodlo.ds_MsSQL.Tables[1].Rows.Count)
                {
                    _cel.Noread_MsSQL("INSERT INTO [dbo].[uzytkownik]([id_uzytkownika],[imie],[nazwisko],[adres],[id_miasta],[kod_pocztowy],[telefon]) VALUES ("
                         + _zrodlo.ds_MsSQL.Tables["uzytkownik"].Rows[i - 1][0].ToString()
                         + ",'" + _zrodlo.ds_MsSQL.Tables["uzytkownik"].Rows[i - 1][1].ToString() + "'"
                         + ",'" + _zrodlo.ds_MsSQL.Tables["uzytkownik"].Rows[i - 1][2].ToString() + "'"
                         + ",'" + _zrodlo.ds_MsSQL.Tables["uzytkownik"].Rows[i - 1][3].ToString()
                         + "," + _zrodlo.ds_MsSQL.Tables["uzytkownik"].Rows[i - 1][4].ToString()
                         + ",'" + _zrodlo.ds_MsSQL.Tables["uzytkownik"].Rows[i - 1][5].ToString() + "')");
                    i++;
                    pb_integruj_Load(ref min, max, zwiekszenie, suma_wierszy, i);
                }

                _cel.Noread_MsSQL("SET IDENTITY_INSERT [dbo].[uzytkownik] OFF");

                _cel.Noread_MsSQL("COMMIT TRANSACTION");

                bt_podglad.Enabled = true;

                bt_podglad_cel.Enabled = true;

                bt_polacz.Enabled = true;

                bt_polacz_cel.Enabled = true;

                bt_integruj.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd integracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _cel.Noread_MsSQL("ROLLBACK TRANSACTION");

                bt_podglad.Enabled = true;

                bt_podglad_cel.Enabled = true;

                bt_polacz.Enabled = true;

                bt_polacz_cel.Enabled = true;

                bt_integruj.Enabled = true;
            }
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OProgramie _okno = new OProgramie();
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania okna o programie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bazaDanychŹródłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BD_zrodlo _okno = new BD_zrodlo("źródło", false);
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania okna ustawień", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_integruj_Load(ref int min, int max, int zwiekszenie, int suma_wierszy, int krok)
        {
            try
            {
                min = min + zwiekszenie;
                if (min > max)
                {
                    min = 100;
                }
                else if (krok == suma_wierszy)
                {
                    min = 100;
                }

                lb_postepu.Text = min.ToString() + "%";

                lb_postepu.Update();

                Thread.Sleep(500);

                pb_integruj.Value = min;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd integracji - pasek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bazaDanychCelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BD_zrodlo _okno = new BD_zrodlo("cel", true);
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania okna ustawień", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_podglad_cel_Click(object sender, EventArgs e)
        {
            try
            {
                Podglad _okno = new Podglad();
                _okno.Connect = this._cel;
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - Podgląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_polacz_cel_Click(object sender, EventArgs e)
        {
            try
            {
                if (_czyCel == false)
                {
                    _cel.Connect_MsSQL(
                        ustawienia.Default.cel_host,
                        ustawienia.Default.cel_port,
                        ustawienia.Default.cel_baza,
                        ustawienia.Default.cel_login,
                        ustawienia.Default.cel_haslo
                    );
                    if (_cel.error_db == null)
                    {
                        _czyCel = true;
                        bt_podglad_cel.Enabled = true;
                        bt_polacz_cel.Text = "Rozłącz";
                        if (_czyZrodlo == true) bt_integruj.Enabled = true;
                    }
                    else
                    {
                        throw new Exception(this._cel.error_db);
                    }
                }
                else
                {
                    _cel.Close_MsSQL();
                    if (_cel.error_db == null)
                    {
                        _czyCel = false;
                        bt_podglad_cel.Enabled = false;
                        bt_polacz_cel.Text = "Połącz";
                        bt_integruj.Enabled = false;

                    }
                    else
                    {
                        throw new Exception(this._cel.error_db);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
