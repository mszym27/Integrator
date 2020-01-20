using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrator
{
    public partial class Podglad : Form
    {
        private Class_Data _polaczenie = null;

        private DataTable _tabela = null;

        public Class_Data Connect
        {
            set
            {
                this._polaczenie = value;
            }
            //get
            //{
            //    return this._polaczenie;
            //}
        }

        public Podglad()
        {
            InitializeComponent();
        }

        public Podglad(Class_Data _connect)
        {
            this._polaczenie = _connect;
            InitializeComponent();
        }

        private void Podglad_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Podgląd bazy danych";
                //MessageBox.Show(this._polaczenie.isOpen_MsSQL().ToString());
                Miasto_Load();
                Uzytkownik_Load();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Błąd ładowania okna - Podgląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Miasto_Load()
        {
            try
            {
                this._polaczenie.Read_MsSQL("SELECT * FROM [miasto]");

                if (this._polaczenie.error_db != null)
                {
                    throw new Exception(this._polaczenie.error_db);
                }
                else
                {
                    this._tabela = new DataTable();
                    this._tabela.Load(this._polaczenie.read_MsSQL);
                    this.dgv_miasto.DataSource = this._tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Uzytkownik_Load()
        {
            try
            {
                this._polaczenie.Read_MsSQL("SELECT * FROM [uzytkownik]");

                if (this._polaczenie.error_db != null)
                {
                    throw new Exception(this._polaczenie.error_db);
                }
                else
                {
                    this._tabela = new DataTable();
                    this._tabela.Load(this._polaczenie.read_MsSQL);
                    this.dgv_uzytkownik.DataSource = this._tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
