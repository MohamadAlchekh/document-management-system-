using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace document_management_system
{
    internal class DosyaDepartman
    {
        MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        public DataTable Show_Data()
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from DosyaDepartman ", Con);
            da.Fill(dt);
            return dt;
        }
        public void AddDosya(string dosyaDepartman)
        {
            MySqlCommand cmd =
            new MySqlCommand(
            "insert into DosyaDepartman(`DosyaDepartman`) " +
            "VALUES (@DosyaDepartman)", Con);
            cmd.Parameters.AddWithValue("@DosyaDepartman", dosyaDepartman);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
