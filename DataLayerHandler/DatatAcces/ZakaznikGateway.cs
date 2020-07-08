using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHandler.DatatAcces
{
    public class ZakaznikGateway
    {

        public static string SqlSelectById = "Select idz, jmeno, Prijmeni, Datum_narozeni, Tel_cislo, Email, idZU from zakaznik where idz = @idZ";
        public static string SqlInsert = "INSERT INTO zakaznik (idz, jmeno, Prijmeni, Datum_narozeni,Tel_cislo,Email) VALUES(@idz, @jmeno, @prijmeni, @datum , @TelCislo, @email)";
        public static string SqlCount = "Select count(*) FROM zakaznik";
        public static string SqlInsertSluzba = "INSERT INTO sluzby (ids, nazev, cena, Datum_Od,Datum_Do,jmeno, prijmeni) VALUES(@ids, @nazev, @cena, @Datum_Od, @Datum_Do, @jmeno, @prijmeni)";
        public static string SqlCountSluzby = "Select COUNT(*) from sluzby";

        public static Zakaznik Detail(int idZ)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelectById);
            command.Parameters.AddWithValue("@idZ", idZ);
            SqlDataReader reader = db.Select(command);

  
            Collection<Zakaznik> zakaznici = Read(reader);
            Zakaznik zakaznik = null;
            if(zakaznici.Count == 1)
            {
                zakaznik = zakaznici[0];
            }
            reader.Close();

            db.Close();
            return zakaznik;
        }

        public static int Count ()
        {
            var db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SqlCount);
            //SqlDataReader reader = db.Select(command);
            int pocet = Convert.ToInt32(command.ExecuteScalar().ToString());
            return pocet;
        }

        

        public static int Insert (int idz, string jmeno,string prijmeni, DateTime datum_narozeni, int Tel_cislo, string email)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlInsert);
            command.Parameters.AddWithValue("@idz", idz);
            command.Parameters.AddWithValue("@jmeno", jmeno);
            command.Parameters.AddWithValue("@prijmeni", prijmeni);
            command.Parameters.AddWithValue("@datum", datum_narozeni);
            command.Parameters.AddWithValue("@TelCislo", Tel_cislo);
            command.Parameters.AddWithValue("@email", email);
            //command.Parameters.AddWithValue("@idzu", idZU);
            SqlDataReader reader = db.Select(command);
     
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }

        public static int InsertSluzba(int ids, string nazev,int cena,DateTime od, DateTime doo, string jmeno, string prijmeni)
        {
            var db = new Database();
            db.Connect();

          

            SqlCommand command = db.CreateCommand(SqlInsertSluzba);
            command.Parameters.AddWithValue("@ids", ids);
            command.Parameters.AddWithValue("@nazev", nazev);
            command.Parameters.AddWithValue("@cena", cena);
            command.Parameters.AddWithValue("@Datum_Od", od);
            command.Parameters.AddWithValue("@Datum_Do", doo);
            command.Parameters.AddWithValue("@jmeno", jmeno);
            command.Parameters.AddWithValue("@prijmeni", prijmeni);
            //command.Parameters.AddWithValue("@idzu", idZU);
            SqlDataReader reader = db.Select(command);

            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }

        public static int CountSluzby()
        {
            var db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SqlCountSluzby);
            //SqlDataReader reader = db.Select(command);
            int pocet = Convert.ToInt32(command.ExecuteScalar().ToString());
            return pocet;
        }


        private static Collection<Zakaznik> Read(SqlDataReader reader)
        {
            Collection<Zakaznik> zakaznici = new Collection<Zakaznik>();

            while (reader.Read())
            {
                
                Zakaznik zakaznik = new Zakaznik();
                int i = -1;
                zakaznik.idz = reader.GetInt32(++i);
                zakaznik.jmeno = reader.GetString(++i);
                zakaznik.Prijmeni = reader.GetString(++i);
                zakaznik.Datum_narozeni = reader.GetDateTime(++i);
                zakaznik.tel_cislo = reader.GetInt32(++i);
                zakaznik.Email = reader.GetString(++i);
                
                zakaznici.Add(zakaznik);
            }
            return zakaznici;
        }



    }
}
