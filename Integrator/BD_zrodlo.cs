using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

using ustawienia = Integrator.Properties.Settings;

namespace Integrator
{
    partial class BD_zrodlo : Form
    {
        private String _title;
        private Boolean _czyCel;

        private Class_Data _polaczenie = null;

        public BD_zrodlo(String title, Boolean czyCel)
        {
            InitializeComponent();
            _title = title;
            _czyCel = czyCel;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void BD_zrodlo_Load(object sender, EventArgs e)
        {
            try
            {
                bt_zapisz.Enabled = false;
                this.Text = "Ustawienia bazy danych - " + _title;

                if (!_czyCel)
                {
                    tb_host.Text = ustawienia.Default.zrodlo_host;
                    tb_port.Text = ustawienia.Default.zrodlo_port;
                    tb_baza.Text = ustawienia.Default.zrodlo_baza;
                    tb_login.Text = ustawienia.Default.zrodlo_login;
                    tb_haslo.Text = ustawienia.Default.zrodlo_haslo;
                }
                else
                {
                    tb_host.Text = ustawienia.Default.cel_host;
                    tb_port.Text = ustawienia.Default.cel_port;
                    tb_baza.Text = ustawienia.Default.cel_baza;
                    tb_login.Text = ustawienia.Default.cel_login;
                    tb_haslo.Text = ustawienia.Default.cel_haslo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ustawień bazy danych - " + _title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void tb_port_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_port.Text != "")
                {
                    if (!char.IsDigit(tb_port.Text, tb_port.Text.Length - 1))
                    {
                        tb_port.Text = tb_port.Text.Substring(0, tb_port.Text.Length - 1);
                        tb_port.Text = "";
                        tb_port.Select(tb_port.Text.Length, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd wprowadzania danych - port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            _polaczenie = new Class_Data();

            _polaczenie.Connect_MsSQL(tb_host.Text, tb_port.Text, tb_baza.Text, tb_login.Text, tb_haslo.Text);
            try
            {
                if (_polaczenie.error_db != null)
                {
                    bt_zapisz.Enabled = false;

                    throw new Exception(this._polaczenie.error_db);
                }
                else
                {
                    bt_zapisz.Enabled = true;
                    MessageBox.Show("Połączenie powiodło sie", "Połączenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_polaczenie.isOpen_MsSQL())
                    {
                        _polaczenie.Close_MsSQL();
                    }

                }
            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd testu połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_czyCel)
                {
                    Glowne_okno._bt_polacz.Enabled = true;

                    ustawienia.Default.zrodlo_host = tb_host.Text;
                    ustawienia.Default.zrodlo_port = tb_port.Text;
                    ustawienia.Default.zrodlo_baza = tb_baza.Text;
                    ustawienia.Default.zrodlo_login = tb_login.Text;
                    ustawienia.Default.zrodlo_haslo = tb_haslo.Text;
                }
                else
                {
                    Glowne_okno._bt_polacz_cel.Enabled = true;

                    ustawienia.Default.cel_host = tb_host.Text;
                    ustawienia.Default.cel_port = tb_port.Text;
                    ustawienia.Default.cel_baza = tb_baza.Text;
                    ustawienia.Default.cel_login = tb_login.Text;
                    ustawienia.Default.cel_haslo = tb_haslo.Text;
                }
                ustawienia.Default.Save();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd zapisywania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine(ex.Message);
            }
        }

        private void bt_anuluj_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd zamykania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
