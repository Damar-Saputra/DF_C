// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Create Data Base");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table
{
    class Program
    {
        
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-VHM1FF8V\\SQLEXPRESS;" + "database=cucisepatu;User ID=sa;Password=Masamay2601");

                con.Open();

                SqlCommand cm = new SqlCommand(" Create Table Mahasiswa_Coba (NIM char(12) not null " +
                    "primary key, Nama varchar(50), Alamat varchar(225), Jenis_Kelamin char(1))", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel Sukses Dibuat");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("OPPs, ada yang salah." + e);
                Console.ReadKey();
            }

            finally
            {
                con.Close();
            }

        }
    }
}


