using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Security.Policy;
using System.Text;
namespace Consulta_DNI_RUC_V2
{
    public partial class Form1 : Form
    {
        private string databaseFile = String.Format("Data Source={0}", @"database.db");
        string token = "";
        string url = "https://dniruc.apisperu.com/api/v1/";
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

        public async void ConsultaDNI()
        {
            try
            {

                txb_rdnirz.Text = "";
                if (System.IO.File.Exists(@"database.db"))
                {
                    using (var conexionSQLite = new SQLiteConnection(databaseFile))
                    {
                        conexionSQLite.Open();
                        consultaSqlite(conexionSQLite);

                    }


                    using (var client = new HttpClient())
                    {

                        HttpResponseMessage response = await client.GetAsync(url + "dni/" + txb_dni.Text + "?token=" + token + "");
                        var responseJson = await response.Content.ReadAsStringAsync();
                        var json = JsonConvert.DeserializeObject<dynamic>(responseJson);
                        string messageFinal = json.success;
                        if (Convert.ToBoolean(messageFinal.ToLower()))
                        {
                            string aPaterno = json.apellidoPaterno.ToString();
                            string aMaterno = json.apellidoMaterno.ToString();
                            string nombres = json.nombres.ToString();
                            string datos = "" + aPaterno + "  " + aMaterno + " " + nombres + "";
                            txb_rdnirz.Text = Regex.Replace(datos, @"\s{2,}", " ").TrimEnd(' ');
                            txb_dni.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show(json.message.ToString());
                            txb_dni.Enabled = true;
                            txb_dni.Text = "";
                            txb_dni.Focus();
                            return;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Registre un toquen en Help>token");
                    txb_dni.Enabled = true;
                    txb_dni.Text = "";
                    txb_dni.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txb_dni.Enabled = true;
                txb_dni.Text = "";
                txb_dni.Focus();
                lcampos();
            }
        }

        private void consultaSqlite(SQLiteConnection conexionSQLite)
        {

            string consultaSQL = "SELECT token FROM api_token WHERE id = 1";
            SQLiteCommand comandoSQL = new SQLiteCommand(consultaSQL, conexionSQLite);
            string nombreAPIClave = (string)comandoSQL.ExecuteScalar();
            token = nombreAPIClave;
        }
        public async void ConsultaRuc()
        {
            try
            {
                txb_rdnirz.Text = "";
                if (System.IO.File.Exists(@"database.db"))
                {
                    using (var conexionSQLite = new SQLiteConnection(databaseFile))
                    {
                        conexionSQLite.Open();
                        consultaSqlite(conexionSQLite);

                    }

                    using (var client = new HttpClient())
                    {

                        HttpResponseMessage response = await client.GetAsync(url + "ruc/" + txb_ruc.Text + "?token=" + token + "");
                        var responseJson = await response.Content.ReadAsStringAsync();
                        var json = JsonConvert.DeserializeObject<dynamic>(responseJson);
                        string messageFinal = json.success;
                        if (response.StatusCode == HttpStatusCode.OK)
                        {

                            txb_ruc.Enabled = true;
                            txb_rdnirz.Text = json.razonSocial.ToString();
                            txb_nroruc.Text = json.ruc.ToString();
                            txb_estado.Text = json.estado.ToString();
                            txb_condicion.Text = json.condicion.ToString();
                            txb_direccion.Text = json.direccion.ToString();
                            txb_ubigeo.Text = json.ubigeo.ToString();
                            txb_distrito.Text = json.distrito.ToString();
                            txb_provincia.Text = json.provincia.ToString();
                            txb_departamento.Text = json.departamento.ToString();

                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("No se encontró resultados");
                            txb_ruc.Enabled = true;
                            txb_ruc.Text = "";
                            txb_ruc.Focus();
                            return;
                        }


                    }
                }


                else
                {
                    MessageBox.Show("Registre un toquen en Help>token");
                    txb_dni.Text = "";
                    txb_ruc.Enabled = true;
                    txb_dni.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                txb_ruc.Enabled = true;
                txb_ruc.Text = "";
                txb_ruc.Focus();
                lcampos();
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
                txb_dni.Enabled = false;
                ConsultaDNI();
            }
        }

        private void txb_ruc_TextChanged(object sender, EventArgs e)
        {

            if (this.txb_ruc.Text.Length == 11)
            {
                this.txb_rdnirz.Focus();
                txb_ruc.Enabled = false;
                ConsultaRuc();
            }
        }
    }
}