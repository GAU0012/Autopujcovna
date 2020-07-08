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
    public class ZakaznikUcetGateway
    {
        public static string SqlSelect = "Select  idzu, login, Heslo, Zakaznik_idZ from zakaznicky_ucet";
        public static string SqlInsert = "INSERT INTO zakaznicky_ucet (idzu, login, Heslo, Zakaznik_idZ) VALUES (@idzu, @login, @heslo, @idza)";


        public static int Insert(int idzu, string login, string heslo, int idza)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlInsert);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@heslo", heslo);
            command.Parameters.AddWithValue("@idzu", idzu);
            command.Parameters.AddWithValue("@idza", idza);
            SqlDataReader reader = db.Select(command);

            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }


        public static Collection<ZakaznikUcet> Select()
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelect);
            SqlDataReader reader = db.Select(command);

            Collection<ZakaznikUcet> zakaznickeUcte = Read(reader);
            reader.Close();

            db.Close();
            return zakaznickeUcte;

        }

        
        private static Collection<ZakaznikUcet> Read(SqlDataReader reader)
        {
            Collection<ZakaznikUcet> zakaznickeUcty = new Collection<ZakaznikUcet>();

            while (reader.Read())
            {
                //idTrasy, idObj , adresa, firma, typ"
                ZakaznikUcet zakaznik = new ZakaznikUcet();
                int i = -1;
                zakaznik.idzu = reader.GetInt32(++i);
                zakaznik.login = reader.GetString(++i);
                zakaznik.heslo = reader.GetString(++i);
                zakaznik.idzak = reader.GetInt32(++i);
                zakaznickeUcty.Add(zakaznik);
            }
            return zakaznickeUcty;
        }

        





    }
}
