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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace document_management_system
{
    internal class FakulteSekreteri
    {
        Hesapbilgilerimigüncelle form5= new Hesapbilgilerimigüncelle();

        public void UpdateFakulteSekreteriBilgileri(string newUsername, string newPassword)
        {
            MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
            connection.Open();
            string query = "UPDATE FSlogin SET Username = @NewUsername, Password = @NewPassword WHERE id = 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NewUsername", newUsername);
            cmd.Parameters.AddWithValue("@NewPassword", newPassword);
            int rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show($"Bilgilerinizi güncellndi \nyeni Kullanıcı adınız : {newUsername} \nyeni şifreniz : {newPassword}");            
            connection.Close();
        }
    }
}
