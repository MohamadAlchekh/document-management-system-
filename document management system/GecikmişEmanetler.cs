using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace document_management_system
{
    public partial class GecikmişEmanetler : Form
    {

        public GecikmişEmanetler()
        {
            InitializeComponent();
            Main();
        }

        void Main()
        {
            string connectionString = "Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;";
            string query = "SELECT * FROM EmanetEkleme WHERE TeslimTarihi < @CurrentDateTime";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                command.Parameters.AddWithValue("@CurrentDateTime", DateTime.Now);
                connection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
    }
}
