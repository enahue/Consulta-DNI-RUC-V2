using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
namespace Consulta_DNI_RUC_V2
{
    public partial class Form1 : Form
    {
        ConsultaApi consulta = new ConsultaApi();
        private string databaseFile = String.Format("Data Source={0}", @"database.db");
        string token = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            comboBox1.SelectedIndex = 0;
        }

        public void lcampos()

        {

            txb_dni.Text = "";
            txb_rdnirz.Text = "";
            txb_ruc.Text = "";
            txb_nroruc.Text = "";
            txb_estado.Text = "";
            txb_condicion.Text = "";
            txb_direccion.Text = "";
            txb_ubigeo.Text = "";
            txb_distrito.Text = "";
            txb_provincia.Text = "";
            txb_departamento.Text = "";

        }
        public void csize()
        {

            if (comboBox1.Text == "DNI")
            {

                Size = new Size(625, 156);
                lbl_numdoc.Text = "DNI";
                txb_dni.Text = "";
                txb_rdnirz.Text = "";
                txb_ruc.Text = "";
                txb_ruc.Visible = false;
                txb_dni.Visible = true;
                txb_dni.Focus();
                lcampos();



            }

            if (comboBox1.Text == "RUC")
            {
                Size = new Size(625, 376);
                lbl_numdoc.Text = "RUC";
                txb_dni.Text = "";
                txb_rdnirz.Text = "";
                txb_ruc.Text = "";
                txb_ruc.Visible = true;
                txb_dni.Visible = false;
                txb_ruc.Focus();
                lcampos();

            }

        }

        public void rconsulta()
        {
            txb_rdnirz.Text = "";
            if (System.IO.File.Exists(@"database.db"))
            {
                using (var conexionSQLite = new SQLiteConnection(databaseFile))
                {
                    conexionSQLite.Open();
                    consultaSqlite(conexionSQLite);

                }

                try
                {
                    dynamic respuesta = consulta.Get("https://api.apis.net.pe/v2/reniec/dni?numero=" + txb_dni.Text + "&token=" + token + "");

                    string aPaterno = respuesta.apellidoPaterno.ToString();
                    string aMaterno = respuesta.apellidoMaterno.ToString();
                    string nombres = respuesta.nombres.ToString();
                    string datos = "" + aPaterno + "  " + aMaterno + " " + nombres + "";
                    txb_rdnirz.Text = Regex.Replace(datos, @"\s{2,}", " ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txb_dni.Text = "";
                    txb_dni.Focus();
                }
            }
            else
            {
                MessageBox.Show("Registre un toquen en Help>token");
                txb_dni.Text = "";
                txb_dni.Focus();

            }
        }

        private void consultaSqlite(SQLiteConnection conexionSQLite)
        {

            string consultaSQL = "SELECT token FROM api_token WHERE id = 1";
            SQLiteCommand comandoSQL = new SQLiteCommand(consultaSQL, conexionSQLite);
            string nombreAPIClave = (string)comandoSQL.ExecuteScalar();
            token = nombreAPIClave;
        }
        public void rucconsula()
        {
            txb_rdnirz.Text = "";
            if (System.IO.File.Exists(@"database.db"))
            {
                using (var conexionSQLite = new SQLiteConnection(databaseFile))
                {
                    conexionSQLite.Open();
                    consultaSqlite(conexionSQLite);

                }
                try
            {

                dynamic respuesta = consulta.Get("https://api.apis.net.pe/v2/sunat/ruc?numero=" + txb_ruc.Text + "&token=" + token + "");
                txb_rdnirz.Text = respuesta.razonSocial.ToString();
                txb_nroruc.Text = respuesta.numeroDocumento.ToString();
                txb_estado.Text = respuesta.estado.ToString();
                txb_condicion.Text = respuesta.condicion.ToString();
                txb_direccion.Text = respuesta.direccion.ToString();
                txb_ubigeo.Text = respuesta.ubigeo.ToString();
                txb_distrito.Text = respuesta.distrito.ToString();
                txb_provincia.Text = respuesta.provincia.ToString();
                txb_departamento.Text = respuesta.departamento.ToString();




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                txb_dni.Text = "";
                txb_ruc.Focus();
                lcampos();
            }
            }
            else
            {
                MessageBox.Show("Registre un toquen en Help>token");
                txb_dni.Text = "";
                txb_dni.Focus();
            }

        }

        private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TokenControl.Instance == null)
            {
                TokenControl nuevoFormSecundario = new TokenControl();
                nuevoFormSecundario.Show();
            }
            else
            {

                TokenControl.Instance.BringToFront();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            csize();
        }

        private void txb_dni_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_dni.Text.Length == 8)
            {
                this.txb_rdnirz.Focus();
                rconsulta();
            }
        }

        private void txb_ruc_TextChanged(object sender, EventArgs e)
        {

            if (this.txb_ruc.Text.Length == 11)
            {
                this.txb_rdnirz.Focus();
                rucconsula();
            }
        }
    }
}