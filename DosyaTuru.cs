using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace document_management_system
{
    internal class DosyaTuru
    {
        MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        public DataTable Show_Data()
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from DosyaTuru ", Con);
            da.Fill(dt);
            return dt;
        }
        public void AddDosya(string dosyaTuru)
        {
            MySqlCommand cmd =
            new MySqlCommand(
            "insert into DosyaTuru(`DosyaTuru`) " +
            "VALUES (@DosyaTuru)", Con);
            cmd.Parameters.AddWithValue("@DosyaTuru", dosyaTuru);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
