using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab03

{
    public partial class Form1 : Form


    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;
            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";
            //Abrir una conexi�n con el servidor, usando la cadena de conexi�n
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDesconectar.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            //Intentamos obtener el estado de la conexi�n, y en caso est� abierta,
            //recuperamos informaci�n de la misma
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State + "\nVersi�n del servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                else

                    MessageBox.Show("Estado del servidor: " + conn.State);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Inposible determinar el estado del servidor: \n" +
                ex.ToString());

            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Para cerrar la conexi�n verificamos que no este cerrada
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                }

                else
                    MessageBox.Show("La conexi�n ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurri�) un error al cerrar la conexi�n: \n" +
                ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }

            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }
    }
}