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
    
    internal class Memur
    {
        MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        public DataTable Show_Data()
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Memur_Bilgileri ",Con);
            da.Fill(dt);
            return dt;
        }
        public void AddMemur(string Ad, string SoyAd , string TcNo, string TelefonNo, string Username, string Password, string Yetki)
        {
            MySqlCommand cmd = 
            new MySqlCommand(
            "insert into Memur_Bilgileri(`Ad`, `Soyad`, `TcNo`, `PhoneNumber`, `Username`, `Password`, `Yetki`) " +
            "VALUES (@Ad,@SoyAd,@TcNo,@TelefonNo,@Username,@Password,@Yetki)",Con);
            cmd.Parameters.AddWithValue("@Ad", Ad);
            cmd.Parameters.AddWithValue("@SoyAd", SoyAd);
            cmd.Parameters.AddWithValue("@TcNo", TcNo);
            cmd.Parameters.AddWithValue("@TelefonNo", TelefonNo);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Yetki", Yetki);


            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public void UpdateMemur(int id,string Ad, string SoyAd, string TcNo, string TelefonNo, string Username, string Password, string Yetki)
        {
            MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
            connection.Open();
            string query = "UPDATE Memur_Bilgileri SET Ad = @Name, Soyad = @Surname, TcNo = @TcNo, PhoneNumber = @PhoneNumber, Username = @Username, Password = @Password, Yetki = @Yetki Where id=@id ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@Name", Ad);
            cmd.Parameters.AddWithValue("@Surname", SoyAd);
            cmd.Parameters.AddWithValue("@TcNo", TcNo);
            cmd.Parameters.AddWithValue("@PhoneNumber", TelefonNo);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Yetki", Yetki);


            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteMemur(int id)
        {
            MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
            connection.Open();
            string query = "DELETE From Memur_Bilgileri Where id=@id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            

            cmd.ExecuteNonQuery();
            connection.Close();
        }
      
    } 
}
